namespace CAOESTOQUE.WINDOWS
{
    partial class FrmEntradaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntradaEstoque));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txttipocateg = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtQdeEntrada = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.lblvalorUnt = new System.Windows.Forms.Label();
            this.lblqtdEntrada = new System.Windows.Forms.Label();
            this.txtnomeproduto = new System.Windows.Forms.TextBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridEntradaProdutos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dataentrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdataentrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PesquisatextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEntradaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttipocateg);
            this.panel1.Controls.Add(this.lblIdProduto);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtQdeEntrada);
            this.panel1.Controls.Add(this.txtValorUnitario);
            this.panel1.Controls.Add(this.btnsalvar);
            this.panel1.Controls.Add(this.lblvalorUnt);
            this.panel1.Controls.Add(this.lblqtdEntrada);
            this.panel1.Controls.Add(this.txtnomeproduto);
            this.panel1.Controls.Add(this.txtbarcode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 192);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Código do Produto:";
            // 
            // txttipocateg
            // 
            this.txttipocateg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txttipocateg.Location = new System.Drawing.Point(613, 46);
            this.txttipocateg.Name = "txttipocateg";
            this.txttipocateg.ReadOnly = true;
            this.txttipocateg.Size = new System.Drawing.Size(92, 20);
            this.txttipocateg.TabIndex = 12;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Location = new System.Drawing.Point(161, 18);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(0, 13);
            this.lblIdProduto.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtQdeEntrada
            // 
            this.txtQdeEntrada.Location = new System.Drawing.Point(161, 80);
            this.txtQdeEntrada.MaxLength = 10;
            this.txtQdeEntrada.Name = "txtQdeEntrada";
            this.txtQdeEntrada.Size = new System.Drawing.Size(160, 20);
            this.txtQdeEntrada.TabIndex = 9;
            this.txtQdeEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQdeEntrada_KeyPress);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(161, 110);
            this.txtValorUnitario.MaxLength = 8;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(160, 20);
            this.txtValorUnitario.TabIndex = 8;
            this.txtValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorUnitario_KeyPress);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(26, 153);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(118, 32);
            this.btnsalvar.TabIndex = 4;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // lblvalorUnt
            // 
            this.lblvalorUnt.AutoSize = true;
            this.lblvalorUnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorUnt.Location = new System.Drawing.Point(109, 113);
            this.lblvalorUnt.Name = "lblvalorUnt";
            this.lblvalorUnt.Size = new System.Drawing.Size(40, 13);
            this.lblvalorUnt.TabIndex = 7;
            this.lblvalorUnt.Text = "Valor:";
            // 
            // lblqtdEntrada
            // 
            this.lblqtdEntrada.AutoSize = true;
            this.lblqtdEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdEntrada.Location = new System.Drawing.Point(13, 83);
            this.lblqtdEntrada.Name = "lblqtdEntrada";
            this.lblqtdEntrada.Size = new System.Drawing.Size(142, 13);
            this.lblqtdEntrada.TabIndex = 5;
            this.lblqtdEntrada.Text = "Quantidade de Entrada:";
            // 
            // txtnomeproduto
            // 
            this.txtnomeproduto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtnomeproduto.Location = new System.Drawing.Point(325, 47);
            this.txtnomeproduto.Name = "txtnomeproduto";
            this.txtnomeproduto.ReadOnly = true;
            this.txtnomeproduto.Size = new System.Drawing.Size(269, 20);
            this.txtnomeproduto.TabIndex = 4;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(161, 47);
            this.txtbarcode.MaxLength = 200;
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(160, 20);
            this.txtbarcode.TabIndex = 1;
            this.txtbarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarcode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código Barra:";
            // 
            // datagridEntradaProdutos
            // 
            this.datagridEntradaProdutos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridEntradaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridEntradaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridEntradaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridEntradaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Qtde,
            this.Categoria,
            this.Preco,
            this.Dataentrada});
            this.datagridEntradaProdutos.Location = new System.Drawing.Point(16, 261);
            this.datagridEntradaProdutos.MultiSelect = false;
            this.datagridEntradaProdutos.Name = "datagridEntradaProdutos";
            this.datagridEntradaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridEntradaProdutos.Size = new System.Drawing.Size(921, 220);
            this.datagridEntradaProdutos.TabIndex = 11;
            this.datagridEntradaProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridEntradaProdutos_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "QtdeEntrada";
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "TipoCateg";
            this.Categoria.HeaderText = "Tipo";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preco";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Dataentrada
            // 
            this.Dataentrada.DataPropertyName = "Dataentrada";
            this.Dataentrada.HeaderText = "Dataentrada";
            this.Dataentrada.Name = "Dataentrada";
            this.Dataentrada.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(327, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Produtos Cadastrados na Entrada:";
            // 
            // txtdataentrada
            // 
            this.txtdataentrada.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtdataentrada.Location = new System.Drawing.Point(126, 5);
            this.txtdataentrada.Name = "txtdataentrada";
            this.txtdataentrada.ReadOnly = true;
            this.txtdataentrada.Size = new System.Drawing.Size(225, 20);
            this.txtdataentrada.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data de Entrada:";
            // 
            // PesquisatextBox
            // 
            this.PesquisatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisatextBox.Location = new System.Drawing.Point(656, 234);
            this.PesquisatextBox.MaxLength = 46;
            this.PesquisatextBox.Name = "PesquisatextBox";
            this.PesquisatextBox.Size = new System.Drawing.Size(244, 22);
            this.PesquisatextBox.TabIndex = 33;
            this.PesquisatextBox.TextChanged += new System.EventHandler(this.PesquisatextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(435, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Produtos Cadastrados:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(894, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEntradaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 513);
            this.Controls.Add(this.PesquisatextBox);
            this.Controls.Add(this.txtdataentrada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridEntradaProdutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntradaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Mercadorias no Estoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEntradaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Label lblvalorUnt;
        private System.Windows.Forms.Label lblqtdEntrada;
        private System.Windows.Forms.TextBox txtnomeproduto;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagridEntradaProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQdeEntrada;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdataentrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.TextBox txttipocateg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dataentrada;
        private System.Windows.Forms.TextBox PesquisatextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}