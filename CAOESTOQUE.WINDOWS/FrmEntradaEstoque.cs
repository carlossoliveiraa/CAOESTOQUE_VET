using System;
using System.Data;
using System.Windows.Forms;
using CAOESTOQUE.DAO;
using CAOESTOQUE.ENTITY;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmEntradaEstoque : Form
    {

        private string tipodecategoria;
        private int _idprod;

        private double qtdeentrada;


        public FrmEntradaEstoque()
        {
            InitializeComponent();
            txtbarcode.Focus();
            txtdataentrada.Text = @" " + DateTime.Now.ToString("F");
            LoadGrid();

        }

        public void LoadGrid()
        {
            datagridEntradaProdutos.AutoGenerateColumns = false;
            var list = new EntradaProdutosMetodos().ListarTodos();

            foreach (var var in list)
            {  // apenas alias no campo de conta principal.
                var.TipoCateg = var.TipoCateg.ToLower().Equals("kilo") ? "Gramas" : "Unidades";
            }

            datagridEntradaProdutos.DataSource = null;
            datagridEntradaProdutos.DataSource = list;

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            IncluirProdutosNaEntrada();
        }

        private void IncluirProdutosNaEntrada()
        {
            if (_idprod > 0)
            {
                AlterarProdutoNovo();
            }
            else
            {
                InsereProdutoNovo();
            }
        }

        private void AlterarProdutoNovo()
        {
            var prod = new EntradaProdutos();
            prod.Id = _idprod;
            prod.IdLoja = 1;
            prod.QtdeEntrada = txtQdeEntrada.Text.Trim();
            prod.Preco = txtValorUnitario.Text.Replace(",", ".");
            prod.DataEntrada = DateTime.Now;

            try
            {

                if (tipodecategoria.Trim().ToUpper().Equals("KILO"))
                {
                    prod.Nome = txtnomeproduto.Text.Trim();
                    prod.TipoCateg = txttipocateg.Text.Trim();
                    prod.Barcode = txtbarcode.Text.Trim();

                    int inteiro;
                    double real;
                    if (int.TryParse(txtQdeEntrada.Text, out inteiro))
                    {
                        qtdeentrada = Convert.ToDouble(inteiro);
                    }
                    else
                    {
                        double.TryParse(txtQdeEntrada.Text, out real);
                        qtdeentrada = real;
                    }


                    double qtdentrada = qtdeentrada * 1000;
                    prod.QtdeEntrada = Convert.ToString(qtdentrada);


                    double preco = double.Parse(txtValorUnitario.Text.Replace(".", ","));
                    preco = preco / 1000;
                    prod.Preco = preco.ToString().Replace(",", ".");

                    new EntradaProdutosMetodos().Alterar(prod);
                    MessageBox.Show("Entrada Alterada com Sucesso!!!", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    _idprod = 0;
                    LoadGrid();

                    txtnomeproduto.Text = string.Empty;
                    txttipocateg.Text = string.Empty;
                    txtbarcode.Text = string.Empty;
                    txtbarcode.Focus();
                    txtQdeEntrada.Text = string.Empty;
                    txtValorUnitario.Text = string.Empty;
                   
                }
                else
                {
                    prod.Nome = txtnomeproduto.Text.Trim();
                    prod.TipoCateg = txttipocateg.Text.Trim();
                    prod.Barcode = txtbarcode.Text.Trim();
                    var qtd = Convert.ToDouble(txtQdeEntrada.Text.Trim());
                    prod.QtdeEntrada = qtd.ToString();
                    double preco = double.Parse(txtValorUnitario.Text.Replace(".", ","));
                  
                    prod.Preco = preco.ToString().Replace(",", ".");

                    new EntradaProdutosMetodos().Alterar(prod);
                    MessageBox.Show(@"Entrada Alterada com Sucesso!!!!", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    _idprod = 0;
                    LoadGrid();
                   
                    txtnomeproduto.Text = string.Empty;
                    txttipocateg.Text = string.Empty;
                    txtbarcode.Text = string.Empty;
                    txtbarcode.Focus();
                    txtQdeEntrada.Text = string.Empty;
                    txtValorUnitario.Text = string.Empty;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(@"Erro no metodo alteraprodutos - " + e, @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InsereProdutoNovo()
        {
            var prod = new EntradaProdutos();
            prod.IdLoja = 1;
            prod.Id = Convert.ToInt32(lblIdProduto.Text);
            prod.QtdeEntrada = txtQdeEntrada.Text.Replace(",", ".");
            prod.Preco = txtValorUnitario.Text.Replace(",", ".");
            prod.DataEntrada = DateTime.Now;

            try
            {
                if (tipodecategoria.Trim().ToUpper().Equals("KILO"))
                {
                    prod.Nome = txtnomeproduto.Text.Trim();
                    prod.TipoCateg = txttipocateg.Text.Trim();
                    prod.Barcode = txtbarcode.Text.Trim();

                    int inteiro;
                    double real;
                    if (int.TryParse(txtQdeEntrada.Text, out inteiro))
                    {
                        qtdeentrada = Convert.ToDouble(inteiro);
                    }
                    else
                    {
                        double.TryParse(txtQdeEntrada.Text, out real);
                        qtdeentrada = real;
                    }


                    double qtdentrada = qtdeentrada * 1000;
                    prod.QtdeEntrada = Convert.ToString(qtdentrada);


                    double preco = double.Parse(txtValorUnitario.Text.Replace(".", ","));
                    preco = preco / 1000;
                    prod.Preco = preco.ToString().Replace(",", ".");

                    new EntradaProdutosMetodos().Inserir(prod);
                    MessageBox.Show(@"Entrada Feita com Sucesso!!!", @"Aviso", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    LoadGrid();

                    txtnomeproduto.Text = string.Empty;
                    txttipocateg.Text = string.Empty;
                    txtbarcode.Text = string.Empty;
                    txtbarcode.Focus();
                    txtQdeEntrada.Text = string.Empty;
                    txtValorUnitario.Text = string.Empty;
                    _idprod = 0;
                }
                else
                {
                    prod.Nome = txtnomeproduto.Text.Trim();
                    prod.TipoCateg = txttipocateg.Text.Trim();
                    prod.Barcode = txtbarcode.Text.Trim();
                    var qtd = Convert.ToDouble(txtQdeEntrada.Text.Trim());
                    prod.QtdeEntrada = qtd.ToString();
                    double preco = double.Parse(txtValorUnitario.Text.Replace(".", ","));
                    preco = preco;
                    prod.Preco = preco.ToString().Replace(",", ".");

                    new EntradaProdutosMetodos().Inserir(prod);
                    MessageBox.Show("Entrada Feita com Sucesso!!!", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    LoadGrid();

                    txtnomeproduto.Text = string.Empty;
                    txttipocateg.Text = string.Empty;
                    txtbarcode.Text = string.Empty;
                    txtbarcode.Focus();
                    txtQdeEntrada.Text = string.Empty;
                    txtValorUnitario.Text = string.Empty;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Erro no metodo insereprodutos - " + e, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtQdeEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void txtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        //private void txtbarcode_TextChanged(object sender, EventArgs e)
        //{
        //    BuscarProdutosByBarcode(txtbarcode.Text.Trim());
        //}

        private void BuscarProdutosByBarcode(string barcode)
        {
            barcode = txtbarcode.Text;
            string codverificador = barcode.Substring(0, 1);

            try
            {
                if (codverificador == "2")
                {
                    barcode = barcode.Substring(0, 7);
                }

                var getprodutos = new ProdutosMetodos().ListarPorBarcode(barcode);

                if (getprodutos != null)
                {

                    tipodecategoria = getprodutos.TipoCategoria.Trim();

                    txtQdeEntrada.Focus();
                    txtnomeproduto.Text = getprodutos.Nome.Trim();
                    txttipocateg.Text = getprodutos.TipoCategoria.Trim();

                    //if (getprodutos.TipoCategoria.ToString().Trim().ToUpper().Equals("KILO"))
                    //{
                    lblIdProduto.Text = Convert.ToString(getprodutos.Id);
                    txtValorUnitario.Text = getprodutos.Preco.Trim();
                    // }

                }
                else
                {
                    MessageBox.Show("Produto não cadastrado no sistema!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbarcode.Text = string.Empty;
                    txtbarcode.Focus();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro no metodo buscaprodutoscodigobarras - " + e, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarProdutosByBarcode(txtbarcode.Text.Trim());
        }

        private void datagridEntradaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idproduto = int.Parse(datagridEntradaProdutos.CurrentRow.Cells[0].Value.ToString());
            EntradaProdutos listar = new EntradaProdutosMetodos().ListarPorId(idproduto);
            _idprod = listar.Id;

            tipodecategoria = listar.TipoCateg.Trim();

            if (listar.TipoCateg.Trim().Equals("KILO"))
            {
                txtbarcode.Text = listar.Barcode.ToString();
                txtnomeproduto.Text = listar.Nome.ToString();
                txttipocateg.Text = listar.TipoCateg.ToString();

                double qtdEntrada = Convert.ToDouble (listar.QtdeEntrada) / 1000;
                double preco = double.Parse(listar.Preco);
                preco = preco * 1000;

                txtQdeEntrada.Text = qtdEntrada.ToString();
                txtValorUnitario.Text = preco.ToString("F");

            }
            else
            {
                txtbarcode.Text = listar.Barcode.ToString();
                txtnomeproduto.Text = listar.Nome.ToString();
                txttipocateg.Text = listar.TipoCateg.ToString();
                double qtdEntrada = Convert.ToDouble(listar.QtdeEntrada);
                txtQdeEntrada.Text = qtdEntrada.ToString("0");
                double preco = double.Parse(listar.Preco);
                txtValorUnitario.Text = preco.ToString("F");

            }



        }

        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscarProdutosByBarcode(txtbarcode.Text.Trim());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadGridbyName(string nome)
        {
            var list = new EntradaProdutosMetodos().ListarPorNome(nome.ToUpper());
            datagridEntradaProdutos.DataSource = list;

       }

        private void PesquisatextBox_TextChanged(object sender, EventArgs e)
        {
            LoadGridbyName(PesquisatextBox.Text.Trim());
        }


    }
}
