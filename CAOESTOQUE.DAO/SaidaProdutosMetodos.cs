using System;
using System.Collections.Generic;
using System.Data;
using CAOESTOQUE.REPOSITORIO;

namespace CAOESTOQUE.DAO
{
    public sealed class SaidaProdutosMetodos
    {
        internal Contexto contexto;

        public int InserePedido(int Idloja, DateTime datavenda_, string nomecliente, string tipopagto,
            double valordesconto, double subtotal, double total, string observacao, string status)
        {
            try
            {
                int id = 0;
                string strQuery = "";
                strQuery += " INSERT INTO SaidaProdutos(Id_Loja, DataVenda, NomeCliente, TipoPagto,PrecoSubTotalPedido, Desconto, precoTotalPedido, Observacao, Status  )";
                strQuery += string.Format(" VALUES ({0},'{1}','{2}','{3}',{4}, {5}, {6},'{7}', {8}) ", 1, datavenda_.ToString("yyyy/MM/dd"),
                    nomecliente, tipopagto, valordesconto.ToString().Replace(",", "."), subtotal.ToString().Replace(",", "."), total.ToString().Replace(",", "."), observacao, status);

                strQuery += "SELECT CAST(scope_identity() AS int)";

                using (contexto = new Contexto())
                {
                    id = contexto.ExecutaComandoScalar(strQuery);
                }
                //id = IdInserido();
                return id;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public int IdInserido()
        {
            try
            {
                int id = 0;
                contexto = new Contexto();
                var strQuery = string.Format(@" select max(id) as Id from saidaprodutos");
                var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                while (retornodatareader.Read())
                {
                    id = int.Parse(retornodatareader["Id"].ToString().Trim());
                }
                return id;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public int InsereItensdoPedido(List<string> ItensProduto)
        {
            try
            {
                string strQuery = "";
                strQuery += " INSERT INTO SaidaProdutosItens(Id_Pedido, Id_Produto, NomeProduto, Qtde, Preco,  DateIn, [Status], Id_Loja, TipoCategoria  )";
                strQuery += string.Format(" VALUES ({0},{1},'{2}',{3}, {4}, '{5}', {6}, {7},'{8}') ",
                ItensProduto[0], ItensProduto[1], ItensProduto[2], ItensProduto[3].Replace(",", "."), ItensProduto[4].Replace(",", "."), Convert.ToDateTime(ItensProduto[5]).ToString("yyyy/MM/dd"), ItensProduto[6],
                1, ItensProduto[8]);
                using (contexto = new Contexto())
                {
                    contexto.ExecutaComando(strQuery);
                }

                return 1;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        //metodo pronto. busca os produtos em estoque. tabela estoque
        public DataTable ListarProdutosEstoque()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Id_loja", typeof(int));
                dt.Columns.Add("IdProduto", typeof(int));
                dt.Columns.Add("Produto", typeof(string));
                dt.Columns.Add("QtdEstoque", typeof(string));

                contexto = new Contexto();

                var strQuery = string.Format(@" Select  e.Id_loja,
                                                    e.Id_Produto as IdProduto, 
                                                    p.Nome as Produto, 
                                                    SUM(ISNULL(e.Qtdentrada,0) - (ISNULL(e.QtdSaida,0))) as QtdEstoque
                                            from estoque e 
                                            inner join Produtos p on e.Id_Produto = p.Id 
                                            where p.situacao = 0 
                                            group by  Id_loja, Id_Produto, p.Nome ");


                var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);

                while (retornodatareader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Id_loja"] = int.Parse(retornodatareader["Id_loja"].ToString().Trim());
                    dr["IdProduto"] = retornodatareader["IdProduto"].ToString().Trim();
                    dr["Produto"] = retornodatareader["Produto"].ToString().Trim();
                    dr["QtdEstoque"] = retornodatareader["QtdEstoque"].ToString().Trim();

                    dt.Rows.Add(dr);
                }

                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }

        }



        public DataTable ListarProdutosBarcode(string barcode)
        {
            try
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

                contexto = new Contexto();
                var strQuery = string.Format(@"select 
                                               Id_Loja,
                                               Id_Produto,		
                                               p.Nome,	   
                                               p.Barcode,
                                               sum(QtdeEntrada) [Qtdentrada],
                                               ep.Preco,
                                               p.TIPOCATEGORIA,
                                               '1' as Qtde					  
                                               from EntradaProdutos (nolock) ep
                                               inner join Produtos (nolock) p on ep.Id_Produto = p.Id
                                            where p.situacao = 0 and  p.Barcode = '{0}'
                                            group by Id_Loja, Id_Produto,p.Nome, ep.Preco, p.Barcode, p.TIPOCATEGORIA ", barcode.TrimStart().TrimEnd());


                var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);

                while (retornodatareader.Read())
                {
                    DataRow dr = dt.NewRow();
                    // criar as colunas deste datatable
                    dr["Id_loja"] = int.Parse(retornodatareader["Id_loja"].ToString().Trim());
                    dr["IdProduto"] = retornodatareader["Id_Produto"].ToString().Trim();
                    dr["Nome"] = retornodatareader["Nome"].ToString().Trim();
                    dr["Barcode"] = retornodatareader["Barcode"].ToString().Trim();
                    dr["Qtdentrada"] = retornodatareader["Qtdentrada"].ToString().Trim();
                    dr["Preco"] = retornodatareader["Preco"].ToString().Trim();
                    dr["Qtde"] = retornodatareader["Qtde"].ToString().Trim();
                    dr["TIPOCATEGORIA"] = retornodatareader["TIPOCATEGORIA"].ToString().Trim();

                    dt.Rows.Add(dr);
                }

                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

    }
}
