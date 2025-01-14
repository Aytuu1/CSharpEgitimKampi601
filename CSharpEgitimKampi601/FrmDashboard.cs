﻿using CSharpEgitimKampi601.Models;
using System;
using System.Linq;
using System.Windows.Forms;


namespace CSharpEgitimKampi601
{
  public partial class FrmDashboard : Form
  {
    public FrmDashboard()
    {
      InitializeComponent();
    }
    FinancialCrmDbEntities db = new FinancialCrmDbEntities();
    int count = 0;
    private void FrmDashboard_Load(object sender, EventArgs e)
    {
      var totalBalance = db.Banks.Sum(x => x.BankBalance);
      lblTotalBalance.Text = totalBalance.ToString() + " ₺";


      var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
      lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";

      // Chart 1

      var bankData = db.Banks.Select(x => new
      {
        x.BankTitle,
        x.BankBalance
      }).ToList();
      chart1.Series.Clear();
      var series = chart1.Series.Add("Series1");
      foreach (var item in bankData)
      {
        series.Points.AddXY(item.BankTitle, item.BankBalance);
      }



      // Chart 2

      var billData = db.Bills.Select(x => new
      {
        x.BillTitle,
        x.BillAmount
      }).ToList();

      chart2.Series.Clear();
      var series2 = chart2.Series.Add("Faturalar");
      foreach (var item in billData)
      {
        series2.Points.AddXY(item.BillTitle, item.BillAmount);
      }

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      count++;
      if (count % 4 == 1)
      {
        var electricityBill = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();

        lblBillTitle.Text = "Elektrik Faturası";
        lblBillAmount.Text = electricityBill.ToString() + " ₺";
      }
      if (count % 4 == 2)
      {
        var gasBill = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();

        lblBillTitle.Text = "Doğalgaz Faturası";
        lblBillAmount.Text = gasBill.ToString() + " ₺";
      }
      if (count % 4 == 3)
      {
        var waterBill = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();

        lblBillTitle.Text = "Su Faturası";
        lblBillAmount.Text = waterBill.ToString() + " ₺";
      }
      if (count % 4 == 0)
      {
        var netBill = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();

        lblBillTitle.Text = "İnternet Faturası";
        lblBillAmount.Text = netBill.ToString() + " ₺";
      }

    }

    private void button1_Click(object sender, EventArgs e)
    {
      FrmCategory frmCategory = new FrmCategory();
      frmCategory.Show();
      this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      FrmBanks frmBanks = new FrmBanks();
      frmBanks.Show();
      this.Hide();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      FrmBiiling frmBiiling = new FrmBiiling();
      frmBiiling.Show();
      this.Hide();
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panel5_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void lblBillAmount_Click(object sender, EventArgs e)
    {

    }

    private void panel4_Paint(object sender, PaintEventArgs e)
    {

    }

    private void lblBillTitle_Click(object sender, EventArgs e)
    {

    }

    private void lblTotalBalance_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void lblLastBankProcessAmount_Click(object sender, EventArgs e)
    {

    }

    private void button8_Click(object sender, EventArgs e)
    {

    }

    private void button7_Click(object sender, EventArgs e)
    {

    }

    private void button6_Click(object sender, EventArgs e)
    {
      FrmDashboard frmDashboard = new FrmDashboard();
      frmDashboard.Show();
      this.Close();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      FrmSpendings frmSpendings = new FrmSpendings();
      frmSpendings.Show();
      this.Close();
    }

    private void btnBillForm_Click(object sender, EventArgs e)
    {

    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void chart1_Click(object sender, EventArgs e)
    {

    }

    private void chart2_Click(object sender, EventArgs e)
    {

    }

    private void panel6_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void panel7_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }
  }
}
