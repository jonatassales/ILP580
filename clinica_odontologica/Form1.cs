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
        public string busca;

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
            //RENDERIZANDO A HOME
            pnl_home.Visible = true;
            pnl_home.Width = 900;
            pnl_home.Height = 290;
            pnl_home.Left = 0;
            pnl_home.Top = 75;

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

            int id_dentista = int.Parse(Program.usuario_id);

            //USUARIOS-GRID---------------------------------------------------------------------------
            campos = "id as 'Indice', nome as 'Nome', email as 'E-mail', tipo as 'Nivel', username as 'Login', created as 'Criado em' ";
            DataTable rsUsuarios = objUsuarios.getUsuarios(campos, "");
            dgv_usuario.DataSource = rsUsuarios;

            int numUsuarios = objUsuarios.getQuantUsuarios();
            lbl_usuario_total.Text = "Total " + numUsuarios;

            //----------------------------------------------------------------------------------------

            //PACIENTES-GRID--------------------------------------------------------------------------
            campos = "nome as 'Nome', email as 'E-mail', nascimento as 'Data de Nascimento', telefone as 'Telefone'";
            DataTable rsPacientes = objPacientes.getPacientes(campos, "");
            dgv_pacientes.DataSource = rsPacientes;

            lbl_pacientes_total.Text = "Total " + numPacientes;
            //----------------------------------------------------------------------------------------
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_pacientes.Visible = false;
            pnl_home.Visible = false;
            pnl_usuarios.Visible = true;
            pnl_usuarios.Width = 900;
            pnl_usuarios.Height = 290;
            pnl_usuarios.Left = 0;
            pnl_usuarios.Top = 75;
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnl_usuarios.Visible = false;
            pnl_home.Visible = false;
            pnl_pacientes.Visible = true;
            pnl_pacientes.Width = 900;
            pnl_pacientes.Height = 290;
            pnl_pacientes.Left = 0;
            pnl_pacientes.Top = 75;
        }

        private void bt_grid_pacientes_Click(object sender, EventArgs e)
        {
            pnl_usuarios.Visible = false;
            pnl_home.Visible = false;
            pnl_pacientes.Visible = true;
            pnl_pacientes.Width = 900;
            pnl_pacientes.Height = 290;
            pnl_pacientes.Left = 0;
            pnl_pacientes.Top = 75;
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_pacientes.Visible = false;
            pnl_usuarios.Visible = false;
            pnl_home.Visible = true;
            pnl_home.Width = 900;
            pnl_home.Height = 290;
            pnl_home.Left = 0;
            pnl_home.Top = 75;
        }

        private void bt_pacientes_add_Click(object sender, EventArgs e)
        {
            FormPacientes form = new FormPacientes();
            form.Show();
        }

        private void tb_pacientes_busca_KeyUp(object sender, KeyEventArgs e)
        {
            this.busca = tb_pacientes_busca.Text;
            this.campos = "nome as 'Nome', email as 'E-mail', nascimento as 'Data de Nascimento', telefone as 'Telefone'";
            DataTable rsBuscaPacientes = objPacientes.getPacientesBySearch(campos, busca);
            dgv_pacientes.DataSource = rsBuscaPacientes;
        }

        private void dgv_usuario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(dgv_usuario.CurrentRow.Cells["indice"].Value.ToString());
            FormUsuario form = new FormUsuario(id);
            form.Show();
        }

        private void tb_usuario_busca_KeyUp(object sender, KeyEventArgs e)
        {
            this.busca = tb_usuario_busca.Text;
            this.campos = "id as 'Indice', nome as 'Nome', email as 'E-mail', tipo as 'Nivel', username as 'Login', created as 'Criado em' ";
            DataTable rsBuscaUsuarios = objUsuarios.getUsuariosBySearch(campos, busca);
            dgv_usuario.DataSource = rsBuscaUsuarios;
        }
    }
}
