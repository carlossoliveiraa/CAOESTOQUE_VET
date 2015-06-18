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
    public partial class FrmPagamentosPendentes : Form
    {
        public SqlConnection conexao = new SqlConnection(@"Data Source=localhost\SqlExpress;
                                                         Initial Catalog=SalaoCabelereiro;
                                                         Integrated Security=True");


        public FrmPagamentosPendentes()
        {
            InitializeComponent();           
        }
        

          int id;

          public FrmPagamentosPendentes(int id)
        {
            InitializeComponent();
            this.id = id;
            idservicotextBox.Text = id.ToString();
            carregacamposSERV();
        }

          private void panel1_Paint(object sender, PaintEventArgs e)
          {

          }


          public void carregacamposSERV()
          {
              //valdo.entity.eServico S = new valdo.entity.eServico();
              //valdo.dal.dServico MS = new valdo.dal.dServico();
              //DataTable dt = new DataTable();
              //S.Id_Servico = Convert.ToInt32(idservicotextBox.Text);
              //dt = MS.PesquisaIDServico(S);
              //if (dt.Rows.Count > 0)
              //{
              //    ServicotextBox.Text = dt.Rows[0]["Servico"].ToString().Trim();
              //    CodclienteservicotextBox.Text = dt.Rows[0]["Id_Cliente"].ToString().Trim();
              //}
              //else
              //    MessageBox.Show("Nao existe serviço cadastrado");
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
              //        Close();
              //    }
              //    else
              //    {
              //        MessageBox.Show("Pagamento não cadastrado!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              //    }
              //}
          }

          private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

       
    }
}
