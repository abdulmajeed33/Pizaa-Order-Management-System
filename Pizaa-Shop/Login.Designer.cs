using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Pizaa_Shop
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Login : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.UsernameTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.LoginBtn = new Guna.UI.WinForms.GunaButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GunaElipse1
            // 
            this.GunaElipse1.Radius = 15;
            this.GunaElipse1.TargetControl = this;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(200, 495);
            this.Panel1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.Label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label1.Location = new System.Drawing.Point(345, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(252, 29);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Pizaa Ordering System";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(345, 224);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(102, 26);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Username";
            // 
            // UsernameTb
            // 
            this.UsernameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTb.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.UsernameTb.Location = new System.Drawing.Point(349, 255);
            this.UsernameTb.Name = "UsernameTb";
            this.UsernameTb.Size = new System.Drawing.Size(220, 31);
            this.UsernameTb.TabIndex = 3;
            this.UsernameTb.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // PasswordTb
            // 
            this.PasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTb.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.PasswordTb.Location = new System.Drawing.Point(349, 332);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(220, 31);
            this.PasswordTb.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(345, 301);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 26);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Password";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.AnimationHoverSpeed = 0.07F;
            this.LoginBtn.AnimationSpeed = 0.03F;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BaseColor = System.Drawing.Color.OrangeRed;
            this.LoginBtn.BorderColor = System.Drawing.Color.Black;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.FocusedColor = System.Drawing.Color.Empty;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Image = null;
            this.LoginBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.LoginBtn.Location = new System.Drawing.Point(379, 398);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnHoverBaseColor = System.Drawing.Color.Red;
            this.LoginBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.LoginBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnHoverImage = null;
            this.LoginBtn.OnPressedColor = System.Drawing.Color.Black;
            this.LoginBtn.Radius = 15;
            this.LoginBtn.Size = new System.Drawing.Size(160, 42);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.Click += new System.EventHandler(this.GunaButton1_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.Label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label4.Location = new System.Drawing.Point(699, 35);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 35);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "x";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(757, 495);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.UsernameTb);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Guna.UI.WinForms.GunaElipse GunaElipse1;
        internal Panel Panel1;
        internal Label Label1;
        internal TextBox UsernameTb;
        internal Label Label2;
        internal TextBox PasswordTb;
        internal Label Label3;
        internal Guna.UI.WinForms.GunaButton LoginBtn;
        internal Label Label4;

    }
}