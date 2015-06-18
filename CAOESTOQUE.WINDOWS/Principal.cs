using System;
using System.Windows.Forms;

namespace Principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value+5;
            }
            else
            {
                timer1.Enabled = false;
                var log = new FrmLogin();
                log.Show();
                Visible = false;
            }
        }

      
       
    }
}
