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
    public partial class FormUsuario : Form
    {

        //OBJETOS
        Usuarios objUsuario = new Usuarios();

        //GLOBALS
        public int id_usuario;
        public string campos;
        public string filtro;
        public string[] chave;
        public string[] valor;


        public FormUsuario(int id = 0)
        {
            if (id != 0)
            {
                this.id_usuario = id;
            }
            InitializeComponent();
        }

        private void bt_usuario_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.id_usuario > 0)
            {
                //EDIT
                this.valor = new string[4];
                this.chave = new string[4];
                this.filtro = "WHERE id = " + this.id_usuario;
                this.chave[0] = "nome";
                this.valor[0] = tb_usuario_nome.Text;
                this.chave[1] = "email";
                this.valor[1] = tb_usuario_email.Text;
                this.chave[2] = "username";
                this.valor[2] = tb_usuario_username.Text;
                this.chave[3] = "password";
                this.valor[3] = tb_usuario_password.GetHashCode().ToString();

                this.objUsuario.updateUsuarios(this.filtro, this.chave, this.valor);

                this.refreshUsuarios();
                MessageBox.Show("Dados atualizados com sucesso!");
            }
            else
            { 
                //SET
                this.objUsuario.setUsuarios(tb_usuario_nome.Text, tb_usuario_email.Text, 2, tb_usuario_username.Text, tb_usuario_password.Text);
                this.refreshUsuarios();
                MessageBox.Show("Dados salvos com sucesso!");
            }
        }

        private void refreshUsuarios()
        {
            campos = "id as 'Indice', nome as 'Nome', email as 'E-mail', tipo as 'Nivel', username as 'Login', created as 'Criado em' ";
            DataTable rsUsuarios = this.objUsuario.getUsuarios(campos, "");
            Home.dgv_usuarios.DataSource = rsUsuarios;

            int numUsuarios = objUsuario.getQuantUsuarios();
            Home.lbl_usuarios_total.Text = "Total " + numUsuarios;
        }
        private void FormUsuario_Load(object sender, EventArgs e)
        {
            if (id_usuario > 0)
            {
                this.preencheUsuario(id_usuario);
            }
        }

        private void preencheUsuario(int id)
        { 
            DataTable rs = this.objUsuario.getUsuarioById(id);
            tb_usuario_nome.Text = rs.Rows[0].ItemArray[0].ToString();
            tb_usuario_email.Text = rs.Rows[0].ItemArray[1].ToString();
            tb_usuario_username.Text = rs.Rows[0].ItemArray[2].ToString();
            bt_usuario_cadastrar.Text = "Editar";
        }
    }
}
