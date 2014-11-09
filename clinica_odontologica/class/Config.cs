/*
 * MySQL CRUD created by Jonatas
 * Fork me on GitHub github.com/jonatassales
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

        public int findCount(string strQuery)
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

            int numRows = int.Parse(data.Rows[0].ItemArray[0].ToString());
            return numRows;
        }

        public void update(string strQuery)
        {
            this.save(strQuery);
        }

        public void delete(string strQuery)
        {
            this.save(strQuery);
        }
    }
}
