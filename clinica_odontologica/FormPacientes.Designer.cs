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
            this.tb_pacientes_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pacientes_nome = new System.Windows.Forms.TextBox();
            this.bt_pacientes_cadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pacientes_endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pacientes_numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_pacientes_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.tb_pacientes_cep = new System.Windows.Forms.MaskedTextBox();
            this.tb_pacientes_telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tb_pacientes_email
            // 
            this.tb_pacientes_email.Location = new System.Drawing.Point(118, 65);
            this.tb_pacientes_email.Multiline = true;
            this.tb_pacientes_email.Name = "tb_pacientes_email";
            this.tb_pacientes_email.Size = new System.Drawing.Size(294, 30);
            this.tb_pacientes_email.TabIndex = 13;
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
            // tb_pacientes_nome
            // 
            this.tb_pacientes_nome.Location = new System.Drawing.Point(118, 21);
            this.tb_pacientes_nome.Multiline = true;
            this.tb_pacientes_nome.Name = "tb_pacientes_nome";
            this.tb_pacientes_nome.Size = new System.Drawing.Size(294, 30);
            this.tb_pacientes_nome.TabIndex = 10;
            // 
            // bt_pacientes_cadastrar
            // 
            this.bt_pacientes_cadastrar.Location = new System.Drawing.Point(118, 351);
            this.bt_pacientes_cadastrar.Name = "bt_pacientes_cadastrar";
            this.bt_pacientes_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_pacientes_cadastrar.TabIndex = 9;
            this.bt_pacientes_cadastrar.Text = "Cadastrar";
            this.bt_pacientes_cadastrar.UseVisualStyleBackColor = true;
            this.bt_pacientes_cadastrar.Click += new System.EventHandler(this.bt_pacientes_cadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nascimento";
            // 
            // tb_pacientes_endereco
            // 
            this.tb_pacientes_endereco.Location = new System.Drawing.Point(118, 161);
            this.tb_pacientes_endereco.Multiline = true;
            this.tb_pacientes_endereco.Name = "tb_pacientes_endereco";
            this.tb_pacientes_endereco.Size = new System.Drawing.Size(294, 30);
            this.tb_pacientes_endereco.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Endereço";
            // 
            // tb_pacientes_numero
            // 
            this.tb_pacientes_numero.Location = new System.Drawing.Point(118, 210);
            this.tb_pacientes_numero.Multiline = true;
            this.tb_pacientes_numero.Name = "tb_pacientes_numero";
            this.tb_pacientes_numero.Size = new System.Drawing.Size(294, 30);
            this.tb_pacientes_numero.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "CEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Telefone";
            // 
            // tb_pacientes_nascimento
            // 
            this.tb_pacientes_nascimento.Location = new System.Drawing.Point(118, 112);
            this.tb_pacientes_nascimento.Mask = "00/00/0000";
            this.tb_pacientes_nascimento.Name = "tb_pacientes_nascimento";
            this.tb_pacientes_nascimento.Size = new System.Drawing.Size(108, 20);
            this.tb_pacientes_nascimento.TabIndex = 25;
            // 
            // tb_pacientes_cep
            // 
            this.tb_pacientes_cep.Location = new System.Drawing.Point(118, 264);
            this.tb_pacientes_cep.Mask = "00000-000";
            this.tb_pacientes_cep.Name = "tb_pacientes_cep";
            this.tb_pacientes_cep.Size = new System.Drawing.Size(108, 20);
            this.tb_pacientes_cep.TabIndex = 26;
            // 
            // tb_pacientes_telefone
            // 
            this.tb_pacientes_telefone.Location = new System.Drawing.Point(118, 312);
            this.tb_pacientes_telefone.Mask = "(00) 0000-0000";
            this.tb_pacientes_telefone.Name = "tb_pacientes_telefone";
            this.tb_pacientes_telefone.Size = new System.Drawing.Size(108, 20);
            this.tb_pacientes_telefone.TabIndex = 27;
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 386);
            this.Controls.Add(this.tb_pacientes_telefone);
            this.Controls.Add(this.tb_pacientes_cep);
            this.Controls.Add(this.tb_pacientes_nascimento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_pacientes_numero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_pacientes_endereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pacientes_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pacientes_nome);
            this.Controls.Add(this.bt_pacientes_cadastrar);
            this.Name = "FormPacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pacientes_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pacientes_nome;
        private System.Windows.Forms.Button bt_pacientes_cadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pacientes_endereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pacientes_numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox tb_pacientes_nascimento;
        private System.Windows.Forms.MaskedTextBox tb_pacientes_cep;
        private System.Windows.Forms.MaskedTextBox tb_pacientes_telefone;
    }
}