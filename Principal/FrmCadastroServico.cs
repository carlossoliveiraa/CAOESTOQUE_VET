using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Data.SqlClient;

namespace Principal
{
    public partial class FrmCadastrarAgendamento : Form
    {

        public SqlConnection conexao = new SqlConnection(@"Data Source=localhost\SqlExpress;
                                                         Initial Catalog=SalaoCabelereiro;
                                                         Integrated Security=True");



        public FrmCadastrarAgendamento(int id)
        {
            InitializeComponent();
            calendariodateTimePicker1.Text = Convert.ToString(DateTime.Now);
            PesquisatextBox.Focus();

        }

      
        public void carregacampos()
        {
            //valdo.entity.eCliente cliE = new valdo.entity.eCliente();
            //valdo.dal.Clientes Cliente = new valdo.dal.Clientes();
            //DataTable dt = new DataTable();
            //cliE.Id = Convert.ToInt32(idservicotextBox.Text);
            //dt = Cliente.PesquisaID(cliE);
            //if ((dt.Rows.Count > 0) && (dt.Rows[0]["Status"].ToString().Equals("0")))
            //{
            //    nomeclienteservicotextBox.Text = dt.Rows[0]["Nome"].ToString().Trim();
            //    cpftextBox.Text = dt.Rows[0]["CPF"].ToString().Trim();
            //    panel4.Enabled = true;
            //    horaServicotextBox.Focus();
            //}
            //else
            //    MessageBox.Show("Nao existe cliente cadastrado");
        }


        private bool ValidarCampos()
        {
            bool validate = false;

            if(ServicotextBox.Text =="")
            {
                ServicotextBox.Focus();
                servicolabel.Visible = true;
            }
                          
            else if (!Regex.IsMatch(horaServicotextBox.Text,@"^([0-1][0-9]|[2][0-3]):[0-5][0-9]$") || (horaServicotextBox.Text == "") || (horaServicotextBox.Text == "  :"))
            {
                horaServicotextBox.Focus();
                horaservicolabel.Visible = true; 
            }
           
           else
           {
               validate = true;
           }

           return validate;                     
 
        }



        private void salvarbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Em desenvolvimento");
        }

      


        public void carregagrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Id_Cliente,Nome,Email,Endereco,Numero,CPF From Cliente  where Status = 0 and Nome like '%" + PesquisatextBox.Text + "%' or CPF like '%" + PesquisatextBox.Text + "%' and Status='0' order by nome", conexao);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }



        private void salvarbutton_Click_1(object sender, EventArgs e)
        {
            //if (ValidarCampos())
            //{
            //CultureInfo culture = new CultureInfo("pt-br");
            //valdo.entity.eServico S = new valdo.entity.eServico();
            //valdo.dal.dServico MS = new valdo.dal.dServico();
            //S.Id_Cliente = Convert.ToInt32(idservicotextBox.Text);
            //S.DataServico = calendariodateTimePicker1.Value;
            //S.HoraServico = DateTime.ParseExact(string.Format("{0}", horaServicotextBox.Text, "00:00"), "HH:mm", culture);
            //S.Servico = ServicotextBox.Text.Trim();
            //S.ValorServico = Convert.ToDouble(0);
            //S.ValorPago = Convert.ToDouble(0);
            //S.SituacaoPagto = "";
            //S.StatusServico = "PEN";
            //S.DataPagto = DateTime.Now;
            //int result = MS.Inserir(S);
            //CodigoServicolabel.Text = result.ToString();

            //if (result > 0)
            //{
            //    MessageBox.Show("Serviço Cadastrado com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);               
            //    Close();
            //}
            //else
            //{
            //    MessageBox.Show("Serviço não cadastrado!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //}

        }

       

        private void PesquisatextBox_TextChanged(object sender, EventArgs e)
        {
            carregagrid();
        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //FrmCadastrarAgendamento Fcli = new FrmCadastrarAgendamento(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(dataGridView1.SelectedCells[0].RowIndex)].Cells["Id_cliente"].Value.ToString().Trim()));
            //Fcli.ShowDialog(); 
            //carregacampos();
        }

       

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            idservicotextBox.Text = (dataGridView1.Rows[Convert.ToInt32(dataGridView1.SelectedCells[0].RowIndex)].Cells["Id_cliente"].Value.ToString().Trim());
            carregacampos();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
       
        
    }
}
