using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Test_Data
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void myFormSubmit(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\MSSQLSERVER01;Initial Catalog=mystore;Integrated Security=True;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO clients (Name, Email) VALUES (@Name, @Email)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@Email", email.Text);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            lblMessage.Text = "Data saved successfully!";
        }

        protected void loadDataButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.\\MSSQLSERVER01;Initial Catalog=mystore;Integrated Security=True;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM clients";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        GridView1.DataSource = dataTable;
                        GridView1.DataBind();


                    }
                }
            }
        }

    }
}