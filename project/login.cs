using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class login : Form
    {
        String cs = "";
        MySqlConnection c1;
        MySqlCommand cmd;
        String q = "";
        public login()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            try
            {
                c1.Open();
                q = "select * from login where username=@username AND password=@password";
                 cmd = new MySqlCommand(q, c1);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                 cmd.Parameters.AddWithValue("@password", textBox2.Text);
                 MySqlDataReader reader = cmd.ExecuteReader();
                 if (reader.HasRows)
                  {
                       // MessageBox.Show("Login successful!");
                        Form f1 = new Form1();
                        this.Hide();
                        f1.Show();
                  }          
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            cs = "Server=localhost; database=criminal; uid=root; pwd=root";
            c1 = new MySqlConnection(cs);
           // MessageBox.Show("Database connected Succesfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                c1.Open();
                q = "INSERT INTO login (username, password) VALUES ('" + textBox1.Text+ "', '" + textBox2.Text + "')";
                cmd = new MySqlCommand(q, c1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User registered successfully!");

                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
