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
    public partial class ChangeFaculty : Form
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

        public class Groups
        {
            public string Id { get; set; }
            public int Group { get; set; }
            public Groups(object id, object group)
            {
                this.Id = id.ToString();
                this.Group = Convert.ToInt32(group);
            }
        }

        public class Students
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public Students(object id, object surname, object name, object lastname)
            {
                this.Id = id.ToString();
                this.Name = surname.ToString() + " " + name.ToString() + " " + lastname.ToString();
            }
        }

        string facultySelected, groupSelected, studentSelected;
        string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
        List<Faculties> listFaculties = new List<Faculties>();
        List<Groups> listGroups = new List<Groups>();
        public ChangeFaculty()
        {
            InitializeComponent();
        }

        private void ChangeFaculty_Load(object sender, EventArgs e)
        {
            buttonChange.Hide();
            facultiesComboBox1.Hide();
            comboBoxGroups1.Hide();
            LoadFaculties();
            facultiesComboBox.DataSource = listFaculties;
            facultiesComboBox.DisplayMember = "faculty";
            facultiesComboBox.ValueMember = "id";
            try
            {
                
                facultiesComboBox.SelectedIndex = -1;
                facultiesComboBox1.SelectedIndex = -1;
            }
            catch { }
        }

        private void facultiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                facultySelected = facultiesComboBox.SelectedValue.ToString();
                ArrayList groups = new ArrayList();
                string sqlExpression = "SELECT * FROM Groups ORDER BY Группа";
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
                            object group = reader.GetValue(2);
                            if (faculty.ToString() == facultySelected)
                            {
                                groups.Add(new Groups(id, group));
                            }
                        }
                    }
                    comboBoxGroups.DataSource = groups;
                    comboBoxGroups.DisplayMember = "group";
                    comboBoxGroups.ValueMember = "id";
                    reader.Close();
                }
                comboBoxGroups.SelectedIndex = -1;
            }
            catch
            {

            }
        
    

        }
       
        private void comboBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                groupSelected = comboBoxGroups.SelectedValue.ToString();
                List<Students> listStudents = new List<Students>();
                string sqlExpression = "SELECT * FROM Students Order By Фамилия";
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
                            object group = reader.GetValue(2);
                            object surname = reader.GetValue(3);
                            object name = reader.GetValue(4);
                            object lastname = reader.GetValue(5);
                            if (group.ToString() == groupSelected)
                            {
                                listStudents.Add(new Students(id, surname, name, lastname));
                            }
                        }
                    }
                    listBoxStudents.DataSource = listStudents;
                    listBoxStudents.DisplayMember = "name";
                    listBoxStudents.ValueMember = "id";
                    reader.Close();
                }
            }
            catch { }
        }

        private void listBoxStudents_DoubleClick(object sender, EventArgs e)
        {
            buttonChange.Show();
            facultiesComboBox.Hide();
            comboBoxGroups.Hide();
            facultiesComboBox1.Show();
            comboBoxGroups1.Show();
            listBoxStudents.Hide();
            LoadStudent();
            facultiesComboBox1.DataSource = listFaculties;
            facultiesComboBox1.DisplayMember = "faculty";
            facultiesComboBox1.ValueMember = "id";
            facultiesComboBox1.SelectedIndex = -1;
        }

        private void facultiesComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                facultySelected = facultiesComboBox1.SelectedValue.ToString();
                ArrayList groups = new ArrayList();
                string sqlExpression = "SELECT * FROM Groups ORDER BY Группа";
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
                            object group = reader.GetValue(2);
                            if (faculty.ToString() == facultySelected)
                            {
                                groups.Add(new Groups(id, group));
                            }
                        }
                    }
                    comboBoxGroups1.DataSource = groups;
                    comboBoxGroups1.DisplayMember = "group";
                    comboBoxGroups1.ValueMember = "id";
                    reader.Close();
                }
                comboBoxGroups1.SelectedIndex = -1;
            }
            catch
            {

            }
        
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            try 
            {
                facultySelected = facultiesComboBox1.SelectedValue.ToString();
                string group = comboBoxGroups1.SelectedValue.ToString();
                string id = listBoxStudents.SelectedValue.ToString();
                string sqlExpression = "UPDATE Students SET Факультет=@faculty, Группа=@group WHERE Id=@id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlParameter facultyParam = new SqlParameter("@faculty", new Guid(facultySelected));
                    command.Parameters.Add(facultyParam);
                    SqlParameter groupParam = new SqlParameter("@group", new Guid(group));
                    command.Parameters.Add(groupParam);
                    SqlParameter idParam = new SqlParameter("@id", id);
                    command.Parameters.Add(idParam);
                    command.ExecuteNonQuery();
                }
            this.Close();
            }
            catch { }
        }

        public void LoadGroups()
        {
            try
            {
                string sqlExpression = "SELECT * FROM Groups ORDER BY Группа";
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
                            object group = reader.GetValue(2);
                            if (faculty.ToString() == facultySelected)
                            {
                                listGroups.Add(new Groups(id, group));
                            }
                        }
                    }
                    reader.Close();
                    comboBoxGroups1.DataSource = listGroups;
                    comboBoxGroups1.DisplayMember = "group";
                    comboBoxGroups1.ValueMember = "id";
                }
                comboBoxGroups.SelectedIndex = -1;
            }
            catch
            {

            }
        }

        

        public void LoadStudent()
        {
            try
            {
                string s = "";
                studentSelected = listBoxStudents.SelectedValue.ToString();
                string sqlexpression1 = "SELECT * FROM Students ORDER BY Фамилия";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlexpression1, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object id = reader.GetValue(0);
                            object group = reader.GetValue(2);
                            object surname = reader.GetValue(3);
                            object name = reader.GetValue(4);
                            object lastname = reader.GetValue(5);
                            if (id.ToString() == studentSelected)
                            {
                                s = surname.ToString() + " " + name.ToString() + " " + lastname.ToString();
                            }
                        }
                    }
                    reader.Close();
                }
                labelInstr.Text = "Перевести " + s+ " на";
                facultiesComboBox1.Show();
                comboBoxGroups1.Show();
                listBoxStudents.Hide();
            }
            catch
            { }

        }
        
        public void LoadFaculties()
        {
            string sqlExpression = "SELECT * FROM Faculties ORDER BY Факультет";
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
                
                reader.Close();
            }

        }
    }
}
