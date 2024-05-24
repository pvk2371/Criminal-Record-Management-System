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
    public partial class monthly : Form
    {
        String cs = "", q = "";
        MySqlConnection c1;
        MySqlCommand cmd;
        MySqlDataReader d;
        MySqlDataAdapter da;
        public monthly()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            c1.Open();
            try
            {

                int year = dateTimePicker1.Value.Year;
                int month = dateTimePicker1.Value.Month;


                q = string.Format("select * from register where year(dateofcrime) = {0} and month(dateofcrime) = {1}", year, month);

                cmd = new MySqlCommand(q, c1);
                da = new MySqlDataAdapter(cmd);
                DataTable t = new DataTable();
                da.Fill(t);
                if (t.Rows.Count == 0)
                {
                    MessageBox.Show("No criminal records found for the selected month.");
                }
                else
                {
                    dataGridView1.DataSource = t;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorting Exception:" + ex);
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }

        }

        private void monthly_Load(object sender, EventArgs e)
        {
            cs = "Server=localhost; database=criminal; uid=root; pwd=root";
            c1 = new MySqlConnection(cs);
           // MessageBox.Show("Database connected Succesfully");
        }
    }
}
