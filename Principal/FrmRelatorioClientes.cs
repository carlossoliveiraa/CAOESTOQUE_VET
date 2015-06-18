using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel_12 = Microsoft.Office.Interop.Excel;


namespace Principal
{
    public partial class FrmRelatorioClientes : Form
    {
        public SqlConnection conexao = new SqlConnection(@"Data Source=localhost\SqlExpress;
                                                         Initial Catalog=SalaoCabelereiro;
                                                         Integrated Security=True");



        public void explortarexcel()
        {
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excelapp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            excelapp.Visible = true;
            try
            {
                // pegando a primeira planilha do excel;
                // deixando-a como ativa e ao final,
                // será atribuido um nome a ela.

                // Excel_12.Worksheet Worksheet = new Excel_12.Worksheet();

                worksheet = (Excel_12.Worksheet)workbook.Sheets["Plan1"];
                worksheet = (Excel_12.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Exportado de um DataGridView";

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
                //workbook.SaveAs(@"C:\DGVToExcel.xlsx",
                //    Type.Missing, Type.Missing, Type.Missing,
                //    Type.Missing, Type.Missing,
                //    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                //    Type.Missing, Type.Missing, Type.Missing,
                //    Type.Missing, Type.Missing);

                //MessageBox.Show("Arquivo criado com sucesso");

            }
            catch (Exception ex)
            {
                Close();
               // MessageBox.Show("Erro: " + ex.Message);
            }
        }


        public FrmRelatorioClientes()
        {
            InitializeComponent();
            carregagrid();          
        }

        private void FrmRelatorioClientes_Load(object sender, EventArgs e)
        {

        }

        public void carregagrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Id_Cliente,Nome,Email,Endereco,Numero,CPF,Aniversario From Cliente  where Status = 0 order by nome", conexao);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            explortarexcel();
            Close();         

        }


    }
}
