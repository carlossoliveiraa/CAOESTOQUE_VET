using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel_12 = Microsoft.Office.Interop.Excel;
using System.Globalization;
using System.Text.RegularExpressions;



namespace Principal
{
    public partial class FrmRelatorioDiario : Form
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


        public FrmRelatorioDiario()
        {
            InitializeComponent();
           
            DataInicialtextBox.Text = Convert.ToString(DateTime.Now);
            DataFinalTextBox.Text = Convert.ToString(DateTime.Now);

            datainicialI = DataInicialtextBox.Text;
            datafinalF = DataFinalTextBox.Text;

            carregagrid();
            

        }

       


       

      
        private void FrmRelatorioDiario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ExportDataGridViewTo_Excel12(dataGridView1);
            // instanciando as variáveis
            explortarexcel();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        

        public void carregagrid()
        {
            CultureInfo culture = new CultureInfo("pt-br");
           
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select SS.Id_Servico [NºServiço],CC.Nome, SS.DataServico,convert(char(10), SS.DataPagto,103) [Data Pagto],SS.ValorServico [Valor Serviço],SS.SituacaoPagto from Servico SS join Cliente CC on CC.Id_Cliente = SS.Id_cliente where convert(char(10), SS.DataPagto,103) between '" + datainicialI + "' and '" + datafinalF + "'  ", conexao);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        string datainicialI;
        string datafinalF;

        private void button2_Click(object sender, EventArgs e)
        {         

            datainicialI = DataInicialtextBox.Text.Trim();
            datafinalF = DataFinalTextBox.Text.Trim();
            carregagrid();
        }


    }
}
