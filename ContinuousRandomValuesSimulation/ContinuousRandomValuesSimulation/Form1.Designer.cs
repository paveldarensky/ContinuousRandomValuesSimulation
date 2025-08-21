namespace ContinuousRandomValuesSimulation
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.chart_Statistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_Parameters = new System.Windows.Forms.TableLayoutPanel();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_Mean = new System.Windows.Forms.Label();
            this.label_Variance = new System.Windows.Forms.Label();
            this.label_SampleSize = new System.Windows.Forms.Label();
            this.textBox_Mean = new System.Windows.Forms.TextBox();
            this.textBox_Variance = new System.Windows.Forms.TextBox();
            this.textBox_SampleSize = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Characteristics = new System.Windows.Forms.TableLayoutPanel();
            this.label_MeanCharacteristic = new System.Windows.Forms.Label();
            this.label_VarianceCharacteristic = new System.Windows.Forms.Label();
            this.label_ChiSquaredCharacteristic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Statistics)).BeginInit();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.tableLayoutPanel_Parameters.SuspendLayout();
            this.tableLayoutPanel_Characteristics.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.Controls.Add(this.tableLayoutPanel_Main);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.chart_Statistics);
            this.splitContainer_Main.Size = new System.Drawing.Size(1200, 594);
            this.splitContainer_Main.SplitterDistance = 303;
            this.splitContainer_Main.TabIndex = 0;
            // 
            // chart_Statistics
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -45;
            chartArea1.AxisX.LabelStyle.Format = "F2";
            chartArea1.AxisX.Title = "Интервалы";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.Title = "Относительная частота / Плотность";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.Name = "ChartArea1";
            this.chart_Statistics.ChartAreas.Add(chartArea1);
            this.chart_Statistics.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 40F;
            legend1.Name = "Legend1";
            legend1.TextWrapThreshold = 10;
            this.chart_Statistics.Legends.Add(legend1);
            this.chart_Statistics.Location = new System.Drawing.Point(0, 0);
            this.chart_Statistics.Name = "chart_Statistics";
            this.chart_Statistics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Гистограмма нормального распределения";
            series1.Name = "Series_Empirical";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Теоретическое нормальное распределение";
            series2.Name = "Series_Theoretical";
            this.chart_Statistics.Series.Add(series1);
            this.chart_Statistics.Series.Add(series2);
            this.chart_Statistics.Size = new System.Drawing.Size(891, 592);
            this.chart_Statistics.TabIndex = 0;
            this.chart_Statistics.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Гистограмма и теоретическое нормальное распределение";
            this.chart_Statistics.Titles.Add(title1);
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Parameters, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.button_Start, 0, 1);
            this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_Characteristics, 0, 2);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.71717F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.28283F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 393F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(301, 592);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // tableLayoutPanel_Parameters
            // 
            this.tableLayoutPanel_Parameters.ColumnCount = 2;
            this.tableLayoutPanel_Parameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Parameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Parameters.Controls.Add(this.textBox_SampleSize, 1, 2);
            this.tableLayoutPanel_Parameters.Controls.Add(this.textBox_Variance, 1, 1);
            this.tableLayoutPanel_Parameters.Controls.Add(this.label_Mean, 0, 0);
            this.tableLayoutPanel_Parameters.Controls.Add(this.label_Variance, 0, 1);
            this.tableLayoutPanel_Parameters.Controls.Add(this.label_SampleSize, 0, 2);
            this.tableLayoutPanel_Parameters.Controls.Add(this.textBox_Mean, 1, 0);
            this.tableLayoutPanel_Parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Parameters.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_Parameters.Name = "tableLayoutPanel_Parameters";
            this.tableLayoutPanel_Parameters.RowCount = 3;
            this.tableLayoutPanel_Parameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Parameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Parameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Parameters.Size = new System.Drawing.Size(295, 136);
            this.tableLayoutPanel_Parameters.TabIndex = 0;
            // 
            // button_Start
            // 
            this.button_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Start.AutoSize = true;
            this.button_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Start.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(107, 152);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(86, 36);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Старт";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Mean
            // 
            this.label_Mean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Mean.AutoSize = true;
            this.label_Mean.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Mean.Location = new System.Drawing.Point(48, 12);
            this.label_Mean.Name = "label_Mean";
            this.label_Mean.Size = new System.Drawing.Size(51, 21);
            this.label_Mean.TabIndex = 0;
            this.label_Mean.Text = "Mean";
            // 
            // label_Variance
            // 
            this.label_Variance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Variance.AutoSize = true;
            this.label_Variance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Variance.Location = new System.Drawing.Point(37, 57);
            this.label_Variance.Name = "label_Variance";
            this.label_Variance.Size = new System.Drawing.Size(73, 21);
            this.label_Variance.TabIndex = 1;
            this.label_Variance.Text = "Variance";
            // 
            // label_SampleSize
            // 
            this.label_SampleSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_SampleSize.AutoSize = true;
            this.label_SampleSize.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_SampleSize.Location = new System.Drawing.Point(24, 102);
            this.label_SampleSize.Name = "label_SampleSize";
            this.label_SampleSize.Size = new System.Drawing.Size(98, 21);
            this.label_SampleSize.TabIndex = 2;
            this.label_SampleSize.Text = "Sample size";
            // 
            // textBox_Mean
            // 
            this.textBox_Mean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Mean.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Mean.Location = new System.Drawing.Point(171, 8);
            this.textBox_Mean.Name = "textBox_Mean";
            this.textBox_Mean.Size = new System.Drawing.Size(100, 29);
            this.textBox_Mean.TabIndex = 3;
            this.textBox_Mean.Text = "0";
            // 
            // textBox_Variance
            // 
            this.textBox_Variance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Variance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Variance.Location = new System.Drawing.Point(171, 53);
            this.textBox_Variance.Name = "textBox_Variance";
            this.textBox_Variance.Size = new System.Drawing.Size(100, 29);
            this.textBox_Variance.TabIndex = 4;
            this.textBox_Variance.Text = "1";
            // 
            // textBox_SampleSize
            // 
            this.textBox_SampleSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SampleSize.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SampleSize.Location = new System.Drawing.Point(171, 98);
            this.textBox_SampleSize.Name = "textBox_SampleSize";
            this.textBox_SampleSize.Size = new System.Drawing.Size(100, 29);
            this.textBox_SampleSize.TabIndex = 5;
            this.textBox_SampleSize.Text = "1000";
            // 
            // tableLayoutPanel_Characteristics
            // 
            this.tableLayoutPanel_Characteristics.ColumnCount = 1;
            this.tableLayoutPanel_Characteristics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Characteristics.Controls.Add(this.label_ChiSquaredCharacteristic, 0, 2);
            this.tableLayoutPanel_Characteristics.Controls.Add(this.label_VarianceCharacteristic, 0, 1);
            this.tableLayoutPanel_Characteristics.Controls.Add(this.label_MeanCharacteristic, 0, 0);
            this.tableLayoutPanel_Characteristics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Characteristics.Location = new System.Drawing.Point(3, 201);
            this.tableLayoutPanel_Characteristics.Name = "tableLayoutPanel_Characteristics";
            this.tableLayoutPanel_Characteristics.RowCount = 3;
            this.tableLayoutPanel_Characteristics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Characteristics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Characteristics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Characteristics.Size = new System.Drawing.Size(295, 388);
            this.tableLayoutPanel_Characteristics.TabIndex = 2;
            // 
            // label_MeanCharacteristic
            // 
            this.label_MeanCharacteristic.AutoSize = true;
            this.label_MeanCharacteristic.Location = new System.Drawing.Point(3, 0);
            this.label_MeanCharacteristic.Name = "label_MeanCharacteristic";
            this.label_MeanCharacteristic.Size = new System.Drawing.Size(47, 19);
            this.label_MeanCharacteristic.TabIndex = 0;
            this.label_MeanCharacteristic.Text = "Mean:";
            // 
            // label_VarianceCharacteristic
            // 
            this.label_VarianceCharacteristic.AutoSize = true;
            this.label_VarianceCharacteristic.Location = new System.Drawing.Point(3, 129);
            this.label_VarianceCharacteristic.Name = "label_VarianceCharacteristic";
            this.label_VarianceCharacteristic.Size = new System.Drawing.Size(64, 19);
            this.label_VarianceCharacteristic.TabIndex = 1;
            this.label_VarianceCharacteristic.Text = "Variance:";
            // 
            // label_ChiSquaredCharacteristic
            // 
            this.label_ChiSquaredCharacteristic.AutoSize = true;
            this.label_ChiSquaredCharacteristic.Location = new System.Drawing.Point(3, 258);
            this.label_ChiSquaredCharacteristic.Name = "label_ChiSquaredCharacteristic";
            this.label_ChiSquaredCharacteristic.Size = new System.Drawing.Size(84, 19);
            this.label_ChiSquaredCharacteristic.TabIndex = 2;
            this.label_ChiSquaredCharacteristic.Text = "Chi-squared";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 594);
            this.Controls.Add(this.splitContainer_Main);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Main";
            this.Text = "ContinuousRandomValuesSimulation";
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Statistics)).EndInit();
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.tableLayoutPanel_Main.PerformLayout();
            this.tableLayoutPanel_Parameters.ResumeLayout(false);
            this.tableLayoutPanel_Parameters.PerformLayout();
            this.tableLayoutPanel_Characteristics.ResumeLayout(false);
            this.tableLayoutPanel_Characteristics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer_Main;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Statistics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Parameters;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Mean;
        private System.Windows.Forms.TextBox textBox_SampleSize;
        private System.Windows.Forms.TextBox textBox_Variance;
        private System.Windows.Forms.Label label_Variance;
        private System.Windows.Forms.Label label_SampleSize;
        private System.Windows.Forms.TextBox textBox_Mean;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Characteristics;
        private System.Windows.Forms.Label label_ChiSquaredCharacteristic;
        private System.Windows.Forms.Label label_VarianceCharacteristic;
        private System.Windows.Forms.Label label_MeanCharacteristic;
    }
}

