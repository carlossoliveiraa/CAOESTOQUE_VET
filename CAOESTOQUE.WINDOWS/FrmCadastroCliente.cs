using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CAOESTOQUE.DAO;
using CAOESTOQUE.ENTITY;

namespace CAOESTOQUE.WINDOWS
{
    public partial class FrmCadastroCliente : Form
    {
       private readonly int id;
      
        public FrmCadastroCliente(int id)
        {
            this.id = id;
            InitializeComponent();

            if (id > 0)
            {
                AlterarClienteLoad();
            }
        }

        #region LimpaeValidaCampos
        private void LimpaCampo()
        {
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
            // aniversariotextBox.Text = "";
            sexoFradioButton.Checked = false;
            sexoMradioButton.Checked = false;
            observacaotextBox.Text = "";
            codigolabel.Text = "";
            nometextBox.Focus();

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
            else if (!CAOESTOQUE.NEGOCIOS.Validacoes.ValidaCpf(cpftextBox.Text))
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
        #endregion

        private void salvarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                IncluirCliente();
                Close();
            }
        }

        private void IncluirCliente()
        {
            var cliE = new Clientes();
            cliE.Id = id;
            cliE.Nome = nometextBox.Text.ToUpper();
            cliE.Email = emailtextBox.Text.ToUpper();
            cliE.Endereco = enderecotextBox.Text.ToUpper();
            cliE.Numero = numerotextBox.Text.ToUpper();
            cliE.Bairro = bairrotextBox.Text.ToUpper();
            cliE.Cidade = cidadetextBox.Text.ToUpper();
            cliE.UF = ufcomboBox.Text.ToUpper();
            if (telfixotextBox.Text.Equals("(  )     -")) { cliE.TelFixo = ""; } else { cliE.TelFixo = telfixotextBox.Text; };
            if (telceltextBox.Text.Equals("(  )     -")) { cliE.TelCel = ""; } else { cliE.TelCel = telceltextBox.Text; };
            if (telcomtextBox.Text.Equals("(  )     -")) { cliE.TelCom = ""; } else { cliE.TelCom = telcomtextBox.Text; };
            cliE.CPF = cpftextBox.Text;
            //CultureInfo culture = new CultureInfo("pt-br");
            cliE.Aniversario = maskedTextBoxNiver.Text.Trim();
            if (sexoMradioButton.Checked == true)
            {
                cliE.Sexo = sexoMradioButton.Text.ToUpper();
            }
            else if (sexoFradioButton.Checked == true)
            {
                cliE.Sexo = sexoFradioButton.Text.ToUpper();
            }
            else
            {
                cliE.Sexo = "NENHUM";
            }
            cliE.Observacao = observacaotextBox.Text.Trim().ToUpper();
            new ClientesMetodos().Salvar(cliE);

            if (id > 0)
            {
                MessageBox.Show("Cliente alterado com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cliente incluido com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 
            LimpaCampo();
        }

        private void AlterarClienteLoad()
        {
            var list = new ClientesMetodos().ListarPorId(this.id);
            nometextBox.Text = list.Nome.Trim();
            emailtextBox.Text = list.Email.Trim();
            enderecotextBox.Text = list.Endereco.Trim();
            numerotextBox.Text = list.Numero.Trim();
            bairrotextBox.Text = list.Bairro.Trim();
            cidadetextBox.Text = list.Cidade.Trim();
            for (int i = 0; i < ufcomboBox.Items.Count; i++)
            {
                if (ufcomboBox.Items[i].ToString().ToUpper().Contains(list.UF.TrimStart().TrimEnd().ToUpper()))
                {
                    ufcomboBox.SelectedIndex = i;
                }
            }
            telfixotextBox.Text = list.TelFixo.Trim();
            telceltextBox.Text = list.TelCel.Trim();
            telcomtextBox.Text = list.TelCom.Trim();
            cpftextBox.Text = list.CPF.Trim();
            maskedTextBoxNiver.Text = list.Aniversario.Trim();
            string sexo = list.Sexo.Trim();
            if (sexo.ToUpper().Equals("MASCULINO")) { sexoMradioButton.Checked = true; }
            else sexoFradioButton.Checked = true;
            observacaotextBox.Text = list.Observacao.Trim();

        }


    }
}
