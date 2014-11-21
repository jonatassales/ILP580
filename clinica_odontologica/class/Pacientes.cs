using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace clinica_odontologica
{
    class Pacientes : Config
    {
        public void setPacientes(string nome, string nascimento, string cpf, int cidade_id, int estado_id, string bairro, string endereco, int numero, string cep, string telefone, string email, string imagem) 
        {
            string query=""; 
            query  = "INSERT INTO clientes";
            query += "(nome, nascimento, cpf, cidade_id, estado_id, bairro, endereco, numero, cep, telefone, email, imagem)";
            query += "VALUES";
            query += "('"+nome+"', '"+nascimento+"', '"+cpf+"', "+cidade_id+", "+estado_id+", '"+bairro+"', '"+endereco+"', "+numero+", '"+cep+"', '"+telefone+"', '"+email+"', 'img')";
            this.save(query);
        }

        public void updatePacientes(string filtro, string[] chave, string[] valor)
        {
            string set_campos = "";
            for (int i = 0; i < chave.Length; i++)
            {
                if (i == 0)
                {
                    set_campos = "" + chave[i] + " = '" + valor[i] + "'";
                }
                else
                {
                    set_campos += "," + chave[i] + " = '" + valor[i] + "'";
                }
            }
            this.update("UPDATE clientes SET " + set_campos + " " + filtro);
        }

        public void deletePacientes(int id)
        {
            this.delete("DELETE FROM clientes WHERE id = "+id);
        }

        public DataTable getPacientes(string campos, string filtro)
        {

            return this.find("SELECT " + ((campos == "") ? "*" : campos) + " FROM clientes " + filtro);
        }

        public int getQuantPacientes()
        {

            return this.findCount("SELECT count(id) FROM clientes");
        }

        public DataTable getPacietesById(string campos, int id)
        {
            return this.find("SELECT "+ ((campos == "") ? "*" : campos) +" FROM clientes WHERE id = "+id);
        }

        public DataTable getPacientesBySearch(string campos, string busca) 
        {
            return this.find("SELECT " + ((campos == "") ? "*" : campos) + " FROM clientes WHERE nome like '%" + busca + "%'");
        }

        public void saveImg(string img_path, int id) 
        {
            this.update("UPDATE clientes SET imagem = '"+img_path+"' WHERE id = "+id); 
        }

        public DataTable getImgById(int id)
        {
            return this.find("SELECT imagem FROM clientes WHERE id = "+id);
        }
    }
}
