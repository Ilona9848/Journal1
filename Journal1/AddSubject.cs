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
    public partial class AddSubject : Form
    {
        public class Faculties
        {
            public string Id { get; set; }
            public string Faculty { get; set; }
            public Faculties(object id, object faculty)
            {
                this.Id = id.ToString();
                this.Faculty = faculty.ToString();
            }
        }
        string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
        public AddSubject()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
                string subject = textBoxSubject.Text;
                Guid id = new Guid(facultiesComboBox.SelectedValue.ToString());
                if (subject == "")
                {
                    MessageBox.Show("Введите название предмета и выберите факультет");
                }
                else
                {
                    string sqlExpression = String.Format("INSERT INTO Subjects (Предмет, Факультет) VALUES ('{0}','{1}')", subject,id);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        int number = command.ExecuteNonQuery();
                    }
                    this.Close();
                }
            }
            catch { }
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            LoadFaculties();
            try
            {
                facultiesComboBox.SelectedIndex = -1;
            }
            catch { }
        }

        private void buttonAddFaculty_Click(object sender, EventArgs e)
        {
            AddFaculty addFaculty = new AddFaculty();
            addFaculty.ShowDialog();
            addFaculty.Close();
            LoadFaculties();
            try
            {
                facultiesComboBox.SelectedIndex = -1;
            }
            catch { }
        }
        public void LoadFaculties()
        {
            string sqlExpression = "SELECT * FROM Faculties ORDER BY Факультет";
            List<Faculties> listFaculties = new List<Faculties>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object faculty = reader.GetValue(1);
                        listFaculties.Add(new Faculties(id, faculty));
                    }
                }
                facultiesComboBox.DataSource = listFaculties;
                facultiesComboBox.DisplayMember = "faculty";
                facultiesComboBox.ValueMember = "id";
                reader.Close();
            }

        }
    }
}
