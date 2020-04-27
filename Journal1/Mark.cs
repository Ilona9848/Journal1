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

namespace Journal1
{
    public partial class Mark : Form
    {
        public string groupSelected;
        public int cl;
        DateTime day;
        
        string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";
        public Mark(string groupSelected, int cl, DateTime day)
        {
            InitializeComponent();
            this.groupSelected = groupSelected;
            this.cl = cl;
            this.day = day;
        }

        private void Mark_Load(object sender, EventArgs e)
        {
            day = new DateTime(day.Year, day.Month, day.Day, 0, 0, 0);
            try
            {
                
                string sqlExpression = "SELECT * FROM Students";
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
                    for(int i=0;i<dataGridView1.Rows.Count;i++)
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
                                if (student.ToString() == dataGridView1.Rows[i].Cells[0].Value.ToString() && cla == cl && date == day && be == true)
                                    dataGridView1.Rows[i].Cells[3].Value = true;
                            }
                        }
                        reader1.Close();
                    }
                }
            }
            catch
            {

            }
        }

        private void buttonMark_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    bool b = Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value);
                    bool exist = false;

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string sqlExpression1 = "SELECT * FROM Attendance";
                        string sqlExpression2 = "UPDATE Attendance SET Был=1 WHERE Id=@id";
                        string sqlExpression3 = "UPDATE Attendance SET Был=0 WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(sqlExpression1, connection);
                        SqlDataReader reader1 = cmd.ExecuteReader();
                        for (int k = i; k < dataGridView1.Rows.Count; k++)
                        {

                            if (reader1.HasRows)
                            {
                                while (reader1.Read())
                                {
                                    object id = reader1.GetValue(0);
                                    object student = reader1.GetValue(1);
                                    int cla = reader1.GetInt32(2);
                                    DateTime date = reader1.GetDateTime(3);
                                    bool be = reader1.GetBoolean(4);
                                    if (student.ToString() == dataGridView1.Rows[k].Cells[0].Value.ToString() && cla == cl && date == day && !be && b)
                                    {
                                        SqlCommand cmd2 = new SqlCommand(sqlExpression2, connection);
                                        SqlParameter idParam = new SqlParameter("@id", new Guid(id.ToString()));
                                        cmd2.Parameters.Add(idParam);
                                        cmd2.ExecuteNonQuery();
                                        exist = true;
                                    }
                                    if (student.ToString() == dataGridView1.Rows[k].Cells[0].Value.ToString() && cla == cl && date == day && be && !b)
                                    {
                                        SqlCommand cmd3 = new SqlCommand(sqlExpression3, connection);
                                        SqlParameter idParam = new SqlParameter("@id", new Guid(id.ToString()));
                                        cmd3.Parameters.Add(idParam);
                                        cmd3.ExecuteNonQuery();
                                        exist = true;
                                    }

                                }
                            }

                        }
                        reader1.Close();
                        if (!exist)
                        {
                            string sqlExpression = "INSERT INTO Attendance (Студент, Пара, Дата, Был) VALUES (@student, @class,@date,@be)";
                            SqlCommand command = new SqlCommand(sqlExpression, connection);
                            SqlParameter studParam = new SqlParameter("@student", new Guid(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                            command.Parameters.Add(studParam);
                            SqlParameter clParam = new SqlParameter("@class", cl);
                            command.Parameters.Add(clParam);
                            SqlParameter dateParam = new SqlParameter("@date", day);
                            command.Parameters.Add(dateParam);
                            SqlParameter beParam = new SqlParameter("@be", b);
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
