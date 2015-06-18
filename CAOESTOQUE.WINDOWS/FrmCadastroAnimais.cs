using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmCadastroAnimais : Form
    {
        private string fdiretorio;
        public FrmCadastroAnimais()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd2.InitialDirectory = fdiretorio;
            ofd2.Filter = "bmp,jpeg,png|*.bmp;*.jpg;*.png|all files|*.*";
            DialogResult resultado = ofd2.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                picFoto.ImageLocation = ofd2.FileName;
            }
        }
    }
}
