namespace CAOESTOQUE.WINDOWS
{
    partial class FrmVendasRealizadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendasRealizadas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnovocliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PesquisatextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.lbltotalitens = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnnovocliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.PesquisatextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 76);
            this.panel1.TabIndex = 0;
            // 
            // btnnovocliente
            // 
            this.btnnovocliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnnovocliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovocliente.Location = new System.Drawing.Point(640, 16);
            this.btnnovocliente.Name = "btnnovocliente";
            this.btnnovocliente.Size = new System.Drawing.Size(175, 31);
            this.btnnovocliente.TabIndex = 17;
            this.btnnovocliente.Text = "Consultar Pedido";
            this.btnnovocliente.UseVisualStyleBackColor = false;
            this.btnnovocliente.Click += new System.EventHandler(this.btnnovocliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pesquisar Nome Cliente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(577, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // PesquisatextBox
            // 
            this.PesquisatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisatextBox.Location = new System.Drawing.Point(221, 20);
            this.PesquisatextBox.MaxLength = 46;
            this.PesquisatextBox.Name = "PesquisatextBox";
            this.PesquisatextBox.Size = new System.Drawing.Size(398, 22);
            this.PesquisatextBox.TabIndex = 14;
            this.PesquisatextBox.TextChanged += new System.EventHandler(this.PesquisatextBox_TextChanged);
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.DataEntrada,
            this.TipoPagto,
            this.Observacao});
            this.dataGridViewPedidos.Location = new System.Drawing.Point(12, 109);
            this.dataGridViewPedidos.MultiSelect = false;
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(832, 321);
            this.dataGridViewPedidos.TabIndex = 10;
            this.dataGridViewPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPedidos_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 92.06107F;
            this.Id.HeaderText = "Número Pedido";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 111.4477F;
            this.Nome.HeaderText = "Nome do Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // DataEntrada
            // 
            this.DataEntrada.DataPropertyName = "DataEntrada";
            this.DataEntrada.FillWeight = 73.23468F;
            this.DataEntrada.HeaderText = "Data da Venda";
            this.DataEntrada.Name = "DataEntrada";
            this.DataEntrada.ReadOnly = true;
            // 
            // TipoPagto
            // 
            this.TipoPagto.DataPropertyName = "TipoPagto";
            this.TipoPagto.FillWeight = 96.35296F;
            this.TipoPagto.HeaderText = "Tipo de Pagamento";
            this.TipoPagto.Name = "TipoPagto";
            this.TipoPagto.ReadOnly = true;
            // 
            // Observacao
            // 
            this.Observacao.DataPropertyName = "Observacao";
            this.Observacao.FillWeight = 126.9035F;
            this.Observacao.HeaderText = "Observação";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblTotalVendas);
            this.panel2.Controls.Add(this.lbltotalitens);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(559, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 44);
            this.panel2.TabIndex = 14;
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVendas.Location = new System.Drawing.Point(201, 38);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(0, 17);
            this.lblTotalVendas.TabIndex = 15;
            // 
            // lbltotalitens
            // 
            this.lbltotalitens.AutoSize = true;
            this.lbltotalitens.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalitens.Location = new System.Drawing.Point(207, 11);
            this.lbltotalitens.Name = "lbltotalitens";
            this.lbltotalitens.Size = new System.Drawing.Size(0, 17);
            this.lbltotalitens.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Pedidos Realizados:";
            // 
            // FrmVendasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVendasRealizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas Realizadas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PesquisatextBox;
        private System.Windows.Forms.Button btnnovocliente;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Label lbltotalitens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
    }
}