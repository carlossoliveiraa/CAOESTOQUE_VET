using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using CAOESTOQUE.ENTITY;
using CAOESTOQUE.REPOSITORIO;

namespace CAOESTOQUE.DAO
{
    public sealed class EntradaProdutosMetodos
    {
        internal Contexto contexto;

        public void Inserir(EntradaProdutos prod)
        {
            //voltar prod.DataEntrada.ToString("yyyy/MM/dd")
            try
            {
                string strQuery = "";
                strQuery += " INSERT INTO EntradaProdutos(Id_Loja, Id_Produto, QtdeEntrada, Preco, Dataentrada, Nome, Barcode, TipoCategoria)";
                strQuery += string.Format(" VALUES ({0},{1},{2},{3},'{4}', '{5}','{6}','{7}') ",
                1, prod.Id, prod.QtdeEntrada, prod.Preco, prod.DataEntrada.ToString("yyyy/MM/dd"), prod.Nome, prod.Barcode, prod.TipoCateg);

                using (contexto = new Contexto())
                {
                    contexto.ExecutaComando(strQuery);
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public void Alterar(EntradaProdutos prod)
        {
            try
            {
                var strQuery = "";
                strQuery += " UPDATE ENTRADAPRODUTOS SET ";
                strQuery += string.Format(" Nome ='{0}', ", prod.Nome.Trim());
                strQuery += string.Format(" TipoCategoria ='{0}', ", prod.TipoCateg.Trim());
                strQuery += string.Format(" Barcode ='{0}', ", prod.Barcode);
                strQuery += string.Format(" QtdeEntrada ='{0}', ", prod.QtdeEntrada);
                strQuery += string.Format(" Preco ='{0}' ", prod.Preco);
                strQuery += string.Format(" WHERE Id = {0} ", prod.Id + ";");

                //atualizar tabela estoque
                strQuery += " UPDATE Estoque SET ";
                strQuery += string.Format(" Qtdentrada ='{0}' ", prod.QtdeEntrada);
                strQuery += string.Format(" WHERE Id_Entrada = {0} ", prod.Id);

                using (contexto = new Contexto())
                {
                    contexto.ExecutaComando(strQuery);
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        //Listar aluno por id. apenas um objeto
        public EntradaProdutos ListarPorId(int id)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    //var strQuery = string.Format(" SELECT * FROM PRODUTOS WHERE id = {0}  and Situacao = 0", id);
                    var strQuery = string.Format(@"Select * from EntradaProdutos  where Id = {0} ", id);
                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader).FirstOrDefault();
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        // todo este contexto de dados do banco é transformado em objeto. no caso objto Aluno.
        public List<EntradaProdutos> ListarTodos()
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = @" SELECT TOP 1000 [Id] ,[Id_Loja] ,[Id_Produto] ,convert(decimal(10,0),round([QtdeEntrada],1,1))[QtdeEntrada]
                                        ,[Preco],[Dataentrada],[Barcode],[Nome],[TipoCategoria]  FROM [CAOESTOQUE].[dbo].[EntradaProdutos] order by id desc";
                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader);
                }
            }
            catch (Exception e)
            {
                    
                throw e;
            }
     
        }


        public List<EntradaProdutos> ListarPorNome(string nome)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    if (nome != string.Empty && nome != null)
                    {
                  
                        var strQuery = string.Format(@" SELECT TOP 1000 [Id] ,[Id_Loja] ,[Id_Produto] ,convert(decimal(10,0),round([QtdeEntrada],1,1))[QtdeEntrada]
                                        ,[Preco],[Dataentrada],[Barcode],[Nome],[TipoCategoria]  FROM [CAOESTOQUE].[dbo].[EntradaProdutos] where nome like '%{0}%' order by id desc", nome);
                        var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                        return TransformarReaderEmListaObjetos(retornodatareader);

                    }
                    else
                    {
                        var strQuery = @" SELECT TOP 1000 [Id] ,[Id_Loja] ,[Id_Produto] ,convert(decimal(10,0),round([QtdeEntrada],1,1))[QtdeEntrada]
                                        ,[Preco],[Dataentrada],[Barcode],[Nome],[TipoCategoria]  FROM [CAOESTOQUE].[dbo].[EntradaProdutos] order by id desc";
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


        public List<EntradaProdutos> TransformarReaderEmListaObjetos(SqlDataReader reader)
        {
            try
            {
                var Prod = new List<EntradaProdutos>();
                while (reader.Read())
                {
                    var temObjeto = new EntradaProdutos
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        IdLoja = int.Parse(reader["Id_Loja"].ToString()),
                        IdProduto = int.Parse(reader["Id_Produto"].ToString()),
                        QtdeEntrada = reader["QtdeEntrada"].ToString(),
                        Preco = reader["Preco"].ToString().Trim(),

                        Nome = reader["Nome"].ToString().Trim(),
                        TipoCateg = reader["TipoCategoria"].ToString().Trim(),
                        Barcode = reader["Barcode"].ToString().Trim(),
                        DataEntrada = Convert.ToDateTime(reader["Dataentrada"])


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
