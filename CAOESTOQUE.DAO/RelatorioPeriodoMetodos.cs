using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CAOESTOQUE.ENTITY;
using CAOESTOQUE.REPOSITORIO;

namespace CAOESTOQUE.DAO
{
    public sealed class RelatorioPeriodoMetodos
    {
        internal Contexto contexto;

        public List<Produtos> ListarporPeriodo(string datein, string dateend)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = string.Format(@" select S.Id_Produto, S.NomeProduto, REPLACE(CONVERT(VARCHAR(10), S.DateIn, 103), '.', '/')as DateIn, 
                                                    S.qtde,S.preco from SaidaProdutos sp  
                                                    inner join SaidaProdutosItens  S on sp.Id = S.Id_Pedido                         
                                                    where  s.DateIn between '{0}' and '{1}' order by 4", Convert.ToDateTime(datein).ToString("yyyy/MM/dd"),
                                                                                                       Convert.ToDateTime(dateend).ToString("yyyy/MM/dd"));


                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader);
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }


        public List<Produtos> ListarporPeriodoDetalhado(string datein, string dateend)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = string.Format(@" SELECT 
                                                          s.Id [IdPedido],
                                                          REPLACE(CONVERT(VARCHAR(10), S.DataVenda, 103), '.', '/')as DataVenda,
                                                          S.NomeCliente,
                                                          S.TipoPagto,      
                                                          SP.NomeProduto,
                                                          SP.Preco [PrecoUnitario],  
                                                          S.Desconto,   
                                                          S.PrecoSubTotalPedido,     
                                                          S.PrecoTotalPedido,
                                                          S.Observacao    
                                                             FROM SaidaProdutos S
                                                    INNER JOIN SaidaProdutosItens SP on S.Id = sp.Id_Pedido                      
                                                    where  S.DataVenda between '{0}' and '{1}' ", Convert.ToDateTime(datein).ToString("yyyy/MM/dd"),
                                                                                                            Convert.ToDateTime(dateend).ToString("yyyy/MM/dd"));


                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetosDetalhado(retornodatareader);
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }



        public List<Produtos> TransformarReaderEmListaObjetos(SqlDataReader reader)
        {
            try
            {
                var Prod = new List<Produtos>();
                while (reader.Read())
                {
                    var temObjeto = new Produtos
                    {
                        Id = int.Parse(reader["Id_Produto"].ToString()),
                        Nome = reader["NomeProduto"].ToString().Trim(),
                        DataEntrada = DateTime.Parse(reader["DateIn"].ToString().Trim()),
                        Qtde = reader["Qtde"].ToString(),
                        Preco = reader["Preco"].ToString()
                    };
                    Prod.Add(temObjeto);
                }
                reader.Close();
                return Prod;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public List<Produtos> TransformarReaderEmListaObjetosDetalhado(SqlDataReader reader)
        {
            try
            {
                var Prod = new List<Produtos>();
                while (reader.Read())
                {
                    var temObjeto = new Produtos
                    {
                        Id_Pedido = int.Parse(reader["IdPedido"].ToString()),
                        DataVenda = DateTime.Parse(reader["DataVenda"].ToString().Trim()),
                        NomeCliente = reader["NomeCliente"].ToString(),
                        TipoPagto = reader["TipoPagto"].ToString(),
                        NomeProdutoPedido = reader["NomeProduto"].ToString(),
                        PrecoUnitario = reader["PrecoUnitario"].ToString(),
                        Desconto = reader["Desconto"].ToString(),
                        PrecoSubTotalPedido = reader["PrecoSubTotalPedido"].ToString(),
                        PrecoTotalPedido = reader["PrecoTotalPedido"].ToString(),
                        Observacao = reader["Observacao"].ToString()
                       
                    };
                    Prod.Add(temObjeto);
                }
                reader.Close();
                return Prod;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

    }
}
