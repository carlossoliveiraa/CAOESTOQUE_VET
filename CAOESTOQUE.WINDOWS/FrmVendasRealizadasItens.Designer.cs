namespace CAOESTOQUE.WINDOWS
{
    partial class FrmVendasRealizadasItens
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdatavenda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumeropedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.chkCartao = new System.Windows.Forms.CheckBox();
            this.chkCheque = new System.Windows.Forms.CheckBox();
            this.chkDinheiro = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNomeCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datagridSaidaProdutosItens = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSaidaProdutosItens)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtdatavenda);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnumeropedido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtObservacao);
            this.panel1.Controls.Add(this.chkCartao);
            this.panel1.Controls.Add(this.chkCheque);
            this.panel1.Controls.Add(this.chkDinheiro);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TxtNomeCliente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 155);
            this.panel1.TabIndex = 0;
            // 
            // txtdatavenda
            // 
            this.txtdatavenda.Location = new System.Drawing.Point(117, 10);
            this.txtdatavenda.Name = "txtdatavenda";
            this.txtdatavenda.Size = new System.Drawing.Size(77, 20);
            this.txtdatavenda.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data da Venda:";
            // 
            // txtnumeropedido
            // 
            this.txtnumeropedido.Location = new System.Drawing.Point(304, 10);
            this.txtnumeropedido.Name = "txtnumeropedido";
            this.txtnumeropedido.Size = new System.Drawing.Size(77, 20);
            this.txtnumeropedido.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Pedido Número:";
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.Location = new System.Drawing.Point(485, 57);
            this.TxtObservacao.Multiline = true;
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(327, 83);
            this.TxtObservacao.TabIndex = 25;
            // 
            // chkCartao
            // 
            this.chkCartao.AutoSize = true;
            this.chkCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCartao.Location = new System.Drawing.Point(97, 99);
            this.chkCartao.Name = "chkCartao";
            this.chkCartao.Size = new System.Drawing.Size(63, 17);
            this.chkCartao.TabIndex = 29;
            this.chkCartao.Text = "Cartão";
            this.chkCartao.UseVisualStyleBackColor = true;
            // 
            // chkCheque
            // 
            this.chkCheque.AutoSize = true;
            this.chkCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheque.Location = new System.Drawing.Point(166, 99);
            this.chkCheque.Name = "chkCheque";
            this.chkCheque.Size = new System.Drawing.Size(69, 17);
            this.chkCheque.TabIndex = 28;
            this.chkCheque.Text = "Cheque";
            this.chkCheque.UseVisualStyleBackColor = true;
            // 
            // chkDinheiro
            // 
            this.chkDinheiro.AutoSize = true;
            this.chkDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDinheiro.Location = new System.Drawing.Point(18, 99);
            this.chkDinheiro.Name = "chkDinheiro";
            this.chkDinheiro.Size = new System.Drawing.Size(73, 17);
            this.chkDinheiro.TabIndex = 27;
            this.chkDinheiro.Text = "Dinheiro";
            this.chkDinheiro.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Obs:";
            // 
            // TxtNomeCliente
            // 
            this.TxtNomeCliente.Enabled = false;
            this.TxtNomeCliente.Location = new System.Drawing.Point(71, 54);
            this.TxtNomeCliente.Name = "TxtNomeCliente";
            this.TxtNomeCliente.Size = new System.Drawing.Size(369, 20);
            this.TxtNomeCliente.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cliente:";
            // 
            // datagridSaidaProdutosItens
            // 
            this.datagridSaidaProdutosItens.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridSaidaProdutosItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridSaidaProdutosItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridSaidaProdutosItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSaidaProdutosItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Nome,
            this.Qtde,
            this.Preco});
            this.datagridSaidaProdutosItens.Location = new System.Drawing.Point(12, 201);
            this.datagridSaidaProdutosItens.MultiSelect = false;
            this.datagridSaidaProdutosItens.Name = "datagridSaidaProdutosItens";
            this.datagridSaidaProdutosItens.ReadOnly = true;
            this.datagridSaidaProdutosItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridSaidaProdutosItens.Size = new System.Drawing.Size(832, 302);
            this.datagridSaidaProdutosItens.TabIndex = 14;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "Id_Pedido";
            this.IdProduto.HeaderText = "Id";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "NomeProdutoPedido";
            this.Nome.FillWeight = 124.9089F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "QtdeProdutosPedido";
            this.Qtde.FillWeight = 59.23556F;
            this.Qtde.HeaderText = "Quantidade";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "PrecoProdutosPedido";
            this.Preco.FillWeight = 90.08901F;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // FrmVendasRealizadasItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 515);
            this.Controls.Add(this.datagridSaidaProdutosItens);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVendasRealizadasItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas Realizadas Itens";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSaidaProdutosItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdatavenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumeropedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.CheckBox chkCartao;
        private System.Windows.Forms.CheckBox chkCheque;
        private System.Windows.Forms.CheckBox chkDinheiro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNomeCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView datagridSaidaProdutosItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
    }
}