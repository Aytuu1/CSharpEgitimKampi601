using CSharpEgitimKampi601.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
  public partial class AdminLogin : Form
  {
    public AdminLogin()
    {
      InitializeComponent();
    }
    FinancialCrmDbEntities db = new FinancialCrmDbEntities();
    private void txtuserName_TextChanged(object sender, EventArgs e)
    {



    }

    private void btnAdmlnLogin_Click(object sender, EventArgs e)
    {
      var userName = txtuserName.Text.Trim();
      var password = txtuserPassword.Text.Trim();
      var userInformation = db.AdminLogin.ToList();
      foreach (var user in userInformation)
      {
        if (user.UserName == userName & user.Password == password & user.IsAdmin == true)
        {
          FrmDashboard frmDashboard = new FrmDashboard();
          frmDashboard.Show();
          this.Hide();
        }
      }
    }

    private void label2_Click(object sender, EventArgs e)
    {


    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox1.Checked)
      {
        txtuserPassword.UseSystemPasswordChar = false;
      }
      else
      {
        txtuserPassword.UseSystemPasswordChar = true;
      }
    }

    private void txtuserPassword_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
