namespace clinica_odontologica
{
    partial class FormPacientes
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
            this.tb_usuario_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_usuario_nome = new System.Windows.Forms.TextBox();
            this.bt_usuario_cadastrar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tb_usuario_email
            // 
            this.tb_usuario_email.Location = new System.Drawing.Point(96, 71);
            this.tb_usuario_email.Multiline = true;
            this.tb_usuario_email.Name = "tb_usuario_email";
            this.tb_usuario_email.Size = new System.Drawing.Size(294, 30);
            this.tb_usuario_email.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // tb_usuario_nome
            // 
            this.tb_usuario_nome.Location = new System.Drawing.Point(96, 27);
            this.tb_usuario_nome.Multiline = true;
            this.tb_usuario_nome.Name = "tb_usuario_nome";
            this.tb_usuario_nome.Size = new System.Drawing.Size(294, 30);
            this.tb_usuario_nome.TabIndex = 10;
            // 
            // bt_usuario_cadastrar
            // 
            this.bt_usuario_cadastrar.Location = new System.Drawing.Point(96, 203);
            this.bt_usuario_cadastrar.Name = "bt_usuario_cadastrar";
            this.bt_usuario_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_usuario_cadastrar.TabIndex = 9;
            this.bt_usuario_cadastrar.Text = "Cadastrar";
            this.bt_usuario_cadastrar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 261);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_usuario_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_usuario_nome);
            this.Controls.Add(this.bt_usuario_cadastrar);
            this.Name = "FormPacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_usuario_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_usuario_nome;
        private System.Windows.Forms.Button bt_usuario_cadastrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}