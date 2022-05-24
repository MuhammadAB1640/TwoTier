using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoTier
{
    public partial class UsersForm : Form
    {
        string connectionString = "Server=localhost; database=TwoTier; Integrated Security=True";
        SqlConnection connection;
        public UsersForm()
        {
            InitializeComponent();

            connection = new SqlConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string command = "Select * from Users";

            SqlCommand sqlCommand = new SqlCommand(command, connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            string username = Username.Text;
            string password = Password.Text;
            string command = $"Insert into Users values('{username}', '{password}')";
            SqlCommand sqlCommand = new SqlCommand(command, connection);

            connection.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string command = $"Delete From Users Where Username='{username}'";
            SqlCommand sqlCommand = new SqlCommand(command, connection);

            connection.Close();
        }

        private void ReadButton_Click(object sender, EventArgs e)
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