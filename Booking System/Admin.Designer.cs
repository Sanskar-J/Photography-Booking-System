﻿namespace Booking_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminTb = new System.Windows.Forms.TextBox();
            this.logButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AdminLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 70);
            this.panel1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Bebas Neue", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(363, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 56);
            this.label12.TabIndex = 2;
            this.label12.Text = "X";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label12.UseCompatibleTextRendering = true;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 24.21818F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Login";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // AdminTb
            // 
            this.AdminTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminTb.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTb.Location = new System.Drawing.Point(148, 93);
            this.AdminTb.Name = "AdminTb";
            this.AdminTb.PasswordChar = '*';
            this.AdminTb.Size = new System.Drawing.Size(204, 33);
            this.AdminTb.TabIndex = 7;
            // 
            // logButton
            // 
            this.logButton.ActiveBorderThickness = 1;
            this.logButton.ActiveCornerRadius = 20;
            this.logButton.ActiveFillColor = System.Drawing.Color.Black;
            this.logButton.ActiveForecolor = System.Drawing.Color.White;
            this.logButton.ActiveLineColor = System.Drawing.Color.DimGray;
            this.logButton.BackColor = System.Drawing.Color.White;
            this.logButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logButton.BackgroundImage")));
            this.logButton.ButtonText = "LOGIN";
            this.logButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.ForeColor = System.Drawing.Color.Black;
            this.logButton.IdleBorderThickness = 1;
            this.logButton.IdleCornerRadius = 20;
            this.logButton.IdleFillColor = System.Drawing.Color.White;
            this.logButton.IdleForecolor = System.Drawing.Color.Black;
            this.logButton.IdleLineColor = System.Drawing.Color.Black;
            this.logButton.Location = new System.Drawing.Point(108, 140);
            this.logButton.Margin = new System.Windows.Forms.Padding(5);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(181, 41);
            this.logButton.TabIndex = 9;
            this.logButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logButton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // AdminLogin
            // 
            this.AdminLogin.AutoSize = true;
            this.AdminLogin.BackColor = System.Drawing.Color.Black;
            this.AdminLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.74545F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogin.ForeColor = System.Drawing.Color.White;
            this.AdminLogin.Location = new System.Drawing.Point(148, 186);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(90, 27);
            this.AdminLogin.TabIndex = 10;
            this.AdminLogin.Text = "home login";
            this.AdminLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            this.AdminLogin.MouseLeave += new System.EventHandler(this.AdminLogin_MouseLeave);
            this.AdminLogin.MouseHover += new System.EventHandler(this.AdminLogin_MouseHover);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 236);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 logButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdminTb;
        private System.Windows.Forms.Label AdminLogin;
    }
}