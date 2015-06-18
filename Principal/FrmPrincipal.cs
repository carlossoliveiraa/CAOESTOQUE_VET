using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            FrmCadastroCliente cli = new FrmCadastroCliente();
            cli.ShowDialog();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cli = new FrmCadastroCliente();
            cli.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente clilista = new FrmConsultaCliente();
            clilista.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente clilista = new FrmConsultaCliente();
            clilista.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmCadastrarAgendamento servlista = new FrmCadastrarAgendamento(0);
            servlista.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarAgendamento servlista = new FrmCadastrarAgendamento(0);
            servlista.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmListaServico cadastrodeservico = new FrmListaServico();
            cadastrodeservico.ShowDialog();

        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListaServico cadastrodeservico = new FrmListaServico();
            cadastrodeservico.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmConsultaPagtosPendentes pagamentospendentes = new FrmConsultaPagtosPendentes();
            pagamentospendentes.ShowDialog();

        }

        private void sobreSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();

        }

        private void agendamentoNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmCadastrarAgendamento Fcli = new FrmCadastrarAgendamento();
            //Fcli.ShowDialog();
        }

        private void relatórioClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioClientes clientes = new FrmRelatorioClientes();
            clientes.explortarexcel();
          //  clientes.ShowDialog();

        }

        private void relatórioDiárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioDiario diario = new FrmRelatorioDiario();
            diario.ShowDialog();
           
        }

        

    }
}
