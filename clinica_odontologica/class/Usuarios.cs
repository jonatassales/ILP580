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
    class Usuarios : Config
    {
        public void setUsuarios(string nome, string email, int tipo, string username, string password)
        {
            string query = "";
            query = "INSERT INTO usuarios";
            query += "(nome, email, tipo, username, password)";
            query += "VALUES";
            query += "('" + nome + "', '" + email + "', " + tipo + ", '" + username + "', '" + password.GetHashCode().ToString() + "')";
            this.save(query);
        }

        public void updateUsuarios(string filtro, string[] chave, string[] valor)
        {
            string set_campos = "";
            for(int i = 0; i < chave.Length; i++)
            {
                if(i == 0)
                {
                    set_campos = ""+chave[i]+" = '"+valor[i]+"'";
                }
                else
                {
                    set_campos += ","+chave[i]+" = '"+valor[i]+"'";
                }
            }
            this.update("UPDATE usuarios SET " + set_campos+" "+filtro);
        }

        public void deleteUsuarios(int id)
        {
            this.delete("DELETE FROM usuarios WHERE id = " + id);
        }

        public DataTable getUsuarios(string campos, string filtro)
        {
            return this.find("SELECT " + ((campos == "") ? "*" : campos) + " FROM usuarios " + filtro);
        }

        public DataTable getUsuarioById(int id)
        {
            return this.find("SELECT * FROM usuarios WHERE id = " + id);
        }

        public bool checkLogin(string username, string password)
        {
            int rs;
            rs = this.findCount("SELECT count(id) FROM usuarios WHERE username = '" + username + "' AND password = '" + password+"'");

            if (rs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
