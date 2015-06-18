using System;
using System.Windows.Forms;
using CAOESTOQUE.DAO;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmVendasRealizadas : Form
    {

        public int totalItens { get; set; }

        public FrmVendasRealizadas()
        {
            InitializeComponent();
            dataGridViewPedidos.AutoGenerateColumns = false;

            try
            {
                var list = new PedidoRealizadoMetodos().ListartodosPedidos();
                dataGridViewPedidos.DataSource = list;

                for (int i = 0; i < list.Count; i++)
                {
                    totalItens += 1;
                }

                lbltotalitens.Text = totalItens.ToString();

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no metodo listartodospedidos - " + e, "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }

        private void btnnovocliente_Click(object sender, EventArgs e)
        {

        }

        public void LoadGridbyName(string nome)
        {
            try
            {
                var list = new PedidoRealizadoMetodos().ListartodosPedidosbyNome(nome);
                dataGridViewPedidos.DataSource = list;

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro no metodo loadprodutosbyname - " + e, "Aviso", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }

        }

        private void PesquisatextBox_TextChanged(object sender, EventArgs e)
        {
            LoadGridbyName(PesquisatextBox.Text.Trim());
        }

        private void dataGridViewPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //aqui
            FrmVendasRealizadasItens Fcli = new FrmVendasRealizadasItens(Convert.ToInt32(dataGridViewPedidos.Rows[Convert.ToInt32(dataGridViewPedidos.SelectedCells[0].RowIndex)].Cells["Id"].Value.ToString().Trim()));
            Fcli.ShowDialog();

        }



    }
}
