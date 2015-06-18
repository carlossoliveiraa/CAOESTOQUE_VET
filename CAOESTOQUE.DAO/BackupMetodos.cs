using System;
using CAOESTOQUE.REPOSITORIO;

namespace CAOESTOQUE.DAO
{
    public sealed class BackupMetodos
    {
        internal Contexto contexto;


        public void FazerBackup(string NomeBanco, string CaminhoBackup)
        {
            try
            {
                string strQuery = "";
                strQuery += string.Format(" BACKUP DATABASE {0} TO DISK = '{1}' ", NomeBanco, CaminhoBackup);
                // strQuery += string.Format("  WITH STATS GO  ) ");

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
    }
}
