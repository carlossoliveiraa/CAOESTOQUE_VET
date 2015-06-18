using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Principal
{
    public partial class FrmListaServico : Form
    {
        public FrmListaServico()
        {
            InitializeComponent();
        }

        public SqlConnection conexao = new SqlConnection(@"Data Source=localhost\SqlExpress;
                                                         Initial Catalog=SalaoCabelereiro;
                                                         Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void carregagrid()
        {          
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select SS.Id_Servico [NºServiço], CC.Nome, CC.CPF, convert(char(10),SS.DataServico,103)as 'Data do Serviço', convert(char(10),SS.HoraServico,108)as Horas, SS.Servico [Tipo de Serviço] from Servico SS join Cliente CC on CC.Id_Cliente = SS.Id_cliente where SS.StatusServico ='PEN' order by SS.DataServico, SS.HoraServico ", conexao);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmConsultasdeServico_Load(object sender, EventArgs e)
        {
            carregagrid();                    
        }

        private void pesquisarServicobutton_Click(object sender, EventArgs e)
        {
           // CultureInfo culture = new CultureInfo("pt-br");
           // valdo.entity.eServico S = new valdo.entity.eServico();
           // valdo.dal.dServico MS = new valdo.dal.dServico();
           //// DataTable dt = new DataTable();
           // //SqlDataAdapter da = new SqlDataAdapter();

           // S.dataInicial = DateTime.ParseExact(string.Format("{0} {1}", DataInicialtextBox.Text, "00:00:00"), "dd/MM/yyyy HH:mm:ss", culture);
           // S.datafinal = DateTime.ParseExact(string.Format("{0} {1}", DataFinalTextBox.Text, "23:59:59"), "dd/MM/yyyy HH:mm:ss", culture);
                                 
           //dataGridView1.DataSource = MS.PesquisarHoraHora(S);
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //FrmPagamento pag = new FrmPagamento();
            //pag.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmPagamento FPag = new FrmPagamento(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(dataGridView1.SelectedCells[0].RowIndex)].Cells["NºServiço"].Value.ToString().Trim()));
            FPag.ShowDialog();
            carregagrid();
        }
    }
}


