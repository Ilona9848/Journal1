using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        string connectionString;

        private void DeleteSubject_Load(object sender, EventArgs e)
        {
            FindDataBase();
            LoadFaculties();
            try
            {
                facultiesComboBox.SelectedIndex = -1;
            }
            catch { }
        }

        public void FindDataBase()
        {
            string ds = "";
            string ic = "";
            string id = "";
            string pas = "";
            string ins = "";
            using (StreamReader sr = new StreamReader("config.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] s = sr.ReadLine().Split('=');
                    if (s[0] == "Data Source")
                        ds = s[1];
                    if (s[0] == "Initial Catalog")
                        ic = s[1];
                    if (s[0] == "Integrated Security")
                        ins = s[1];
                    if (s[0] == "User ID")
                        id = s[1];
                    if (s[0] == "Password")
                        pas = s[1];
                }
            }
            if (id != "")
                connectionString = String.Format(@"Data Source={0};Initial Catalog={1};User Id = {2}; Password = {3}", ds, ic, id, pas);
            else
                connectionString = String.Format(@"Data Source={0};Initial Catalog={1};Integrated Security={2}", ds, ic, ins);
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
