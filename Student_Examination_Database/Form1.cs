using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Student_Examination_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-K2HERRJ\SQLEXPRESS;Initial Catalog=ExamsStudents;Integrated Security=True;Pooling=False");

        private void Form1_Load(object sender, EventArgs e)
        {
            this.studentsTableTableAdapter1.Fill(this.examsStudentsDataSet1.studentsTable);
            Display_Data();
            
        }

        private void Display_Data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM studentsTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void Clear_All_TextBoxes()
        {
            id_tb.Clear();
            name_tb.Clear();
            surname_tb.Clear();
            specialization_tb.Clear();
            subject_tb.Clear();
            score_tb.Clear();
            less_tb.Clear();
            more_tb.Clear();
        }

        private bool Check_Input(TextBox tb)
        {
            int test_value;

            if (!int.TryParse(tb.Text.Trim(), out test_value))
                return false;

            return true;
        }

        private void Save_Data()
        {
            if (!string.IsNullOrEmpty(id_tb.Text) && this.Check_Input(id_tb) && !string.IsNullOrEmpty(name_tb.Text) && !string.IsNullOrEmpty(surname_tb.Text) && !string.IsNullOrEmpty(specialization_tb.Text) && !string.IsNullOrEmpty(subject_tb.Text) && !string.IsNullOrEmpty(score_tb.Text) && Convert.ToDouble(score_tb.Text) >= 0 && Convert.ToDouble(score_tb.Text) <= 100)
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO studentsTable VALUES ('" + id_tb.Text + "','" + name_tb.Text + "','" + surname_tb.Text + "','" + specialization_tb.Text + "','" + subject_tb.Text + "','" + score_tb.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                Clear_All_TextBoxes();
                Display_Data();
                Saved saved_msg = new Saved();
                saved_msg.Show();
            }
            else
            {
                Error error_msg = new Error();
                error_msg.Show();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Save_Data();
        }

        private void Delete_By_Id()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM studentsTable WHERE Id = '" + id_tb.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            Clear_All_TextBoxes();
            Display_Data();
            Deleted deleted_msg = new Deleted();
            deleted_msg.Show();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Delete_By_Id();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void less_search()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM studentsTable WHERE Score < '" + less_tb.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
            Clear_All_TextBoxes();
        }

        private void more_search()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM studentsTable WHERE Score >= '" + more_tb.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
            Clear_All_TextBoxes();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (less_tb.Text != "")
                less_search();
            else if (more_tb.Text != "")
                more_search();
            else
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM studentsTable WHERE Id = '" + id_tb.Text + "' OR Name = '" + name_tb.Text + "' OR Surname = '" + surname_tb.Text + "' OR Specialization = '" + specialization_tb.Text + "' OR Subject = '" + subject_tb.Text + "' OR Score = '" + score_tb.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
                Clear_All_TextBoxes();
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://keeroll.wordpress.com");
        }
    }
}
