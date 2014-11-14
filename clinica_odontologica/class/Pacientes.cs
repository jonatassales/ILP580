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
            query += "('"+nome+"', '"+nascimento+"', '"+cpf+"', "+cidade_id+", "+estado_id+", '"+bairro+"', '"+endereco+"', "+numero+", '"+cep+"', '"+telefone+"', '"+email+"', '"+imagem+"')";
            this.save(query);
        }

        public void updatePacientes(int id) { 
            
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

        public DataTable getPacietesById(int id)
        {
            return this.find("SELECT * FROM clientes WHERE id = "+id);
        }
    }
}
