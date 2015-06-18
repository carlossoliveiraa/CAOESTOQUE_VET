namespace CAOESTOQUE.WINDOWS
{
    partial class FrmRelatorioPeriodoDetalhado
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
            this.btnexportExcel = new System.Windows.Forms.Button();
            this.dataGridViewRelatorio = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.txtDatainicial = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoTotalPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexportExcel
            // 
            this.btnexportExcel.Location = new System.Drawing.Point(12, 406);
            this.btnexportExcel.Name = "btnexportExcel";
            this.btnexportExcel.Size = new System.Drawing.Size(128, 44);
            this.btnexportExcel.TabIndex = 18;
            this.btnexportExcel.Text = "Exportar Excel";
            this.btnexportExcel.UseVisualStyleBackColor = true;
            this.btnexportExcel.Click += new System.EventHandler(this.btnexportExcel_Click);
            // 
            // dataGridViewRelatorio
            // 
            this.dataGridViewRelatorio.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewRelatorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DataVenda,
            this.Nome,
            this.TipoPagamento,
            this.Quantidade,
            this.PrecoTotal,
            this.SubTotalPedido,
            this.PrecoTotalPedido,
            this.Desconto,
            this.Observacao});
            this.dataGridViewRelatorio.Location = new System.Drawing.Point(12, 132);
            this.dataGridViewRelatorio.MultiSelect = false;
            this.dataGridViewRelatorio.Name = "dataGridViewRelatorio";
            this.dataGridViewRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRelatorio.Size = new System.Drawing.Size(1187, 255);
            this.dataGridViewRelatorio.TabIndex = 16;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(537, 53);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 23);
            this.btnPesquisar.TabIndex = 36;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Location = new System.Drawing.Point(384, 54);
            this.txtDataFinal.Mask = "00/00/0000";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(125, 22);
            this.txtDataFinal.TabIndex = 35;
            // 
            // txtDatainicial
            // 
            this.txtDatainicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatainicial.Location = new System.Drawing.Point(132, 54);
            this.txtDatainicial.Mask = "00/00/0000";
            this.txtDatainicial.Name = "txtDatainicial";
            this.txtDatainicial.Size = new System.Drawing.Size(125, 22);
            this.txtDatainicial.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(281, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(257, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatório por Período Detalhado";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.txtDataFinal);
            this.panel1.Controls.Add(this.txtDatainicial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 116);
            this.panel1.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_Pedido";
            this.Id.HeaderText = "Numero Pedido";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // DataVenda
            // 
            this.DataVenda.DataPropertyName = "DataVenda";
            this.DataVenda.HeaderText = "Data da Venda";
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "NomeCliente";
            this.Nome.HeaderText = "Nome do Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // TipoPagamento
            // 
            this.TipoPagamento.DataPropertyName = "TipoPagto";
            this.TipoPagamento.HeaderText = "TipoPagamento";
            this.TipoPagamento.Name = "TipoPagamento";
            this.TipoPagamento.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "NomeProdutoPedido";
            this.Quantidade.HeaderText = "Nome Produto";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // PrecoTotal
            // 
            this.PrecoTotal.DataPropertyName = "PrecoUnitario";
            this.PrecoTotal.HeaderText = "Preço Unitario";
            this.PrecoTotal.Name = "PrecoTotal";
            this.PrecoTotal.ReadOnly = true;
            // 
            // SubTotalPedido
            // 
            this.SubTotalPedido.DataPropertyName = "PrecoSubTotalPedido";
            this.SubTotalPedido.HeaderText = "SubTotalPedido";
            this.SubTotalPedido.Name = "SubTotalPedido";
            this.SubTotalPedido.ReadOnly = true;
            // 
            // PrecoTotalPedido
            // 
            this.PrecoTotalPedido.DataPropertyName = "PrecoTotalPedido";
            this.PrecoTotalPedido.HeaderText = "PrecoTotalPedido";
            this.PrecoTotalPedido.Name = "PrecoTotalPedido";
            this.PrecoTotalPedido.ReadOnly = true;
            // 
            // Desconto
            // 
            this.Desconto.DataPropertyName = "Desconto";
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            // 
            // Observacao
            // 
            this.Observacao.DataPropertyName = "Observacao";
            this.Observacao.HeaderText = "Observacao";
            this.Observacao.Name = "Observacao";
            this.Observacao.ReadOnly = true;
            // 
            // FrmRelatorioPeriodoDetalhado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 494);
            this.Controls.Add(this.btnexportExcel);
            this.Controls.Add(this.dataGridViewRelatorio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorioPeriodoDetalhado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio por Periodo Detalhado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexportExcel;
        private System.Windows.Forms.DataGridView dataGridViewRelatorio;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox txtDataFinal;
        private System.Windows.Forms.MaskedTextBox txtDatainicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoTotalPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
    }
}