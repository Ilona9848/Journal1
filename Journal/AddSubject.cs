using System;
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
        string connectionString;
        public AddSubject()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
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
