using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CAOESTOQUE.REPOSITORIO
{
   public class Contexto : IDisposable
    {

        private readonly SqlConnection cnn;


        public Contexto()
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["stringconexionCAOEstoque"].ConnectionString);
            cnn.Open();
        }

        public void ExecutaComando(string strQuery)
        {
            var cmd = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = cnn
            };
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader ExecutaComandoComRetorno(string strquery)
        {
            SqlCommand cmd = new SqlCommand(strquery, cnn);
            return cmd.ExecuteReader();
        }


        public int ExecutaComandoScalar(string strquery)
        {
            Int32 IdRetorno = 0;

            var cmd = new SqlCommand
                {
                    CommandText = strquery,
                    CommandType = CommandType.Text,
                    Connection = cnn
                };
                IdRetorno = (Int32)cmd.ExecuteScalar();
                return (int)IdRetorno;
          
        }

    
        public void Dispose()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
    }
}
