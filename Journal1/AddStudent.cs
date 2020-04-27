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
    public partial class AddStudent : Form
    {
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
        string facultySelected;
        string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
        public AddStudent()
        {
            InitializeComponent();
        }

        private void facultiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDataDataSet);

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
            try
            {
                facultiesComboBox.SelectedIndex = -1;
                comboBoxGroups.SelectedIndex = -1;
            }
            catch
            { }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                string surname = textBoxSurname.Text;
                string name = textBoxName.Text;
                string lastname = textBoxLastName.Text;
                string group = comboBoxGroups.SelectedValue.ToString();
                string sqlExpression = "INSERT INTO Students (Факультет, Группа, Фамилия, Имя, Отчество) VALUES (@faculty, @group, @surname, @name, @lastname)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    SqlParameter facultyParam = new SqlParameter("@faculty", new Guid(facultySelected));
                    command.Parameters.Add(facultyParam);
                    SqlParameter groupParam = new SqlParameter("@group", group);
                    command.Parameters.Add(groupParam);
                    SqlParameter surnameParam = new SqlParameter("@surname", surname);
                    command.Parameters.Add(surnameParam);
                    SqlParameter nameParam = new SqlParameter("@name", name);
                    command.Parameters.Add(nameParam);
                    SqlParameter lastnameParam = new SqlParameter("@lastname", lastname);
                    command.Parameters.Add(lastnameParam);
                    int number = command.ExecuteNonQuery();
                }
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void facultiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ArrayList groups = new ArrayList();
                facultySelected = facultiesComboBox.SelectedValue.ToString();
                string sqlExpression = "SELECT * FROM Groups";
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
    }
}
