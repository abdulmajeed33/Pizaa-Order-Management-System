using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Pizaa_Shop
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Settings : Form
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
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.PizzaCb = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new Guna.UI.WinForms.GunaButton();
            this.Backlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GunaElipse1
            // 
            this.GunaElipse1.Radius = 14;
            this.GunaElipse1.TargetControl = this;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(102, 528);
            this.Panel1.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.Label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label4.Location = new System.Drawing.Point(890, 32);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 35);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "x";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.Label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label1.Location = new System.Drawing.Point(378, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(252, 29);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Pizaa Ordering System";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.Label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label2.Location = new System.Drawing.Point(444, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 29);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Settings";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label3.Location = new System.Drawing.Point(355, 184);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(157, 26);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Select the Pizza";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PizzaCb
            // 
            this.PizzaCb.FormattingEnabled = true;
            this.PizzaCb.Items.AddRange(new object[] {
            "Extra Large",
            "Large",
            "Medium",
            "Small",
            "",
            ""});
            this.PizzaCb.Location = new System.Drawing.Point(360, 216);
            this.PizzaCb.Name = "PizzaCb";
            this.PizzaCb.Size = new System.Drawing.Size(270, 34);
            this.PizzaCb.TabIndex = 12;
            this.PizzaCb.SelectedIndexChanged += new System.EventHandler(this.PizzaCb_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.Label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label5.Location = new System.Drawing.Point(355, 279);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(148, 26);
            this.Label5.TabIndex = 13;
            this.Label5.Text = "Enter the Price";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceTb
            // 
            this.PriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTb.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.PriceTb.Location = new System.Drawing.Point(360, 308);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(270, 31);
            this.PriceTb.TabIndex = 14;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.AnimationHoverSpeed = 0.07F;
            this.SubmitBtn.AnimationSpeed = 0.03F;
            this.SubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.SubmitBtn.BaseColor = System.Drawing.Color.OrangeRed;
            this.SubmitBtn.BorderColor = System.Drawing.Color.Black;
            this.SubmitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SubmitBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Image = null;
            this.SubmitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SubmitBtn.Location = new System.Drawing.Point(377, 384);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.OnHoverBaseColor = System.Drawing.Color.Red;
            this.SubmitBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SubmitBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SubmitBtn.OnHoverImage = null;
            this.SubmitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SubmitBtn.Radius = 15;
            this.SubmitBtn.Size = new System.Drawing.Size(216, 42);
            this.SubmitBtn.TabIndex = 15;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Backlbl
            // 
            this.Backlbl.AutoSize = true;
            this.Backlbl.BackColor = System.Drawing.Color.White;
            this.Backlbl.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backlbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.Backlbl.Location = new System.Drawing.Point(144, 478);
            this.Backlbl.Name = "Backlbl";
            this.Backlbl.Size = new System.Drawing.Size(54, 26);
            this.Backlbl.TabIndex = 16;
            this.Backlbl.Text = "Back";
            this.Backlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Backlbl.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 528);
            this.Controls.Add(this.Backlbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.PizzaCb);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Guna.UI.WinForms.GunaElipse GunaElipse1;
        internal Panel Panel1;
        internal ComboBox PizzaCb;
        internal Label Label3;
        internal Label Label2;
        internal Label Label4;
        internal Label Label1;
        internal Label Label5;
        internal TextBox PriceTb;
        internal Label Backlbl;
        internal Guna.UI.WinForms.GunaButton SubmitBtn;
    }
}