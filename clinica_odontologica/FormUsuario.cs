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
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void bt_usuario_cadastrar_Click(object sender, EventArgs e)
        {
            Usuarios objUsuario = new Usuarios();
            objUsuario.setUsuarios(tb_usuario_nome.Text,tb_usuario_email.Text,2,tb_usuario_username.Text,tb_usuario_password.Text);
        }
    }
}
