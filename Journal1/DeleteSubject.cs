using System;
using System.Collections;
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
    public partial class DeleteSubject : Form
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
        public class Subjects
        {
            public string Id { get; set; }
            public string Subject { get; set; }
            public Subjects(object id, object subject)
            {
                this.Id = id.ToString();
                this.Subject = subject.ToString();
            }
        }
        public DeleteSubject()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
        private void DeleteSubject_Load(object sender, EventArgs e)
        {
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

        private void facultiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ArrayList subjects = new ArrayList();
                string facultySelected = facultiesComboBox.SelectedValue.ToString();
                string sqlExpression = "SELECT * FROM Subjects ORDER BY Предмет";
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
                            object subject = reader.GetValue(1);
                            object faculty = reader.GetValue(2);
                            if (faculty.ToString() == facultySelected)
                            {
                                subjects.Add(new Subjects(id, subject));
                            }
                        }
                    }
                    listBoxSubjects.DataSource = subjects;
                    listBoxSubjects.DisplayMember = "subject";
                    listBoxSubjects.ValueMember = "id";
                    reader.Close();
                }
            }
            catch { }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Удаление может привести к потере данных. Вы уверены, что хотите продолжить?", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Guid id = new Guid(listBoxSubjects.SelectedValue.ToString());
                    string sqlExpression = "DELETE FROM Subjects WHERE Id=@id";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlParameter idParam = new SqlParameter("@id", id);
                        command.Parameters.Add(idParam);
                        command.ExecuteNonQuery();
                    }
                    this.Close();
                }
            }
            catch { }
        }
    }
}
