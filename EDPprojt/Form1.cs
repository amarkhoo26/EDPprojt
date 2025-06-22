using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EDPprojt
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
            labelName.Visible = false;
            labelPhone.Visible = false;
            textBoxName.Visible = false;
            textBoxPhone.Visible = false;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool isGuest = checkBoxGuest.Checked;

            labelName.Visible = isGuest;
            labelPhone.Visible = isGuest;
            textBoxName.Visible = isGuest;
            textBoxPhone.Visible = isGuest;

            // Hide login input when guest
            textBox1.Enabled = !isGuest;
            textBox2.Enabled = !isGuest;
            btnLogIn.Enabled = !isGuest;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp signUpForm = new FormSignUp();
            signUpForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            string connectionString = @"C:\Users\ADMIN\Documents\DIPLOMA\SEM 4\DRIVEN PROGRAMMING\EDPprojt\EDPprojt\DbLogIn.mdf";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }


        }
    }
}
