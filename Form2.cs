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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lbl_desc_Click(object sender, EventArgs e)
        {

        }

        private void txt_user_MouseHover(object sender, EventArgs e)
        {
            txt_user.BackColor = Color.White;
        }

        private void txt_user_MouseLeave(object sender, EventArgs e)
        {
            txt_user.BackColor = SystemColors.Control;
        }

        private void txt_pass_MouseHover(object sender, EventArgs e)
        {
            txt_user.BackColor = Color.White;
        }

        private void txt_pass_MouseLeave(object sender, EventArgs e)
        {
            txt_user.BackColor = SystemColors.Control;
        }

    }
}
