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
    public partial class allcriminals : Form
    {
        String cs = "";
        MySqlConnection c1;
        MySqlDataAdapter da;
        String q = "";
        public allcriminals()
        {
            InitializeComponent();
        }

        private void allcriminals_Load(object sender, EventArgs e)
        {
            cs = "Server=localhost; database=criminal; uid=root; pwd=root";
            c1 = new MySqlConnection(cs);
           // MessageBox.Show("Database connected Succesfully");

            c1.Open();
            try
            {
                q = " select * from register ";
                da = new MySqlDataAdapter(q, c1);
                DataTable t = new DataTable();
                da.Fill(t);
                dataGridView1.DataSource = t;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Display Exception=" + ex);

            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }
    }
}
