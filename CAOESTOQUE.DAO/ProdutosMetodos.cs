using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using CAOESTOQUE.ENTITY;
using CAOESTOQUE.REPOSITORIO;

namespace CAOESTOQUE.DAO
{
    public sealed class ProdutosMetodos
    {
        internal Contexto contexto;

        private void Inserir(Produtos prod)
        {
            try
            {
                string strQuery = "";
                strQuery += " INSERT INTO PRODUTOS(Nome,Id_Categoria,Id_fornecedor,QtdeMinima,Barcode,Preco,Situacao, TIPOCATEGORIA)";
                strQuery += string.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}') ",
                prod.Nome, prod.IdCategoria, prod.IdFornecedor, prod.QtdeMinima, prod.Barcode, prod.Preco, prod.Situacao, prod.TipoCategoria);

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

        public void Alterar(Produtos prod)
        {
            try
            {
                var strQuery = "";
                strQuery += " UPDATE PRODUTOS SET ";
                strQuery += string.Format(" Nome ='{0}', ", prod.Nome.Trim());
                strQuery += string.Format(" Id_Categoria ='{0}', ", prod.IdCategoria);
                strQuery += string.Format(" Id_fornecedor ='{0}', ", prod.IdFornecedor);
                strQuery += string.Format(" QtdeMinima ='{0}', ", prod.QtdeMinima);
                strQuery += string.Format(" Barcode ='{0}', ", prod.Barcode);
                strQuery += string.Format(" Situacao ='{0}', ", prod.Situacao);
                strQuery += string.Format(" TIPOCATEGORIA ='{0}', ", prod.TipoCategoria);
                strQuery += string.Format(" Preco ='{0}' ", prod.Preco);

                strQuery += string.Format(" WHERE Id = {0} ", prod.Id);

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

        public void Salvar(Produtos prod)
        {
            if (prod.Id > 0)
            {
                Alterar(prod);
            }
            else
            {
                Inserir(prod);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                var strQuery = "";
                strQuery += " UPDATE PRODUTOS SET ";

                strQuery += string.Format(" Situacao ='{0}' ", 1);

                strQuery += string.Format(" WHERE Id = {0} ", id);

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

        // todo este contexto de dados do banco é transformado em objeto. no caso objto Aluno.
        public List<Produtos> ListarTodos()
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = @"SELECT P.id [Id], P.nome [Nome], P.QtdeMinima [QtdeMinima],
                            P.Id_Categoria [Id_Categoria], CAT.nome [NomeCategoria], 
                            P.barcode [Barcode], P.Preco [Preco], P.situacao [Situacao], P.TIPOCATEGORIA FROM PRODUTOS P 
                            INNER JOIN CATEGORIAS CAT ON P.ID_CATEGORIA = CAT.ID where p.situacao = 0";
                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader);
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        //Listar aluno por id. apenas um objeto
        public Produtos ListarPorId(int id)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    //var strQuery = string.Format(" SELECT * FROM PRODUTOS WHERE id = {0}  and Situacao = 0", id);
                    var strQuery = string.Format(@"SELECT P.id [Id], P.nome [Nome], P.QtdeMinima [QtdeMinima],
                            P.Id_Categoria [Id_Categoria], CAT.nome [NomeCategoria], 
                            P.barcode [Barcode],P.Preco [Preco], P.situacao [Situacao],P.TIPOCATEGORIA FROM PRODUTOS P 
                            INNER JOIN CATEGORIAS CAT ON P.ID_CATEGORIA = CAT.ID where p.situacao = 0 and P.Id = {0} ", id);

                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader).FirstOrDefault();
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }


        //Listar aluno por id. apenas um objeto
        public Produtos ListarPorBarcode(string barcode)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    //var strQuery = string.Format(" SELECT * FROM PRODUTOS WHERE BARCODE = '{0}' and Situacao = 0", barcode.TrimStart().TrimEnd());

                    var strQuery = string.Format(@"SELECT P.id [Id], P.nome [Nome], P.QtdeMinima [QtdeMinima],
                            P.Id_Categoria [Id_Categoria], CAT.nome [NomeCategoria], 
                            P.barcode [Barcode], P.Preco [Preco], P.situacao [Situacao],P.TIPOCATEGORIA FROM PRODUTOS P 
                            INNER JOIN CATEGORIAS CAT ON P.ID_CATEGORIA = CAT.ID where p.situacao = 0 and P.Barcode ='{0}'", barcode.TrimStart().TrimEnd());


                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader).FirstOrDefault();
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }


        //Listar aluno por id. apenas um objeto
        public List<Produtos> ListarPorNome(string nome)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    if (nome != string.Empty && nome != null)
                    {
                        //var strQuery = string.Format(" SELECT * FROM PRODUTOS WHERE Nome like '%{0}%' ", nome);

                        var strQuery = string.Format(@"SELECT P.id [Id], P.nome [Nome], P.QtdeMinima [QtdeMinima],
                            P.Id_Categoria [Id_Categoria], CAT.nome [NomeCategoria], 
                            P.barcode [Barcode], P.Preco [Preco], P.situacao [Situacao], P.TIPOCATEGORIA FROM PRODUTOS P 
                            INNER JOIN CATEGORIAS CAT ON P.ID_CATEGORIA = CAT.ID where p.situacao = 0 and P.Nome like '%{0}%' OR CAT.NOME like '%{0}%' ", nome);

                        var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                        return TransformarReaderEmListaObjetos(retornodatareader);
                    }
                    else
                    {
                        var strQuery = @"SELECT P.id [Id], P.nome [Nome], P.QtdeMinima [QtdeMinima],
                            P.Id_Categoria [Id_Categoria], CAT.nome [NomeCategoria], 
                            P.barcode [Barcode], P.Preco [Preco], P.situacao [Situacao], P.TIPOCATEGORIA FROM PRODUTOS P 
                            INNER JOIN CATEGORIAS CAT ON P.ID_CATEGORIA = CAT.ID where p.situacao = 0";
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

        // strQuery += " INSERT INTO PRODUTOS(Nome,Id_Categoria,Id_fornecedor,QtdeMinima,Barcode,Situacao)";
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
                        Nome = reader["Nome"].ToString().Trim(),
                        QtdeMinima = Convert.ToInt32(reader["QtdeMinima"]),
                        IdCategoria = Convert.ToInt32(reader["Id_Categoria"]),
                        NomeCategoria = reader["NomeCategoria"].ToString(),
                        Barcode = reader["Barcode"].ToString().Trim(),
                        Preco = reader["Preco"].ToString().Trim(),
                        TipoCategoria = reader["TIPOCATEGORIA"].ToString(),
                        Situacao = Convert.ToByte(reader["Situacao"])
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
