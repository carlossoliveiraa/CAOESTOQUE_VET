namespace CAOESTOQUE.WINDOWS
{
    partial class FrmCadastroCategoriaeProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroCategoriaeProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.codigolabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbxtipocateg = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarCategoria = new System.Windows.Forms.Button();
            this.NomeCategoriatextBox = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTxtPreco = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.brnExcluirProdutos = new System.Windows.Forms.Button();
            this.lblCadastrarouAlterar = new System.Windows.Forms.Label();
            this.btnSalvarProdutos = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtnomeproduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PesquisatextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // codigolabel
            // 
            this.codigolabel.AutoSize = true;
            this.codigolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigolabel.Location = new System.Drawing.Point(168, 24);
            this.codigolabel.Name = "codigolabel";
            this.codigolabel.Size = new System.Drawing.Size(0, 20);
            this.codigolabel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 516);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.cbxtipocateg);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dataGridViewCategorias);
            this.tabPage1.Controls.Add(this.btnExcluirCategoria);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSalvarCategoria);
            this.tabPage1.Controls.Add(this.NomeCategoriatextBox);
            this.tabPage1.Controls.Add(this.lblCategoria);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categoria";
            // 
            // cbxtipocateg
            // 
            this.cbxtipocateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipocateg.FormattingEnabled = true;
            this.cbxtipocateg.Items.AddRange(new object[] {
            "KILO",
            "UNIDADE"});
            this.cbxtipocateg.Location = new System.Drawing.Point(221, 59);
            this.cbxtipocateg.Name = "cbxtipocateg";
            this.cbxtipocateg.Size = new System.Drawing.Size(100, 21);
            this.cbxtipocateg.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "TIPO CATEGORIA:";
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.TipoCategoria});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategorias.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(6, 196);
            this.dataGridViewCategorias.MultiSelect = false;
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategorias.Size = new System.Drawing.Size(745, 288);
            this.dataGridViewCategorias.TabIndex = 13;
            this.dataGridViewCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategorias_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id.FillWeight = 71.38781F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nome.FillWeight = 152.2843F;
            this.Nome.HeaderText = "Nome da Categoria";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // TipoCategoria
            // 
            this.TipoCategoria.DataPropertyName = "TipoCategoria";
            this.TipoCategoria.HeaderText = "Tipo da Categoria";
            this.TipoCategoria.Name = "TipoCategoria";
            this.TipoCategoria.ReadOnly = true;
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.BackColor = System.Drawing.Color.Red;
            this.btnExcluirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCategoria.Location = new System.Drawing.Point(169, 115);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(131, 36);
            this.btnExcluirCategoria.TabIndex = 12;
            this.btnExcluirCategoria.Text = "&Excluir";
            this.btnExcluirCategoria.UseVisualStyleBackColor = false;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categorias Cadastradas:";
            // 
            // btnSalvarCategoria
            // 
            this.btnSalvarCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCategoria.Location = new System.Drawing.Point(20, 115);
            this.btnSalvarCategoria.Name = "btnSalvarCategoria";
            this.btnSalvarCategoria.Size = new System.Drawing.Size(131, 36);
            this.btnSalvarCategoria.TabIndex = 2;
            this.btnSalvarCategoria.Text = "&Salvar";
            this.btnSalvarCategoria.UseVisualStyleBackColor = false;
            this.btnSalvarCategoria.Click += new System.EventHandler(this.btnSalvarCategoria_Click);
            // 
            // NomeCategoriatextBox
            // 
            this.NomeCategoriatextBox.Location = new System.Drawing.Point(221, 21);
            this.NomeCategoriatextBox.MaxLength = 100;
            this.NomeCategoriatextBox.Name = "NomeCategoriatextBox";
            this.NomeCategoriatextBox.Size = new System.Drawing.Size(233, 20);
            this.NomeCategoriatextBox.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(21, 19);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(194, 22);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "NOME CATEGORIA:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.PesquisatextBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridViewProdutos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Produto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.maskedTxtPreco);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.brnExcluirProdutos);
            this.panel1.Controls.Add(this.lblCadastrarouAlterar);
            this.panel1.Controls.Add(this.btnSalvarProdutos);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtnomeproduto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtbarcode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 217);
            this.panel1.TabIndex = 16;
            // 
            // maskedTxtPreco
            // 
            this.maskedTxtPreco.Location = new System.Drawing.Point(176, 126);
            this.maskedTxtPreco.Name = "maskedTxtPreco";
            this.maskedTxtPreco.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtPreco.TabIndex = 20;
            this.maskedTxtPreco.Text = "0";
            this.maskedTxtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "PREÇO:";
            // 
            // brnExcluirProdutos
            // 
            this.brnExcluirProdutos.BackColor = System.Drawing.Color.Red;
            this.brnExcluirProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnExcluirProdutos.Location = new System.Drawing.Point(147, 174);
            this.brnExcluirProdutos.Name = "brnExcluirProdutos";
            this.brnExcluirProdutos.Size = new System.Drawing.Size(131, 36);
            this.brnExcluirProdutos.TabIndex = 18;
            this.brnExcluirProdutos.Text = "EXCLUIR";
            this.brnExcluirProdutos.UseVisualStyleBackColor = false;
            this.brnExcluirProdutos.Click += new System.EventHandler(this.brnExcluirProdutos_Click);
            // 
            // lblCadastrarouAlterar
            // 
            this.lblCadastrarouAlterar.AutoSize = true;
            this.lblCadastrarouAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarouAlterar.ForeColor = System.Drawing.Color.Red;
            this.lblCadastrarouAlterar.Location = new System.Drawing.Point(3, 0);
            this.lblCadastrarouAlterar.Name = "lblCadastrarouAlterar";
            this.lblCadastrarouAlterar.Size = new System.Drawing.Size(161, 18);
            this.lblCadastrarouAlterar.TabIndex = 17;
            this.lblCadastrarouAlterar.Text = "Cadastrar Produtos:";
            // 
            // btnSalvarProdutos
            // 
            this.btnSalvarProdutos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProdutos.Location = new System.Drawing.Point(7, 174);
            this.btnSalvarProdutos.Name = "btnSalvarProdutos";
            this.btnSalvarProdutos.Size = new System.Drawing.Size(131, 36);
            this.btnSalvarProdutos.TabIndex = 14;
            this.btnSalvarProdutos.Text = "&Salvar";
            this.btnSalvarProdutos.UseVisualStyleBackColor = false;
            this.btnSalvarProdutos.Click += new System.EventHandler(this.btnSalvarProdutos_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // txtnomeproduto
            // 
            this.txtnomeproduto.Location = new System.Drawing.Point(176, 65);
            this.txtnomeproduto.Name = "txtnomeproduto";
            this.txtnomeproduto.Size = new System.Drawing.Size(233, 20);
            this.txtnomeproduto.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "CATEGORIA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "NOME PRODUTO:";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(176, 35);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(233, 20);
            this.txtbarcode.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "CÓDIGO BARRA:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(706, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PesquisatextBox
            // 
            this.PesquisatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisatextBox.Location = new System.Drawing.Point(468, 229);
            this.PesquisatextBox.MaxLength = 46;
            this.PesquisatextBox.Name = "PesquisatextBox";
            this.PesquisatextBox.Size = new System.Drawing.Size(232, 22);
            this.PesquisatextBox.TabIndex = 14;
            this.PesquisatextBox.TextChanged += new System.EventHandler(this.PesquisatextBox_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(247, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Produtos Cadastrados:";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProdutos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(3, 254);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(745, 233);
            this.dataGridViewProdutos.TabIndex = 12;
            this.dataGridViewProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellDoubleClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 76.14214F;
            this.dataGridViewImageColumn1.HeaderText = "Excluir";
            this.dataGridViewImageColumn1.Image = global::CAOESTOQUE.WINDOWS.Properties.Resources.DeleteRed;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 175;
            // 
            // FrmCadastroCategoriaeProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 552);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.codigolabel);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroCategoriaeProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categorias e Cadastro de Produtos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigolabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnSalvarCategoria;
        private System.Windows.Forms.TextBox NomeCategoriatextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Button btnExcluirCategoria;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dataGridViewCategorias;
        private System.Windows.Forms.TextBox PesquisatextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCadastrarouAlterar;
        private System.Windows.Forms.Button btnSalvarProdutos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtnomeproduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button brnExcluirProdutos;
        private System.Windows.Forms.MaskedTextBox maskedTxtPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxtipocateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCategoria;
    }
}