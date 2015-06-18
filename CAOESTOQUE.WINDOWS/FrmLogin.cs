using System;
using System.Configuration;
using System.Windows.Forms;

namespace Principal
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

 
        private void entrarbutton_Click(object sender, EventArgs e)
        {
            string user = ConfigurationManager.AppSettings["user"].Trim();
            string password = ConfigurationManager.AppSettings["password"].Trim();

            if ((logintextBox.Text == user) && (senhatextBox.Text == password))
            {
                var frmprin = new FrmPrincipal();
                frmprin.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalido", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logintextBox.Text = "";
                senhatextBox.Text = "";
                logintextBox.Focus();
                
            }
        }


        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logintextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void senhatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void logintextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.entrarbutton.PerformClick();
            if (e.KeyCode == Keys.Escape)
                this.cancelarbutton.PerformClick();
        }
    }
}
