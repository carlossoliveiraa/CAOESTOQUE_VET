using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CAOESTOQUE.DAO;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmSaidaProdutos : Form
    {

        #region Propriedades
        public string Barcodes { get; set; }
        public int Idloja { get; set; }
        public double qtdemestoque { get; set; }
        public string codigobarrasinput { get; set; }
        public string precoinput { get; set; }
        public double precocadastradoKiloNoBD { get; set; }
        public double precodaEtiqueta { get; set; }
        public double resultadoemgramascalculada { get; set; }
        public string nomecliente { get; set; }
        public string tipopagto { get; set; }
        public string observacao { get; set; }
        public double subtotal { get; set; }
        public int qtd { get; set; }
        public DataTable DatatableEstoque;
        public DataTable DatatableClone;
        private DateTime datavenda_;


        public double valordesconto { get; set; }
        public double preco_ { get; set; }
        public double precofinalfechamentopedido { get; set; }

        #endregion

        public FrmSaidaProdutos()
        {
            InitializeComponent();
            txtdatasaida.Text = @" " + DateTime.Now.ToString("F");
       
            chkDinheiro.Checked = true;
            datagridSaidaProdutos.AutoGenerateColumns = false;
            this.datagridSaidaProdutos.Columns[0].Visible = false;
        }

      
        private void MetodoUnidade(out DataTable resposta)
        {
            // sempre vou ter q buscar os produtos q estao em estoque
            //pq a medida q for saindo uma venda..ele ja carrega pra ver se acabou
            // podia colocar no pagload da pagina mais neste caso sempre tenho q dar get na tabela de estoque
            DatatableEstoque = new SaidaProdutosMetodos().ListarProdutosEstoque();
            //busca o produto e sua quantidade em estoque no banco.( metodo buscaproduto ) 
            resposta = new SaidaProdutosMetodos().ListarProdutosBarcode(Barcodes);
            //todo: primeira coisa. ve se tem dados no datatable q eh responsavel pelos itens add.
            // datatableestoque é o datatable que esta todos os produtos em estoque da tabela estoque.
            if (DatatableEstoque.Rows.Count > 0 && resposta.Rows.Count > 0)
            {
                //todo:pega apenas a linha do datatable q eh responsavel pelos itens add e joga no datarow.
                DataRow[] drqtdestoque = DatatableEstoque.Select(string.Format("IdProduto = '{0}'", resposta.Rows[0]["IdProduto"]));

                if (drqtdestoque.Length > 0)
                {
                    qtdemestoque = Convert.ToDouble(drqtdestoque[0]["QtdEstoque"]);

                    //Int32 qtdesaida = Convert.ToInt32(resposta.Rows[0]["Qtde"]);

                    if (qtdemestoque <= 0)
                    {
                        MessageBox.Show("PRODUTO ACABOU NO ESTOQUE!!!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //if (qtdemestoque < qtdesaida)
                    //{
                    //    MessageBox.Show("PRODUTO ACABOU NO ESTOQUE!!!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return;
                    //}
                }
            }
            else
            {
                MessageBox.Show("PRODUTO ACABOU NO ESTOQUE OU NÃO FOI FEITO A ENTRADA DELE NO SISTEMA!!!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (DatatableClone == null || DatatableClone.Rows.Count == 0)
            {
                DatatableClone = resposta;
            }
            else
            {
                DatatableClone.Merge(resposta);
            }

            datagridSaidaProdutos.DataSource = DatatableClone;

            //zero toda vez aqui pois no for ele vai varrer tudo de novo mesmo pra dar o somatorio
            MetodoSomaGrid();

        }

        private void MetodoKilo(out string inteiro, out string centavos, out string moeda, out DataTable resp)
        {
            DatatableEstoque = new SaidaProdutosMetodos().ListarProdutosEstoque();
            // 2010800002140 convertendo os dados da etiqueta cod barras
            //TIPOCATEGORIA = "KILO";
            codigobarrasinput = Barcodes.Substring(0, 7);
            precoinput = Barcodes.Substring(7, 6);
            inteiro = precoinput.Substring(0, 3);
            centavos = precoinput.Substring(3, 3);
            moeda = inteiro + "," + centavos;
            precodaEtiqueta = Math.Round(double.Parse(moeda), 2);

            resp = new SaidaProdutosMetodos().ListarProdutosBarcode(codigobarrasinput);
            //busco  o preco do produto q esta cadastrado no banco tb produtos
            if (resp.Rows.Count > 0)
            {
                //todo:pega apenas a linha do datatable q eh responsavel pelos itens add e joga no datarow.
                DataRow[] drqtdestoque = DatatableEstoque.Select(string.Format("IdProduto = '{0}'", resp.Rows[0]["IdProduto"]));
                qtdemestoque = Convert.ToDouble(drqtdestoque[0]["QtdEstoque"]);
                //Int32 qtdesaida = Convert.ToInt32(resposta.Rows[0]["Qtde"]);
                if (qtdemestoque <= 0)
                {
                    MessageBox.Show("PRODUTO ACABOU NO ESTOQUE!!!!!", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                Idloja = 1;
                var idproduto = resp.Rows[0]["IdProduto"];
                var recebedobancopreco = resp.Rows[0]["Preco"];
                string nome = resp.Rows[0]["Nome"].ToString();
                string qtdentrada = resp.Rows[0]["Qtdentrada"].ToString();
                string tipocateg = resp.Rows[0]["TIPOCATEGORIA"].ToString();


                precocadastradoKiloNoBD = Convert.ToDouble(recebedobancopreco) * 1000;
                resultadoemgramascalculada = ((1000 * precodaEtiqueta) / precocadastradoKiloNoBD) / 1000;
                resultadoemgramascalculada = Math.Round(resultadoemgramascalculada, 3);


                var dt = DataTableKilo(idproduto, nome, qtdentrada, tipocateg);
                //apenas montei o data table aqui na unha pra n vir do banco. pois o peso e quilo eh calculado na hora
                DataTable respostakilo = dt;

                if (DatatableClone == null || DatatableClone.Rows.Count == 0)
                {
                    DatatableClone = respostakilo;
                }
                else
                {
                    DatatableClone.Merge(respostakilo);
                }

                datagridSaidaProdutos.DataSource = DatatableClone;
            }
            else
            {
                MessageBox.Show(@"PRODUTO ACABOU NO ESTOQUE OU NÃO FOI FEITO A ENTRADA DELE NO SISTEMA!!!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //zero toda vez aqui pois no for ele vai varrer tudo de novo mesmo pra dar o somatorio

            MetodoSomaGrid();
        }

        private void MetodoSomaGrid()
        {
            qtd = 0;
            subtotal = 0;

            if (DatatableClone == null || DatatableClone.Rows.Count == 0)
            {
                MessageBox.Show(@"Não existe produtos cadastrados na entrada de Estoque!!!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < DatatableClone.Rows.Count; i++)
            {
                qtd += 1;

                preco_ = Convert.ToDouble(DatatableClone.Rows[i]["Preco"]);
                subtotal += preco_;

                lblqtd.Text = Convert.ToString(qtd);
                lblsubtotal.Text = subtotal.ToString("F");

                //total desconto
                lblvalorpagar.Text = subtotal.ToString("F");
                precofinalfechamentopedido = subtotal;
            }
        }

        private DataTable DataTableKilo(object idproduto, string nome, string qtdentrada, string tipocateg)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id_loja", typeof(int));
            dt.Columns.Add("IdProduto", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Barcode", typeof(string));
            dt.Columns.Add("Qtdentrada", typeof(string));
            dt.Columns.Add("Preco", typeof(string));
            dt.Columns.Add("Qtde", typeof(string));
            dt.Columns.Add("TIPOCATEGORIA", typeof(string));
            DataRow dr = dt.NewRow();
            // criar as colunas deste datatable
            dr["Id_loja"] = Idloja;
            dr["IdProduto"] = idproduto;
            dr["Nome"] = nome;
            dr["Barcode"] = codigobarrasinput;
            dr["Qtdentrada"] = qtdentrada;
            dr["Preco"] = precodaEtiqueta;
            dr["Qtde"] = resultadoemgramascalculada;
            dr["TIPOCATEGORIA"] = tipocateg;
            dt.Rows.Add(dr);
            return dt;
        }

        private void chkDinheiro_Click(object sender, EventArgs e)
        {
            chkCartao.Checked = false;
            chkCheque.Checked = false;
        }

        private void chkCheque_Click(object sender, EventArgs e)
        {
            chkDinheiro.Checked = false;
            chkCartao.Checked = false;
        }

        private void chkCartao_Click(object sender, EventArgs e)
        {
            chkDinheiro.Checked = false;
            chkCheque.Checked = false;
        }

        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtbarcode.TextLength > 12)
                {
                    //LblErros.Visible = false;
                    Barcodes = txtbarcode.Text.Trim();

                    if (Barcodes.Count() < 13)
                    {
                        MessageBox.Show(@"Código de Barras Inválido");
                        txtbarcode.Text = Barcodes;
                        txtbarcode.Focus();
                        return;
                    }

                    string codverificador = Barcodes.Substring(0, 1);

                    if (codverificador == "2")
                    {
                        string inteiro;
                        string centavos;
                        string moeda;
                        DataTable resp;
                        MetodoKilo(out inteiro, out centavos, out moeda, out resp);

                        txtbarcode.Clear();
                        txtbarcode.Focus();
                    }
                    else
                    {
                        DataTable resposta;
                        MetodoUnidade(out resposta);

                        txtbarcode.Clear();
                        txtbarcode.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(@"Código de Barras Inválido!!!!!", @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbarcode.Clear();
                    txtbarcode.Focus();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (datagridSaidaProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show(@"Nenhum registro selecionado para Exclusão!!!", @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var idproduto = int.Parse(datagridSaidaProdutos.CurrentRow.Cells["IdProduto"].Value.ToString());

            if (idproduto > 0)
            {
                var remove = -1;
                for (var i = 0; i < DatatableClone.Rows.Count; i++)
                {
                    if (DatatableClone.Rows[i]["IdProduto"].ToString() == Convert.ToString(idproduto))
                    {
                        remove = i;
                        break;
                    }
                }

                if (remove > -1)
                {
                    DatatableClone.Rows.RemoveAt(remove);
                }

            }
            datagridSaidaProdutos.DataSource = DatatableClone;

            txtdesconto.Text = "0";

            MetodoSomaGrid();



        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (DatatableClone == null)
            {
                MessageBox.Show(@"Adicione Produtos para salvar o pedido!!!!!", @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> ItensProduto = new List<string>();

            //  string data =  Request["data_1"] != string.Empty ? Request["data_1"] : DateTime.Now.ToString();
            nomecliente = TxtNomeCliente.Text.Trim() != string.Empty ? TxtNomeCliente.Text.Trim() : "Sem Nome Cliente";
            datavenda_ = DateTime.Now;

            string status = "0";

            if (chkDinheiro.Checked)
            {
                tipopagto = "Dinheiro";
            }

            if (chkCheque.Checked)
            {
                tipopagto = "Cheque";
            }
            if (chkCartao.Checked)
            {
                tipopagto = "Cartão";
            }

            observacao = TxtObservacao.Text.Trim();

            //Cria o pedido aqui. depois add os itens do pedido
            int saidapedido = new SaidaProdutosMetodos().InserePedido(Idloja, datavenda_, nomecliente,tipopagto,subtotal, valordesconto, precofinalfechamentopedido,  observacao, status);

            //grava primeira tabela do pedido e retonar o id
            //int saidapedido = criasaidaproduto.CreateSaidaProduto(Idloja, datavenda_, nomecliente, tipopagto, observacao);

            if (saidapedido > 0)
            {
                foreach (System.Data.DataRow item in DatatableClone.Rows)
                {
                    ItensProduto.Clear();
                    //IdPedido    
                    ItensProduto.Add(Convert.ToString(saidapedido));
                    //Id Produto
                    ItensProduto.Add(item.ItemArray[1].ToString());
                    //NomeProduto
                    ItensProduto.Add(item.ItemArray[2].ToString());
                    //qtde
                    ItensProduto.Add(item.ItemArray[6].ToString());
                    //preco
                    ItensProduto.Add(item.ItemArray[5].ToString());
                    //data do dia
                    ItensProduto.Add(DateTime.Now.ToString());
                    //status
                    ItensProduto.Add("0");
                    //id da loja
                    ItensProduto.Add(Idloja.ToString());
                    //tipo categoria
                    ItensProduto.Add(item.ItemArray[7].ToString());

                    var itensdopedido = new SaidaProdutosMetodos().InsereItensdoPedido(ItensProduto);
                }

                if (saidapedido > 0)
                {
                    MessageBox.Show(@"Venda Realizada com Sucesso!!!", @"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbarcode.Clear();
                    txtbarcode.Focus();
                    DatatableClone = null;
                    datagridSaidaProdutos.DataSource = DatatableClone;

                    lblqtd.Text = string.Empty;
                    lblsubtotal.Text = string.Empty;
                    txtdesconto.Text = "0";
                    lblvalorpagar.Text = string.Empty;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdesconto_TextChanged(object sender, EventArgs e)
        {
            int desconto = 0;
            int.TryParse(txtdesconto.Text, out desconto);
            valordesconto = subtotal * desconto / 100;
            precofinalfechamentopedido = subtotal - valordesconto;
            lblvalorpagar.Text = precofinalfechamentopedido.ToString("F");
        }

     


    }
}
