namespace CAOESTOQUE.WINDOWS
{
    partial class FrmCadastroProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProdutos));
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
            this.PesquisatextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTxtPreco
            // 
            this.maskedTxtPreco.Location = new System.Drawing.Point(183, 132);
            this.maskedTxtPreco.Name = "maskedTxtPreco";
            this.maskedTxtPreco.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtPreco.TabIndex = 35;
            this.maskedTxtPreco.Text = "0";
            this.maskedTxtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTxtPreco_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(100, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "PREÇO:";
            // 
            // brnExcluirProdutos
            // 
            this.brnExcluirProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.brnExcluirProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnExcluirProdutos.Location = new System.Drawing.Point(154, 180);
            this.brnExcluirProdutos.Name = "brnExcluirProdutos";
            this.brnExcluirProdutos.Size = new System.Drawing.Size(131, 36);
            this.brnExcluirProdutos.TabIndex = 33;
            this.brnExcluirProdutos.Text = "EXCLUIR";
            this.brnExcluirProdutos.UseVisualStyleBackColor = false;
            this.brnExcluirProdutos.Click += new System.EventHandler(this.brnExcluirProdutos_Click_1);
            // 
            // lblCadastrarouAlterar
            // 
            this.lblCadastrarouAlterar.AutoSize = true;
            this.lblCadastrarouAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrarouAlterar.ForeColor = System.Drawing.Color.Red;
            this.lblCadastrarouAlterar.Location = new System.Drawing.Point(10, 6);
            this.lblCadastrarouAlterar.Name = "lblCadastrarouAlterar";
            this.lblCadastrarouAlterar.Size = new System.Drawing.Size(161, 18);
            this.lblCadastrarouAlterar.TabIndex = 32;
            this.lblCadastrarouAlterar.Text = "Cadastrar Produtos:";
            // 
            // btnSalvarProdutos
            // 
            this.btnSalvarProdutos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProdutos.Location = new System.Drawing.Point(14, 180);
            this.btnSalvarProdutos.Name = "btnSalvarProdutos";
            this.btnSalvarProdutos.Size = new System.Drawing.Size(131, 36);
            this.btnSalvarProdutos.TabIndex = 29;
            this.btnSalvarProdutos.Text = "&Salvar";
            this.btnSalvarProdutos.UseVisualStyleBackColor = false;
            this.btnSalvarProdutos.Click += new System.EventHandler(this.btnSalvarProdutos_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // txtnomeproduto
            // 
            this.txtnomeproduto.Location = new System.Drawing.Point(183, 71);
            this.txtnomeproduto.MaxLength = 50;
            this.txtnomeproduto.Name = "txtnomeproduto";
            this.txtnomeproduto.Size = new System.Drawing.Size(233, 20);
            this.txtnomeproduto.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "CATEGORIA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "NOME PRODUTO:";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(183, 41);
            this.txtbarcode.MaxLength = 200;
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(233, 20);
            this.txtbarcode.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "CÓDIGO BARRA:";
            // 
            // PesquisatextBox
            // 
            this.PesquisatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisatextBox.Location = new System.Drawing.Point(475, 235);
            this.PesquisatextBox.MaxLength = 46;
            this.PesquisatextBox.Name = "PesquisatextBox";
            this.PesquisatextBox.Size = new System.Drawing.Size(244, 22);
            this.PesquisatextBox.TabIndex = 30;
            this.PesquisatextBox.TextChanged += new System.EventHandler(this.PesquisatextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(254, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Produtos Cadastrados:";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.NomeCategoria,
            this.Preco,
            this.Barcode});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(10, 260);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(745, 233);
            this.dataGridViewProdutos.TabIndex = 26;
            this.dataGridViewProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellDoubleClick_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 22.13551F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 109.3828F;
            this.Nome.HeaderText = "Nome do Produto";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // NomeCategoria
            // 
            this.NomeCategoria.DataPropertyName = "NomeCategoria";
            this.NomeCategoria.FillWeight = 135.4924F;
            this.NomeCategoria.HeaderText = "TIpo de Categoria";
            this.NomeCategoria.Name = "NomeCategoria";
            this.NomeCategoria.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.FillWeight = 106.0858F;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.FillWeight = 126.9035F;
            this.Barcode.HeaderText = "Codigo de Barras";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(713, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 510);
            this.Controls.Add(this.maskedTxtPreco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.brnExcluirProdutos);
            this.Controls.Add(this.lblCadastrarouAlterar);
            this.Controls.Add(this.btnSalvarProdutos);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtnomeproduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PesquisatextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTxtPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button brnExcluirProdutos;
        private System.Windows.Forms.Label lblCadastrarouAlterar;
        private System.Windows.Forms.Button btnSalvarProdutos;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtnomeproduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PesquisatextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
    }
}