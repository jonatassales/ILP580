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
    public partial class Home : Form
    {
        public int usuario_id;
        public Home()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.ShowDialog();
            lbl_bem_vindo.Text = "Bem-vindo Dr. " + Program.usuario;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario form = new FormUsuario();
            form.Show();
        }
    }
}
