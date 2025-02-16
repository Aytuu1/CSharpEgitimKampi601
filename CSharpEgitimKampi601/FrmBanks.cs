﻿using CSharpEgitimKampi601.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
  public partial class FrmBanks : Form
  {
    public FrmBanks()
    {
      InitializeComponent();
    }
    FinancialCrmDbEntities db = new FinancialCrmDbEntities();
    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void FrmBanks_Load(object sender, EventArgs e)
    {
      // Banka Bakiyeleri

      var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();

      var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "VakıfBank").Select(y => y.BankBalance).FirstOrDefault();

      var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

      lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
      lblVakifBankBalance.Text = vakifBankBalance.ToString() + " ₺";
      lblisBankasiBalance.Text = isBankBalance.ToString() + " ₺";


      // Banka Hareketleri
      var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
      lblbankProcess1.Text = $"{bankProcess1.Description} {bankProcess1.Amount} {bankProcess1.ProcessDate} ";

      var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
      lblbankProcess2.Text = $"{bankProcess2.Description} {bankProcess2.Amount} {bankProcess2.ProcessDate} ";

      var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
      lblbankProcess3.Text = $"{bankProcess3.Description} {bankProcess3.Amount} {bankProcess3.ProcessDate} ";

      var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
      lblbankProcess2.Text = $"{bankProcess4.Description} {bankProcess4.Amount} {bankProcess4.ProcessDate} ";

      var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
      lblbankProcess5.Text = $"{bankProcess5.Description} {bankProcess5.Amount} {bankProcess5.ProcessDate} ";

    }

    private void groupBox3_Enter(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void label12_Click(object sender, EventArgs e)
    {

    }

    private void btnBillForm_Click(object sender, EventArgs e)
    {
      FrmBiiling frmBiiling = new FrmBiiling();
      frmBiiling.Show();
      this.Hide();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      FrmCategory category = new FrmCategory();
      category.Show();
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      FrmBanks frmBanks = new FrmBanks();
      frmBanks.Show();
      this.Close();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      FrmBiiling frmBiiling = new FrmBiiling();
      frmBiiling.Show();
      this.Close();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      FrmSpendings frmSpendings = new FrmSpendings();
      frmSpendings.Show();
      this.Close();
    }
  }
}
