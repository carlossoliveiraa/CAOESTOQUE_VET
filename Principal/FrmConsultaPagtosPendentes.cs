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
    public partial class FrmConsultaPagtosPendentes : Form
    {

        public SqlConnection conexao = new SqlConnection(@"Data Source=localhost\SqlExpress;
                                                         Initial Catalog=SalaoCabelereiro;
                                                         Integrated Security=True");

       

        public FrmConsultaPagtosPendentes()
        {
           
            InitializeComponent();           
            ConsultanometextBox.Focus();
            carregagrid();
        }

        


        public void carregagrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select SS.Id_Servico [NºServiço], CC.Nome, SS.DataServico, SS.Servico [Tipo de Serviço], SS.ValorServico [Valor Serviço Pendente],SS.SituacaoPagto from Servico SS join Cliente CC on CC.Id_Cliente = SS.Id_cliente where SS.SituacaoPagto = 'Não' and CC.Nome like '%" + ConsultanometextBox.Text + "%' ", conexao);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmConsultaPagtosPendentes_Load(object sender, EventArgs e)
        {
            carregagrid(); 
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmPagamentosPendentes FPag = new FrmPagamentosPendentes(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(dataGridView1.SelectedCells[0].RowIndex)].Cells["NºServiço"].Value.ToString().Trim()));
            FPag.ShowDialog();
            carregagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultanometextBox_TextChanged(object sender, EventArgs e)
        {
            carregagrid();
        }



    }
}
