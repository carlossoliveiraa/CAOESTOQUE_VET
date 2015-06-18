using System;
using System.Configuration;
using System.Windows.Forms;
using CAOESTOQUE.DAO;
using CAOESTOQUE.ENTITY;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmCadastroProdutos : Form
    {
        public FrmCadastroProdutos()
        {
            InitializeComponent();
            CarregarCategoriasNoCombo();
            CarregarGridProdutos();
        }

        

        private int _idprod;
        private int IdCat;
        private string NomeCat { get; set; }

        private void CarregarCategoriasNoCombo()
        {
            dataGridViewProdutos.AutoGenerateColumns = false;
            var list = new CategoriasMetodos().ListarDtCategorias();
            // cbBanco1.DataSource = dataAccess.ObterTodos().OrderBy(b=>b.Codigo).ToList();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = -1;

        }


        private void CarregarGridProdutos()
        {
            var todosProdutos = new ProdutosMetodos().ListarTodos();
            dataGridViewProdutos.DataSource = todosProdutos;
        }


        private void CadastrarProduros()
        {
            if (txtnomeproduto.Text == string.Empty)
            {
                MessageBox.Show("O NOME DO PRODUTO É OBRIGATORIO!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione uma categoria!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            var nometipocategoria = new CategoriasMetodos().ListarTipoCategoriabyId(Convert.ToInt32(comboBox1.SelectedValue));
            NomeCat = nometipocategoria.TipoCategoria.Trim();

            var listaprod = new ProdutosMetodos().ListarPorBarcode(txtbarcode.Text.Trim());
            if (listaprod != null)
            {
                MessageBox.Show("Produto já Cadastrado no Sistema!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbarcode.Text = string.Empty;
                txtnomeproduto.Text = string.Empty;
                txtbarcode.Focus();
            }
            else
            {

                var prod = new Produtos
                {
                    Id = 0,
                    Barcode = txtbarcode.Text.Trim(),
                    IdCategoria = Convert.ToInt32(comboBox1.SelectedValue),
                    IdFornecedor = 1,
                    Nome = txtnomeproduto.Text.TrimStart().TrimEnd().ToUpper(),
                    QtdeMinima = Convert.ToInt32(ConfigurationManager.AppSettings["quantidademinima"]),
                    Situacao = 0,
                    Preco = maskedTxtPreco.Text.Trim().Replace(",", "."),
                    TipoCategoria = NomeCat
                };
                new ProdutosMetodos().Salvar(prod);
                MessageBox.Show("Produto cadastrado com sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbarcode.Text = string.Empty;
                txtnomeproduto.Text = string.Empty;
                maskedTxtPreco.Text = string.Empty;
                comboBox1.SelectedIndex = -1;
                CarregarGridProdutos();
            }
        }

     

        public void LoadGridbyName(string nome)
        {
            var list = new ProdutosMetodos().ListarPorNome(nome.ToUpper());
            dataGridViewProdutos.DataSource = list;
        }
        

        private void btnSalvarProdutos_Click(object sender, EventArgs e)
        {
            if (_idprod > 0)
            {
                if (txtnomeproduto.Text == string.Empty)
                {
                    txtnomeproduto.Focus();
                    MessageBox.Show("O NOME DO PRODUTO É OBRIGATORIO!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                    if (comboBox1.SelectedIndex == -1)
                    {
                        txtnomeproduto.Focus();
                        MessageBox.Show("Selecione uma categoria!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                var nometipocategoria = new CategoriasMetodos().ListarTipoCategoriabyId(Convert.ToInt32(comboBox1.SelectedValue));
                NomeCat = nometipocategoria.Nome.Trim();

                var prod = new Produtos
                {
                    Id = _idprod,
                    Barcode = txtbarcode.Text.Trim(),
                    IdCategoria = Convert.ToInt32(comboBox1.SelectedValue),
                    IdFornecedor = 1,
                    Nome = txtnomeproduto.Text.TrimStart().TrimEnd().ToUpper(),
                    QtdeMinima = Convert.ToInt32(ConfigurationManager.AppSettings["quantidademinima"]),
                    Situacao = 0,
                    Preco = maskedTxtPreco.Text.Trim().Replace(",", "."),
                    TipoCategoria = NomeCat.ToString()
                };
                new ProdutosMetodos().Alterar(prod);

                MessageBox.Show("Produto alterado com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                lblCadastrarouAlterar.Text = "Cadastrar Produtos";
                txtbarcode.Text = string.Empty;
                txtbarcode.Focus();
                txtnomeproduto.Text = string.Empty;
                comboBox1.SelectedIndex = -1;
                CarregarGridProdutos();
                _idprod = 0;

            }
            else
            {
                CadastrarProduros();
            }

        }

        private void brnExcluirProdutos_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado para Exclusão!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var resultado = MessageBox.Show("Deseja Excluir este Registro??", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                return;
            }
            var idproduto = int.Parse(dataGridViewProdutos.CurrentRow.Cells[0].Value.ToString());
            new ProdutosMetodos().Excluir(idproduto);
            MessageBox.Show("Produto excluido com Sucesso!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            CarregarGridProdutos();
        }

        private void dataGridViewProdutos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CarregarCategoriasNoCombo();

                lblCadastrarouAlterar.Text = "Alterar Produto";
                var idproduto = int.Parse(dataGridViewProdutos.CurrentRow.Cells[0].Value.ToString());
                Produtos listar = new ProdutosMetodos().ListarPorId(idproduto);
                _idprod = listar.Id;
                txtbarcode.Text = listar.Barcode.Trim();
                txtnomeproduto.Text = listar.Nome.Trim().ToUpper();

                //comboBox1.SelectedIndex = listar.IdCategoria - 1;
                comboBox1.SelectedValue = listar.IdCategoria;
                //cbxtipocategoria.ValueMember = listar.TipoCategoria;
                maskedTxtPreco.Text = listar.Preco;
                //cbxtipocategoria.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Entre em contato com o Administrador do Sistema!" + "Erro: " + ex, "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void PesquisatextBox_TextChanged(object sender, EventArgs e)
        {
            LoadGridbyName(PesquisatextBox.Text.Trim());
        }

        private void maskedTxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
