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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacientes));
            this.tb_pacientes_email = new System.Windows.Forms.TextBox();
            this.tb_pacientes_nome = new System.Windows.Forms.TextBox();
            this.bt_pacientes_cadastrar = new System.Windows.Forms.Button();
            this.tb_pacientes_endereco = new System.Windows.Forms.TextBox();
            this.tb_pacientes_numero = new System.Windows.Forms.TextBox();
            this.tb_pacientes_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.tb_pacientes_cep = new System.Windows.Forms.MaskedTextBox();
            this.tb_pacientes_telefone = new System.Windows.Forms.MaskedTextBox();
            this.bt_pacientes_excluir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_pacientes_fechar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_pacientes_email
            // 
            this.tb_pacientes_email.Location = new System.Drawing.Point(147, 111);
            this.tb_pacientes_email.Multiline = true;
            this.tb_pacientes_email.Name = "tb_pacientes_email";
            this.tb_pacientes_email.Size = new System.Drawing.Size(294, 22);
            this.tb_pacientes_email.TabIndex = 13;
            // 
            // tb_pacientes_nome
            // 
            this.tb_pacientes_nome.Location = new System.Drawing.Point(147, 73);
            this.tb_pacientes_nome.Multiline = true;
            this.tb_pacientes_nome.Name = "tb_pacientes_nome";
            this.tb_pacientes_nome.Size = new System.Drawing.Size(294, 22);
            this.tb_pacientes_nome.TabIndex = 10;
            // 
            // bt_pacientes_cadastrar
            // 
            this.bt_pacientes_cadastrar.Location = new System.Drawing.Point(147, 336);
            this.bt_pacientes_cadastrar.Name = "bt_pacientes_cadastrar";
            this.bt_pacientes_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_pacientes_cadastrar.TabIndex = 9;
            this.bt_pacientes_cadastrar.Text = "Cadastrar";
            this.bt_pacientes_cadastrar.UseVisualStyleBackColor = true;
            this.bt_pacientes_cadastrar.Click += new System.EventHandler(this.bt_pacientes_cadastrar_Click);
            // 
            // tb_pacientes_endereco
            // 
            this.tb_pacientes_endereco.Location = new System.Drawing.Point(147, 184);
            this.tb_pacientes_endereco.Multiline = true;
            this.tb_pacientes_endereco.Name = "tb_pacientes_endereco";
            this.tb_pacientes_endereco.Size = new System.Drawing.Size(294, 22);
            this.tb_pacientes_endereco.TabIndex = 18;
            // 
            // tb_pacientes_numero
            // 
            this.tb_pacientes_numero.Location = new System.Drawing.Point(147, 221);
            this.tb_pacientes_numero.Multiline = true;
            this.tb_pacientes_numero.Name = "tb_pacientes_numero";
            this.tb_pacientes_numero.Size = new System.Drawing.Size(108, 22);
            this.tb_pacientes_numero.TabIndex = 20;
            // 
            // tb_pacientes_nascimento
            // 
            this.tb_pacientes_nascimento.Location = new System.Drawing.Point(147, 148);
            this.tb_pacientes_nascimento.Mask = "00/00/0000";
            this.tb_pacientes_nascimento.Name = "tb_pacientes_nascimento";
            this.tb_pacientes_nascimento.Size = new System.Drawing.Size(108, 20);
            this.tb_pacientes_nascimento.TabIndex = 25;
            // 
            // tb_pacientes_cep
            // 
            this.tb_pacientes_cep.Location = new System.Drawing.Point(147, 258);
            this.tb_pacientes_cep.Mask = "00000-000";
            this.tb_pacientes_cep.Name = "tb_pacientes_cep";
            this.tb_pacientes_cep.Size = new System.Drawing.Size(108, 20);
            this.tb_pacientes_cep.TabIndex = 26;
            // 
            // tb_pacientes_telefone
            // 
            this.tb_pacientes_telefone.Location = new System.Drawing.Point(147, 293);
            this.tb_pacientes_telefone.Mask = "(00) 0000-0000";
            this.tb_pacientes_telefone.Name = "tb_pacientes_telefone";
            this.tb_pacientes_telefone.Size = new System.Drawing.Size(108, 20);
            this.tb_pacientes_telefone.TabIndex = 27;
            // 
            // bt_pacientes_excluir
            // 
            this.bt_pacientes_excluir.Location = new System.Drawing.Point(366, 336);
            this.bt_pacientes_excluir.Name = "bt_pacientes_excluir";
            this.bt_pacientes_excluir.Size = new System.Drawing.Size(75, 23);
            this.bt_pacientes_excluir.TabIndex = 28;
            this.bt_pacientes_excluir.Text = "Excluir";
            this.bt_pacientes_excluir.UseVisualStyleBackColor = true;
            this.bt_pacientes_excluir.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Endereco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Telefone";
            // 
            // bt_pacientes_fechar
            // 
            this.bt_pacientes_fechar.AutoSize = true;
            this.bt_pacientes_fechar.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pacientes_fechar.Location = new System.Drawing.Point(502, 9);
            this.bt_pacientes_fechar.Name = "bt_pacientes_fechar";
            this.bt_pacientes_fechar.Size = new System.Drawing.Size(16, 16);
            this.bt_pacientes_fechar.TabIndex = 36;
            this.bt_pacientes_fechar.Text = "X";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 46);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(190, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 46);
            this.label7.TabIndex = 38;
            this.label7.Text = "Pacientes";
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(530, 386);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_pacientes_fechar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_pacientes_excluir);
            this.Controls.Add(this.tb_pacientes_telefone);
            this.Controls.Add(this.tb_pacientes_cep);
            this.Controls.Add(this.tb_pacientes_nascimento);
            this.Controls.Add(this.tb_pacientes_numero);
            this.Controls.Add(this.tb_pacientes_endereco);
            this.Controls.Add(this.tb_pacientes_email);
            this.Controls.Add(this.tb_pacientes_nome);
            this.Controls.Add(this.bt_pacientes_cadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pacientes_email;
        private System.Windows.Forms.TextBox tb_pacientes_nome;
        private System.Windows.Forms.Button bt_pacientes_cadastrar;
        private System.Windows.Forms.TextBox tb_pacientes_endereco;
        private System.Windows.Forms.TextBox tb_pacientes_numero;
        private System.Windows.Forms.MaskedTextBox tb_pacientes_nascimento;
        private System.Windows.Forms.MaskedTextBox tb_pacientes_cep;
        private System.Windows.Forms.MaskedTextBox tb_pacientes_telefone;
        private System.Windows.Forms.Button bt_pacientes_excluir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bt_pacientes_fechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}