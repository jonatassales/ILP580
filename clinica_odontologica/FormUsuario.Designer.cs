﻿namespace clinica_odontologica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.bt_usuario_cadastrar = new System.Windows.Forms.Button();
            this.tb_usuario_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_usuario_username = new System.Windows.Forms.TextBox();
            this.tb_usuario_password = new System.Windows.Forms.TextBox();
            this.tb_usuario_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_usuario_excluir = new System.Windows.Forms.Button();
            this.bt_usuarios_fechar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_usuario_cadastrar
            // 
            this.bt_usuario_cadastrar.Location = new System.Drawing.Point(139, 248);
            this.bt_usuario_cadastrar.Name = "bt_usuario_cadastrar";
            this.bt_usuario_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_usuario_cadastrar.TabIndex = 0;
            this.bt_usuario_cadastrar.Text = "Cadastrar";
            this.bt_usuario_cadastrar.UseVisualStyleBackColor = true;
            this.bt_usuario_cadastrar.Click += new System.EventHandler(this.bt_usuario_cadastrar_Click);
            // 
            // tb_usuario_nome
            // 
            this.tb_usuario_nome.Location = new System.Drawing.Point(139, 72);
            this.tb_usuario_nome.Multiline = true;
            this.tb_usuario_nome.Name = "tb_usuario_nome";
            this.tb_usuario_nome.Size = new System.Drawing.Size(294, 30);
            this.tb_usuario_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // tb_usuario_username
            // 
            this.tb_usuario_username.Location = new System.Drawing.Point(139, 160);
            this.tb_usuario_username.Multiline = true;
            this.tb_usuario_username.Name = "tb_usuario_username";
            this.tb_usuario_username.Size = new System.Drawing.Size(212, 30);
            this.tb_usuario_username.TabIndex = 6;
            // 
            // tb_usuario_password
            // 
            this.tb_usuario_password.Location = new System.Drawing.Point(139, 203);
            this.tb_usuario_password.Multiline = true;
            this.tb_usuario_password.Name = "tb_usuario_password";
            this.tb_usuario_password.PasswordChar = '*';
            this.tb_usuario_password.Size = new System.Drawing.Size(212, 30);
            this.tb_usuario_password.TabIndex = 7;
            // 
            // tb_usuario_email
            // 
            this.tb_usuario_email.Location = new System.Drawing.Point(139, 116);
            this.tb_usuario_email.Multiline = true;
            this.tb_usuario_email.Name = "tb_usuario_email";
            this.tb_usuario_email.Size = new System.Drawing.Size(294, 30);
            this.tb_usuario_email.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "E-mail";
            // 
            // bt_usuario_excluir
            // 
            this.bt_usuario_excluir.Location = new System.Drawing.Point(276, 248);
            this.bt_usuario_excluir.Name = "bt_usuario_excluir";
            this.bt_usuario_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_usuario_excluir.TabIndex = 12;
            this.bt_usuario_excluir.Text = "Excluir";
            this.bt_usuario_excluir.UseVisualStyleBackColor = true;
            this.bt_usuario_excluir.Visible = false;
            this.bt_usuario_excluir.Click += new System.EventHandler(this.bt_usuario_excluir_Click);
            // 
            // bt_usuarios_fechar
            // 
            this.bt_usuarios_fechar.AutoSize = true;
            this.bt_usuarios_fechar.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_usuarios_fechar.Location = new System.Drawing.Point(480, 9);
            this.bt_usuarios_fechar.Name = "bt_usuarios_fechar";
            this.bt_usuarios_fechar.Size = new System.Drawing.Size(19, 20);
            this.bt_usuarios_fechar.TabIndex = 13;
            this.bt_usuarios_fechar.Text = "X";
            this.bt_usuarios_fechar.Click += new System.EventHandler(this.bt_usuarios_fechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 46);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 46);
            this.label2.TabIndex = 39;
            this.label2.Text = "Usuarios";
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(511, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_usuarios_fechar);
            this.Controls.Add(this.bt_usuario_excluir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_usuario_email);
            this.Controls.Add(this.tb_usuario_password);
            this.Controls.Add(this.tb_usuario_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_usuario_nome);
            this.Controls.Add(this.bt_usuario_cadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_usuario_cadastrar;
        private System.Windows.Forms.TextBox tb_usuario_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_usuario_username;
        private System.Windows.Forms.TextBox tb_usuario_password;
        private System.Windows.Forms.TextBox tb_usuario_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_usuario_excluir;
        private System.Windows.Forms.Label bt_usuarios_fechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}