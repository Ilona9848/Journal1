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
    public partial class Mark : Form
    {
        public string groupSelected;
        public int cl;
        DateTime day;
        public string facultySelected;
        string n = "";

        string connectionString;
        public Mark(string groupSelected, int cl, DateTime day,string facultySelected)
        {
            InitializeComponent();
            this.groupSelected = groupSelected;
            this.cl = cl;
            this.day = day;
            this.facultySelected = facultySelected;
        }

        public void FindDataBase()
        {
            string ds = "";
            string ic = "";
            string id = "";
            string pas = "";
            string ins= "";
            using(StreamReader sr=new StreamReader("config.txt"))
            {
                while(!sr.EndOfStream)
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

        private void Mark_Load(object sender, EventArgs e)
        {
            FindDataBase();
            day = new DateTime(day.Year, day.Month, day.Day, 0, 0, 0);
            FindFaculty();
            FindGroup();
            labelName.Text = n;
            this.Text =  day.ToShortDateString()+ " | " + cl.ToString()+" пара";
            FindStudents();
        }
        
        private void FindFaculty()
        {
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
                                n = faculty.ToString() + " ";
                            }
                        }
                    }
                    reader.Close();
                }
            }
            catch
            { }
        }

        private void FindGroup()
        {
            try
            {
                string sqlexpression4 = "SELECT * FROM Groups";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlexpression4, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            object id = reader.GetValue(0);
                            object group = reader.GetValue(2);
                            if (id.ToString() == groupSelected)
                            {
                                n = n + " " + group.ToString() + " группа ";
                            }
                        }
                    }
                    reader.Close();
                }
            }
            catch { }
        }

        private void FindStudents()
        {
            try
            {
                string sqlExpression = "SELECT * FROM Students ORDER BY Фамилия";
                int row = 0;
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
                            string surname = reader.GetString(3);
                            string name = reader.GetString(4);
                            if (group.ToString() == groupSelected)
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[row].Cells[0].Value = id.ToString();
                                dataGridView1.Rows[row].Cells[1].Value = surname;
                                dataGridView1.Rows[row].Cells[2].Value = name;
                                row++;
                            }
                        }
                    }
                    reader.Close();
                    sqlExpression = "SELECT * FROM Attendance";
                    for(int i=0;i<dataGridView1.Rows.Count-1;i++)
                    {
                        SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                        SqlDataReader reader1 = cmd.ExecuteReader();
                        if(reader1.HasRows)
                        {
                            while(reader1.Read())
                            {
                                object student = reader1.GetValue(1);
                                int cla = reader1.GetInt32(2);
                                DateTime date = reader1.GetDateTime(3);
                                bool be = reader1.GetBoolean(4);
                                if (student.ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString() && cla == cl && date == day && be)
                                    dataGridView1.Rows[i].Cells[3].Value = true;
                            }
                        }
                        reader1.Close();
                    }
                }
            }
            catch
            { }
        }

        private void buttonMark_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    bool b = Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlExpression1 = "DELETE FROM Attendance WHERE Студент = @student AND Пара=@class AND Дата=@date";
                        SqlCommand cmd = new SqlCommand(sqlExpression1, connection);
                        SqlParameter studParam = new SqlParameter("@student", new Guid(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                        cmd.Parameters.Add(studParam);
                        SqlParameter clParam = new SqlParameter("@class", cl);
                        cmd.Parameters.Add(clParam);
                        SqlParameter dateParam = new SqlParameter("@date", day);
                        cmd.Parameters.Add(dateParam);
                        cmd.ExecuteNonQuery();
                        if (b)
                        {
                            string sqlExpression = "INSERT INTO Attendance (Студент, Пара, Дата, Был) VALUES (@students, @class1,@date1,@be)";
                            SqlCommand command = new SqlCommand(sqlExpression, connection);
                            SqlParameter studParam1 = new SqlParameter("@students", new Guid(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                            command.Parameters.Add(studParam1);
                            SqlParameter clParam1 = new SqlParameter("@class1", cl);
                            command.Parameters.Add(clParam1);
                            SqlParameter dateParam1 = new SqlParameter("@date1", day);
                            command.Parameters.Add(dateParam1);
                            SqlParameter beParam = new SqlParameter("@be", 1);
                            command.Parameters.Add(beParam);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                this.Close();
            }
            catch { }
        }
    }
}
