using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal1
{
    public partial class JournalMain : Form
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

        //Для создания групп
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

        //Адрес сервера
        string connectionString;

        //Выбранные данные
        int weekdaySelected, weekSelected;
        string facultySelected;

        public JournalMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FindDataBase();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.TypeOfClass". При необходимости она может быть перемещена или удалена.
            this.typeOfClassTableAdapter.Fill(this.journalDataDataSet.TypeOfClass);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.journalDataDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.journalDataDataSet.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
            Back();
            LoadFaculties();
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
        private void facultiesListBox_DoubleClick(object sender, EventArgs e)
        {
            OpenGroups();
        }
        
        private void buttonOpenGroups_Click(object sender, EventArgs e)
        {
            OpenGroups();
        }
        
        private void listBoxGroups_DoubleClick(object sender, EventArgs e)
        {
            OpenDate();
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            OpenDate();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dateTimePicker.Hide();
            buttonNext.Hide();
            labelInstruction.Hide();
            comboBoxWeek.Hide();
            labelDate.Show();
            UpdateSchedule();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Mark mark = new Mark(listBoxGroups.SelectedValue.ToString(),1,dateTimePicker.Value,facultySelected);
            mark.ShowDialog();
            mark.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark(listBoxGroups.SelectedValue.ToString(), 2, dateTimePicker.Value,facultySelected);
            mark.ShowDialog();
            mark.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark(listBoxGroups.SelectedValue.ToString(), 3, dateTimePicker.Value,facultySelected);
            mark.ShowDialog();
            mark.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark(listBoxGroups.SelectedValue.ToString(), 4, dateTimePicker.Value,facultySelected);
            mark.ShowDialog();
            mark.Close();
        }

        private void buttonNextSubjects_Click(object sender, EventArgs e)
        {
            facultiesComboBox.Hide();
            buttonNextSubjects.Hide();
            listBoxSubjects.Show();
            labelFaculty.Show();
            facultySelected = facultiesComboBox.SelectedValue.ToString();
            try
            {
                string sqlexpression1 = "SELECT * FROM Faculties ORDER BY Факультет";
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
                                labelFaculty.Text = faculty.ToString();
                            }
                        }
                    }
                    reader.Close();
                }
                LoadSubjects();
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
                facultiesListBox.DataSource = listFaculties;
                facultiesListBox.DisplayMember = "faculty";
                facultiesListBox.ValueMember = "id";
                reader.Close();
            }

        }

        public void OpenDate()
        {
            try
            {
                buttonDate.Hide();
                listBoxGroups.Hide();
                string groupSelected = listBoxGroups.SelectedValue.ToString();
                string sqlexpression1 = "SELECT * FROM Groups";
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
                            if (id.ToString() == groupSelected)
                            {
                                labelGroup.Text = group.ToString() + " группа";
                            }
                        }
                    }
                    labelGroup.Show();
                    reader.Close();
                }
                dateTimePicker.Show();
                buttonNext.Show();
                labelInstruction.Show();
                comboBoxWeek.Show();
            }
            catch
            {
                MessageBox.Show("Групп нет");
                Back();
            }

        }

        public void OpenGroups()
        {
            try
            {
                labelFaculty.Show();
                facultiesListBox.Hide();
                listBoxGroups.Show();
                buttonOpenGroups.Hide();
                buttonDate.Show();
                facultySelected = facultiesListBox.SelectedValue.ToString();
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
                                labelFaculty.Text = faculty.ToString();
                            }
                        }
                    }
                    LoadGroups();
                    reader.Close();
                }
                
            }
            catch { }
        }

        public void LoadGroups()
        {
            List<Groups> listGroups = new List<Groups>();
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
                listBoxGroups.DataSource = listGroups;
                listBoxGroups.DisplayMember = "group";
                listBoxGroups.ValueMember = "id";
                reader.Close();
            }

        }

        private void Back()//Возвращает на основное меню
        {
            buttonOpenGroups.Show();
            listBoxGroups.Hide();
            facultiesListBox.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            buttonNext.Hide();
            dateTimePicker.Hide();
            labelDate.Hide();
            labelFaculty.Hide();
            labelGroup.Hide();
            labelInstruction.Hide();
            comboBoxWeek.Hide();
            facultiesComboBox.Hide();
            listBoxSubjects.Hide();
            buttonNextSubjects.Hide();
            buttonDate.Hide();
            
        }

        public void UpdateSchedule()
        {
            DateTime day = dateTimePicker.Value;
            if (comboBoxWeek.SelectedIndex == 0)
                weekSelected = 1;
            else
                weekSelected = 2;
            labelDate.Text = day.ToShortDateString();
            weekdaySelected = (int)day.DayOfWeek;
            try
            {
                string sqlExpression = "SELECT * FROM Schedule";
                StringBuilder sb1 = new StringBuilder();
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
                            int week = reader.GetInt32(1);
                            int weekday = reader.GetInt32(2);
                            int cl = reader.GetInt32(3);
                            object group = reader.GetValue(4);
                            object sub = reader.GetValue(5);
                            object type = reader.GetValue(6);
                            if (weekSelected == week && weekdaySelected == weekday && listBoxGroups.SelectedValue.ToString() == group.ToString() && cl == 1)
                            {
                                FindSubject(sub.ToString(), sb1);
                                FindType((int)type, sb1);
                                label1.Text = sb1.ToString();
                                button1.Show(); label1.Show();
                                sb1.Clear();
                            }
                            if (weekSelected == week && weekdaySelected == weekday && listBoxGroups.SelectedValue.ToString() == group.ToString() && cl == 2)
                            {
                                FindSubject(sub.ToString(), sb1);
                                FindType((int)type, sb1);
                                label2.Text = sb1.ToString();
                                button2.Show(); label2.Show();
                                sb1.Clear();
                            }
                            if (weekSelected == week && weekdaySelected == weekday && listBoxGroups.SelectedValue.ToString() == group.ToString() && cl == 3)
                            {
                                FindSubject(sub.ToString(), sb1);
                                FindType((int)type, sb1);
                                label3.Text = sb1.ToString();
                                button3.Show(); label3.Show();
                                sb1.Clear();
                            }
                            if (weekSelected == week && weekdaySelected == weekday && listBoxGroups.SelectedValue.ToString() == group.ToString() && cl == 4)
                            {
                                FindSubject(sub.ToString(), sb1);
                                FindType((int)type, sb1);
                                label4.Text = sb1.ToString();
                                button4.Show(); label4.Show();
                                sb1.Clear();
                            }
                        }
                    }
                    reader.Close();
                }
            }
            catch { }
        }

        public void LoadSubjects()
        {
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
                        object subject = reader.GetValue(1);
                        object faculty = reader.GetValue(2);
                        if (faculty.ToString() == facultySelected)
                        {
                            listBoxSubjects.Items.Add(subject.ToString());
                        }
                    }
                }
                reader.Close();
            }

        }

        public void FindSubject(string idSEl, StringBuilder sb1)
        {
            string sqlExpression1 = "SELECT * FROM Subjects ORDER BY Предмет";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object sub = reader.GetValue(1);
                        if (id.ToString() == idSEl)
                            sb1.Append(sub.ToString() + " ");
                    }
                }
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            Back();
            LoadFaculties();
        }

        private void ToolStripMenuItemListOfFaculties_Click(object sender, EventArgs e)
        {
            facultiesListBox.Show();
            listBoxGroups.Hide();
            dateTimePicker.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            buttonNext.Hide();
            labelFaculty.Hide();
            labelGroup.Hide();
            labelInstruction.Hide();
            comboBoxWeek.Hide();
            labelDate.Hide();
            facultiesComboBox.Hide();
            listBoxSubjects.Hide();
            buttonNextSubjects.Hide();
            LoadFaculties();
        }

        private void ToolStripMenuItemListOfSubjects_Click(object sender, EventArgs e)
        {
            facultiesListBox.Hide();
            listBoxGroups.Hide();
            dateTimePicker.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            buttonNext.Hide();
            labelFaculty.Hide();
            labelGroup.Hide();
            labelInstruction.Hide();
            comboBoxWeek.Hide();
            labelDate.Hide();
            facultiesComboBox.Show();
            buttonNextSubjects.Show();
            listBoxSubjects.Items.Clear();
            listBoxSubjects.Hide();
            buttonOpenGroups.Hide();
            buttonDate.Hide();
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

        private void ToolStripMenuItemListOfStudents_Click(object sender, EventArgs e)
        {
            StudentsList studentsList = new StudentsList();
            studentsList.ShowDialog();
            studentsList.Close();
        }

        private void ToolStripMenuItemPeriodTable_Click(object sender, EventArgs e)
        {
            Table table = new Table();
            table.ShowDialog();
            table.Close();
        }

        private void ToolStripMenuItemAddFaculty_Click(object sender, EventArgs e)
        {
            AddFaculty addFaculty = new AddFaculty();
            addFaculty.ShowDialog();
            addFaculty.Close();
            LoadFaculties();
        }

        private void ToolStripMenuItemAddGroup_Click(object sender, EventArgs e)
        {
            AddGroupWithoutStudents withoutStudents = new AddGroupWithoutStudents();
            withoutStudents.ShowDialog();
            withoutStudents.Close();
            LoadFaculties();
            LoadGroups();
        }

        private void ToolStripMenuItemAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            addStudent.Close();
            LoadFaculties();
            LoadGroups();
        }

        private void ToolStripMenuItemAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.ShowDialog();
            addSubject.Close();
            LoadFaculties();
            LoadSubjects();
        }

        private void ToolStripMenuItemAddSchedule_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule = new AddSchedule();
            addSchedule.ShowDialog();
            addSchedule.Close();
            LoadFaculties();
            LoadGroups();
            UpdateSchedule();
        }

        private void ToolStripMenuItemDeleteFaculty_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteFaculty deleteFaculty = new DeleteFaculty();
                deleteFaculty.ShowDialog();
                deleteFaculty.Close();
                LoadFaculties();
                LoadGroups();
                LoadSubjects();
                UpdateSchedule();
            }
            catch
            {
                Back();
            }
        }

        private void ToolStripMenuItemDeleteGroup_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteGroup deleteGroup = new DeleteGroup();
                deleteGroup.ShowDialog();
                deleteGroup.Close();
                LoadGroups();
                LoadSubjects();
                UpdateSchedule();
            }
            catch
            {
                Back();
            }
        }

        private void ToolStripMenuItemDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.ShowDialog();
            deleteStudent.Close();
        }

        private void ToolStripMenuItemDeleteSubject_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteSubject deleteSubject = new DeleteSubject();
                deleteSubject.ShowDialog();
                deleteSubject.Close();
                LoadSubjects();
                UpdateSchedule();
            }
            catch
            {
                Back();
            }
        }

        private void toolStripDropDownButtonChange_Click(object sender, EventArgs e)
        {
            ChangeFaculty changeFaculty = new ChangeFaculty();
            changeFaculty.ShowDialog();
            changeFaculty.Close();
        }

        public void FindType(int idSel,StringBuilder sb)
        {
            string sqlExpression1 = "SELECT * FROM TypeOfClass";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object type = reader.GetValue(1);
                        if ((int)id == idSel)
                            sb.Append(type.ToString());
                    }
                }
            }
        }
    }
}
