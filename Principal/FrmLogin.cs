using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Principal
{
    public partial class FrmLogin : Form
    {
       
        public FrmLogin()
        {
            InitializeComponent();
        }

        //private void entrarbutton_Click(object sender, EventArgs e)
        //{
        //    if ((logintextBox.Text == "admin") && (senhatextBox.Text == "admin"))
        //    {
        //        FrmPrincipal frmprin = new FrmPrincipal();
        //        frmprin.Show();
        //        this.Visible = false;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Usuário ou senha invalido","Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        logintextBox.Text = "";
        //        senhatextBox.Text = "";
        //        logintextBox.Focus();
                
        //    }
        //}

        private void entrarbutton_Click(object sender, EventArgs e)
        {

            FrmPrincipal frmprin = new FrmPrincipal();
            frmprin.Show();


            //valdo.entity.Usuario u = new valdo.entity.Usuario();
            //valdo.dal.Usuario buscaU = new valdo.dal.Usuario();
            //DataTable dt = new DataTable();


            //u.Login = logintextBox.Text;
            //u.Senha = senhatextBox.Text;

            //dt = buscaU.VerificaUsuario(u);
            //if (dt.Rows.Count > 0)
            //{
            //    FrmPrincipal frmprin = new FrmPrincipal();
            //    frmprin.Show();
            //    this.Visible = false;
            //}
            //else
            //{
            //    MessageBox.Show("Usuário ou senha invalido", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    logintextBox.Text = "";
            //    senhatextBox.Text = "";
            //    logintextBox.Focus();

            //}


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
