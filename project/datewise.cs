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
    public partial class datewise : Form
    {
        String cs = "", q = "";
        MySqlConnection c1;
        MySqlCommand cmd;
        MySqlDataReader d;
        MySqlDataAdapter da;
        public datewise()
        {
            InitializeComponent();
        }

        private void datewise_Load(object sender, EventArgs e)
        {
            cs = "Server=localhost; database=criminal; uid=root; pwd=root";
            c1 = new MySqlConnection(cs);
           // MessageBox.Show("Database connected Succesfully");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            c1.Open();
            try
            {
                q = "select * from register where regdate = @rdate";
                da = new MySqlDataAdapter(q, c1);
                da.SelectCommand.Parameters.AddWithValue("@rdate", dateTimePicker1.Value.Date);
                DataTable t = new DataTable();
                da.Fill(t);
                dataGridView1.DataSource = t;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorting Exception" + ex);
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }

        }
    }
}
