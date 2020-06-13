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
    public partial class AddSchedule : Form
    {
        string facultySelected;
        string groupSelected;
        int weekSelected;
        int weekDaySelected;
        string connectionString;
        bool exist = true;

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

        public AddSchedule()
        {
            InitializeComponent();
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

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            FindDataBase();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.TypeOfClass". При необходимости она может быть перемещена или удалена.
            this.typeOfClassTableAdapter.Fill(this.journalDataDataSet.TypeOfClass);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.journalDataDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Weekday". При необходимости она может быть перемещена или удалена.
            this.weekdayTableAdapter.Fill(this.journalDataDataSet.Weekday);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Week". При необходимости она может быть перемещена или удалена.
            this.weekTableAdapter.Fill(this.journalDataDataSet.Week);
            buttonAdd.Hide();
            labelFirst.Hide();
            labelSecond.Hide();
            labelThird.Hide();
            labelFourth.Hide();
            subjectsComboBox1.Hide();
            subjectsComboBox2.Hide();
            subjectsComboBox3.Hide();
            subjectsComboBox4.Hide();
            typeOfClassComboBox1.Hide();
            typeOfClassComboBox2.Hide();
            typeOfClassComboBox3.Hide();
            typeOfClassComboBox4.Hide();
            buttonAddSubject.Hide();
            LoadFaculties();
            labelName.Hide();
            try
            {
                facultiesComboBox.SelectedIndex = -1;
                weekComboBox.SelectedIndex = -1;
                weekdayComboBox.SelectedIndex = -1;
            }
            catch { }
        }

        private void facultiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                facultySelected = facultiesComboBox.SelectedValue.ToString();
                LoadGroups();
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

        public void LoadGroups()
        {
            try
            {
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

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string c1="",c2="",c3="",c4="";
            weekSelected = Convert.ToInt32(weekComboBox.SelectedValue);
            weekDaySelected = Convert.ToInt32(weekdayComboBox.SelectedValue);
            groupSelected = comboBoxGroups.SelectedValue.ToString();
            string sqlExpression = "SELECT * FROM Schedule ORDER BY Предмет";
            bool fl = false;
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
                        object week = reader.GetValue(1);
                        object weekday = reader.GetValue(2);
                        object clas = reader.GetValue(3);
                        object group = reader.GetValue(4);
                        if (Convert.ToInt32(week)==weekSelected&&Convert.ToInt32(weekday)==weekDaySelected&&group.ToString()==groupSelected)
                        {
                            if (!fl)
                            {
                                DialogResult result = MessageBox.Show("Расписание на этот день уже есть. Хотите изменить его? Это приведет к потере данных", "Подтверждение", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    if (clas.ToString() == "1")
                                        c1 = id.ToString();
                                    if (clas.ToString() == "2")
                                        c2 = id.ToString();
                                    if (clas.ToString() == "3")
                                        c3 = id.ToString();
                                    if (clas.ToString() == "4")
                                        c4 = id.ToString();
                                    exist = true;
                                    fl = true;
                                }
                                else
                                {
                                    exist = false;
                                    break;
                                }
                            }
                            else
                            {
                                if (clas.ToString() == "1")
                                    c1 = id.ToString();
                                if (clas.ToString() == "2")
                                    c2 = id.ToString();
                                if (clas.ToString() == "3")
                                    c3 = id.ToString();
                                if (clas.ToString() == "4")
                                    c4 = id.ToString();
                            }
                        }
                    }
                }
                reader.Close();
            }
            if (exist)
            {
                if (c1 != "")
                {
                    Delete(c1);
                }
                if (c2 != "")
                {
                    Delete(c2);
                }
                if (c3 != "")
                {
                    Delete(c3);
                }
                if (c4 != "")
                {
                    Delete(c4);
                }
                Change();
            }
        }

        public void Delete(string idS)
        {
            Guid id = new Guid(idS);
            string sqlExpression = String.Format("DELETE FROM Schedule WHERE Id=@id");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlParameter idParam = new SqlParameter("@id", id);
                command.Parameters.Add(idParam);
                command.ExecuteNonQuery();
            }
        }

        public void Change()
        {
            try
            {
                buttonAddSubject.Show();
                labelFaculty.Hide();
                labelGroup.Hide();
                labelWeek.Hide();
                labelWeekDay.Hide();
                facultiesComboBox.Hide();
                comboBoxGroups.Hide();
                weekComboBox.Hide();
                weekdayComboBox.Hide();
                buttonNext.Hide();
                labelFirst.Show();
                labelSecond.Show();
                labelThird.Show();
                labelFourth.Show();
                subjectsComboBox1.Show();
                subjectsComboBox2.Show();
                subjectsComboBox3.Show();
                subjectsComboBox4.Show();
                typeOfClassComboBox1.Show();
                typeOfClassComboBox1.SelectedIndex = -1;
                typeOfClassComboBox2.Show();
                typeOfClassComboBox2.SelectedIndex = -1;
                typeOfClassComboBox3.Show();
                typeOfClassComboBox3.SelectedIndex = -1;
                typeOfClassComboBox4.Show();
                typeOfClassComboBox4.SelectedIndex = -1;
                buttonAdd.Show();
                buttonAddFaculty.Hide();
                buttonAddGroup.Hide();
                subjectsComboBox1.SelectedIndex = -1;
                subjectsComboBox2.SelectedIndex = -1;
                subjectsComboBox3.SelectedIndex = -1;
                subjectsComboBox4.SelectedIndex = -1;
                Subj();
                
                string sqlexpression1 = "SELECT * FROM Faculties";
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
                            object faculty = reader.GetValue(1);
                            if (id.ToString() == facultySelected)
                            {
                                labelName.Text = faculty.ToString()+" ";
                            }
                        }
                    }
                    reader.Close();
                }
                string sqlexpression = "SELECT * FROM Groups";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlexpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object id = reader.GetValue(0);
                            object group = reader.GetValue(2);
                            if (id.ToString() == groupSelected)
                            {
                                labelName.Text =labelName.Text+ group.ToString()+" ";
                            }
                        }
                    }
                    reader.Close();
                }
                string day = "";
                sqlexpression = "SELECT * FROM Weekday";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlexpression, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object id = reader.GetValue(0);
                            object wd = reader.GetValue(1);
                            if (Convert.ToInt32(id) == weekDaySelected)
                            {
                                day = wd.ToString();
                            }
                        }
                    }
                    reader.Close();
                }
                labelName.Text = labelName.Text + weekSelected+" неделя "+day;
                labelName.Show();
            }
            catch { }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (subjectsComboBox1.SelectedIndex!=-1&&typeOfClassComboBox1.SelectedIndex!=-1)
                {
                    Insert(1, subjectsComboBox1.SelectedValue.ToString(), Convert.ToInt32(typeOfClassComboBox1.SelectedValue));
                }
                if(subjectsComboBox2.SelectedIndex != -1 && typeOfClassComboBox2.SelectedIndex != -1)
                {
                    Insert(2, subjectsComboBox2.SelectedValue.ToString(), Convert.ToInt32(typeOfClassComboBox2.SelectedValue));
                }
                if (subjectsComboBox3.SelectedIndex != -1 && typeOfClassComboBox3.SelectedIndex != -1)
                {
                    Insert(3, subjectsComboBox3.SelectedValue.ToString(), Convert.ToInt32(typeOfClassComboBox3.SelectedValue));
                }
                if (subjectsComboBox4.SelectedIndex != -1 && typeOfClassComboBox4.SelectedIndex != -1)
                {
                    Insert(4, subjectsComboBox4.SelectedValue.ToString(), Convert.ToInt32(typeOfClassComboBox4.SelectedValue));
                }
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Заполните предмет и тип занятия");
            }
        }

        public void Insert(int cl, string sub, int type)
        {
            string sqlExpression = String.Format("INSERT INTO Schedule (Неделя, День_недели, Пара, Группа, Предмет, Тип_занятия) VALUES (@week, @weekday ,@class,@group,@subject,@type)");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlParameter weekParam = new SqlParameter("@week", weekSelected);
                command.Parameters.Add(weekParam);
                SqlParameter dayParam = new SqlParameter("@weekday", weekDaySelected);
                command.Parameters.Add(dayParam);
                SqlParameter clParam = new SqlParameter("@class", cl);
                command.Parameters.Add(clParam);
                SqlParameter grParam = new SqlParameter("@group", new Guid(groupSelected));
                command.Parameters.Add(grParam);
                SqlParameter subParam = new SqlParameter("@subject", new Guid(sub));
                command.Parameters.Add(subParam);
                SqlParameter typeParam = new SqlParameter("@type", type);
                command.Parameters.Add(typeParam);
                int number = command.ExecuteNonQuery();
            }
        }

        private void buttonAddFaculty_Click(object sender, EventArgs e)
        {
            try
            {
                AddFaculty addFaculty = new AddFaculty();
                addFaculty.ShowDialog();
                addFaculty.Close();
                this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
                facultiesComboBox.SelectedIndex = -1;
            }
            catch { }
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                AddGroupWithoutStudents withoutStudents = new AddGroupWithoutStudents();
                withoutStudents.ShowDialog();
                LoadGroups();
                withoutStudents.Close();

            }
            catch { }
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.ShowDialog();
            addSubject.Close();
            Subj();
        }

        public void Subj()
        {
            try
            {
                int s1 = subjectsComboBox1.SelectedIndex;
                int s2 = subjectsComboBox2.SelectedIndex;
                int s3 = subjectsComboBox3.SelectedIndex;
                int s4 = subjectsComboBox4.SelectedIndex;
                ArrayList subjects1 = new ArrayList();
                ArrayList subjects2 = new ArrayList();
                ArrayList subjects3 = new ArrayList();
                ArrayList subjects4 = new ArrayList();
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
                                subjects1.Add(new Subjects(id, subject));
                                subjects2.Add(new Subjects(id, subject));
                                subjects3.Add(new Subjects(id, subject));
                                subjects4.Add(new Subjects(id, subject));
                            }
                        }
                    }
                    subjectsComboBox1.DataSource = subjects1;
                    subjectsComboBox1.DisplayMember = "subject";
                    subjectsComboBox1.ValueMember = "id";
                    subjectsComboBox2.DataSource = subjects2;
                    subjectsComboBox2.DisplayMember = "subject";
                    subjectsComboBox2.ValueMember = "id";
                    subjectsComboBox3.DataSource = subjects3;
                    subjectsComboBox3.DisplayMember = "subject";
                    subjectsComboBox3.ValueMember = "id";
                    subjectsComboBox4.DataSource = subjects4;
                    subjectsComboBox4.DisplayMember = "subject";
                    subjectsComboBox4.ValueMember = "id";
                    reader.Close();
                }
                subjectsComboBox1.SelectedIndex = s1;
                subjectsComboBox2.SelectedIndex = s2;
                subjectsComboBox3.SelectedIndex = s3;
                subjectsComboBox4.SelectedIndex = s4;
            }
            catch { }
        }
    }
}
