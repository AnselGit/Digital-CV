using System;
using System.Windows.Forms;
using DigitalCV;

namespace DigitalCV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Heading1.BackColor = System.Drawing.Color.Transparent;
        }

        private void btn_CallToAction_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
