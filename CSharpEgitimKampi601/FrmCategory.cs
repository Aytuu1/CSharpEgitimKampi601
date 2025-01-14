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
  public partial class FrmCategory : Form
  {
    public FrmCategory()
    {
      InitializeComponent();
    }
    FinancialCrmDbEntities db = new FinancialCrmDbEntities();
    private void button1_Click(object sender, EventArgs e)
    {
      FrmCategory frmCategory = new FrmCategory();
      frmCategory.Show();
      this.Close();
    }

    private void FrmCategory_Load(object sender, EventArgs e)
    {
      lblFatura.Text = db.TblCategory.Where(x => x.CategoryName == "Faturalar").Select(y => y.CategoryName).FirstOrDefault();
      lblEvAletleri.Text = db.TblCategory.Where(x => x.CategoryName == "Ev aletleri").Select(y => y.CategoryName).FirstOrDefault();
      lblFood.Text = db.TblCategory.Where(x => x.CategoryName == "Yeme - İçme").Select(y => y.CategoryName).FirstOrDefault();
      lblSpor.Text = db.TblCategory.Where(x => x.CategoryName == "Spor").Select(y => y.CategoryName).FirstOrDefault();
      lblOkul.Text = db.TblCategory.Where(x => x.CategoryName == "Okul").Select(y => y.CategoryName).FirstOrDefault();
      lblKira.Text = db.TblCategory.Where(x => x.CategoryName == "Kira").Select(y => y.CategoryName).FirstOrDefault();
      lblTeknoloji.Text = db.TblCategory.Where(x => x.CategoryName == "Teknoloji").Select(y => y.CategoryName).FirstOrDefault();
      lblGiyim.Text = db.TblCategory.Where(x => x.CategoryName == "Giyim").Select(y => y.CategoryName).FirstOrDefault();
      lblUlasım.Text = db.TblCategory.Where(x => x.CategoryName == "Ulaşım").Select(y => y.CategoryName).FirstOrDefault();
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
  }
}
