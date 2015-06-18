using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CAOESTOQUE.DAO;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            //this.dataGridView1.Columns[0].Visible = false;
            InitializeComponent();


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].Visible = false;

            LoadGrid();
            PesquisatextBox.Focus();
        }


        public void LoadGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            var list = new ClientesMetodos().ListarTodos();
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = list;
          
        }

        public void LoadGridbyName(string nome)
        {
            var list = new ClientesMetodos().ListarPorNome(nome);
            dataGridView1.DataSource = list;
        }

        private void PesquisatextBox_TextChanged(object sender, EventArgs e)
        {
            LoadGridbyName(PesquisatextBox.Text.TrimStart().TrimEnd().ToUpper());       
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmCadastroCliente Fcli = new FrmCadastroCliente(Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(dataGridView1.SelectedCells[0].RowIndex)].Cells["Id"].Value.ToString().Trim()));
            Fcli.FormClosed += FrmCadastroClienteClose;
            Fcli.ShowDialog();
            //Close();
           
        }

        private void btnnovocliente_Click(object sender, EventArgs e)
        {
            var cli = new FrmCadastroCliente(0);
            cli.FormClosed += FrmCadastroClienteClose;
            cli.ShowDialog();
            
        }

        private void FrmCadastroClienteClose(object sender, FormClosedEventArgs e)
        {
            LoadGrid();
        }



        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado para Exclusão!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            System.Windows.Forms.DialogResult resultado = MessageBox.Show("Deseja Excluir este Registro??", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                return;
            }
            var idcliente = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            new ClientesMetodos().Excluir(idcliente);
            MessageBox.Show("Cliente Excluido com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LoadGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadGrid();
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
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "clientescadastrados.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(dataGridView1, @"c:\export.xls");
                    ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name 
                    MessageBox.Show("Dados Exportado com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }              
            }
            else
            {
                MessageBox.Show("Não Existe Dados Para exportar para o Excel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

    }
}
