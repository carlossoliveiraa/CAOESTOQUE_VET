namespace Principal
{
    partial class FrmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServicotextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.formapagtocomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.valorpagotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.valorservicotextBox = new System.Windows.Forms.TextBox();
            this.salvarbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CodclienteservicotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idservicotextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ServicotextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.formapagtocomboBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.valorpagotextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.valorservicotextBox);
            this.panel1.Controls.Add(this.salvarbutton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 286);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ServicotextBox
            // 
            this.ServicotextBox.Enabled = false;
            this.ServicotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.ServicotextBox.Location = new System.Drawing.Point(381, 95);
            this.ServicotextBox.MaxLength = 1000;
            this.ServicotextBox.Multiline = true;
            this.ServicotextBox.Name = "ServicotextBox";
            this.ServicotextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ServicotextBox.Size = new System.Drawing.Size(332, 177);
            this.ServicotextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Serviço feito:";
            // 
            // formapagtocomboBox
            // 
            this.formapagtocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formapagtocomboBox.FormattingEnabled = true;
            this.formapagtocomboBox.ItemHeight = 13;
            this.formapagtocomboBox.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.formapagtocomboBox.Location = new System.Drawing.Point(147, 160);
            this.formapagtocomboBox.Name = "formapagtocomboBox";
            this.formapagtocomboBox.Size = new System.Drawing.Size(120, 21);
            this.formapagtocomboBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Serviço Pago?";
            // 
            // valorpagotextBox
            // 
            this.valorpagotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.valorpagotextBox.Location = new System.Drawing.Point(147, 126);
            this.valorpagotextBox.MaxLength = 50;
            this.valorpagotextBox.Name = "valorpagotextBox";
            this.valorpagotextBox.Size = new System.Drawing.Size(119, 21);
            this.valorpagotextBox.TabIndex = 5;
            this.valorpagotextBox.Text = "0.00";
            this.valorpagotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorpagotextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total a Pagar:";
            // 
            // valorservicotextBox
            // 
            this.valorservicotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.valorservicotextBox.Location = new System.Drawing.Point(147, 91);
            this.valorservicotextBox.MaxLength = 50;
            this.valorservicotextBox.Name = "valorservicotextBox";
            this.valorservicotextBox.Size = new System.Drawing.Size(119, 21);
            this.valorservicotextBox.TabIndex = 4;
            this.valorservicotextBox.Text = "0.00";
            this.valorservicotextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valorservicotextBox_KeyDown);
            this.valorservicotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorservicotextBox_KeyPress);
            // 
            // salvarbutton
            // 
            this.salvarbutton.BackColor = System.Drawing.Color.Teal;
            this.salvarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarbutton.Location = new System.Drawing.Point(7, 234);
            this.salvarbutton.Name = "salvarbutton";
            this.salvarbutton.Size = new System.Drawing.Size(155, 38);
            this.salvarbutton.TabIndex = 7;
            this.salvarbutton.Text = "Salvar";
            this.salvarbutton.UseVisualStyleBackColor = false;
            this.salvarbutton.Click += new System.EventHandler(this.salvarbutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor do Serviço:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.CodclienteservicotextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.idservicotextBox);
            this.panel2.Location = new System.Drawing.Point(10, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 52);
            this.panel2.TabIndex = 8;
            // 
            // CodclienteservicotextBox
            // 
            this.CodclienteservicotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodclienteservicotextBox.Location = new System.Drawing.Point(340, 15);
            this.CodclienteservicotextBox.MaxLength = 50;
            this.CodclienteservicotextBox.Name = "CodclienteservicotextBox";
            this.CodclienteservicotextBox.ReadOnly = true;
            this.CodclienteservicotextBox.Size = new System.Drawing.Size(63, 22);
            this.CodclienteservicotextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código do Serviço:";
            // 
            // idservicotextBox
            // 
            this.idservicotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idservicotextBox.Location = new System.Drawing.Point(152, 15);
            this.idservicotextBox.MaxLength = 50;
            this.idservicotextBox.Name = "idservicotextBox";
            this.idservicotextBox.ReadOnly = true;
            this.idservicotextBox.Size = new System.Drawing.Size(66, 22);
            this.idservicotextBox.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(4, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(724, 187);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pagamentos Pendentes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 140);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // FrmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 509);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pagamento";
            this.Load += new System.EventHandler(this.FrmPagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox formapagtocomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox valorpagotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valorservicotextBox;
        private System.Windows.Forms.Button salvarbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idservicotextBox;
        private System.Windows.Forms.TextBox ServicotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CodclienteservicotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}