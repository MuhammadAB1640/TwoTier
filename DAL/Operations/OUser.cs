using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entities;

namespace DAL.Operations
{
    public class OUser
    {
        public void Save(EUser Username, EUser Password)
        {
            string username = Username.Text;
            string password = Password.Text;
            string command = $"Insert into Users values('{username}', '{password}')";
            SqlCommand sqlCommand = new SqlCommand(command, connection);

            connection.Close();
        }

        public void Delete(EUser Username)
        {
            string username = Username.Text;
            string command = $"Delete From Users Where Username='{username}'";
            SqlCommand sqlCommand = new SqlCommand(command, connection);

            connection.Close();
        }

        public void Read()
        {
            string command = "Select * from Users";

            SqlCommand sqlCommand = new SqlCommand(command, connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
