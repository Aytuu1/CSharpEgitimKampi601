namespace CSharpEgitimKampi601
{
  partial class FrmDashboard
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.lblBillAmount = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.lblBillTitle = new System.Windows.Forms.Label();
      this.lblTotalBalance = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.button8 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.btnBillForm = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.panel6 = new System.Windows.Forms.Panel();
      this.panel7 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.panel5.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
      this.panel6.SuspendLayout();
      this.panel7.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblLastBankProcessAmount
      // 
      this.lblLastBankProcessAmount.AutoSize = true;
      this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblLastBankProcessAmount.ForeColor = System.Drawing.Color.White;
      this.lblLastBankProcessAmount.Location = new System.Drawing.Point(99, 65);
      this.lblLastBankProcessAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
      this.lblLastBankProcessAmount.Size = new System.Drawing.Size(92, 37);
      this.lblLastBankProcessAmount.TabIndex = 16;
      this.lblLastBankProcessAmount.Text = "0.00 ₺";
      // 
      // panel5
      // 
      this.panel5.BackColor = System.Drawing.Color.DarkCyan;
      this.panel5.Controls.Add(this.lblLastBankProcessAmount);
      this.panel5.Controls.Add(this.label4);
      this.panel5.Location = new System.Drawing.Point(949, 76);
      this.panel5.Margin = new System.Windows.Forms.Padding(4);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(273, 142);
      this.panel5.TabIndex = 20;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(19, 9);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(157, 24);
      this.label4.TabIndex = 11;
      this.label4.Text = "Gelen Son Havale";
      // 
      // lblBillAmount
      // 
      this.lblBillAmount.AutoSize = true;
      this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblBillAmount.ForeColor = System.Drawing.Color.White;
      this.lblBillAmount.Location = new System.Drawing.Point(91, 68);
      this.lblBillAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblBillAmount.Name = "lblBillAmount";
      this.lblBillAmount.Size = new System.Drawing.Size(92, 37);
      this.lblBillAmount.TabIndex = 16;
      this.lblBillAmount.Text = "0.00 ₺";
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.Color.Indigo;
      this.panel4.Controls.Add(this.lblBillAmount);
      this.panel4.Controls.Add(this.lblBillTitle);
      this.panel4.Location = new System.Drawing.Point(612, 77);
      this.panel4.Margin = new System.Windows.Forms.Padding(4);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(289, 142);
      this.panel4.TabIndex = 19;
      // 
      // lblBillTitle
      // 
      this.lblBillTitle.AutoSize = true;
      this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblBillTitle.ForeColor = System.Drawing.Color.White;
      this.lblBillTitle.Location = new System.Drawing.Point(4, 9);
      this.lblBillTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblBillTitle.Name = "lblBillTitle";
      this.lblBillTitle.Size = new System.Drawing.Size(121, 24);
      this.lblBillTitle.TabIndex = 11;
      this.lblBillTitle.Text = "Fatura Başlığı";
      // 
      // lblTotalBalance
      // 
      this.lblTotalBalance.AutoSize = true;
      this.lblTotalBalance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblTotalBalance.ForeColor = System.Drawing.Color.White;
      this.lblTotalBalance.Location = new System.Drawing.Point(69, 68);
      this.lblTotalBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblTotalBalance.Name = "lblTotalBalance";
      this.lblTotalBalance.Size = new System.Drawing.Size(92, 37);
      this.lblTotalBalance.TabIndex = 15;
      this.lblTotalBalance.Text = "0.00 ₺";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(4, 9);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(147, 24);
      this.label2.TabIndex = 10;
      this.label2.Text = "Toplam Bakiyem";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(20, 18);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(278, 24);
      this.label1.TabIndex = 2;
      this.label1.Text = "Dashboard / Genel Bakış Formu";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.Blue;
      this.panel2.Controls.Add(this.label1);
      this.panel2.Location = new System.Drawing.Point(4, 3);
      this.panel2.Margin = new System.Windows.Forms.Padding(4);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1226, 58);
      this.panel2.TabIndex = 17;
      // 
      // button8
      // 
      this.button8.BackColor = System.Drawing.Color.Transparent;
      this.button8.Cursor = System.Windows.Forms.Cursors.Default;
      this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button8.ForeColor = System.Drawing.Color.White;
      this.button8.Location = new System.Drawing.Point(24, 489);
      this.button8.Margin = new System.Windows.Forms.Padding(4);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(189, 44);
      this.button8.TabIndex = 7;
      this.button8.Text = "Çıkış Yap";
      this.button8.UseVisualStyleBackColor = false;
      // 
      // button7
      // 
      this.button7.BackColor = System.Drawing.Color.Transparent;
      this.button7.Cursor = System.Windows.Forms.Cursors.Default;
      this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button7.ForeColor = System.Drawing.Color.White;
      this.button7.Location = new System.Drawing.Point(24, 424);
      this.button7.Margin = new System.Windows.Forms.Padding(4);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(189, 44);
      this.button7.TabIndex = 6;
      this.button7.Text = "Ayarlar";
      this.button7.UseVisualStyleBackColor = false;
      // 
      // button6
      // 
      this.button6.BackColor = System.Drawing.Color.Transparent;
      this.button6.Cursor = System.Windows.Forms.Cursors.Default;
      this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button6.ForeColor = System.Drawing.Color.White;
      this.button6.Location = new System.Drawing.Point(24, 363);
      this.button6.Margin = new System.Windows.Forms.Padding(4);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(189, 44);
      this.button6.TabIndex = 5;
      this.button6.Text = "Dashboard";
      this.button6.UseVisualStyleBackColor = false;
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.Color.Transparent;
      this.button5.Cursor = System.Windows.Forms.Cursors.Default;
      this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button5.ForeColor = System.Drawing.Color.White;
      this.button5.Location = new System.Drawing.Point(24, 303);
      this.button5.Margin = new System.Windows.Forms.Padding(4);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(189, 49);
      this.button5.TabIndex = 4;
      this.button5.Text = "Banka Hareketleri";
      this.button5.UseVisualStyleBackColor = false;
      // 
      // btnBillForm
      // 
      this.btnBillForm.BackColor = System.Drawing.Color.Transparent;
      this.btnBillForm.Cursor = System.Windows.Forms.Cursors.Default;
      this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBillForm.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.btnBillForm.ForeColor = System.Drawing.Color.White;
      this.btnBillForm.Location = new System.Drawing.Point(24, 236);
      this.btnBillForm.Margin = new System.Windows.Forms.Padding(4);
      this.btnBillForm.Name = "btnBillForm";
      this.btnBillForm.Size = new System.Drawing.Size(189, 49);
      this.btnBillForm.TabIndex = 3;
      this.btnBillForm.Text = "Giderler";
      this.btnBillForm.UseVisualStyleBackColor = false;
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.Transparent;
      this.button3.Cursor = System.Windows.Forms.Cursors.Default;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button3.ForeColor = System.Drawing.Color.White;
      this.button3.Location = new System.Drawing.Point(24, 174);
      this.button3.Margin = new System.Windows.Forms.Padding(4);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(189, 50);
      this.button3.TabIndex = 2;
      this.button3.Text = "Faturalar";
      this.button3.UseVisualStyleBackColor = false;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Transparent;
      this.button2.Cursor = System.Windows.Forms.Cursors.Default;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button2.ForeColor = System.Drawing.Color.White;
      this.button2.Location = new System.Drawing.Point(24, 105);
      this.button2.Margin = new System.Windows.Forms.Padding(4);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(189, 53);
      this.button2.TabIndex = 1;
      this.button2.Text = "Bankalar";
      this.button2.UseVisualStyleBackColor = false;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Transparent;
      this.button1.Cursor = System.Windows.Forms.Cursors.Default;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button1.ForeColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(24, 32);
      this.button1.Margin = new System.Windows.Forms.Padding(4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(189, 54);
      this.button1.TabIndex = 0;
      this.button1.Text = "Kategoriler";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
      this.panel3.Controls.Add(this.lblTotalBalance);
      this.panel3.Controls.Add(this.label2);
      this.panel3.Location = new System.Drawing.Point(268, 77);
      this.panel3.Margin = new System.Windows.Forms.Padding(4);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(272, 141);
      this.panel3.TabIndex = 18;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkBlue;
      this.panel1.Controls.Add(this.button8);
      this.panel1.Controls.Add(this.button7);
      this.panel1.Controls.Add(this.button6);
      this.panel1.Controls.Add(this.button5);
      this.panel1.Controls.Add(this.btnBillForm);
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Location = new System.Drawing.Point(4, 61);
      this.panel1.Margin = new System.Windows.Forms.Padding(4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(233, 553);
      this.panel1.TabIndex = 16;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(244, 313);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(470, 258);
      this.chart1.TabIndex = 21;
      this.chart1.Text = "chart1";
      // 
      // chart2
      // 
      chartArea2.Name = "ChartArea1";
      this.chart2.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.chart2.Legends.Add(legend2);
      this.chart2.Location = new System.Drawing.Point(774, 313);
      this.chart2.Name = "chart2";
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
      series2.Legend = "Legend1";
      series2.Name = "Faturalar";
      this.chart2.Series.Add(series2);
      this.chart2.Size = new System.Drawing.Size(448, 258);
      this.chart2.TabIndex = 22;
      this.chart2.Text = "chart2";
      // 
      // panel6
      // 
      this.panel6.BackColor = System.Drawing.Color.Silver;
      this.panel6.Controls.Add(this.label3);
      this.panel6.Location = new System.Drawing.Point(244, 253);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(470, 54);
      this.panel6.TabIndex = 23;
      // 
      // panel7
      // 
      this.panel7.BackColor = System.Drawing.Color.Silver;
      this.panel7.Controls.Add(this.label5);
      this.panel7.Location = new System.Drawing.Point(774, 253);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(448, 54);
      this.panel7.TabIndex = 24;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label3.ForeColor = System.Drawing.Color.Black;
      this.label3.Location = new System.Drawing.Point(4, 4);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(397, 48);
      this.label3.TabIndex = 16;
      this.label3.Text = "Bankalar ve Banka hesaplarında\'ki para \r\nmiktarlarına aşağıdaki grafikten ulaşabi" +
    "lirsiniz.\r\n";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label5.ForeColor = System.Drawing.Color.Black;
      this.label5.Location = new System.Drawing.Point(4, 4);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(410, 48);
      this.label5.TabIndex = 17;
      this.label5.Text = "Ödenen ve Ödenmesi gereken fatura tutarlarına\r\naşağıdaki grafikten ulaşabilirsini" +
    "z.\r\n";
      // 
      // FrmDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1224, 601);
      this.Controls.Add(this.panel7);
      this.Controls.Add(this.panel6);
      this.Controls.Add(this.chart2);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.panel5);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel1);
      this.Name = "FrmDashboard";
      this.Text = "Dashboard Formu";
      this.Load += new System.EventHandler(this.FrmDashboard_Load);
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Label lblLastBankProcessAmount;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblBillAmount;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label lblBillTitle;
    private System.Windows.Forms.Label lblTotalBalance;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button btnBillForm;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Label label5;
  }
}