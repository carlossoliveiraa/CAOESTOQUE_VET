namespace Principal
{
    partial class FrmCadastrarAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarAgendamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.salvarbutton = new System.Windows.Forms.Button();
            this.ServicotextBox = new System.Windows.Forms.TextBox();
            this.servicolabel = new System.Windows.Forms.Label();
            this.calendariodateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.horaservicolabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.horaServicotextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.PesquisatextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cpftextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nomeclienteservicotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idservicotextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CodigoServicolabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 504);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.salvarbutton);
            this.panel4.Controls.Add(this.ServicotextBox);
            this.panel4.Controls.Add(this.servicolabel);
            this.panel4.Controls.Add(this.calendariodateTimePicker1);
            this.panel4.Controls.Add(this.horaservicolabel);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.horaServicotextBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(9, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(705, 226);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // salvarbutton
            // 
            this.salvarbutton.BackColor = System.Drawing.Color.Teal;
            this.salvarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvarbutton.Location = new System.Drawing.Point(3, 185);
            this.salvarbutton.Name = "salvarbutton";
            this.salvarbutton.Size = new System.Drawing.Size(155, 38);
            this.salvarbutton.TabIndex = 7;
            this.salvarbutton.Text = "Salvar";
            this.salvarbutton.UseVisualStyleBackColor = false;
            this.salvarbutton.Click += new System.EventHandler(this.salvarbutton_Click_1);
            // 
            // ServicotextBox
            // 
            this.ServicotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.ServicotextBox.Location = new System.Drawing.Point(7, 73);
            this.ServicotextBox.MaxLength = 1000;
            this.ServicotextBox.Multiline = true;
            this.ServicotextBox.Name = "ServicotextBox";
            this.ServicotextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ServicotextBox.Size = new System.Drawing.Size(609, 106);
            this.ServicotextBox.TabIndex = 3;
            // 
            // servicolabel
            // 
            this.servicolabel.AutoSize = true;
            this.servicolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicolabel.ForeColor = System.Drawing.Color.Red;
            this.servicolabel.Location = new System.Drawing.Point(622, 73);
            this.servicolabel.Name = "servicolabel";
            this.servicolabel.Size = new System.Drawing.Size(21, 25);
            this.servicolabel.TabIndex = 27;
            this.servicolabel.Text = "*";
            this.servicolabel.Visible = false;
            // 
            // calendariodateTimePicker1
            // 
            this.calendariodateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendariodateTimePicker1.Location = new System.Drawing.Point(142, 17);
            this.calendariodateTimePicker1.Name = "calendariodateTimePicker1";
            this.calendariodateTimePicker1.Size = new System.Drawing.Size(254, 19);
            this.calendariodateTimePicker1.TabIndex = 28;
            this.calendariodateTimePicker1.Value = new System.DateTime(2011, 12, 30, 0, 0, 0, 0);
            // 
            // horaservicolabel
            // 
            this.horaservicolabel.AutoSize = true;
            this.horaservicolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaservicolabel.ForeColor = System.Drawing.Color.Red;
            this.horaservicolabel.Location = new System.Drawing.Point(622, 19);
            this.horaservicolabel.Name = "horaservicolabel";
            this.horaservicolabel.Size = new System.Drawing.Size(21, 25);
            this.horaservicolabel.TabIndex = 26;
            this.horaservicolabel.Text = "*";
            this.horaservicolabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Serviço a ser feito:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Data do Serviço:";
            // 
            // horaServicotextBox
            // 
            this.horaServicotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaServicotextBox.Location = new System.Drawing.Point(538, 17);
            this.horaServicotextBox.Mask = "00:00";
            this.horaServicotextBox.Name = "horaServicotextBox";
            this.horaServicotextBox.Size = new System.Drawing.Size(78, 22);
            this.horaServicotextBox.TabIndex = 2;
            this.horaServicotextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hora do Serviço:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.PesquisatextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(9, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 180);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(653, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 105);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(4, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Clientes Cadastrados:";
            // 
            // PesquisatextBox
            // 
            this.PesquisatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesquisatextBox.Location = new System.Drawing.Point(83, 9);
            this.PesquisatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PesquisatextBox.MaxLength = 38;
            this.PesquisatextBox.Name = "PesquisatextBox";
            this.PesquisatextBox.Size = new System.Drawing.Size(612, 22);
            this.PesquisatextBox.TabIndex = 1;
            this.PesquisatextBox.TextChanged += new System.EventHandler(this.PesquisatextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Procurar:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cpftextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.nomeclienteservicotextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.idservicotextBox);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(10, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 52);
            this.panel2.TabIndex = 1;
            // 
            // cpftextBox
            // 
            this.cpftextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpftextBox.Location = new System.Drawing.Point(548, 14);
            this.cpftextBox.MaxLength = 50;
            this.cpftextBox.Name = "cpftextBox";
            this.cpftextBox.ReadOnly = true;
            this.cpftextBox.Size = new System.Drawing.Size(146, 22);
            this.cpftextBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "CPF:";
            // 
            // nomeclienteservicotextBox
            // 
            this.nomeclienteservicotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeclienteservicotextBox.Location = new System.Drawing.Point(254, 14);
            this.nomeclienteservicotextBox.MaxLength = 50;
            this.nomeclienteservicotextBox.Name = "nomeclienteservicotextBox";
            this.nomeclienteservicotextBox.ReadOnly = true;
            this.nomeclienteservicotextBox.Size = new System.Drawing.Size(255, 22);
            this.nomeclienteservicotextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código Cliente:";
            // 
            // idservicotextBox
            // 
            this.idservicotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idservicotextBox.Location = new System.Drawing.Point(124, 15);
            this.idservicotextBox.MaxLength = 50;
            this.idservicotextBox.Name = "idservicotextBox";
            this.idservicotextBox.ReadOnly = true;
            this.idservicotextBox.Size = new System.Drawing.Size(66, 22);
            this.idservicotextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(2, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Código do Serviço:";
            // 
            // CodigoServicolabel
            // 
            this.CodigoServicolabel.AutoSize = true;
            this.CodigoServicolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoServicolabel.ForeColor = System.Drawing.Color.Red;
            this.CodigoServicolabel.Location = new System.Drawing.Point(165, 8);
            this.CodigoServicolabel.Name = "CodigoServicolabel";
            this.CodigoServicolabel.Size = new System.Drawing.Size(14, 20);
            this.CodigoServicolabel.TabIndex = 1;
            this.CodigoServicolabel.Text = ".";
            // 
            // FrmCadastrarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 538);
            this.Controls.Add(this.CodigoServicolabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastrarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Serviço do Cliente";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox horaServicotextBox;
        private System.Windows.Forms.TextBox ServicotextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox idservicotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nomeclienteservicotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button salvarbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CodigoServicolabel;
        private System.Windows.Forms.TextBox cpftextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label servicolabel;
        private System.Windows.Forms.Label horaservicolabel;
        private System.Windows.Forms.DateTimePicker calendariodateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PesquisatextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}