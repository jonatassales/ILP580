/*
 * MySQL CRUD created by Jonatas
 * copyright 2014
 */

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace clinica_odontologica
{
    class Config
    {
        private MySqlConnection connection;
        private string path = "SERVER=localhost;PORT=3306;DATABASE=clinica_odontologica;UID=root;PASSWORD=;";


        public void save(string strQuery) {
            connection = new MySqlConnection(path);
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = strQuery;

            try
            {
                connection.Open();
                query.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: "+e.Message,"ERRO");
            }
        }

        public DataTable find(string strQuery)
        {
            connection = new MySqlConnection(path);
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = strQuery;

            DataTable data = new DataTable();
            try
            {
                connection.Open();
                MySqlDataReader reader = query.ExecuteReader();
                data.Load(reader);
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message, "ERRO");
            }

            return data;
        }

        public void update(string strQuery)
        { 
        
        }

        public void delete(string strQuery)
        { 
        
        }
    }
}
