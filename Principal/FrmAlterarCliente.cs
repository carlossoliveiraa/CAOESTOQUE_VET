using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CAOESTOQUE.DAO;
namespace Principal
{
    public partial class FrmAlterarCliente : Form
    {
        int id;
        public FrmAlterarCliente(int id)
        {
            this.id = id;
            InitializeComponent();
            pesquisartextBox.Text = id.ToString();
            Carregacampos();
            panel1.Enabled = true;
        }

        private void salvarbutton_Click(object sender, EventArgs e)
        {
            //valdo.dal.Clientes cli = new valdo.dal.Clientes();
            //valdo.entity.eCliente cliE = new valdo.entity.eCliente();


            //if (ValidarCampos())
            //{
            //    cliE.Nome = nometextBox.Text;
            //    cliE.Email = emailtextBox.Text;
            //    cliE.Endereco = enderecotextBox.Text;
            //    cliE.Numero = numerotextBox.Text;
            //    cliE.Bairro = bairrotextBox.Text;
            //    cliE.Complemento = ComplemtextBox.Text;
            //    cliE.Cidade = cidadetextBox.Text;
            //    cliE.Estado = ufcomboBox.Text;
            //    cliE.Telfixo = telfixotextBox.Text;
            //    cliE.Telcelular = telceltextBox.Text;
            //    cliE.Telcomercial = telcomtextBox.Text;
            //    cliE.Cpf = cpftextBox.Text;
            //    CultureInfo culture = new CultureInfo("pt-br");

            //    if (aniversariotextBox.Text == "  /  /")
            //    {
            //        cliE.Aniversario = DateTime.Now.Date;
            //    }
            //    else
            //    {
            //        cliE.Aniversario = DateTime.ParseExact(string.Format("{0} {1}", aniversariotextBox.Text, "00:00:00"), "dd/MM/yyyy HH:mm:ss", culture);
            //    }


            //    if (sexoMradioButton.Checked == true)
            //    {
            //        cliE.Sexo = sexoMradioButton.Text;
            //    }
            //    else cliE.Sexo = sexoFradioButton.Text;
            //    cliE.Observacao = observacaotextBox.Text.Trim();
            //    cliE.Id = Convert.ToInt32(CodAlteracaoClientelabel.Text);

            //    if (cli.Altera(cliE))
            //    {
            //        MessageBox.Show("Cliente alterado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        pesquisartextBox.Text = "";
            //        pesquisartextBox.Focus();
            //        panel1.Enabled = false;

            //    }
            //    else
            //        MessageBox.Show("Cliente nao alterado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
        }
        
        #region ValidaCpf

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

            if (cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333332" || cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999" || cpf == "00000000000" || cpf == "12345678901")
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

        #endregion

        #region ValidarCampos
        private void ClearValidates()
        {
            nomelabel.Visible = false;
            cpflabel.Visible = false;
            aniversariolabel.Visible = false;
        }



        private bool ValidarCampos()
        {
            bool validate = false;
            ClearValidates();

            if (nometextBox.Text.Trim() == "")
            {
                nomelabel.Visible = true;
                nometextBox.Focus();
            }
            else if (cpftextBox.Text.Length < 14)
            {
                cpflabel.Visible = true;
                cpftextBox.Focus();
            }
            //verifica se o email é valido. se n digitar nada passa pq tb estou verficando se é diferente de vazio.
            else if (!Regex.IsMatch(emailtextBox.Text, @"^[a-zA-Z0-9\._\-]+\@+[a-zA-Z0-9\._\-]+\.[a-zA-Z]+$") && (emailtextBox.Text != string.Empty))
            {
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

            else if (!Regex.IsMatch(aniversariotextBox.Text, @"^([1-9]|0[1-9]|1[012])[- /.]([1-9]|0[1-9]|[12][0-9]|3[01])[- /.][0-9]{4}$")
                && (aniversariotextBox.Text != "  /  /"))
            {

                aniversariotextBox.Focus();
                MessageBox.Show("Informe uma data válida");
                aniversariolabel.Visible = true;
            }


            //else if (aniversariotextBox.Text.Length < 10)
            //{
            //    aniversariolabel.Visible = true;
            //    aniversariotextBox.Focus();
            //}
            else
            {
                validate = true;
            }

            return validate;
        }

        #endregion

        #region LimpaCampo

        public void LimpaCampo()
        {
            //   label18.Text = "";
            pesquisartextBox.Text = "";
            nometextBox.Text = "";
            emailtextBox.Text = string.Empty;
            enderecotextBox.Text = "";
            numerotextBox.Text = "";
            bairrotextBox.Text = "";
            cidadetextBox.Text = "";
            ufcomboBox.SelectedIndex = -1;
            telfixotextBox.Text = "";
            telceltextBox.Text = "";
            telcomtextBox.Text = "";
            cpftextBox.Text = "";
            aniversariotextBox.Text = "";
            sexoFradioButton.Checked = false;
            sexoMradioButton.Checked = false;
            observacaotextBox.Text = "";
            codigolabel.Text = "";
            nometextBox.Focus();

        }

        #endregion

        //public long ValidarFuncionarioExistente(string Nome, string CPF, string RG)
        //{
        //    string Query = "select count(*) from Funcionarios ";
        //    Query += " where Nome = '" + Nome + "' and CPF = '" + CPF + "' and RG = '" + RG + "' and FlagDelete = 0";
        //    return ReturnScalar(Query);
        //}


        //public DataTable Listar(string Pesquisa)
        //{
        //    string Query = "select * from Funcionarios where FlagDelete = 0 ";
        //    if (!string.IsNullOrEmpty(Pesquisa))
        //        Query += " and Nome like '%" + Pesquisa + "%' ";

        //    return ReturnDataTable(Query);
        //}



        public void Carregacampos()
        {
            var list = new ClientesAplicacao().ListarTodos();     

            

            //valdo.entity.eCliente cliE = new valdo.entity.eCliente();
            //valdo.dal.Clientes Cliente = new valdo.dal.Clientes();
            //DataTable dt = new DataTable();

            //cliE.Id = Convert.ToInt32(pesquisartextBox.Text);
            //dt = Cliente.PesquisaID(cliE);

            //if ((dt.Rows.Count > 0) && (dt.Rows[0]["Status"].ToString().Equals("0")))
            //{

            //    panel1.Enabled = Visible;
            //    // label18.Text = dt.Rows[0]["Id_Cliente"].ToString();
            //    CodAlteracaoClientelabel.Text = dt.Rows[0]["Id_Cliente"].ToString();
            //    nometextBox.Text = dt.Rows[0]["Nome"].ToString().Trim();
            //    emailtextBox.Text = dt.Rows[0]["Email"].ToString().Trim();
            //    enderecotextBox.Text = dt.Rows[0]["Endereco"].ToString().Trim();
            //    numerotextBox.Text = dt.Rows[0]["Numero"].ToString().Trim();
            //    bairrotextBox.Text = dt.Rows[0]["Bairro"].ToString().Trim();
            //    //ComplemtextBox.Text = dt.Rows[0]["Complemento"].ToString().Trim();
            //    cidadetextBox.Text = dt.Rows[0]["Cidade"].ToString().Trim(); ;
            //    ufcomboBox.DataSource = dt; ufcomboBox.DisplayMember = "UF";
            //    telfixotextBox.Text = dt.Rows[0]["Telfixo"].ToString();
            //    telceltextBox.Text = dt.Rows[0]["Telcel"].ToString();
            //    telcomtextBox.Text = dt.Rows[0]["Telcom"].ToString();
            //    cpftextBox.Text = dt.Rows[0]["Cpf"].ToString();
            //    aniversariotextBox.Text = dt.Rows[0]["Aniversario"].ToString();
            //    string sexo = dt.Rows[0]["Sexo"].ToString();
            //    if (sexo == "Masculino ") { sexoMradioButton.Checked = true; }
            //    else sexoFradioButton.Checked = true;
            //    observacaotextBox.Text = dt.Rows[0]["Observacao"].ToString().Trim();

            //}
            //else
            //{
            //    MessageBox.Show("Cliente não existe");
            //    pesquisartextBox.Text = "";
            //    pesquisartextBox.Focus();
            //    panel1.Enabled = false;

            //}

        }




        private void pesquisarbutton_Click(object sender, EventArgs e)
        {
            if (pesquisartextBox.Text == "")
            {
                MessageBox.Show("Informe o código do cliente");
                pesquisartextBox.Text = "";
                pesquisartextBox.Focus();
                panel1.Enabled = false;

            }
            else
            {
                Carregacampos();
            }


        }


        private void pesquisartextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //valdo.entity.eCliente cliE = new valdo.entity.eCliente();
            //valdo.dal.Clientes cli = new valdo.dal.Clientes();

            //cliE.Id = Convert.ToInt32(pesquisartextBox.Text);

            //DialogResult resposta = MessageBox.Show("Deseja mesmo excluir esse cliente?",
            //"Alerta de Exclusão", MessageBoxButtons.YesNo,
            //MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //if (resposta == DialogResult.Yes)
            //{
            //    if (cli.Excluir(cliE))
            //    {
            //        MessageBox.Show("Cliente excluido!!!");
            //        LimpaCampo();
            //        pesquisartextBox.Focus();
            //        panel1.Enabled = false;
            //    }
            //}
            //else
            //{
            //    return;
            //}

        }

    }
}
