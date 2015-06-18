using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CAOESTOQUE.DAO;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();

            dataGridViewEstoque.AutoGenerateColumns = false;

            var list = new RelatorioEstoqueMetodos().ListarTodosEstoque();
            dataGridViewEstoque.DataSource = list;
        }

        private void PesquisatextBox_TextChanged(object sender, System.EventArgs e)
        {
            LoadGridbyName(PesquisatextBox.Text.TrimStart().TrimEnd().ToUpper());   
        }

        public void LoadGridbyName(string nome)
        {
            var list = new RelatorioEstoqueMetodos().ListarPorNome(nome);
            dataGridViewEstoque.DataSource = list;
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            //for (int i = 0; i < dGV.RowCount - 1; i++)
            for (int i = 0; i < dGV.RowCount; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void btnexportExcel_Click(object sender, System.EventArgs e)
        {
            if (dataGridViewEstoque.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "estoque.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(dataGridView1, @"c:\export.xls");
                    ToCsV(dataGridViewEstoque, sfd.FileName); // Here dataGridview1 is your grid view name 
                }

                MessageBox.Show("Dados Exportado com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Não Existe Dados Para exportar para o Excel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
        }
    }
}
