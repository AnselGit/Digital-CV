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
            this.AcceptButton = btn_login;

            // Attach Enter key listener
            txt_user.KeyDown += TextBoxes_KeyDown;
            txt_pass.KeyDown += TextBoxes_KeyDown;

            // Attach focus events
            txt_user.Enter += txt_user_Enter;
            txt_user.Leave += txt_user_Leave;
            txt_pass.Enter += txt_pass_Enter;
            txt_pass.Leave += txt_pass_Leave;

            // Attach button hover and click visuals
            btn_login.MouseEnter += btn_login_MouseEnter;
            btn_login.MouseLeave += btn_login_MouseLeave;
            btn_login.MouseDown += btn_login_MouseDown;
            btn_login.MouseUp += btn_login_MouseUp;
        }

        private void lbl_desc_Click(object sender, EventArgs e)
        {
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            txt_user.BackColor = Color.White;
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            txt_user.BackColor = SystemColors.Control;
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            txt_pass.BackColor = Color.White;
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            txt_pass.BackColor = SystemColors.Control;
        }

        private void btn_login_MouseEnter(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.RoyalBlue;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = SystemColors.Control;
        }

        private void btn_login_MouseDown(object sender, MouseEventArgs e)
        {
            btn_login.BackColor = Color.MidnightBlue;
        }

        private void btn_login_MouseUp(object sender, MouseEventArgs e)
        {
            btn_login.BackColor = Color.RoyalBlue;
        }

        private void TextBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string username = txt_user.Text.Trim();
            string password = txt_pass.Text.Trim();

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Form3().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
