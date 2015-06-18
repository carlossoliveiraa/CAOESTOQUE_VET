using System;
using System.Configuration;
using System.Windows.Forms;
using CAOESTOQUE.DAO;
using CAOESTOQUE.WINDOWS;


namespace Principal
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var cli = new FrmConsultaCliente();
            cli.ShowDialog();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cli = new FrmConsultaCliente();
            cli.ShowDialog();
        }

     


        private void sobreSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sobre = new Sobre();
            sobre.ShowDialog();
        }



        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CreateBackup();
        }

        private void CreateBackup()
        {
            try
            {
                string nomebanco = ConfigurationManager.AppSettings["nomebanco"].Trim();
                string caminho = ConfigurationManager.AppSettings["caminhobackup"].Trim();
                new BackupMetodos().FazerBackup(nomebanco,caminho);
                MessageBox.Show(@"Backup Feito com Sucesso!", @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Problema ao fazer backup. Erro  " + ex, @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

      
        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroanimais = new FrmCadastroAnimais();
            cadastroanimais.ShowDialog();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            var cadastroanimais = new FrmCadastroAnimais();
            cadastroanimais.ShowDialog();
        }




    }
}
