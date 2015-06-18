namespace CAOESTOQUE.WINDOWS
{
    partial class FrmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexportExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PesquisatextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAOESTOQUEDataSet = new CAOESTOQUE.WINDOWS.CAOESTOQUEDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAOESTOQUEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnexportExcel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.PesquisatextBox);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 95);
            this.panel1.TabIndex = 0;
            // 
            // btnexportExcel
            // 
            this.btnexportExcel.Location = new System.Drawing.Point(559, 25);
            this.btnexportExcel.Name = "btnexportExcel";
            this.btnexportExcel.Size = new System.Drawing.Size(128, 44);
            this.btnexportExcel.TabIndex = 15;
            this.btnexportExcel.Text = "Exportar Excel";
            this.btnexportExcel.UseVisualStyleBackColor = true;
            this.btnexportExcel.Click += new System.EventHandler(this.btnexportExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Procurar por NOME:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // PesquisatextBox
            // 
            this.PesquisatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisatextBox.Location = new System.Drawing.Point(187, 36);
            this.PesquisatextBox.MaxLength = 46;
            this.PesquisatextBox.Name = "PesquisatextBox";
            this.PesquisatextBox.Size = new System.Drawing.Size(319, 22);
            this.PesquisatextBox.TabIndex = 13;
            this.PesquisatextBox.TextChanged += new System.EventHandler(this.PesquisatextBox_TextChanged);
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewEstoque.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Produto,
            this.Estoque,
            this.Categoria});
            this.dataGridViewEstoque.Location = new System.Drawing.Point(12, 124);
            this.dataGridViewEstoque.MultiSelect = false;
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(724, 321);
            this.dataGridViewEstoque.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.DataPropertyName = "Nome";
            this.Produto.HeaderText = "Nome Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.DataPropertyName = "Qtde";
            this.Estoque.HeaderText = "Quantidade Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "TipoCategoria";
            this.Categoria.HeaderText = "Tipo";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // cAOESTOQUEDataSet
            // 
            this.cAOESTOQUEDataSet.DataSetName = "CAOESTOQUEDataSet";
            this.cAOESTOQUEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 483);
            this.Controls.Add(this.dataGridViewEstoque);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos em Estoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAOESTOQUEDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PesquisatextBox;
        private System.Windows.Forms.DataGridView dataGridViewEstoque;
        private System.Windows.Forms.Button btnexportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private CAOESTOQUEDataSet cAOESTOQUEDataSet;
    }
}