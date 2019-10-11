using System;
using System.Windows.Forms;

namespace PrestigeClient_WinForms
{
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindPurchaces ff = new FindPurchaces();
            ff.ShowDialog();
        }
    }
}
