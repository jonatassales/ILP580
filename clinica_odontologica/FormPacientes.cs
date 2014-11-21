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
        //OBJETOS
        Pacientes objPacientes = new Pacientes();

        //GLOBALS
        public int id_usuario;
        public string campos;
        public string filtro;
        public string[] chave;
        public string[] valor;
        public string pacientes_file_path;

        public FormPacientes(int id = 0)
        {
            if (id != 0)
            {
                this.id_usuario = id;
            }
            InitializeComponent();
        }

        private void bt_pacientes_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.id_usuario > 0)
            {
                //EDIT
                this.valor = new string[7];
                this.chave = new string[7];
                this.filtro = "WHERE id = " + this.id_usuario;
                this.chave[0] = "nome";
                this.valor[0] = tb_pacientes_nome.Text;
                this.chave[1] = "email";
                this.valor[1] = tb_pacientes_email.Text;
                this.chave[2] = "nascimento";
                this.valor[2] = tb_pacientes_nascimento.Text;
                this.chave[3] = "endereco";
                this.valor[3] = tb_pacientes_endereco.Text;
                this.chave[4] = "numero";
                this.valor[4] = tb_pacientes_numero.Text;
                this.chave[5] = "cep";
                this.valor[5] = tb_pacientes_cep.Text;
                this.chave[6] = "telefone";
                this.valor[6] = tb_pacientes_telefone.Text;
               

                this.objPacientes.updatePacientes(this.filtro, this.chave, this.valor);
                MessageBox.Show("Dados atualizados com sucesso!");
                this.Close();
            }
            else
            {
                //SET
                this.objPacientes.setPacientes(tb_pacientes_nome.Text, tb_pacientes_nascimento.Text, "", 1, 1, "", tb_pacientes_endereco.Text, int.Parse(tb_pacientes_numero.Text), tb_pacientes_cep.Text, tb_pacientes_telefone.Text, tb_pacientes_email.Text, "");
                MessageBox.Show("Dados salvos com sucesso!");
                this.Close();
            }
        }

        private void bt_pacientes_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPacientes_Load(object sender, EventArgs e)
        {
            if (this.id_usuario > 0)
            {
                bt_pacientes_excluir.Visible = true;
                this.preenchePaciente(this.id_usuario);
            }
        }

        private void preenchePaciente(int id) 
        {
            this.campos = "nome,email,nascimento,endereco,numero,cep,telefone";
            DataTable rs = this.objPacientes.getPacietesById(this.campos,id);
            tb_pacientes_nome.Text = rs.Rows[0].ItemArray[0].ToString();
            tb_pacientes_email.Text = rs.Rows[0].ItemArray[1].ToString();
            tb_pacientes_nascimento.Text = rs.Rows[0].ItemArray[2].ToString();
            tb_pacientes_endereco.Text = rs.Rows[0].ItemArray[3].ToString();
            tb_pacientes_numero.Text = rs.Rows[0].ItemArray[4].ToString();
            tb_pacientes_cep.Text = rs.Rows[0].ItemArray[5].ToString();
            tb_pacientes_telefone.Text = rs.Rows[0].ItemArray[6].ToString();

            bt_pacientes_cadastrar.Text = "Editar";
        }

        private void bt_pacientes_excluir_Click(object sender, EventArgs e)
        {
            this.objPacientes.deletePacientes(this.id_usuario);
            MessageBox.Show("Registro excluido com sucesso!");
            this.Close();
        }

        private void bt_pacientes_upload_Click(object sender, EventArgs e)
        {
            ofd_pacientes.ShowDialog();
        }

        private void ofd_pacientes_FileOk(object sender, CancelEventArgs e)
        {
            this.pacientes_file_path = ofd_pacientes.FileName;
            string file_name = "file.jpg";
            try
            {
                System.IO.File.Copy(this.pacientes_file_path, Program.img_path + ""+file_name);
                this.objPacientes.saveImg(Program.img_path + "" + file_name, this.id_usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            
        }

    }
}
