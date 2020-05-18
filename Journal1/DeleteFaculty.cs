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
    public partial class DeleteFaculty : Form
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

        public DeleteFaculty()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=.\SQLSEXPRESS;Initial Catalog=JournalData;Integrated Security=True";

        private void DeleteFaculty_Load(object sender, EventArgs e)
        {
            LoadFaculties();

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
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Удаление факультета может привести к удалению всех судентов и предметов, связанных с ним. Вы уверены, что хотите продолжить?", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Guid id = new Guid(facultiesListBox.SelectedValue.ToString());
                    string sqlExpression = "DELETE FROM Faculties WHERE Id=@id";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlParameter idParam = new SqlParameter("@id", id);
                        command.Parameters.Add(idParam);
                        command.ExecuteNonQuery();
                    }
                    this.Close();
                }
            }
            catch { }
        }
    }
}
