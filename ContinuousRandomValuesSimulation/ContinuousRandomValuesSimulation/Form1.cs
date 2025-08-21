using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics.Distributions;

namespace ContinuousRandomValuesSimulation
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (!Validation(out double mean, out double variance, out int sampleSize))
                return;

            List<double> normalSamples = GenerateNormalDistribution(mean, variance, sampleSize);

            DrawStatistics(normalSamples, mean, variance);
        }

        private bool Validation(out double mean, out double variance, out int sampleSize)
        {
            mean = 0;
            variance = 1;
            sampleSize = 1000;

            if (!double.TryParse(textBox_Mean.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out mean))
            {
                MessageBox.Show("Некорректное значение математического ожидания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!double.TryParse(textBox_Variance.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out variance) || variance <= 0)
            {
                MessageBox.Show("Введите корректное положительное значение дисперсии.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(textBox_SampleSize.Text, out sampleSize) || sampleSize <= 0)
            {
                MessageBox.Show("Введите корректную положительную длину выборки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private Random random = new Random(); // seed

        private List<double> GenerateNormalDistribution(double mean, double variance, int sampleSize)
        {
            List<double> samples = new List<double>();
            double stdDev = Math.Sqrt(variance);

            for (int i = 0; i < sampleSize / 2; i++)
            {
                double alpha1 = random.NextDouble();
                double alpha2 = random.NextDouble();

                // Преобразование Бокса-Мюллера
                double factor = Math.Sqrt(-2.0 * Math.Log(alpha1));
                double ksi_1 = factor * Math.Cos(2 * Math.PI * alpha2);
                double ksi_2 = factor * Math.Sin(2 * Math.PI * alpha2);

                samples.Add(mean + stdDev * ksi_1);
                if (samples.Count < sampleSize)
                    samples.Add(mean + stdDev * ksi_2);
            }

            return samples;
        }

        private void DrawStatistics(List<double> sample, double mean, double variance)
        {
            int N = sample.Count;
            if (N == 0)
                return;

            List<(double a, double b)> intervals = new List<(double a, double b)>();

            chart_Statistics.Series[0].Points.Clear();
            chart_Statistics.Series[1].Points.Clear();

            // k = [log2(N)] + 1
            int k = (int)Math.Floor(Math.Log(N, 2)) + 1; // num of intervals

            double min = sample.Min();
            double max = sample.Max();
            double intervalWidth = ((max - min) + 0.01) / k;

            List<int> frequencies = new List<int>(new int[k]);
            foreach (double x in sample)
            {
                int index = (int)Math.Ceiling((x - min) / intervalWidth) - 1;
                if (index < 0) index = 0;
                frequencies[index]++;
            }

            List<double> relativeFrequencies = frequencies.Select(f => f / (double)N).ToList();

            // empirical - histogram
            for (int i = 0; i < k; i++)
            {
                double binStart = min + i * intervalWidth;
                double binEnd = binStart + intervalWidth;
                double binCenter = binStart + intervalWidth / 2.0;

                intervals.Add((binStart, binEnd));

                var point = new DataPoint(binCenter, relativeFrequencies[i]);

                point.Label = $"({binStart:F2}; {binEnd:F2}]"; // (a;b]

                point.LabelForeColor = Color.Black;
                point.Font = new Font("Times New Roman", 8);

                chart_Statistics.Series[0].Points.Add(point);
            }

            // theoretical - normal prob distr func
            int theoryPoints = 500;
            for (int i = 0; i < theoryPoints; i++)
            {
                double x = min + i * (max - min) / theoryPoints;
                double y = NormalPdf(x, mean, Math.Sqrt(variance));
                chart_Statistics.Series[1].Points.AddXY(x, y);
            }

            CalculateAndShowProbCharacteristics(sample, mean, variance, relativeFrequencies, intervals);
        }

        private double NormalPdf(double x, double mean, double stdDev)
        {
            double exponent = -Math.Pow(x - mean, 2) / (2 * stdDev * stdDev);
            return (1.0 / (stdDev * Math.Sqrt(2 * Math.PI))) * Math.Exp(exponent);
        }

        private void CalculateAndShowProbCharacteristics(List<double> sample, double mean_theoretical, double variance_theoretical,
                                                         List<double> relativeFrequencies, List<(double a, double b)> intervals)
        {
            int N = sample.Count;
            if (N == 0 || intervals.Count != relativeFrequencies.Count)
                return;

            // для Хи-квадрат 
            List<double> pi = intervals.Select(interval =>
            {
                double center = (interval.a + interval.b) / 2.0;
                double width = interval.b - interval.a;
                return width * NormalPdf(center, mean_theoretical, Math.Sqrt(variance_theoretical));
            }).ToList();

            // empirical mean
            double mean_empirical = sample.Average();

            // empirical var
            double variance_empirical = sample.Sum(x => (x - mean_empirical) * (x - mean_empirical)) / sample.Count;

            // Хи-квадрат
            double chi_squared = 0;
            for (int i = 0; i < intervals.Count; i++)
            {
                if (pi[i] > 0)
                {
                    chi_squared += Math.Pow(relativeFrequencies[i] - pi[i], 2) / pi[i];
                }
            }
            chi_squared *= N;

            // Ошибки
            double abs_mean_error = Math.Abs(mean_empirical - mean_theoretical);
            double abs_var_error = Math.Abs(variance_empirical - variance_theoretical);

            double relative_mean_error = abs_mean_error / Math.Abs(mean_theoretical);
            double relative_var_error = abs_var_error / Math.Abs(variance_theoretical);

            // Вывод
            label_MeanCharacteristic.Text = $"Мат. ожидание:\n" +
                              $"  Теоретическое: {mean_theoretical:F3}\n" +
                              $"  Эмпирическое:   {mean_empirical:F3}\n" +
                              $"  Абс. ошибка:     {abs_mean_error:F3}\n" +
                              $"  Отн. ошибка:     {relative_mean_error:P2}";

            label_VarianceCharacteristic.Text = $"Дисперсия:\n" +
                                  $"  Теоретическая: {variance_theoretical:F3}\n" +
                                  $"  Эмпирическая:  {variance_empirical:F3}\n" +
                                  $"  Абс. ошибка:    {abs_var_error:F3}\n" +
                                  $"  Отн. ошибка:     {relative_var_error:P2}";

            int k = intervals.Count;
            int df = k - 1 - 2; // по Пирсону
            double alpha = 0.05; // уровень значимости
            double table_chi_squared = ChiSquared.InvCDF(df, 1 - alpha); // квантиль хи-квадрат
            bool hypothesisRejected = chi_squared > table_chi_squared;

            label_ChiSquaredCharacteristic.Text = $"Критерий χ²:\n" +
                                    $"  χ² расчётное: {chi_squared:F3}\n" +
                                    $"  χ² табличное: {table_chi_squared:F3}\n" +
                                    $"  Гипотеза {(hypothesisRejected ? "отклоняется" : "принимается")} (при α = 0.05)";
        }


    }
}
