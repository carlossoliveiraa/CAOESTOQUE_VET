using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using CAOESTOQUE.ENTITY;
using CAOESTOQUE.REPOSITORIO;

namespace CAOESTOQUE.DAO
{
    public sealed class ClientesMetodos
    {
        internal Contexto contexto;

        private void Inserir(Clientes cli)
        {
            try
            {
                var strQuery = "";
                strQuery += " INSERT INTO CLIENTES(Nome,Email,Endereco,Numero,Bairro,Cidade,UF,TelFixo,TelCel,TelCom,CPF,Aniversario,Sexo,Observacao,Situacao)";
                strQuery += string.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}') ",
                cli.Nome, cli.Email, cli.Endereco, cli.Numero, cli.Bairro, cli.Cidade, cli.UF, cli.TelFixo, cli.TelCel, cli.TelCom, cli.CPF, cli.Aniversario, cli.Sexo, cli.Observacao, cli.Situacao);

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

        private void Alterar(Clientes cli)
        {
            try
            {

                var strQuery = "";
                strQuery += " UPDATE CLIENTES SET ";
                strQuery += string.Format(" Nome ='{0}', ", cli.Nome.Trim());
                strQuery += string.Format(" Email ='{0}', ", cli.Email.Trim());
                strQuery += string.Format(" Endereco ='{0}', ", cli.Endereco.Trim());
                strQuery += string.Format(" Numero ='{0}', ", cli.Numero.Trim());
                strQuery += string.Format(" Bairro ='{0}', ", cli.Bairro.Trim());
                strQuery += string.Format(" Cidade ='{0}', ", cli.Cidade.Trim());
                strQuery += string.Format(" UF ='{0}', ", cli.UF.Trim());
                strQuery += string.Format(" TelFixo ='{0}', ", cli.TelFixo.Trim());
                strQuery += string.Format(" TelCel ='{0}', ", cli.TelCel.Trim());
                strQuery += string.Format(" TelCom ='{0}', ", cli.TelCom.Trim());
                strQuery += string.Format(" CPF ='{0}', ", cli.CPF.Trim());
                strQuery += string.Format(" Aniversario ='{0}', ", cli.Aniversario.Trim());
                strQuery += string.Format(" Sexo ='{0}', ", cli.Sexo.Trim());
                strQuery += string.Format(" Observacao ='{0}', ", cli.Observacao.Trim());
                strQuery += string.Format(" Situacao ='{0}' ", cli.Situacao);
                strQuery += string.Format(" WHERE Id = {0} ", cli.Id);

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

        public void Salvar(Clientes cli)
        {
            if (cli.Id > 0)
            {
                Alterar(cli);
            }
            else
            {
                Inserir(cli);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                var strQuery = "";
                strQuery += " UPDATE CLIENTES SET ";
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
        public List<Clientes> ListarTodos()
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = " SELECT * FROM CLIENTES where situacao = 0";
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
        public Clientes ListarPorId(int id)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = string.Format(" SELECT * FROM CLIENTES WHERE Id = {0}  and Situacao = 0", id);
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
        public List<Clientes> ListarPorNome(string nome)
        {
            try
            {
                using (contexto = new Contexto())
                {
                   
                        var strQuery = string.Format(@"SELECT * FROM CLIENTES 
                                            WHERE Nome like '%{0}%' or cpf like '%{0}%' or Email like '%{0}%'
                                            or TelFixo like '%{0}%' or TelCom like '%{0}%' or
                                            TelCel like '%{0}%' or cpf like '%{0}%' 
                                            and Situacao = 0", nome);
                        var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                        return TransformarReaderEmListaObjetos(retornodatareader);
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public List<Clientes> TransformarReaderEmListaObjetos(SqlDataReader reader)
        {
            try
            {
                var Cli = new List<Clientes>();
                while (reader.Read())
                {
                    var temObjeto = new Clientes
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nome = reader["Nome"].ToString(),
                        Email = reader["Email"].ToString(),
                        Endereco = reader["Endereco"].ToString(),
                        Numero = reader["Numero"].ToString(),
                        Bairro = reader["Bairro"].ToString(),
                        Cidade = reader["Cidade"].ToString(),
                        UF = reader["UF"].ToString(),
                        TelFixo = reader["TelFixo"].ToString(),
                        TelCel = reader["TelCel"].ToString(),
                        TelCom = reader["TelCom"].ToString(),
                        CPF = reader["CPF"].ToString(),
                        Aniversario = reader["Aniversario"].ToString(),
                        Sexo = reader["Sexo"].ToString(),
                        Observacao = reader["Observacao"].ToString(),
                        Situacao = Convert.ToByte(reader["Situacao"])
                    };
                    Cli.Add(temObjeto);
                }
                reader.Close();
                return Cli;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

    }
}
