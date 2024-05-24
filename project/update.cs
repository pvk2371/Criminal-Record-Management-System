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
    public partial class update : Form
    {
        String cs = "";
        MySqlConnection c1;
        MySqlCommand cmd;
        MySqlDataAdapter d1;
        MySqlDataReader d;
        String q = "",photo="";
        public update()
        {
            InitializeComponent();
        }

        private void update_Load(object sender, EventArgs e)
        {
            cs = "Server=localhost; database=criminal; uid=root; pwd=root";
            c1 = new MySqlConnection(cs);
            c1.Open();
            try 
            {
                
                q = "Select name from register";
                cmd = new MySqlCommand(q, c1);
                d1 = new MySqlDataAdapter(q, c1);
                DataTable dt = new DataTable();
                d1.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    criminalNameComboBox.Items.Add(dr["name"].ToString());
                }

                //MessageBox.Show("Database Connected Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Exception" + ex);
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }

        private void criminalNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c1.State == ConnectionState.Open)
                c1.Close();
            c1.Open();
            try
            {
                q = "select * from register where name ='"+criminalNameComboBox.SelectedItem.ToString () +"'";// @name";
                cmd = new MySqlCommand(q, c1);
                //scmd.Parameters.AddWithValue("@name", criminalNameComboBox.Text);
                
                d = cmd.ExecuteReader();
                if (d.Read())
                {
                    addressTextBox.Text = d.GetString("address");
                    contactTextBox.Text = d.GetString("contact");
                    penaltyTextBox.Text = d.GetString("penalty");
                    amountTextBox.Text = d.GetString("amount");
                    photoPictureBox.ImageLocation = d.GetString("photo");
                    photo = d.GetString("photo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            finally
            {
                
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog a1 = new OpenFileDialog();
            a1.Filter = "Image Files(*.jpg;*.jpeg;*gif;*.png;*.bmp)| *.jpg;*.jpeg;*.gif;*.png;*.bmp";
            string r = "";
            if (a1.ShowDialog() == DialogResult.OK)
            {
                photoPictureBox.Image = new Bitmap(a1.FileName);
                r = a1.FileName;
                photo = r;
                MessageBox.Show(r);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.Open();
            try
            {
                
                q = "update register set address=@address, contact=@contact, penalty=@penalty, amount=@amount, photo=@photo where name=@name";
                cmd = new MySqlCommand(q, c1);
                cmd.Parameters.AddWithValue("@name", criminalNameComboBox.Text);
                cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@contact", contactTextBox.Text);
                cmd.Parameters.AddWithValue("@penalty", penaltyTextBox.Text);
                cmd.Parameters.AddWithValue("@amount", amountTextBox.Text);
                cmd.Parameters.AddWithValue("@photo", photo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");

                criminalNameComboBox.SelectedItem = null; addressTextBox.Clear(); contactTextBox.Clear(); penaltyTextBox.Clear(); amountTextBox.Clear(); photoPictureBox.Image = null;
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Updation Exception : " + ex);
            }
            finally 
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }

        }
    }
}
