using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CAOESTOQUE.ENTITY;
using CAOESTOQUE.REPOSITORIO;
using System.Linq;

namespace CAOESTOQUE.DAO
{
    public sealed class CategoriasMetodos
    {
        internal Contexto contexto;

        private void InserirCategoria(Categorias cat)
        {
            try
            {
                var strQuery = "";
                strQuery += " INSERT INTO CATEGORIAS(Nome,Situacao, TipoCategoria)";
                strQuery += string.Format(" VALUES ('{0}','{1}','{2}') ",
                cat.Nome, cat.Situacao, cat.TipoCategoria);

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

        public void AlterarCategoria(Categorias cat)
        {
            try
            {
                var strQuery = "";
                strQuery += " UPDATE CATEGORIAS SET ";
                strQuery += string.Format(" Nome ='{0}', ", cat.Nome.Trim());
                strQuery += string.Format(" TipoCategoria ='{0}', ", cat.TipoCategoria.Trim());
                strQuery += string.Format(" Situacao ='{0}' ", cat.Situacao);
                strQuery += string.Format(" WHERE Id = {0} ", cat.Id);

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

        public void Salvar(Categorias cat)
        {
            if (cat.Id > 0)
            {
                AlterarCategoria(cat);
            }
            else
            {
                InserirCategoria(cat);
            }
        }

        public void ExcluirCategoria(int id)
        {
            try
            {
                var strQuery = "";
                strQuery += " UPDATE CATEGORIAS SET ";
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
        public List<Categorias> ListarTodasCategorias()
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = " SELECT * FROM CATEGORIAS WHERE SITUACAO = 0";
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
        public List<Categorias> ListarPorNome(string nome)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    //var strQuery = string.Format(" SELECT * FROM CATEGORIAS WHERE Nome like '%{0}%'  and Situacao = 0", nome.TrimStart().TrimEnd());
                    var strQuery = string.Format(" SELECT * FROM CATEGORIAS WHERE Nome = '{0}' and Situacao = 0", nome.TrimStart().TrimEnd());
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
        public Categorias ListarPorId(int id)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = string.Format(" SELECT * FROM CATEGORIAS WHERE id = {0}  and Situacao = 0", id);
                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader).FirstOrDefault();
                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public List<Categorias> TransformarReaderEmListaObjetos(SqlDataReader reader)
        {
            try
            {
                var cat = new List<Categorias>();
                while (reader.Read())
                {
                    var temObjeto = new Categorias
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nome = reader["Nome"].ToString(),
                        TipoCategoria = reader["TipoCategoria"].ToString(),
                        Situacao = Convert.ToByte(reader["Situacao"])
                    };

                    cat.Add(temObjeto);
                }
                reader.Close();
                return cat;
            }
            catch (Exception e)
            {

                throw e;
            }

        }


        public DataTable ListarDtCategorias()
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("TipoCategoria", typeof(string));

                contexto = new Contexto();
                var strQuery = " SELECT * FROM CATEGORIAS WHERE SITUACAO = 0";
                var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);

                while (retornodatareader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Id"] = int.Parse(retornodatareader["Id"].ToString().Trim());
                    dr["Nome"] = retornodatareader["Nome"].ToString().Trim();
                    dr["TipoCategoria"] = retornodatareader["TipoCategoria"].ToString().Trim();

                    dt.Rows.Add(dr);
                }

                return dt;

            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public DataTable ListarDtCategoriasTIPO()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Nome", typeof(string));
                dt.Rows.Add(1, "KILO");
                dt.Rows.Add(2, "UNIDADE");
                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }

        }


        public Categorias ListarTipoCategoriabyId(Int32 id)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = string.Format(" SELECT * FROM CATEGORIAS WHERE id = {0}  and Situacao = 0", id);
                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader).FirstOrDefault();
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
