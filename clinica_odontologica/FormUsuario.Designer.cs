namespace clinica_odontologica
{
    partial class FormUsuario
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
            this.bt_usuario_cadastrar = new System.Windows.Forms.Button();
            this.tb_usuario_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_usuario_username = new System.Windows.Forms.TextBox();
            this.tb_usuario_password = new System.Windows.Forms.TextBox();
            this.tb_usuario_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_usuario_cadastrar
            // 
            this.bt_usuario_cadastrar.Location = new System.Drawing.Point(111, 215);
            this.bt_usuario_cadastrar.Name = "bt_usuario_cadastrar";
            this.bt_usuario_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_usuario_cadastrar.TabIndex = 0;
            this.bt_usuario_cadastrar.Text = "Cadastrar";
            this.bt_usuario_cadastrar.UseVisualStyleBackColor = true;
            this.bt_usuario_cadastrar.Click += new System.EventHandler(this.bt_usuario_cadastrar_Click);
            // 
            // tb_usuario_nome
            // 
            this.tb_usuario_nome.Location = new System.Drawing.Point(111, 39);
            this.tb_usuario_nome.Multiline = true;
            this.tb_usuario_nome.Name = "tb_usuario_nome";
            this.tb_usuario_nome.Size = new System.Drawing.Size(294, 30);
            this.tb_usuario_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-mail";
            // 
            // tb_usuario_username
            // 
            this.tb_usuario_username.Location = new System.Drawing.Point(111, 127);
            this.tb_usuario_username.Multiline = true;
            this.tb_usuario_username.Name = "tb_usuario_username";
            this.tb_usuario_username.Size = new System.Drawing.Size(212, 30);
            this.tb_usuario_username.TabIndex = 6;
            // 
            // tb_usuario_password
            // 
            this.tb_usuario_password.Location = new System.Drawing.Point(111, 170);
            this.tb_usuario_password.Multiline = true;
            this.tb_usuario_password.Name = "tb_usuario_password";
            this.tb_usuario_password.PasswordChar = '*';
            this.tb_usuario_password.Size = new System.Drawing.Size(212, 30);
            this.tb_usuario_password.TabIndex = 7;
            // 
            // tb_usuario_email
            // 
            this.tb_usuario_email.Location = new System.Drawing.Point(111, 83);
            this.tb_usuario_email.Multiline = true;
            this.tb_usuario_email.Name = "tb_usuario_email";
            this.tb_usuario_email.Size = new System.Drawing.Size(294, 30);
            this.tb_usuario_email.TabIndex = 8;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 297);
            this.Controls.Add(this.tb_usuario_email);
            this.Controls.Add(this.tb_usuario_password);
            this.Controls.Add(this.tb_usuario_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_usuario_nome);
            this.Controls.Add(this.bt_usuario_cadastrar);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_usuario_cadastrar;
        private System.Windows.Forms.TextBox tb_usuario_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_usuario_username;
        private System.Windows.Forms.TextBox tb_usuario_password;
        private System.Windows.Forms.TextBox tb_usuario_email;
    }
}