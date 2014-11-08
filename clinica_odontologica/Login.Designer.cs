namespace clinica_odontologica
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tb_login = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.lbl_exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Myriad Pro Cond", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_login.Location = new System.Drawing.Point(80, 164);
            this.tb_login.Multiline = true;
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(301, 52);
            this.tb_login.TabIndex = 0;
            this.tb_login.TabStop = false;
            this.tb_login.Tag = "";
            this.tb_login.Text = "Login";
            this.tb_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_login.Click += new System.EventHandler(this.tb_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tb_senha
            // 
            this.tb_senha.Font = new System.Drawing.Font("Myriad Pro Cond", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_senha.Location = new System.Drawing.Point(80, 242);
            this.tb_senha.Multiline = true;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(301, 52);
            this.tb_senha.TabIndex = 3;
            this.tb_senha.TabStop = false;
            this.tb_senha.Tag = "";
            this.tb_senha.Text = "Senha";
            this.tb_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_senha.Click += new System.EventHandler(this.tb_senha_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_exit.Location = new System.Drawing.Point(436, 9);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(22, 23);
            this.lbl_exit.TabIndex = 4;
            this.lbl_exit.Text = "X";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(470, 352);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lbl_exit;
    }
}