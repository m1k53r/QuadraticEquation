namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bValue = new System.Windows.Forms.TextBox();
            this.cValue = new System.Windows.Forms.TextBox();
            this.resolution = new System.Windows.Forms.TrackBar();
            this.aValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-2, 63);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Wykresik";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(806, 389);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // bValue
            // 
            this.bValue.Location = new System.Drawing.Point(183, 12);
            this.bValue.Name = "bValue";
            this.bValue.Size = new System.Drawing.Size(100, 20);
            this.bValue.TabIndex = 2;
            this.bValue.TextChanged += new System.EventHandler(this.Trigger);
            // 
            // cValue
            // 
            this.cValue.Location = new System.Drawing.Point(309, 12);
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(100, 20);
            this.cValue.TabIndex = 3;
            this.cValue.TextChanged += new System.EventHandler(this.Trigger);
            // 
            // resolution
            // 
            this.resolution.Location = new System.Drawing.Point(519, 12);
            this.resolution.Maximum = 50;
            this.resolution.Minimum = 1;
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(104, 45);
            this.resolution.TabIndex = 4;
            this.resolution.Value = 1;
            this.resolution.Scroll += new System.EventHandler(this.Trigger);
            // 
            // aValue
            // 
            this.aValue.Location = new System.Drawing.Point(56, 12);
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(100, 20);
            this.aValue.TabIndex = 5;
            this.aValue.TextChanged += new System.EventHandler(this.Trigger);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rozdzielczość: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aValue);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.cValue);
            this.Controls.Add(this.bValue);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox bValue;
        private System.Windows.Forms.TextBox cValue;
        private System.Windows.Forms.TrackBar resolution;
        private System.Windows.Forms.TextBox aValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

