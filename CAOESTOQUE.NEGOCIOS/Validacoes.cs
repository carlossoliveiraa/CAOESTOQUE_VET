
namespace CAOESTOQUE.NEGOCIOS
{
    public class Validacoes
    {

        public static bool ValidaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempDocumento;
            string digito;
            int soma;
            int resto;


            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "");
            cpf = cpf.Replace("-", "");

            if (cpf == "22222222222" || cpf == "33333333332" || cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999" || cpf == "00000000000" || cpf == "12345678901")
                return false;
            if (cpf.Length != 11)
                return false;

            tempDocumento = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempDocumento[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempDocumento = tempDocumento + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempDocumento[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        public static bool ValidaEmail(string email)
        {
            try
            {
                new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
