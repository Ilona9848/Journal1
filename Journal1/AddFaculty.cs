using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal1
{
    public partial class AddFaculty : Form
    {
        public AddFaculty()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-DNNNDF6K\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
            string f = textBoxFaculty.Text;
            if (f == "")
            {
                MessageBox.Show("Введите название факультета");
            }
            else
            {
                string sqlExpression = String.Format("INSERT INTO Faculties (Факультет) VALUES ('{0}')", f);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }
                this.Close();
            }
        }

        private void labelInstruction_Click(object sender, EventArgs e)
        {

        }

        private void labelExample_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFaculty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
