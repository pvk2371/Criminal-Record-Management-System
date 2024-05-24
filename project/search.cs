using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Project
{
    public partial class search : Form
    {
        String cs;
        MySqlConnection c1;
        MySqlDataAdapter d1;
        MySqlDataReader d;
        String q = "";
        MySqlCommand cmd;
        public search()
        {
            InitializeComponent();
        }
        private void search_Load(object sender, EventArgs e)
        {
            try
            {
                cs = "Server=localhost; database=criminal; uid=root; pwd=root";
                c1 = new MySqlConnection(cs);
                c1.Open();
                q = "Select name from register";
                d1 = new MySqlDataAdapter(q, c1);
                DataTable dt = new DataTable();
                d1.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    criminalNameComboBox.Items.Add(dr["name"].ToString());
                }
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
          try
          {
                        cs = "Server=localhost; database=criminal; uid=root; pwd=root";
                        q = "select * from register where name = @name";
                        c1 = new MySqlConnection(cs);
                        cmd = new MySqlCommand(q, c1);
                        cmd.Parameters.AddWithValue("@name", criminalNameComboBox.SelectedItem.ToString());
                        c1.Open();
                        d = cmd.ExecuteReader();
                        if (d.Read())
                        {
                            regdateTextBox.Text = d.GetDateTime("regdate").ToString("yyyy-MM-dd");
                            criminalNameTextBox.Text = d.GetString("name");
                            genderTextBox.Text = d.GetString("gender");
                            aadharTextBox.Text = d.GetString("aadhar");
                            addressTextBox.Text = d.GetString("address");
                            dobTextBox.Text = d.GetDateTime("dob").ToString("yyyy-MM-dd");
                            contactTextBox.Text = d.GetString("contact");
                            typeTextBox.Text = d.GetString("type");
                            penaltyTextBox.Text = d.GetString("penalty");
                            amountTextBox.Text = d.GetString("amount");
                            dateOfCrimeTextBox.Text = d.GetDateTime("dateofcrime").ToString("yyyy-MM-dd");
                            locationTextBox.Text = d.GetString("location");
                            stationTextBox.Text = d.GetString("station");
                            photoPictureBox.ImageLocation = d.GetString("photo");

                        }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception= " + ex);
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }
    }
}
