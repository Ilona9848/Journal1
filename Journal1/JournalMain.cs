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
        string connectionString= @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
        int weekdaySelected, weekSelected;
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
            listBoxGroups.Hide();
            subjectsListBox.Hide();
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
        }

        private void ToolStripMenuItemAddFaculty_Click(object sender, EventArgs e)
        {
            AddFaculty addFaculty = new AddFaculty();
            addFaculty.ShowDialog();
            addFaculty.Close();
            this.facultiesTableAdapter.Fill(this.journalDataDataSet.Faculties);
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
            listBoxGroups.Hide();
            subjectsListBox.Hide();
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
        }

        private void ToolStripMenuItemSubjectsList_Click(object sender, EventArgs e)
        {
            facultiesListBox.Hide();
            listBoxGroups.Hide();
            dateTimePicker.Hide();
            subjectsListBox.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            buttonNext.Hide();
            
        }

        private void ToolStripMenuItemAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
            addStudent.Close();
        }

        private void facultiesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                    facultiesListBox.Hide();
                    listBoxGroups.Show();
                    ArrayList groups = new ArrayList();
                    string facultySelected = facultiesListBox.SelectedValue.ToString();
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
                    listBoxGroups.DataSource = groups;
                    listBoxGroups.DisplayMember = "group";
                    listBoxGroups.ValueMember = "id";
                    reader.Close();
                }
            }
            catch
            {

            }

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
                this.groupsTableAdapter.Fill(this.journalDataDataSet.Groups);
            }
            catch
            { }

        }

        private void ToolStripMenuItemAddSchedule_Click(object sender, EventArgs e)
        {
            AddSchedule addSchedule = new AddSchedule();
            addSchedule.ShowDialog();
            addSchedule.Close();
        }

        private void ToolStripMenuItemAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.ShowDialog();
            addSubject.Close();
        }

        private void ToolStripMenuItemFacultiesList_Click(object sender, EventArgs e)
        {
            facultiesListBox.Show();
            listBoxGroups.Hide();
            subjectsListBox.Hide();
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
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxGroups.Hide();
            dateTimePicker.Show();
            buttonNext.Show();
        }

        public void Lab(string idSEl,StringBuilder sb1)
        {
            string sqlExpression1 = "SELECT * FROM Subjects";
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
            listBoxGroups.Hide();
            dateTimePicker.Show();
            buttonNext.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker.Hide();
            buttonNext.Hide();
            DateTime day = dateTimePicker.Value;
            weekdaySelected = (int)day.DayOfWeek;
            GregorianCalendar cal = new GregorianCalendar(GregorianCalendarTypes.Localized);
            weekSelected=cal.GetWeekOfYear(day, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)%2;
            if (weekSelected == 0)
                weekSelected = 2;
            else
                weekSelected = 1;
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
                            if (weekSelected==week&&weekdaySelected==weekday&&listBoxGroups.SelectedValue.ToString()==group.ToString()&&cl==1)
                            {
                                Lab(sub.ToString(), sb1);
                                Lab2((int)type, sb1);
                                label1.Text = sb1.ToString();
                                button1.Show();label1.Show();
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
            catch {}

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Mark mark = new Mark(listBoxGroups.SelectedValue.ToString(),1,dateTimePicker.Value);
            mark.ShowDialog();
            mark.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark(listBoxGroups.SelectedValue.ToString(), 2, dateTimePicker.Value);
            mark.ShowDialog();
            mark.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark(listBoxGroups.SelectedValue.ToString(), 3, dateTimePicker.Value);
            mark.ShowDialog();
            mark.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mark mark = new Mark(listBoxGroups.SelectedValue.ToString(), 4, dateTimePicker.Value);
            mark.ShowDialog();
            mark.Close();
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
