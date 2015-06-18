namespace CAOESTOQUE.WINDOWS
{
    partial class FrmSaidaProdutos
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.lblqtd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridSaidaProdutos = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOCATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.txtdatasaida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNomeCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkDinheiro = new System.Windows.Forms.CheckBox();
            this.chkCheque = new System.Windows.Forms.CheckBox();
            this.chkCartao = new System.Windows.Forms.CheckBox();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblvalorpagar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSaidaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblsubtotal);
            this.panel1.Controls.Add(this.lblqtd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtbarcode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 119);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.ForeColor = System.Drawing.Color.Red;
            this.lblsubtotal.Location = new System.Drawing.Point(595, 70);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(0, 31);
            this.lblsubtotal.TabIndex = 5;
            // 
            // lblqtd
            // 
            this.lblqtd.AutoSize = true;
            this.lblqtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtd.ForeColor = System.Drawing.Color.Red;
            this.lblqtd.Location = new System.Drawing.Point(595, 19);
            this.lblqtd.Name = "lblqtd";
            this.lblqtd.Size = new System.Drawing.Size(0, 31);
            this.lblqtd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(449, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "SubTotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(449, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Itens:";
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(217, 28);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(150, 20);
            this.txtbarcode.TabIndex = 1;
            this.txtbarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbarcode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca por Códgio de Barras:";
            // 
            // datagridSaidaProdutos
            // 
            this.datagridSaidaProdutos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridSaidaProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridSaidaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridSaidaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSaidaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Nome,
            this.Qtde,
            this.TIPOCATEGORIA,
            this.Preco});
            this.datagridSaidaProdutos.Location = new System.Drawing.Point(16, 239);
            this.datagridSaidaProdutos.MultiSelect = false;
            this.datagridSaidaProdutos.Name = "datagridSaidaProdutos";
            this.datagridSaidaProdutos.ReadOnly = true;
            this.datagridSaidaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridSaidaProdutos.Size = new System.Drawing.Size(979, 220);
            this.datagridSaidaProdutos.TabIndex = 13;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "IdProduto";
            this.IdProduto.HeaderText = "Id";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 124.9089F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "Qtde";
            this.Qtde.FillWeight = 59.23556F;
            this.Qtde.HeaderText = "Qtde Saida";
            this.Qtde.Name = "Qtde";
            this.Qtde.ReadOnly = true;
            // 
            // TIPOCATEGORIA
            // 
            this.TIPOCATEGORIA.DataPropertyName = "TIPOCATEGORIA";
            this.TIPOCATEGORIA.FillWeight = 73.4823F;
            this.TIPOCATEGORIA.HeaderText = "Categoria";
            this.TIPOCATEGORIA.Name = "TIPOCATEGORIA";
            this.TIPOCATEGORIA.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.FillWeight = 90.08901F;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(20, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Produtos Adicionados para Compra";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvar.Location = new System.Drawing.Point(611, 469);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(167, 32);
            this.btnsalvar.TabIndex = 23;
            this.btnsalvar.Text = "Finalizar Venda";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // txtdatasaida
            // 
            this.txtdatasaida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtdatasaida.Location = new System.Drawing.Point(137, 13);
            this.txtdatasaida.Name = "txtdatasaida";
            this.txtdatasaida.ReadOnly = true;
            this.txtdatasaida.Size = new System.Drawing.Size(224, 20);
            this.txtdatasaida.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data da Venda:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cliente:";
            // 
            // TxtNomeCliente
            // 
            this.TxtNomeCliente.Location = new System.Drawing.Point(73, 476);
            this.TxtNomeCliente.Name = "TxtNomeCliente";
            this.TxtNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.TxtNomeCliente.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Obs:";
            // 
            // chkDinheiro
            // 
            this.chkDinheiro.AutoSize = true;
            this.chkDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDinheiro.Location = new System.Drawing.Point(356, 479);
            this.chkDinheiro.Name = "chkDinheiro";
            this.chkDinheiro.Size = new System.Drawing.Size(73, 17);
            this.chkDinheiro.TabIndex = 20;
            this.chkDinheiro.Text = "Dinheiro";
            this.chkDinheiro.UseVisualStyleBackColor = true;
            this.chkDinheiro.Click += new System.EventHandler(this.chkDinheiro_Click);
            // 
            // chkCheque
            // 
            this.chkCheque.AutoSize = true;
            this.chkCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheque.Location = new System.Drawing.Point(441, 478);
            this.chkCheque.Name = "chkCheque";
            this.chkCheque.Size = new System.Drawing.Size(69, 17);
            this.chkCheque.TabIndex = 21;
            this.chkCheque.Text = "Cheque";
            this.chkCheque.UseVisualStyleBackColor = true;
            this.chkCheque.Click += new System.EventHandler(this.chkCheque_Click);
            // 
            // chkCartao
            // 
            this.chkCartao.AutoSize = true;
            this.chkCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCartao.Location = new System.Drawing.Point(525, 478);
            this.chkCartao.Name = "chkCartao";
            this.chkCartao.Size = new System.Drawing.Size(63, 17);
            this.chkCartao.TabIndex = 22;
            this.chkCartao.Text = "Cartão";
            this.chkCartao.UseVisualStyleBackColor = true;
            this.chkCartao.Click += new System.EventHandler(this.chkCartao_Click);
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.Location = new System.Drawing.Point(221, 475);
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(123, 20);
            this.TxtObservacao.TabIndex = 19;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(367, 204);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "&Excluir Item";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtdesconto
            // 
            this.txtdesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesconto.Location = new System.Drawing.Point(593, 207);
            this.txtdesconto.MaxLength = 2;
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(26, 20);
            this.txtdesconto.TabIndex = 7;
            this.txtdesconto.Text = "0";
            this.txtdesconto.TextChanged += new System.EventHandler(this.txtdesconto_TextChanged);
            this.txtdesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Desconto %";
            // 
            // lblvalorpagar
            // 
            this.lblvalorpagar.AutoSize = true;
            this.lblvalorpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorpagar.ForeColor = System.Drawing.Color.Red;
            this.lblvalorpagar.Location = new System.Drawing.Point(880, 196);
            this.lblvalorpagar.Name = "lblvalorpagar";
            this.lblvalorpagar.Size = new System.Drawing.Size(30, 31);
            this.lblvalorpagar.TabIndex = 8;
            this.lblvalorpagar.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(698, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 31);
            this.label10.TabIndex = 7;
            this.label10.Text = "Valor Pagar:";
            // 
            // FrmSaidaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 517);
            this.Controls.Add(this.lblvalorpagar);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.TxtObservacao);
            this.Controls.Add(this.chkCartao);
            this.Controls.Add(this.chkCheque);
            this.Controls.Add(this.chkDinheiro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtNomeCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdatasaida);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.datagridSaidaProdutos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaidaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida de Produtos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSaidaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label lblqtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.DataGridView datagridSaidaProdutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtdatasaida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNomeCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkDinheiro;
        private System.Windows.Forms.CheckBox chkCheque;
        private System.Windows.Forms.CheckBox chkCartao;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOCATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.Label lblvalorpagar;
        private System.Windows.Forms.Label label10;
    }
}