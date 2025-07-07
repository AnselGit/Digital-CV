using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalCV
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        // Labels
        private Label Heading1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Heading1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CallToAction = new DigitalCV.RoundedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Heading1
            // 
            this.Heading1.AutoSize = true;
            this.Heading1.BackColor = System.Drawing.Color.Transparent;
            this.Heading1.Font = new System.Drawing.Font("MODERNIZ", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading1.ForeColor = System.Drawing.Color.White;
            this.Heading1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Heading1.Location = new System.Drawing.Point(385, 248);
            this.Heading1.Name = "Heading1";
            this.Heading1.Size = new System.Drawing.Size(511, 86);
            this.Heading1.TabIndex = 0;
            this.Heading1.Text = "welcome\r\n";
            this.Heading1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 102);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is a Digital CV";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_CallToAction);
            this.panel1.Controls.Add(this.Heading1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 680);
            this.panel1.TabIndex = 3;
            // 
            // btn_CallToAction
            // 
            this.btn_CallToAction.BackColor = System.Drawing.Color.White;
            this.btn_CallToAction.BorderRadius = 45;
            this.btn_CallToAction.ClickBackColor = System.Drawing.Color.Black;
            this.btn_CallToAction.FlatAppearance.BorderSize = 0;
            this.btn_CallToAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_CallToAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CallToAction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CallToAction.ForeColor = System.Drawing.Color.Black;
            this.btn_CallToAction.HoverBackColor = System.Drawing.Color.White;
            this.btn_CallToAction.Location = new System.Drawing.Point(410, 493);
            this.btn_CallToAction.Name = "btn_CallToAction";
            this.btn_CallToAction.NormalBackColor = System.Drawing.Color.White;
            this.btn_CallToAction.Size = new System.Drawing.Size(461, 42);
            this.btn_CallToAction.TabIndex = 2;
            this.btn_CallToAction.Text = "See Your CV Now!";
            this.btn_CallToAction.TextColor = System.Drawing.Color.Black;
            this.btn_CallToAction.UseVisualStyleBackColor = false;
            this.btn_CallToAction.Click += new System.EventHandler(this.btn_CallToAction_Click_1);
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital CV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private Label label1;
        private Panel panel1;
        private RoundedButton btn_CallToAction;        
    }
}
