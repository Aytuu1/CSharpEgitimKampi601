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
  public partial class FinancialCrm : Form
  {
    private UserControl _activeControl;
    public FinancialCrm()
    {
      InitializeComponent();
    }

    private void LoadControl(UserControl control)
    {
      if (_activeControl != null)
      {
        pnlContent.Controls.Remove(_activeControl);
      }
      _activeControl = control;
      _activeControl.Dock = DockStyle.Fill;
      pnlContent.Controls.Add(_activeControl);
    }
    private void FinancialCrm_Load(object sender, EventArgs e)
    {

    }

    private void pnlContent_Paint(object sender, PaintEventArgs e)
    {

    }

    private void btnBanksForm_Click(object sender, EventArgs e)
    {

    }
  }
}
