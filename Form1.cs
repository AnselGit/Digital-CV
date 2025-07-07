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

        private Form2 form2Instance;

        private void btn_CallToAction_Click_1(object sender, EventArgs e)
        {
            if (form2Instance == null || form2Instance.IsDisposed)
            {
                form2Instance = new Form2();
                form2Instance.Show();
            }
            else
            {
                form2Instance.BringToFront(); // Optional: bring to top if it's hidden
            }
        }

    }
}
