using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAOESTOQUE.ENTITY;
using CAOESTOQUE.REPOSITORIO;

namespace CAOESTOQUE.DAO
{
    public sealed class RelatorioEstoqueMetodos
    {
        internal Contexto contexto;


        public List<Produtos> ListarTodosEstoque()
        {
            try
            {
                using (contexto = new Contexto())
                {
                    var strQuery = string.Format(@" Select     
                                                      e.Id_Produto as Id,
                                                      p.Nome as Produto,
                                                      CONVERT(decimal(10,0),ROUND(SUM(ISNULL(e.Qtdentrada,0) - (ISNULL(e.QtdSaida,0))),1,1)) as QtdEstoque,    
                                                     case 
                                                         when p.TIPOCATEGORIA ='KILO' then 'Gramas' 
                                                         when p.TIPOCATEGORIA ='UNIDADE' then 'Unids' 
                                                     end as TipoCategoria 
                                                from estoque e
                                                inner join Produtos p on e.Id_Produto = p.Id
                                                group by  Id_Produto, p.Nome, p.TIPOCATEGORIA");

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
        public List<Produtos> ListarPorNome(string nome)
        {
            try
            {
                using (contexto = new Contexto())
                {
                    // if (nome != string.Empty && nome != null) mesma coisa
                    //if (!string.IsNullOrEmpty(nome))
                    var strQuery = string.Format(@" Select     
                                                e.Id_Produto as Id,
                                                p.Nome as Produto,
                                                SUM(ISNULL(e.Qtdentrada,0) - (ISNULL(e.QtdSaida,0))) as QtdEstoque,    
                                                   case 
                                                       when p.TIPOCATEGORIA ='KILO' then 'Gramas' 
                                                       when p.TIPOCATEGORIA ='UNIDADE' then 'Unds' 
                                                   end as TipoCategoria 
                                                 from estoque e
                                                 inner join Produtos p on e.Id_Produto = p.Id
                                                 where p.Nome like '%{0}%'
                                                 group by  Id_Produto, p.Nome, p.TIPOCATEGORIA ", nome);
                    var retornodatareader = contexto.ExecutaComandoComRetorno(strQuery);
                    return TransformarReaderEmListaObjetos(retornodatareader);
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
                        Id = int.Parse(reader["Id"].ToString()),
                        Nome = reader["Produto"].ToString().Trim(),
                        Qtde = reader["QtdEstoque"].ToString(),
                        TipoCategoria = reader["TipoCategoria"].ToString()
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
