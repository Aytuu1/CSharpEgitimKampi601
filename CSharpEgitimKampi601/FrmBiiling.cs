using System;
using System.Linq;
using System.Windows.Forms;
using CSharpEgitimKampi601.Models;
namespace CSharpEgitimKampi601
{
  public partial class FrmBiiling : Form
  {
    public FrmBiiling()
    {
      InitializeComponent();
    }
    FinancialCrmDbEntities db = new FinancialCrmDbEntities();
    public void BillList()
    {
      var values = db.Bills.ToList();
      dataGridView1.DataSource = values;
    }
    private void button11_Click(object sender, EventArgs e)
    {
      int id = int.Parse(txtBillId.Text);
      var removeValue = db.Bills.Find(id);
      db.Bills.Remove(removeValue);
      db.SaveChanges();
      MessageBox.Show("Ödeme Bilgisi Başarılı Şekilde Silindi", "Ödeme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      BillList();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void FrmBiiling_Load(object sender, EventArgs e)
    {
      BillList();
    }

    private void btnBillList_Click(object sender, EventArgs e)
    {
      BillList();

    }

    private void btnCreateBill_Click(object sender, EventArgs e)
    {
      string title = txtBillTitle.Text;
      decimal amount = decimal.Parse(txtBillAmount.Text);
      string period = txtBillPeriod.Text;

      Bills bill = new Bills();
      bill.BillTitle = title;
      bill.BillAmount = amount;
      bill.BillPeriod = period;
      db.Bills.Add(bill);
      db.SaveChanges();
      MessageBox.Show("Ödeme Başarılı bir şekilde sisteme eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
      BillList();

    }

    private void btnUpdateBill_Click(object sender, EventArgs e)
    {
      string title = txtBillTitle.Text;
      decimal amount = Decimal.Parse(txtBillAmount.Text);
      string period = txtBillPeriod.Text;
      int id = int.Parse(txtBillId.Text);

      var values = db.Bills.Find(id);
      values.BillTitle = title;
      values.BillAmount = amount;
      values.BillPeriod = period;
      db.SaveChanges();
      MessageBox.Show("Ödeme Planı Başarıyla Güncellendi");

      BillList();
    }

    private void btnBanksForm_Click(object sender, EventArgs e)
    {
      FrmBanks frmBanks = new FrmBanks();
      frmBanks.Show();
      this.Hide();
    }
  }
}
