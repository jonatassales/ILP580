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
        public string campos;
        public string filtro;

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

                    //PEGANDO DADOS DO USUARIO
                    this.campos = "id, nome";
                    this.filtro = "WHERE username = '"+username+"' AND password = '"+password+"'";
                    DataTable rs = objUsuarios.getUsuarios(campos, filtro);
                    Program.usuario = rs.Rows[0].ItemArray[1].ToString();
                    Program.usuario_id = rs.Rows[0].ItemArray[0].ToString();
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
