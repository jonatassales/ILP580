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
    public partial class FormPacientes : Form
    {
        Pacientes objPacientes = new Pacientes();
        public FormPacientes()
        {
            InitializeComponent();
        }

        private void bt_pacientes_cadastrar_Click(object sender, EventArgs e)
        {
            this.objPacientes.setPacientes(tb_pacientes_nome.Text, tb_pacientes_nascimento.Text, "", 1, 1, "", tb_pacientes_endereco.Text, int.Parse(tb_pacientes_numero.Text), tb_pacientes_cep.Text, tb_pacientes_telefone.Text, tb_pacientes_email.Text, "");
        }
    }
}
