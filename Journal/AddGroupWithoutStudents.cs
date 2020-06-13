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
using System.IO;

namespace Journal1
{
    public partial class AddGroupWithoutStudents : Form
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
        string facultySelected;
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
        public AddGroupWithoutStudents()
        {
            InitializeComponent();
        }

        private void AddGroupWithoutStudents_Load(object sender, EventArgs e)
        {
            FindDataBase();
            LoadFaculties();
            try
            {
                facultiesComboBox.SelectedIndex = -1;
            }
            catch { }
        }
       
        private void facultiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                facultySelected = facultiesComboBox.SelectedValue.ToString();
            }
            catch { }

        }
        
        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                int group = Convert.ToInt32(textBoxGroup.Text);
                string sqlExpression = "INSERT INTO Groups (Факультет, Группа) VALUES (@faculty, @group)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlParameter facultyParam = new SqlParameter("@faculty", new Guid(facultySelected));
                    command.Parameters.Add(facultyParam);
                    SqlParameter groupParam = new SqlParameter("@group", group);
                    command.Parameters.Add(groupParam);
                    int number = command.ExecuteNonQuery();
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Выберите факультет и введите номер группы");
            }
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
