namespace DigitalCV
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ptb_graphic = new System.Windows.Forms.PictureBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.btn_login = new DigitalCV.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_graphic)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_graphic
            // 
            this.ptb_graphic.Image = ((System.Drawing.Image)(resources.GetObject("ptb_graphic.Image")));
            this.ptb_graphic.Location = new System.Drawing.Point(12, 12);
            this.ptb_graphic.Name = "ptb_graphic";
            this.ptb_graphic.Size = new System.Drawing.Size(406, 312);
            this.ptb_graphic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_graphic.TabIndex = 4;
            this.ptb_graphic.TabStop = false;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_user.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(13, 404);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(109, 30);
            this.lbl_user.TabIndex = 5;
            this.lbl_user.Text = "Username";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_pass.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(13, 495);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(104, 30);
            this.lbl_pass.TabIndex = 6;
            this.lbl_pass.Text = "Password";
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.SystemColors.Control;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(12, 440);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(405, 35);
            this.txt_user.TabIndex = 7;
            this.txt_user.MouseHover += new System.EventHandler(this.txt_user_MouseHover);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.SystemColors.Control;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(12, 528);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(405, 35);
            this.txt_pass.TabIndex = 8;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.Location = new System.Drawing.Point(9, 327);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(360, 34);
            this.lbl_desc.TabIndex = 9;
            this.lbl_desc.Text = "This is a static login form, meaning credentials are declared \r\nrather dynamicall" +
    "y fetching in a database.\r\n";
            this.lbl_desc.Click += new System.EventHandler(this.lbl_desc_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_login.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btn_login.BorderRadius = 45;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(12, 603);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(406, 42);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "See Your CV Now!";
            this.btn_login.TextColor = System.Drawing.Color.White;
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 657);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.ptb_graphic);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_graphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton btn_login;
        private System.Windows.Forms.PictureBox ptb_graphic;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_desc;
    }
}