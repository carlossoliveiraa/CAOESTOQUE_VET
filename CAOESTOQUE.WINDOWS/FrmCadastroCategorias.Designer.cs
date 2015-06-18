namespace CAOESTOQUE.WINDOWS
{
    partial class FrmCadastroCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxtipocateg
            // 
            this.cbxtipocateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtipocateg.FormattingEnabled = true;
            this.cbxtipocateg.Items.AddRange(new object[] {
            "KILO",
            "UNIDADE"});
            this.cbxtipocateg.Location = new System.Drawing.Point(236, 57);
            this.cbxtipocateg.Name = "cbxtipocateg";
            this.cbxtipocateg.Size = new System.Drawing.Size(100, 21);
            this.cbxtipocateg.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 22);
            this.label9.TabIndex = 31;
            this.label9.Text = "TIPO CATEGORIA:";
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategorias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.TipoCategoria});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCategorias.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(12, 194);
            this.dataGridViewCategorias.MultiSelect = false;
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategorias.Size = new System.Drawing.Size(766, 298);
            this.dataGridViewCategorias.TabIndex = 30;
            this.dataGridViewCategorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategorias_CellDoubleClick_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Id.DefaultCellStyle = dataGridViewCellStyle13;
            this.Id.FillWeight = 71.38781F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle14;
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
            this.btnExcluirCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCategoria.Location = new System.Drawing.Point(184, 113);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(131, 36);
            this.btnExcluirCategoria.TabIndex = 29;
            this.btnExcluirCategoria.Text = "&Excluir";
            this.btnExcluirCategoria.UseVisualStyleBackColor = false;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Categorias Cadastradas:";
            // 
            // btnSalvarCategoria
            // 
            this.btnSalvarCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCategoria.Location = new System.Drawing.Point(35, 113);
            this.btnSalvarCategoria.Name = "btnSalvarCategoria";
            this.btnSalvarCategoria.Size = new System.Drawing.Size(131, 36);
            this.btnSalvarCategoria.TabIndex = 27;
            this.btnSalvarCategoria.Text = "&Salvar";
            this.btnSalvarCategoria.UseVisualStyleBackColor = false;
            this.btnSalvarCategoria.Click += new System.EventHandler(this.btnSalvarCategoria_Click_1);
            // 
            // NomeCategoriatextBox
            // 
            this.NomeCategoriatextBox.Location = new System.Drawing.Point(236, 19);
            this.NomeCategoriatextBox.Name = "NomeCategoriatextBox";
            this.NomeCategoriatextBox.Size = new System.Drawing.Size(233, 20);
            this.NomeCategoriatextBox.TabIndex = 26;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(36, 17);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(194, 22);
            this.lblCategoria.TabIndex = 25;
            this.lblCategoria.Text = "NOME CATEGORIA:";
            // 
            // FrmCadastroCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(790, 504);
            this.Controls.Add(this.cbxtipocateg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewCategorias);
            this.Controls.Add(this.btnExcluirCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarCategoria);
            this.Controls.Add(this.NomeCategoriatextBox);
            this.Controls.Add(this.lblCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxtipocateg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCategoria;
        private System.Windows.Forms.Button btnExcluirCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvarCategoria;
        private System.Windows.Forms.TextBox NomeCategoriatextBox;
        private System.Windows.Forms.Label lblCategoria;
    }
}