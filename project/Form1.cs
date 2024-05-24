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
    public partial class Form1 : Form
    {
        String cs = "";
       MySqlConnection c1;
        MySqlCommand cmd, cmd1;
        MySqlDataReader d; 
        String q = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register1 f2 = new register1();
            f2.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search s1 = new search();
            s1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update u1 = new update();
            u1.Show();
        }

        private void allRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allcriminals a1= new allcriminals();
            a1.Show();
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthly m1= new monthly();
            m1.Show();
        }

        private void crimeTypeWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typewise t1=new typewise();
            t1.Show();
        }

        private void dateWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datewise d1=new datewise();
            d1.Show();
        }

        private void locationWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            locationwise l1=new locationwise();
            l1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
