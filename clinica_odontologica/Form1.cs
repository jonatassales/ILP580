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

        //GLOBAIS
        public string campos;
        public string filtro;

        //BOOTSTRAP
        Pacientes objPacientes = new Pacientes();

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

            //PEGANDO DADOS DE APRESENTAÇÃO

            //PACIENTES
            int numPacientes = objPacientes.getQuantPacientes();
            lbl_est_pacientes.Text = numPacientes + " Pacientes cadastrados até o momento.";

            //PRONTUARIOS

            //TRATAMENTOS

            //PARCELAS

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

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPacientes form = new FormPacientes();
            form.Show();
        }
    }
}
