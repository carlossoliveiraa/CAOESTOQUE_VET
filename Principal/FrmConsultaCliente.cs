using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Principal
{
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
            carregagrid();
            PesquisatextBox.Focus();
        }

        public SqlConnection conexao = new SqlConnection(@"Data Source=localhost\SqlExpress;
                                                         Initial Catalog=SalaoCabelereiro;
                                                         Integrated Security=True");

        private void Pesquisarbutton_Click(object sender, EventArgs e)
        {
                   
        }

        private void FrmListaRapida_Load(object sender, EventArgs e)
        {
           
        }


        public void carregagrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Id_Cliente,Nome,Email,Endereco,Numero,CPF From Cliente  where Status = 0 and Nome like '%" + PesquisatextBox.Text + "%' or CPF like '%" + PesquisatextBox.Text + "%' and Status='0' order by nome", conexao);
            da.Fill(dt);
            dataGridView1.DataSource = dt;          
          
        }

        private void PesquisatextBox_TextChanged(object sender, EventArgs e)
        {
            carregagrid();          
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           // FrmAlteraClientePeloGrid cli = new FrmAlteraClientePeloGrid();            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {                       
            FrmAlterarCliente Fcli = new FrmAlterarCliente(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(dataGridView1.SelectedCells[0].RowIndex)].Cells["Id_cliente"].Value.ToString().Trim()));
            Fcli.ShowDialog();
            carregagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook =  excelapp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            excelapp.Visible = true;
            try
            {
                // pegando a primeira planilha do excel;
                // deixando-a como ativa e ao final,
                // será atribuido um nome a ela.

                //worksheet = (Worksheet)workbook.Sheets["Plan1"];
                //worksheet = (Worksheet)workbook.ActiveSheet;
                //worksheet.Name = "Exportado de um DataGridView";

                // pegando os nomes das colunas do DataGridView
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] =
                        dataGridView1.Columns[i - 1].HeaderText;
                }

                // fazendo um loop no DataGridView, que recupera as rows
                // do DataGridView, correspondente a cada column.
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] =
                            dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // ao final, salva no formato do Excel.
                workbook.SaveAs(@"C:\DGVToExcel.xlsx",
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing);

                MessageBox.Show("Arquivo criado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
