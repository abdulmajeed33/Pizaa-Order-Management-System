using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Pizaa_Shop
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Billing : Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.GunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.GunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.GunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ExtraLargeBtn = new Guna.UI.WinForms.GunaRadioButton();
            this.MediumBtn = new Guna.UI.WinForms.GunaRadioButton();
            this.LargeBtn = new Guna.UI.WinForms.GunaRadioButton();
            this.SmallBtn = new Guna.UI.WinForms.GunaRadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.OrderBtn = new Guna.UI.WinForms.GunaButton();
            this.BILLDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label3 = new System.Windows.Forms.Label();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.GrdTotalLbl = new System.Windows.Forms.Label();
            this.SettingsBtn = new Guna.UI.WinForms.GunaButton();
            this.PrintBtn = new Guna.UI.WinForms.GunaButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Label4 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BILLDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaElipse1
            // 
            this.GunaElipse1.TargetControl = this;
            // 
            // GunaElipse2
            // 
            this.GunaElipse2.TargetControl = this;
            // 
            // GunaElipse3
            // 
            this.GunaElipse3.Radius = 15;
            this.GunaElipse3.TargetControl = this;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(139, 822);
            this.Panel1.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.Label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label2.Location = new System.Drawing.Point(179, 27);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(394, 29);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Pizza Ordering Management System";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.ExtraLargeBtn);
            this.Panel2.Controls.Add(this.MediumBtn);
            this.Panel2.Controls.Add(this.LargeBtn);
            this.Panel2.Controls.Add(this.SmallBtn);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(247, 96);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(462, 340);
            this.Panel2.TabIndex = 4;
            // 
            // ExtraLargeBtn
            // 
            this.ExtraLargeBtn.BaseColor = System.Drawing.SystemColors.Control;
            this.ExtraLargeBtn.CheckedOffColor = System.Drawing.Color.Gray;
            this.ExtraLargeBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExtraLargeBtn.FillColor = System.Drawing.Color.White;
            this.ExtraLargeBtn.Location = new System.Drawing.Point(37, 208);
            this.ExtraLargeBtn.MinimumSize = new System.Drawing.Size(400, 0);
            this.ExtraLargeBtn.Name = "ExtraLargeBtn";
            this.ExtraLargeBtn.Padding = new System.Windows.Forms.Padding(3);
            this.ExtraLargeBtn.Size = new System.Drawing.Size(400, 20);
            this.ExtraLargeBtn.TabIndex = 4;
            this.ExtraLargeBtn.Text = "Extra Large";
            this.ExtraLargeBtn.CheckedChanged += new System.EventHandler(this.GunaRadioButton4_CheckedChanged);
            // 
            // MediumBtn
            // 
            this.MediumBtn.BaseColor = System.Drawing.SystemColors.Control;
            this.MediumBtn.CheckedOffColor = System.Drawing.Color.Gray;
            this.MediumBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.MediumBtn.FillColor = System.Drawing.Color.White;
            this.MediumBtn.Location = new System.Drawing.Point(37, 137);
            this.MediumBtn.MinimumSize = new System.Drawing.Size(400, 0);
            this.MediumBtn.Name = "MediumBtn";
            this.MediumBtn.Size = new System.Drawing.Size(400, 20);
            this.MediumBtn.TabIndex = 3;
            this.MediumBtn.Text = "Medium";
            this.MediumBtn.CheckedChanged += new System.EventHandler(this.MediumBtn_CheckedChanged);
            // 
            // LargeBtn
            // 
            this.LargeBtn.BaseColor = System.Drawing.SystemColors.Control;
            this.LargeBtn.CheckedOffColor = System.Drawing.Color.Gray;
            this.LargeBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LargeBtn.FillColor = System.Drawing.Color.White;
            this.LargeBtn.Location = new System.Drawing.Point(37, 170);
            this.LargeBtn.MaximumSize = new System.Drawing.Size(400, 0);
            this.LargeBtn.MinimumSize = new System.Drawing.Size(400, 0);
            this.LargeBtn.Name = "LargeBtn";
            this.LargeBtn.Padding = new System.Windows.Forms.Padding(3);
            this.LargeBtn.Size = new System.Drawing.Size(400, 28);
            this.LargeBtn.TabIndex = 2;
            this.LargeBtn.Text = "Large";
            this.LargeBtn.CheckedChanged += new System.EventHandler(this.LargeBtn_CheckedChanged);
            // 
            // SmallBtn
            // 
            this.SmallBtn.BaseColor = System.Drawing.SystemColors.Control;
            this.SmallBtn.CheckedOffColor = System.Drawing.Color.Gray;
            this.SmallBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SmallBtn.FillColor = System.Drawing.Color.White;
            this.SmallBtn.Location = new System.Drawing.Point(37, 103);
            this.SmallBtn.MinimumSize = new System.Drawing.Size(400, 0);
            this.SmallBtn.Name = "SmallBtn";
            this.SmallBtn.Size = new System.Drawing.Size(400, 20);
            this.SmallBtn.TabIndex = 1;
            this.SmallBtn.Text = "Small";
            this.SmallBtn.CheckedChanged += new System.EventHandler(this.SmallBtn_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.Label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label1.Location = new System.Drawing.Point(32, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(237, 29);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Please Select a Pizza";
            // 
            // OrderBtn
            // 
            this.OrderBtn.AnimationHoverSpeed = 0.07F;
            this.OrderBtn.AnimationSpeed = 0.03F;
            this.OrderBtn.BackColor = System.Drawing.Color.Transparent;
            this.OrderBtn.BaseColor = System.Drawing.Color.OrangeRed;
            this.OrderBtn.BorderColor = System.Drawing.Color.Black;
            this.OrderBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OrderBtn.FocusedColor = System.Drawing.Color.Empty;
            this.OrderBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OrderBtn.ForeColor = System.Drawing.Color.White;
            this.OrderBtn.Image = null;
            this.OrderBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.OrderBtn.Location = new System.Drawing.Point(375, 548);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.OnHoverBaseColor = System.Drawing.Color.Red;
            this.OrderBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.OrderBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.OrderBtn.OnHoverImage = null;
            this.OrderBtn.OnPressedColor = System.Drawing.Color.Black;
            this.OrderBtn.Radius = 15;
            this.OrderBtn.Size = new System.Drawing.Size(216, 42);
            this.OrderBtn.TabIndex = 7;
            this.OrderBtn.Text = "Add to Your Order";
            this.OrderBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrderBtn.Click += new System.EventHandler(this.GunaButton1_Click);
            // 
            // BILLDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.BILLDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.BILLDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BILLDGV.BackgroundColor = System.Drawing.Color.White;
            this.BILLDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BILLDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BILLDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BILLDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.BILLDGV.ColumnHeadersHeight = 28;
            this.BILLDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BILLDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.BILLDGV.EnableHeadersVisualStyles = false;
            this.BILLDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.BILLDGV.Location = new System.Drawing.Point(756, 96);
            this.BILLDGV.Name = "BILLDGV";
            this.BILLDGV.RowHeadersVisible = false;
            this.BILLDGV.RowHeadersWidth = 51;
            this.BILLDGV.RowTemplate.Height = 24;
            this.BILLDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BILLDGV.Size = new System.Drawing.Size(699, 518);
            this.BILLDGV.TabIndex = 8;
            this.BILLDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Orange;
            this.BILLDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(225)))), ((int)(((byte)(184)))));
            this.BILLDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BILLDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BILLDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BILLDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BILLDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BILLDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(171)))));
            this.BILLDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.BILLDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BILLDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BILLDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BILLDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BILLDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.BILLDGV.ThemeStyle.ReadOnly = false;
            this.BILLDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(235)))), ((int)(((byte)(207)))));
            this.BILLDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BILLDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BILLDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.BILLDGV.ThemeStyle.RowsStyle.Height = 24;
            this.BILLDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(189)))), ((int)(((byte)(97)))));
            this.BILLDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.BILLDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GunaDataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pizza";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(381, 466);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(91, 26);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Quantity";
            // 
            // QtyTb
            // 
            this.QtyTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QtyTb.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.QtyTb.Location = new System.Drawing.Point(386, 497);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(120, 31);
            this.QtyTb.TabIndex = 10;
            // 
            // GrdTotalLbl
            // 
            this.GrdTotalLbl.AutoSize = true;
            this.GrdTotalLbl.Location = new System.Drawing.Point(1064, 700);
            this.GrdTotalLbl.Name = "GrdTotalLbl";
            this.GrdTotalLbl.Size = new System.Drawing.Size(108, 26);
            this.GrdTotalLbl.TabIndex = 11;
            this.GrdTotalLbl.Text = "GrdTotalBl";
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.AnimationHoverSpeed = 0.07F;
            this.SettingsBtn.AnimationSpeed = 0.03F;
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.BaseColor = System.Drawing.Color.Orange;
            this.SettingsBtn.BorderColor = System.Drawing.Color.Black;
            this.SettingsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Image = null;
            this.SettingsBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.SettingsBtn.Location = new System.Drawing.Point(247, 738);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.OnHoverBaseColor = System.Drawing.Color.Red;
            this.SettingsBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SettingsBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.SettingsBtn.OnHoverImage = null;
            this.SettingsBtn.OnPressedColor = System.Drawing.Color.Black;
            this.SettingsBtn.Radius = 12;
            this.SettingsBtn.Size = new System.Drawing.Size(175, 28);
            this.SettingsBtn.TabIndex = 13;
            this.SettingsBtn.Text = "Set The Price";
            this.SettingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SettingsBtn.Click += new System.EventHandler(this.GunaButton3_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.AnimationHoverSpeed = 0.07F;
            this.PrintBtn.AnimationSpeed = 0.03F;
            this.PrintBtn.BackColor = System.Drawing.Color.Transparent;
            this.PrintBtn.BaseColor = System.Drawing.Color.OrangeRed;
            this.PrintBtn.BorderColor = System.Drawing.Color.Black;
            this.PrintBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PrintBtn.FocusedColor = System.Drawing.Color.Empty;
            this.PrintBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PrintBtn.ForeColor = System.Drawing.Color.White;
            this.PrintBtn.Image = null;
            this.PrintBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.PrintBtn.Location = new System.Drawing.Point(1015, 738);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.OnHoverBaseColor = System.Drawing.Color.Red;
            this.PrintBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.PrintBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.PrintBtn.OnHoverImage = null;
            this.PrintBtn.OnPressedColor = System.Drawing.Color.Black;
            this.PrintBtn.Radius = 15;
            this.PrintBtn.Size = new System.Drawing.Size(216, 42);
            this.PrintBtn.TabIndex = 14;
            this.PrintBtn.Text = "Print Your Order";
            this.PrintBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrintBtn.Click += new System.EventHandler(this.PrintDocument1_Click_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.Label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.Label4.Location = new System.Drawing.Point(1503, 27);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 35);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "x";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Blue;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(448, 738);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Red;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 12;
            this.gunaButton1.Size = new System.Drawing.Size(175, 28);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.Text = "Logout";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click_1);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1544, 822);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.GrdTotalLbl);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.BILLDGV);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BILLDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal Guna.UI.WinForms.GunaElipse GunaElipse1;
        internal Panel Panel1;
        internal Guna.UI.WinForms.GunaElipse GunaElipse2;
        internal Guna.UI.WinForms.GunaElipse GunaElipse3;
        internal Label Label2;
        internal Panel Panel2;
        internal Guna.UI.WinForms.GunaRadioButton ExtraLargeBtn;
        internal Guna.UI.WinForms.GunaRadioButton MediumBtn;
        internal Guna.UI.WinForms.GunaRadioButton LargeBtn;
        internal Guna.UI.WinForms.GunaRadioButton SmallBtn;
        internal Label Label1;
        internal Guna.UI.WinForms.GunaButton OrderBtn;
        internal Guna.UI.WinForms.GunaDataGridView BILLDGV;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column5;
        internal Label Label3;
        internal Guna.UI.WinForms.GunaButton SettingsBtn;
        internal Label GrdTotalLbl;
        internal TextBox QtyTb;
        internal Guna.UI.WinForms.GunaButton PrintBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        internal Label Label4;
        internal Guna.UI.WinForms.GunaButton gunaButton1;
    }
}