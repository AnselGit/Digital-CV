using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalCV
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lkl_close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Close all forms except the main one (optional)
            foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
            {
                frm.Close();
            }

            // Optional: if you want to make sure the app exits completely
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form4().Show();
        }

        private void lkl_close_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
            {
                frm.Close();
            }
        }
    }
}
