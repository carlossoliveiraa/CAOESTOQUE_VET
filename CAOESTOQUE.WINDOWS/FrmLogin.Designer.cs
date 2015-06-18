namespace Principal
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.entrarbutton = new System.Windows.Forms.Button();
            this.senhatextBox = new System.Windows.Forms.TextBox();
            this.logintextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cancelarbutton);
            this.panel1.Controls.Add(this.entrarbutton);
            this.panel1.Controls.Add(this.senhatextBox);
            this.panel1.Controls.Add(this.logintextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 210);
            this.panel1.TabIndex = 0;
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(335, 157);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(96, 23);
            this.cancelarbutton.TabIndex = 8;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // entrarbutton
            // 
            this.entrarbutton.Location = new System.Drawing.Point(234, 157);
            this.entrarbutton.Name = "entrarbutton";
            this.entrarbutton.Size = new System.Drawing.Size(95, 23);
            this.entrarbutton.TabIndex = 7;
            this.entrarbutton.Text = "Entrar";
            this.entrarbutton.UseVisualStyleBackColor = true;
            this.entrarbutton.Click += new System.EventHandler(this.entrarbutton_Click);
            // 
            // senhatextBox
            // 
            this.senhatextBox.Location = new System.Drawing.Point(214, 115);
            this.senhatextBox.Name = "senhatextBox";
            this.senhatextBox.PasswordChar = '*';
            this.senhatextBox.Size = new System.Drawing.Size(217, 20);
            this.senhatextBox.TabIndex = 5;
            this.senhatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.senhatextBox_KeyPress);
            // 
            // logintextBox
            // 
            this.logintextBox.Location = new System.Drawing.Point(214, 76);
            this.logintextBox.Name = "logintextBox";
            this.logintextBox.Size = new System.Drawing.Size(217, 20);
            this.logintextBox.TabIndex = 4;
            this.logintextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logintextBox_KeyPress);
            this.logintextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.logintextBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite seu login e Senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::CAOESTOQUE.WINDOWS.Properties.Resources.How_to_password_protect_folders_in_Windows_71;
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(467, 206);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 214;
            this.lineShape1.X2 = 430;
            this.lineShape1.Y1 = 43;
            this.lineShape1.Y2 = 43;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(471, 210);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.Button entrarbutton;
        private System.Windows.Forms.TextBox senhatextBox;
        private System.Windows.Forms.TextBox logintextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}