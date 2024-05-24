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
    public partial class register1 : Form
    {
        String cs = "";
        MySqlConnection c1;
        MySqlCommand cmd;
        String g = "";
        String q = "",photo="";
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public register1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (maleRadioButton.Checked)
                g = "Male";
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRadioButton.Checked)
                g = "Female";
        }

        private void register_Load(object sender, EventArgs e)
        {
            cs = "Server=localhost; database=criminal; uid=root; pwd=root";
            c1 = new MySqlConnection(cs);
       //     MessageBox.Show("Database connected Succesfully");
            loadid();
        }
        void loadid()
        {
            c1.Open();
            try
            {
                q = "SELECT MAX(id) FROM register";
                MySqlCommand cmd = new MySqlCommand(q, c1);
                object result = cmd.ExecuteScalar();

                int newId = 1;
                if (result != null && result != DBNull.Value)
                {
                   newId = Convert.ToInt32(result) + 1;
                }
                textBox1.Text = newId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating ID: " + ex);
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }

        }
        public void clearall()
        {

            regDatePicker.Value = DateTime.Now;
            nameTextBox.Clear();
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            aadharTextBox.Clear();
            addressTextBox.Clear();
            dobDatePicker.Value = DateTime.Now;
            contactTextBox.Clear();
            typeComboBox.SelectedItem = null;
            penaltyTextBox.Clear();
            amountTextBox.Clear();
            dateOfCrimeDatePicker.Value = DateTime.Now;
            locationComboBox.SelectedItem = null;
            photoPictureBox.Image = null;
            stationTextBox.Clear();
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Name");
                nameTextBox.Focus();
            }
            else
                if (!maleRadioButton.Checked && !femaleRadioButton.Checked)
                {
                    MessageBox.Show("Please Select Gender");
                    maleRadioButton.Focus();
                    femaleRadioButton.Focus();
                }
                else
                    if (aadharTextBox.Text == "")
                    {
                        MessageBox.Show("Please Enter Aadhar Number");
                        aadharTextBox.Focus();
                    }
                    else
                        if (addressTextBox.Text == "")
                        {
                            MessageBox.Show("Please Enter Address");
                            addressTextBox.Focus();
                        }
                        else
                            if (dobDatePicker.Value.Date == null)
                            {
                                MessageBox.Show("Please Enter Date Of Birth");
                                dobDatePicker.Focus();
                            }
                            else
                                if (contactTextBox.Text == "")
                                {
                                    MessageBox.Show("Please Enter Contact Number");
                                    contactTextBox.Focus();
                                }
                                else
                                    if (typeComboBox.Text == "")
                                    {
                                        MessageBox.Show("Please Select Type of Crime");
                                        typeComboBox.Focus();
                                    }
                                    else
                                        if (penaltyTextBox.Text == "")
                                        {
                                            MessageBox.Show("Please Enter Penalty");
                                            penaltyTextBox.Focus();
                                        }
                                        else
                                            if (amountTextBox.Text == "")
                                            {
                                                MessageBox.Show("Please  Enter Penalty Amount");
                                                amountTextBox.Focus();
                                            }
                                            else
                                                if (dateOfCrimeDatePicker.Value.Date == null)
                                                {
                                                    MessageBox.Show("Please Enter Date of Crime");
                                                    dateOfCrimeDatePicker.Focus();
                                                }
                                                else
                                                    if (locationComboBox.Text == "")
                                                    {
                                                        MessageBox.Show("Please Select Crime Location");
                                                        locationComboBox.Focus();
                                                    }
                                                    else
                                                        if (stationTextBox.Text == "")
                                                        {
                                                            MessageBox.Show("Please Enter Police Station");
                                                            stationTextBox.Focus();
                                                        }
                                                        else
                                                            if (photoPictureBox.Image == null)
                                                            {
                                                                MessageBox.Show("Please Upload Photo");
                                                                photoPictureBox.Focus();
                                                            }
                                                            else
                                                            {
                                                                c1.Open();
                                                                try
                                                                {
                                                 

                                                                    q = "insert into register(regdate, name, gender, aadhar, address, dob, contact, type, penalty, amount, dateofcrime, location, station, photo) VALUES (@rdate, '" + nameTextBox.Text + "','"+g+"','" + aadharTextBox.Text + "', '" + addressTextBox.Text + "',@dob, '" + contactTextBox.Text + "', '" + typeComboBox.Text + "', '" + penaltyTextBox.Text + "', " + amountTextBox.Text + ",@cdate,'" + locationComboBox.Text + "', '" + stationTextBox.Text + "', @photo)";

                                                                    cmd = new MySqlCommand(q, c1);
                                                                    cmd.Parameters.AddWithValue("@rdate", regDatePicker.Value.ToString("yyyy-MM-dd"));
                                                                    cmd.Parameters.AddWithValue("@cdate",dateOfCrimeDatePicker.Value.ToString("yyyy-MM-dd"));
                                                                    cmd.Parameters.AddWithValue("@dob", dobDatePicker.Value.ToString("yyyy-MM-dd"));
                                                                    cmd.Parameters.AddWithValue("@photo", photo);
                                                                    cmd.ExecuteNonQuery();
                                                                    MessageBox.Show("Data Saved Successfully!");

                                                                   
                                                                }
                                                                catch (Exception ex)
                                                                {
                                                                    MessageBox.Show("Error:" + ex);
                                                                }
                                                                finally
                                                                {
                                                                    if (c1.State == ConnectionState.Open)
                                                                        c1.Close();
                                                                    clearall();
                                                                    loadid();

                                                                }
                                                            }
                                                            
        }

        public string gender { get; set; }

    }
}
