namespace Principal
{
    partial class FrmAlterarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterarCliente));
            this.cpftextBox = new System.Windows.Forms.MaskedTextBox();
            this.telcomtextBox = new System.Windows.Forms.MaskedTextBox();
            this.telceltextBox = new System.Windows.Forms.MaskedTextBox();
            this.telfixotextBox = new System.Windows.Forms.MaskedTextBox();
            this.aniversariotextBox = new System.Windows.Forms.MaskedTextBox();
            this.sexoFradioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComplemtextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cpflabel = new System.Windows.Forms.Label();
            this.aniversariolabel = new System.Windows.Forms.Label();
            this.nomelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sexoMradioButton = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salvarbutton = new System.Windows.Forms.Button();
            this.observacaotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bairrotextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numerotextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.enderecotextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ufcomboBox = new System.Windows.Forms.ComboBox();
            this.cidadetextBox = new System.Windows.Forms.TextBox();
            this.nometextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pesquisarbutton = new System.Windows.Forms.Button();
            this.pesquisartextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codigolabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.CodAlteracaoClientelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpftextBox
            // 
            this.cpftextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpftextBox.Location = new System.Drawing.Point(72, 132);
            this.cpftextBox.Mask = "000-000-000-00";
            this.cpftextBox.Name = "cpftextBox";
            this.cpftextBox.Size = new System.Drawing.Size(125, 22);
            this.cpftextBox.TabIndex = 10;
            // 
            // telcomtextBox
            // 
            this.telcomtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telcomtextBox.Location = new System.Drawing.Point(540, 105);
            this.telcomtextBox.Mask = "(99) 0000-0000";
            this.telcomtextBox.Name = "telcomtextBox";
            this.telcomtextBox.Size = new System.Drawing.Size(125, 22);
            this.telcomtextBox.TabIndex = 9;
            // 
            // telceltextBox
            // 
            this.telceltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telceltextBox.Location = new System.Drawing.Point(315, 102);
            this.telceltextBox.Mask = "(99) 0000-0000";
            this.telceltextBox.Name = "telceltextBox";
            this.telceltextBox.Size = new System.Drawing.Size(125, 22);
            this.telceltextBox.TabIndex = 8;
            // 
            // telfixotextBox
            // 
            this.telfixotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telfixotextBox.Location = new System.Drawing.Point(72, 101);
            this.telfixotextBox.Mask = "(99) 0000-0000";
            this.telfixotextBox.Name = "telfixotextBox";
            this.telfixotextBox.Size = new System.Drawing.Size(125, 22);
            this.telfixotextBox.TabIndex = 7;
            // 
            // aniversariotextBox
            // 
            this.aniversariotextBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aniversariotextBox.Location = new System.Drawing.Point(315, 131);
            this.aniversariotextBox.Margin = new System.Windows.Forms.Padding(6);
            this.aniversariotextBox.Mask = "00/00/0000";
            this.aniversariotextBox.Name = "aniversariotextBox";
            this.aniversariotextBox.Size = new System.Drawing.Size(125, 24);
            this.aniversariotextBox.TabIndex = 11;
            this.aniversariotextBox.ValidatingType = typeof(System.DateTime);
            // 
            // sexoFradioButton
            // 
            this.sexoFradioButton.AutoSize = true;
            this.sexoFradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.sexoFradioButton.Location = new System.Drawing.Point(591, 139);
            this.sexoFradioButton.Name = "sexoFradioButton";
            this.sexoFradioButton.Size = new System.Drawing.Size(75, 17);
            this.sexoFradioButton.TabIndex = 13;
            this.sexoFradioButton.Text = "Feminino";
            this.sexoFradioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ComplemtextBox);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cpflabel);
            this.panel1.Controls.Add(this.aniversariolabel);
            this.panel1.Controls.Add(this.nomelabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cpftextBox);
            this.panel1.Controls.Add(this.telcomtextBox);
            this.panel1.Controls.Add(this.telceltextBox);
            this.panel1.Controls.Add(this.telfixotextBox);
            this.panel1.Controls.Add(this.aniversariotextBox);
            this.panel1.Controls.Add(this.sexoFradioButton);
            this.panel1.Controls.Add(this.sexoMradioButton);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.salvarbutton);
            this.panel1.Controls.Add(this.observacaotextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.emailtextBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.bairrotextBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.numerotextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.enderecotextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.ufcomboBox);
            this.panel1.Controls.Add(this.cidadetextBox);
            this.panel1.Controls.Add(this.nometextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Enabled = false;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 401);
            this.panel1.TabIndex = 6;
            // 
            // ComplemtextBox
            // 
            this.ComplemtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.ComplemtextBox.Location = new System.Drawing.Point(577, 45);
            this.ComplemtextBox.MaxLength = 50;
            this.ComplemtextBox.Name = "ComplemtextBox";
            this.ComplemtextBox.Size = new System.Drawing.Size(122, 21);
            this.ComplemtextBox.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(498, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "Complem:";
            // 
            // cpflabel
            // 
            this.cpflabel.AutoSize = true;
            this.cpflabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpflabel.ForeColor = System.Drawing.Color.Red;
            this.cpflabel.Location = new System.Drawing.Point(194, 134);
            this.cpflabel.Name = "cpflabel";
            this.cpflabel.Size = new System.Drawing.Size(18, 24);
            this.cpflabel.TabIndex = 32;
            this.cpflabel.Text = "*";
            this.cpflabel.Visible = false;
            // 
            // aniversariolabel
            // 
            this.aniversariolabel.AutoSize = true;
            this.aniversariolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aniversariolabel.ForeColor = System.Drawing.Color.Red;
            this.aniversariolabel.Location = new System.Drawing.Point(437, 132);
            this.aniversariolabel.Name = "aniversariolabel";
            this.aniversariolabel.Size = new System.Drawing.Size(21, 25);
            this.aniversariolabel.TabIndex = 31;
            this.aniversariolabel.Text = "*";
            this.aniversariolabel.Visible = false;
            // 
            // nomelabel
            // 
            this.nomelabel.AutoSize = true;
            this.nomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomelabel.ForeColor = System.Drawing.Color.Red;
            this.nomelabel.Location = new System.Drawing.Point(321, 15);
            this.nomelabel.Name = "nomelabel";
            this.nomelabel.Size = new System.Drawing.Size(21, 25);
            this.nomelabel.TabIndex = 30;
            this.nomelabel.Text = "*";
            this.nomelabel.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sexoMradioButton
            // 
            this.sexoMradioButton.AutoSize = true;
            this.sexoMradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.sexoMradioButton.Location = new System.Drawing.Point(509, 138);
            this.sexoMradioButton.Name = "sexoMradioButton";
            this.sexoMradioButton.Size = new System.Drawing.Size(81, 17);
            this.sexoMradioButton.TabIndex = 12;
            this.sexoMradioButton.Text = "Masculino";
            this.sexoMradioButton.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(462, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Aniversário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "CPF:";
            // 
            // salvarbutton
            // 
            this.salvarbutton.BackColor = System.Drawing.Color.Teal;
            this.salvarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarbutton.Location = new System.Drawing.Point(7, 346);
            this.salvarbutton.Name = "salvarbutton";
            this.salvarbutton.Size = new System.Drawing.Size(155, 38);
            this.salvarbutton.TabIndex = 15;
            this.salvarbutton.Text = "Salvar";
            this.salvarbutton.UseVisualStyleBackColor = false;
            this.salvarbutton.Click += new System.EventHandler(this.salvarbutton_Click);
            // 
            // observacaotextBox
            // 
            this.observacaotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.observacaotextBox.Location = new System.Drawing.Point(7, 181);
            this.observacaotextBox.MaxLength = 1000;
            this.observacaotextBox.Multiline = true;
            this.observacaotextBox.Name = "observacaotextBox";
            this.observacaotextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observacaotextBox.Size = new System.Drawing.Size(692, 147);
            this.observacaotextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Observações:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(471, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Tel Com:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(217, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Tel Celular:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Tel Fixo:";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(391, 11);
            this.emailtextBox.MaxLength = 50;
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(308, 21);
            this.emailtextBox.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(344, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Email:";
            // 
            // bairrotextBox
            // 
            this.bairrotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.bairrotextBox.Location = new System.Drawing.Point(392, 44);
            this.bairrotextBox.MaxLength = 50;
            this.bairrotextBox.Name = "bairrotextBox";
            this.bairrotextBox.Size = new System.Drawing.Size(105, 21);
            this.bairrotextBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(332, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Bairro:";
            // 
            // numerotextBox
            // 
            this.numerotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.numerotextBox.Location = new System.Drawing.Point(250, 45);
            this.numerotextBox.MaxLength = 8;
            this.numerotextBox.Name = "numerotextBox";
            this.numerotextBox.Size = new System.Drawing.Size(71, 21);
            this.numerotextBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(214, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nro:";
            // 
            // enderecotextBox
            // 
            this.enderecotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.enderecotextBox.Location = new System.Drawing.Point(72, 45);
            this.enderecotextBox.MaxLength = 50;
            this.enderecotextBox.Name = "enderecotextBox";
            this.enderecotextBox.Size = new System.Drawing.Size(140, 21);
            this.enderecotextBox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "End.:";
            // 
            // ufcomboBox
            // 
            this.ufcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ufcomboBox.FormattingEnabled = true;
            this.ufcomboBox.ItemHeight = 13;
            this.ufcomboBox.Items.AddRange(new object[] {
            "Acre – AC",
            "Alagoas – AL",
            "Amapá – AP",
            "Amazonas – AM",
            "Bahia – BA",
            "Ceará – CE",
            "Distrito Federal – DF",
            "Espírito Santo – ES",
            "Goiás – GO",
            "Maranhão – MA",
            "Mato Grosso – MT",
            "Mato Grosso do Sul – MS",
            "Minas Gerais – MG",
            "Pará – PA",
            "Paraíba – PB",
            "Paraná – PR",
            "Pernambuco – PE",
            "Piauí – PI",
            "Roraima – RR",
            "Rondônia – RO",
            "Rio de Janeiro – RJ",
            "Rio Grande do Norte – RN",
            "Rio Grande do Sul – RS",
            "Santa Catarina – SC",
            "São Paulo – SP",
            "Sergipe – SE",
            "Tocantins – TO"});
            this.ufcomboBox.Location = new System.Drawing.Point(391, 71);
            this.ufcomboBox.Name = "ufcomboBox";
            this.ufcomboBox.Size = new System.Drawing.Size(134, 21);
            this.ufcomboBox.TabIndex = 6;
            // 
            // cidadetextBox
            // 
            this.cidadetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.cidadetextBox.Location = new System.Drawing.Point(72, 72);
            this.cidadetextBox.MaxLength = 50;
            this.cidadetextBox.Name = "cidadetextBox";
            this.cidadetextBox.Size = new System.Drawing.Size(249, 21);
            this.cidadetextBox.TabIndex = 5;
            // 
            // nometextBox
            // 
            this.nometextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.nometextBox.Location = new System.Drawing.Point(72, 13);
            this.nometextBox.MaxLength = 50;
            this.nometextBox.Name = "nometextBox";
            this.nometextBox.Size = new System.Drawing.Size(249, 21);
            this.nometextBox.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nome:";
            // 
            // pesquisarbutton
            // 
            this.pesquisarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarbutton.ForeColor = System.Drawing.Color.Red;
            this.pesquisarbutton.Location = new System.Drawing.Point(262, 8);
            this.pesquisarbutton.Name = "pesquisarbutton";
            this.pesquisarbutton.Size = new System.Drawing.Size(171, 30);
            this.pesquisarbutton.TabIndex = 27;
            this.pesquisarbutton.Text = "Pesquisar";
            this.pesquisarbutton.UseVisualStyleBackColor = true;
            this.pesquisarbutton.Click += new System.EventHandler(this.pesquisarbutton_Click);
            // 
            // pesquisartextBox
            // 
            this.pesquisartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisartextBox.Location = new System.Drawing.Point(169, 10);
            this.pesquisartextBox.MaxLength = 5;
            this.pesquisartextBox.Name = "pesquisartextBox";
            this.pesquisartextBox.Size = new System.Drawing.Size(87, 26);
            this.pesquisartextBox.TabIndex = 0;
            this.pesquisartextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pesquisartextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Digite o Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // codigolabel
            // 
            this.codigolabel.AutoSize = true;
            this.codigolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigolabel.Location = new System.Drawing.Point(116, 66);
            this.codigolabel.Name = "codigolabel";
            this.codigolabel.Size = new System.Drawing.Size(0, 20);
            this.codigolabel.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(79, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 31;
            // 
            // CodAlteracaoClientelabel
            // 
            this.CodAlteracaoClientelabel.AutoSize = true;
            this.CodAlteracaoClientelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodAlteracaoClientelabel.Location = new System.Drawing.Point(160, 14);
            this.CodAlteracaoClientelabel.Name = "CodAlteracaoClientelabel";
            this.CodAlteracaoClientelabel.Size = new System.Drawing.Size(12, 16);
            this.CodAlteracaoClientelabel.TabIndex = 32;
            this.CodAlteracaoClientelabel.Text = " ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pesquisartextBox);
            this.panel2.Controls.Add(this.pesquisarbutton);
            this.panel2.Location = new System.Drawing.Point(9, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 48);
            this.panel2.TabIndex = 33;
            // 
            // FrmAlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 484);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CodAlteracaoClientelabel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigolabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox cpftextBox;
        private System.Windows.Forms.MaskedTextBox telcomtextBox;
        private System.Windows.Forms.MaskedTextBox telceltextBox;
        private System.Windows.Forms.MaskedTextBox telfixotextBox;
        private System.Windows.Forms.MaskedTextBox aniversariotextBox;
        private System.Windows.Forms.RadioButton sexoFradioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton sexoMradioButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button salvarbutton;
        private System.Windows.Forms.TextBox observacaotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox bairrotextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox numerotextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox enderecotextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ufcomboBox;
        private System.Windows.Forms.TextBox cidadetextBox;
        private System.Windows.Forms.TextBox nometextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label codigolabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pesquisarbutton;
        private System.Windows.Forms.TextBox pesquisartextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cpflabel;
        private System.Windows.Forms.Label aniversariolabel;
        private System.Windows.Forms.Label nomelabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label CodAlteracaoClientelabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ComplemtextBox;
        private System.Windows.Forms.Label label17;
    }
}