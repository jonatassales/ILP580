using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_odontologica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tb_login_Click(object sender, EventArgs e)
        {
            tb_login.Text = "";
        }

        private void tb_senha_Click(object sender, EventArgs e)
        {
            tb_senha.Text = "";
            tb_senha.PasswordChar = '*';
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login() {
            string username, password;
            username = tb_login.Text;
            password = tb_senha.Text;

            if (username != "" && password != "")
            {
                Usuarios objUsuarios = new Usuarios();
                bool result = objUsuarios.checkLogin(username, password);

                if (result)
                {
                    lbl_login_result.ForeColor = Color.Green;
                    lbl_login_result.Text = "Logado com sucesso!";
                    Program.home.Visible = true;
                    Program.home.Enabled = true;
                    this.Close();
                }
                else 
                {
                    lbl_login_result.ForeColor = Color.Red;
                    lbl_login_result.Text = "Login e(ou) senha incorreo(s).";
                }
            }
            else
            {
                lbl_login_result.ForeColor = Color.Red;
                lbl_login_result.Text = "Você deve preencher todos os campos.";
            }
        }

        private void lbl_logar_Click(object sender, EventArgs e)
        {
            this.login();
        }
    }
}
