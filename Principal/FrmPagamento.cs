using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Principal
{
    public partial class FrmPagamento : Form
    {

        public SqlConnection conexao = new SqlConnection(@"Data Source=localhost\SqlExpress;
                                                         Initial Catalog=SalaoCabelereiro;
                                                         Integrated Security=True");


       int id;

        public FrmPagamento(int id)
        {
            InitializeComponent();
            this.id = id;
            idservicotextBox.Text = id.ToString();
            carregacamposSERV();
        }

   


        public void carregacamposSERV()
        {
           // valdo.entity.eServico S = new valdo.entity.eServico();
           // valdo.dal.dServico MS = new valdo.dal.dServico();
           // DataTable dt = new DataTable();
           // S.Id_Servico = Convert.ToInt32(idservicotextBox.Text);
           // dt = MS.PesquisaIDServico(S);
           //if (dt.Rows.Count > 0)
           // {
           //     ServicotextBox.Text = dt.Rows[0]["Servico"].ToString().Trim();
           //     CodclienteservicotextBox.Text = dt.Rows[0]["Id_Cliente"].ToString().Trim();
           // }
           // else
           //     MessageBox.Show("Nao existe serviço cadastrado");
        }

        public void carregagrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select SS.Id_Servico [NºServiço], CC.Nome, SS.DataServico, SS.Servico [Tipo de Serviço], SS.ValorServico [Valor Serviço Pendente],SS.SituacaoPagto from Servico SS join Cliente CC on CC.Id_Cliente = SS.Id_cliente where SS.SituacaoPagto = 'Não' and CC.Id_Cliente = '" + CodclienteservicotextBox.Text + "' ", conexao);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
      

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            carregagrid();          
        }


        private bool ValidarCampos()
        {
            bool validate = false;

            if (formapagtocomboBox.Text == "")
            {
                MessageBox.Show("Selecione uma forma de Pagamento");
            }

            else
            {
                validate = true;
            }

            return validate;
        }

        private void salvarbutton_Click(object sender, EventArgs e)
        {
            //if (ValidarCampos())
            //{
            //    valdo.entity.eServico S = new valdo.entity.eServico();
            //    valdo.dal.dServico MS = new valdo.dal.dServico();

            //    S.Id_Servico = Convert.ToInt32(idservicotextBox.Text);
            //    S.ValorServico = Convert.ToDouble(valorservicotextBox.Text);
            //    S.ValorPago = Convert.ToDouble(valorpagotextBox.Text);

            //    S.SituacaoPagto = formapagtocomboBox.Text;

            //    S.StatusServico = "FEC";

            //    if (MS.AlteraServicopag(S))
            //    {

            //        MessageBox.Show("Pagamento Cadastrado com Sucesso e Serviço Fechado!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        carregagrid();
            //        Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Pagamento não cadastrado!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
          
        }

        private void valorservicotextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void valorservicotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 & e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void valorpagotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 & e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            FrmPagamento FPag = new FrmPagamento(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(dataGridView1.SelectedCells[0].RowIndex)].Cells["NºServiço"].Value.ToString().Trim()));
            FPag.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select SS.Id_Servico [NºServiço], CC.Nome, SS.DataServico, SS.Servico [Tipo de Serviço], SS.ValorServico [Valor Serviço Pendente],SS.SituacaoPagto from Servico SS join Cliente CC on CC.Id_Cliente = SS.Id_cliente where SS.SituacaoPagto = 'Não' and CC.Id_Cliente = '" + CodclienteservicotextBox.Text + "' ", conexao);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            da.UpdateCommand = builder.GetUpdateCommand();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
