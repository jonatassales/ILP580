﻿using System;
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
            query += "('" + nome + "', '" + email + "', " + tipo + ", '" + username + "', '" + password + "')";
            this.save(query);
        }

        public void updateUsuarios(int id)
        {

        }

        public void deleteUsuarios(int id)
        {
            this.delete("DELETE FROM usuarios WHERE id = " + id);
        }

        public DataTable getUsuarios()
        {
            return this.find("SELECT * FROM usuarios");
        }

        public DataTable getUsuariosById(int id)
        {
            return this.find("SELECT * FROM usuarios WHERE id = " + id);
        }
    }
}