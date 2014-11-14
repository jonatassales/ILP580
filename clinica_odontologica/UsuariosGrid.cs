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
    public partial class UsuariosGrid : Form
    {
        Usuarios objUsuarios = new Usuarios();
        public string campos = "";
        public string filtro = "";
        public UsuariosGrid()
        {
            InitializeComponent();
        }

        private void UsuariosGrid_Load(object sender, EventArgs e)
        {
            int id_dentista = int.Parse(Program.usuario_id);
            campos = "nome as 'Nome', email as 'E-mail', tipo as 'Nivel', username as 'Login', created as 'Criado em' ";
            DataTable rs = objUsuarios.getUsuarios(campos, "");
            dgv_pacientes.DataSource = rs;
        }
    }
}
