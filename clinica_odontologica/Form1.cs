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
        Usuarios objUsuarios = new Usuarios();

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

            //HOME------------------------------------------------------------------------------------
            //PACIENTES
            int numPacientes = objPacientes.getQuantPacientes();

            if (numPacientes > 0)
            {
                lbl_est_pacientes.Text = numPacientes + " Pacientes cadastrados até o momento.";
            }
            else
            {
                lbl_est_pacientes.Text = "Nenhum Paciente cadastrado até o momento.";
            }
            

            //PRONTUARIOS
            int numProntuarios = 0;
            if (numProntuarios > 0)
            {
                lbl_est_prontuarios.Text = numProntuarios + " Prontuarios cadastrados até o momento.";
            }
            else
            {
                lbl_est_prontuarios.Text = "Nenhum prontuario cadastrado até o momento.";
            }

            //TRATAMENTOS
            int numTratamentos = 0;
            if (numTratamentos > 0)
            {
                lbl_est_tratamentos.Text = numTratamentos + " Tratamentos cadastrados até o momento.";
            }
            else
            {
                lbl_est_tratamentos.Text = "Nenhum tratamento cadastrado até o momento.";
            }

            //PARCELAS
            int numParcelas = 0;
            if (numProntuarios > 0)
            {
                lbl_est_parcelas.Text = numParcelas + " Parcelas cadastrados até o momento.";
            }
            else
            {
                lbl_est_parcelas.Text = "Nenhuma parcela em atraso.";
            }
            //----------------------------------------------------------------------------------------

            //USUARIOS--------------------------------------------------------------------------------
            int id_dentista = int.Parse(Program.usuario_id);
            campos = "nome as 'Nome', email as 'E-mail', tipo as 'Nivel', username as 'Login', created as 'Criado em' ";
            DataTable rs = objUsuarios.getUsuarios(campos, "");
            dgv_usuarios.DataSource = rs;

            int numUsuarios = objUsuarios.getQuantUsuarios();
            lbl_usuarios_total.Text = "Total " + numUsuarios;

            //----------------------------------------------------------------------------------------

            //PACIENTES-------------------------------------------------------------------------------

            //----------------------------------------------------------------------------------------

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

        private void bt_grid_pacientes_Click(object sender, EventArgs e)
        {
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\wamp\www\Fatec\odontology-system\clinica_odontologica\about\documento.pdf");
        }

        private void bt_usuarios_add_Click(object sender, EventArgs e)
        {
            FormUsuario form = new FormUsuario();
            form.Show();
        }
    }
}
