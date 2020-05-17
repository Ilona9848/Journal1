using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal1
{
    public partial class JournalMain : Form
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
        string connectionString= @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
        int weekdaySelected, weekSelected;
        string facultySelected;
        public JournalMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.TypeOfClass". При необходимости она может быть перемещена или удалена.
            this.typeOfClassTableAdapter.Fill(this.journalDataDataSet.TypeOfClass);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.journalDataDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.journalDataDataSet.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
            Back();
        }

        private void ToolStripMenuItemAddFaculty_Click(object sender, EventArgs e)
        {
            AddFaculty addFaculty = new AddFaculty();
            addFaculty.ShowDialog();
            addFaculty.Close();
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
            Back();
        }

        private void facultiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.journalDataDataSet);
        }

        private void ToolStripMenuItemBack_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.journalDataDataSet.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.journalDataDataSet.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "journalDataDataSet.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
            Back();
        }

        private void ToolStripMenuItemSubjectsList_Click(object sender, EventArgs e)
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
        }

        private void ToolStripMenuItemAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            addStudent.Close();
            Back();
        }

        private void ToolStripMenuItemAddGroup_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxGroups.Hide();
                facultiesListBox.Show();
                AddGroupWithoutStudents withoutStudents = new AddGroupWithoutStudents();
                withoutStudents.ShowDialog();
                withoutStudents.Close();
                Back();
                this.groupsTableAdapter.Fill(this.journalDataDataSet.Groups);
            }
            catch { }
        }
        private void Back()
        {
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
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
        }
        private void ToolStripMenuItemAddSchedule_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule = new AddSchedule();
            addSchedule.ShowDialog();
            addSchedule.Close();
            Back();
        }

        private void ToolStripMenuItemAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.ShowDialog();
            addSubject.Close();
            Back();
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
        }

        private void ToolStripMenuItemFacultiesList_Click(object sender, EventArgs e)
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
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxGroups.Hide();
            labelInstruction.Show();
            comboBoxWeek.Show();
            dateTimePicker.Show();
            buttonNext.Show();
        }

        public void Lab(string idSEl,StringBuilder sb1)
        {
            string sqlExpression1 = "SELECT * FROM Subjects ORDER BY Предмет";
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression1, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        object id = reader.GetValue(0);
                        object sub = reader.GetValue(1);
                        if (id.ToString() == idSEl)
                            sb1.Append(sub.ToString() + " ");
                    }
                }
            }
        }

        private void listBoxGroups_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxGroups.Hide();
                labelGroup.Show();
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
                                labelGroup.Text = group.ToString();
                            }
                        }
                    }
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
        public void Click()
        {
            dateTimePicker.Hide();
            buttonNext.Hide();
            labelInstruction.Hide();
            comboBoxWeek.Hide();
            labelDate.Show();
            DateTime day = dateTimePicker.Value;
            if (comboBoxWeek.SelectedIndex == 0)
                weekSelected = 1;
            else
                weekSelected=2;
            labelDate.Text = day.ToShortDateString();
            weekdaySelected = (int)day.DayOfWeek;
            try
            {
                ArrayList groups = new ArrayList();
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
                                Lab(sub.ToString(), sb1);
                                Lab2((int)type, sb1);
                                label1.Text = sb1.ToString();
                                button1.Show(); label1.Show();
                                sb1.Clear();
                            }
                            if (weekSelected == week && weekdaySelected == weekday && listBoxGroups.SelectedValue.ToString() == group.ToString() && cl == 2)
                            {
                                Lab(sub.ToString(), sb1);
                                Lab2((int)type, sb1);
                                label2.Text = sb1.ToString();
                                button2.Show(); label2.Show();
                                sb1.Clear();
                            }
                            if (weekSelected == week && weekdaySelected == weekday && listBoxGroups.SelectedValue.ToString() == group.ToString() && cl == 3)
                            {
                                Lab(sub.ToString(), sb1);
                                Lab2((int)type, sb1);
                                label3.Text = sb1.ToString();
                                button3.Show(); label3.Show();
                                sb1.Clear();
                            }
                            if (weekSelected == week && weekdaySelected == weekday && listBoxGroups.SelectedValue.ToString() == group.ToString() && cl == 4)
                            {
                                Lab(sub.ToString(), sb1);
                                Lab2((int)type, sb1);
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

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Click();
        }

        private void facultiesListBox_Click(object sender, EventArgs e)
        { 
            try
            {
                labelFaculty.Show();
                facultiesListBox.Hide();
                listBoxGroups.Show();
                ArrayList groups = new ArrayList();
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
                    reader.Close();
                }
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
                    listBoxGroups.DataSource = groups;
                    listBoxGroups.DisplayMember = "group";
                    listBoxGroups.ValueMember = "id";
                    reader.Close();
                }
            }
            catch { }

        }

        private void buttonNextSubjects_Click(object sender, EventArgs e)
        {
            facultiesComboBox.Hide();
            buttonNextSubjects.Hide();
            listBoxSubjects.Show();
            labelFaculty.Show();
            string facultySelected = facultiesComboBox.SelectedValue.ToString();
            try
            {
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
                    reader.Close();
                }
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
                                listBoxSubjects.Items.Add(subject.ToString());
                            }
                        }
                    }
                    reader.Close();
                }
            }
            catch { }
        }

        private void ToolStripMenuItemDeleteFaculty_Click(object sender, EventArgs e)
        {
            DeleteFaculty deleteFaculty = new DeleteFaculty();
            deleteFaculty.ShowDialog();
            deleteFaculty.Close();
            Back();
        }

        private void ToolStripMenuItemDeleteGroup_Click(object sender, EventArgs e)
        {
            DeleteGroup deleteGroup = new DeleteGroup();
            deleteGroup.ShowDialog();
            deleteGroup.Close();
            Back();
        }

        private void ToolStripMenuItemDeleteSubject_Click(object sender, EventArgs e)
        {
            DeleteSubject deleteSubject = new DeleteSubject();
            deleteSubject.ShowDialog();
            deleteSubject.Close();
            Back();
        }

        private void ToolStripMenuItemDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.ShowDialog();
            deleteStudent.Close();
            Back();
        }

        private void ToolStripMenuItemChange_Click(object sender, EventArgs e)
        {
            ChangeFaculty changeFaculty = new ChangeFaculty();
            changeFaculty.ShowDialog();
            changeFaculty.Close();
            Back();
        }

        private void ToolStripMenuItemOpenStudentsList_Click(object sender, EventArgs e)
        {
            StudentsList studentsList = new StudentsList();
            studentsList.ShowDialog();
            studentsList.Close();
            Back();
        }

        public void Lab2(int idSel,StringBuilder sb)
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
