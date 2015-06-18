using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using CAOESTOQUE.ENTITY;
using CAOESTOQUE.REPOSITORIO;

namespace CAOESTOQUE.DAO
{
    public sealed class PedidoRealizadoMetodos
    {
        internal Contexto contexto;


        public List<Produtos> ListartodosPedidos()
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = string.Format(@" Select Id, CONVERT(char,DataVenda,103) as DataVenda,  	      
	                                            NomeCliente,TipoPagto,Observacao, Status	
                                                from SaidaProdutos where Status = 0");

                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader);
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }


        public List<Produtos> ListartodosPedidosbyNome(string nome)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    if (nome != string.Empty && nome != null)
                    {
                        var strQuery = string.Format(@" SELECT * FROM SaidaProdutos WHERE NomeCliente like '%{0}%'
                                                      and Status = 0 ", nome);
                        var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                        return TransformarReaderEmListaObjetos(retornodatareader);
                    }
                    else
                    {
                        var strQuery = string.Format(" SELECT * FROM SaidaProdutos where Status = 0 ", nome);
                        var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                        return TransformarReaderEmListaObjetos(retornodatareader);
                    }

                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        //Listar aluno por id. apenas um objeto
        public Produtos ListartodosPedidosbyIdPedido(int id)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = string.Format(" SELECT * FROM SaidaProdutos WHERE Id = {0}  and Status = 0", id);
                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader).FirstOrDefault();
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }


        public List<Produtos> ListartodosPedidosItens(int id)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = string.Format(@" SELECT * FROM SaidaProdutositens WHERE Id_Pedido =  {0} and Status = 0 ", id);
                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetosItens(retornodatareader);
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public List<Produtos> TransformarReaderEmListaObjetosItens(SqlDataReader reader)
        {
            try
            {
                var Prod = new List<Produtos>();
                while (reader.Read())
                {
                    var temObjeto = new Produtos
                    {
                        Id_Pedido = int.Parse(reader["Id_Pedido"].ToString()),
                        NomeProdutoPedido = reader["NomeProduto"].ToString(),
                        QtdeProdutosPedido = reader["Qtde"].ToString(),
                        PrecoProdutosPedido = reader["Preco"].ToString()
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


        public List<Produtos> TransformarReaderEmListaObjetos(SqlDataReader reader)
        {
            try
            {
                var Prod = new List<Produtos>();
                while (reader.Read())
                {
                    var temObjeto = new Produtos
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        DataEntrada = DateTime.Parse(reader["DataVenda"].ToString().Trim()),
                        Nome = reader["NomeCliente"].ToString(),
                        TipoPagto = reader["TipoPagto"].ToString(),
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
