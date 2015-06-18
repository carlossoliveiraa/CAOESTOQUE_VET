using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace Principal
{
    public partial class FrmCadastroCliente : Form
    {
        public FrmCadastroCliente()
        {
            InitializeComponent();
        }

        private void salvarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ////valdo.dal.Clientes cli = new valdo.dal.Clientes();
                ////valdo.entity.eCliente cliE = new valdo.entity.eCliente();
                //var cliE = new Clientes();

                //cliE.Nome = nometextBox.Text.ToUpper();
                //cliE.Email = emailtextBox.Text.ToUpper();
                //cliE.Endereco = enderecotextBox.Text.ToUpper();
                //cliE.Numero = numerotextBox.Text.ToUpper();
                //cliE.Bairro = bairrotextBox.Text.ToUpper();
                ////cliE.Complemento = ComplemtextBox.Text;
                //cliE.Cidade = cidadetextBox.Text.ToUpper();
                //cliE.Estado = ufcomboBox.Text.ToUpper();

                //if (telfixotextBox.Text.Equals("(  )     -")) { cliE.Telfixo = ""; } else { cliE.Telfixo = telfixotextBox.Text; };

                //if (telceltextBox.Text.Equals("(  )     -")) { cliE.Telcelular = ""; } else { cliE.Telcelular = telceltextBox.Text; };

                //if (telcomtextBox.Text.Equals("(  )     -")) { cliE.Telcomercial = ""; } else { cliE.Telcomercial = telcomtextBox.Text; };


                //cliE.Cpf = cpftextBox.Text;
                //CultureInfo culture = new CultureInfo("pt-br");

                //cliE.Aniversario = calendarioniverPicker.Value.ToString("dd/MM/yyyy");


                //if (sexoMradioButton.Checked == true)
                //{
                //    cliE.Sexo = sexoMradioButton.Text.ToUpper();
                //}

                //else if (sexoFradioButton.Checked == true)
                //{
                //    cliE.Sexo = sexoFradioButton.Text.ToUpper();
                //}

                //else
                //{
                //    cliE.Sexo = "NENHUM";
                //}


                //cliE.Observacao = observacaotextBox.Text.Trim().ToUpper();

                //int result = cli.Inserir(cliE);
                //codigolabel.Text = result.ToString();

                //if (result > 0)
                //{
                //    MessageBox.Show("Cliente incluido com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    LimpaCampo();
                //}
                //else
                //{
                //    MessageBox.Show("Cliente não cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
        }

        private bool ValidarCampos()
        {
            bool validate = false;
           // ClearValidates();

            if (nometextBox.Text.Trim() == "")
            {
                //nometextBox.BorderColor = System.Drawing.Color.Red;
                //nometextBox.BackColor = Color.Red;
                nometextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFDAB9");
                nomelabel.Visible = true;
                nometextBox.Focus();
            }
                   //verifica se o email é valido. se n digitar nada passa pq tb estou verficando se é diferente de vazio.
            else if (!Regex.IsMatch(emailtextBox.Text, @"^[a-zA-Z0-9\._\-]+\@+[a-zA-Z0-9\._\-]+\.[a-zA-Z]+$") && (emailtextBox.Text != string.Empty))
            {
                emailtextBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFDAB9");
                emailtextBox.Focus();
                MessageBox.Show("Informe um email válido!!! Ex: meuemail@hotmail.com.br ");
            }

           //else if (ValidaCpf(cpftextBox.Text) == false) assim ou assim.
            else if (!ValidaCpf(cpftextBox.Text))
            {
                MessageBox.Show("Informe um cpf válido!!!");
                cpftextBox.Focus();
                return false;
            }


            else
            {
                validate = true;
            }

            return validate;
        }

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

      

    }
}
