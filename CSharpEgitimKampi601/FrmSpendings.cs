using CSharpEgitimKampi601.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
  public partial class FrmSpendings : Form
  {
    public FrmSpendings()
    {
      InitializeComponent();
    }
    FinancialCrmDbEntities db = new FinancialCrmDbEntities();
    private void FrmSpendings_Load(object sender, EventArgs e)
    {
      lblakbil.Text = db.Spendings.Where(x => x.SpendingTitle == "Aylık Akbil").Select(y => y.SpendingTitle).FirstOrDefault();

      lblAkbilAmount.Text = db.Spendings.Where(x => x.SpendingTitle == "Aylık Akbil").Select(y => y.SpendingAmount).FirstOrDefault().ToString();


      lblAlısveris.Text = db.Spendings.Where(x => x.SpendingTitle == "Migros Alışveriş").Select(y => y.SpendingTitle).FirstOrDefault();

      lblAlısverisAmount.Text = db.Spendings.Where(x => x.SpendingTitle == "Migros Alışveriş").Select(y => y.SpendingAmount).FirstOrDefault().ToString();



      lblwater.Text = db.Spendings.Where(x => x.SpendingTitle == "Damacana Su").Select(y => y.SpendingTitle).FirstOrDefault();

      lblWaterAmount.Text = db.Spendings.Where(x => x.SpendingTitle == "Damacana Su").Select(y => y.SpendingAmount).FirstOrDefault().ToString();


      lblTelefon.Text = db.Spendings.Where(x => x.SpendingTitle == "Telefon").Select(y => y.SpendingTitle).FirstOrDefault();

      lblTelefonAmount.Text = db.Spendings.Where(x => x.SpendingTitle == "Telefon").Select(y => y.SpendingAmount).FirstOrDefault().ToString();


      lblPc.Text = db.Spendings.Where(x => x.SpendingTitle == "Bilgisayar").Select(y => y.SpendingTitle).FirstOrDefault();

      lblPcAmount.Text = db.Spendings.Where(x => x.SpendingTitle == "Bilgisayar").Select(y => y.SpendingAmount).FirstOrDefault().ToString();



      lblMont.Text = db.Spendings.Where(x => x.SpendingTitle == "Mont").Select(y => y.SpendingTitle).FirstOrDefault();

      lblMontAmount.Text = db.Spendings.Where(x => x.SpendingTitle == "Mont").Select(y => y.SpendingAmount).FirstOrDefault().ToString();


      lblBot.Text = db.Spendings.Where(x => x.SpendingTitle == "Bot").Select(y => y.SpendingTitle).FirstOrDefault();

      lblBotAmount.Text = db.Spendings.Where(x => x.SpendingTitle == "Bot").Select(y => y.SpendingAmount).FirstOrDefault().ToString();


      lblTencereTakımı.Text = db.Spendings.Where(x => x.SpendingTitle == "Tencere Takımı").Select(y => y.SpendingTitle).FirstOrDefault();

      lblTencereTakımıAmount.Text = db.Spendings.Where(x => x.SpendingTitle == "Tencere Takımı").Select(y => y.SpendingAmount).FirstOrDefault().ToString();

      lblKitaplık.Text = db.Spendings.Where(x => x.SpendingTitle == "Kitaplık").Select(y => y.SpendingTitle).FirstOrDefault();

      lblKitaplıkAmount.Text = db.Spendings.Where(x => x.SpendingTitle == "Kitaplık").Select(y => y.SpendingAmount).FirstOrDefault().ToString();


    }

    private void lblwater_Click(object sender, EventArgs e)
    {

    }

    private void panel4_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      FrmCategory frmCategory = new FrmCategory();
      frmCategory.Show();
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

    private void btnBillForm_Click(object sender, EventArgs e)
    {
      FrmSpendings frmSpendings = new FrmSpendings();
      frmSpendings.Show();
      this.Close();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      FrmDashboard frmDashboard = new FrmDashboard();
      frmDashboard.Show();
      this.Close();
    }
  }
}
