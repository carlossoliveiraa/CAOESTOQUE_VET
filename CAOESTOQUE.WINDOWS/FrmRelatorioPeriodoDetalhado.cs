using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAOESTOQUE.DAO;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmRelatorioPeriodoDetalhado : Form
    {
        public FrmRelatorioPeriodoDetalhado()
        {
            InitializeComponent();

            txtDatainicial.Text = DateTime.Now.ToString("d");
            txtDataFinal.Text = DateTime.Now.ToString("d");

            dataGridViewRelatorio.AutoGenerateColumns = false;

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

        private void btnexportExcel_Click(object sender, EventArgs e)
        {
            if (dataGridViewRelatorio.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "produtosvendidos.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(dataGridView1, @"c:\export.xls");
                    ToCsV(dataGridViewRelatorio, sfd.FileName); // Here dataGridview1 is your grid view name 
                }

                MessageBox.Show("Dados Exportado com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Não Existe Dados Para exportar para o Excel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string datein = txtDatainicial.Text.Trim();
            string dateend = txtDataFinal.Text.Trim();
            DateTime dateinn;
            DateTime dateendd;
            DataTable dt = new DataTable();
            int totalItens = 0;
            double totalPedido = 0;

            if (DateTime.TryParse(datein, out dateinn) && DateTime.TryParse(dateend, out dateendd))
            {
                if (dateinn > dateendd)
                {
                    MessageBox.Show("A DATA Inicial não pode ser maior que a DATA Final!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                datein = dateinn.ToString("d");
                dateend = dateendd.ToString("d");

                var list = new RelatorioPeriodoMetodos().ListarporPeriodoDetalhado(datein, dateend);

                dataGridViewRelatorio.DataSource = list;

                for (int i = 0; i < list.Count; i++)
                {
                    totalItens += 1;
                    totalPedido += Convert.ToDouble(list[i].Preco);
                }

            }
        }
    }
}
