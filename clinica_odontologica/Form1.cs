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

        public Home()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            Pacientes objPaciente = new Pacientes();

            objPaciente.setPacientes("nome", "nascimento", "cpf", 1, 1, "bairro", "endereco", 1, "cep", "telefone", "email", "imagem");

            //DataTable data;
            //data = conf.find("SELECT * FROM teste");
            //MessageBox.Show(data.Rows[0].ItemArray[0].ToString());
           // conf.save("INSERT INTO teste (nome) VALUES('EDUARDO')");
        }
    }
}
