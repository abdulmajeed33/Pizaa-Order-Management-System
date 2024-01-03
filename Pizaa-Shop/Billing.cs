using System;
using System.Windows.Forms;
using System.Data;

namespace Pizaa_Shop
{
    public partial class Billing
    {
        Functions Con;
        public Billing()
        {
            Con = new Functions();
            InitializeComponent();

            // Add the event subscription here
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            printPreviewDialog1.Document = printDocument1;
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GunaDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        int Key = 0;
        int Price = 0;
        private void GetPrice(int Key)
        {
            string Pizza = "";
            if (Key == 1)
            {
                Pizza = "Small";
            }
            else if (Key == 2)
            {
                Pizza = "Medium";
            }
            else if (Key == 3)
            {
                Pizza = "Large";
            }
            else if (Key == 4)
            {
                Pizza = "Extra Large";
            }

            string Query = "select * from PizzaTbl where Item = '{0}'";
            Query = string.Format(Query, Pizza);
            Console.WriteLine("query>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>",Query);
            try
            {
                DataTable result = Con.GetData(Query);

                if (result.Rows.Count > 0)
                {
                    Price = Convert.ToInt32(result.Rows[0][1].ToString());
                }
                else
                {
                    // Log the error or show a message indicating that no data was found
                    MessageBox.Show("No data found for the specified pizza.");
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        int n = 0;
        int GrdTotal = 0;
        string Items;

        private void GunaButton1_Click(object sender, EventArgs e)
        {
            if (SmallBtn.Checked == true)
            {
                Key = 1;
                Items = "Small Pizza";
            }
            else if (MediumBtn.Checked == true)
            {
                Key = 2;
                Items = "Medium Pizza";
            }
            else if (LargeBtn.Checked == true)
            {
                Key = 3;
                Items = "Large Pizza";

            }
            else if (ExtraLargeBtn.Checked == true)
            {
                Key = 4;
                Items = "Extra Large Large";
            }

            GetPrice(Key);
            int qty = Convert.ToInt32(QtyTb.Text);
            int total = qty * Price;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BILLDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = Items;
            newRow.Cells[2].Value = Price;
            newRow.Cells[3].Value = QtyTb.Text;
            newRow.Cells[4].Value = total;
            BILLDGV.Rows.Add(newRow);

            n++;
            GrdTotal = GrdTotal + total;
            GrdTotalLbl.Text = "Rs " + GrdTotal;
        }

        private void GunaButton3_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
            this.Hide();
        }
        

        private void GunaRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void SmallBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MediumBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LargeBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PrintDocument1_Click_1(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred during printing: {ex.Message}");
                }
            }
        }

        int prodid, prodprice, prodqty, tottal, pos = 70;

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("PIZZA ORDERING", new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Red, new System.Drawing.Point(70));
            pos += 20;
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new System.Drawing.Font("Century Gothic", 10, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Red, new System.Drawing.Point(4,pos));
            pos += 20;
            foreach (DataGridViewRow row in BILLDGV.Rows)
            {
            prodid = Convert.ToInt32(row.Cells["Column1"].Value);
            prodname = "" + row.Cells["Column2"].Value;
            prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
            prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
            tottal = Convert.ToInt32(row.Cells["Column5"].Value);
            e.Graphics.DrawString("" + prodid, new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Blue, new System.Drawing.Point(10, pos));
            e.Graphics.DrawString("" + prodname, new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Blue, new System.Drawing.Point(30, pos));
            e.Graphics.DrawString("" + prodprice, new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Blue, new System.Drawing.Point(115, pos));
            e.Graphics.DrawString("" + prodqty, new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Blue, new System.Drawing.Point(170, pos));
            e.Graphics.DrawString("" + tottal, new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Blue, new System.Drawing.Point(235, pos));
            pos = pos + 20;
            }

            e.Graphics.DrawString("Grand Total: RS" + GrdTotal, new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Red, new System.Drawing.Point(50, pos + 50));
            e.Graphics.DrawString("****************PIZZA***************" + GrdTotal, new System.Drawing.Font("Century Gothic", 12, System.Drawing.FontStyle.Bold), System.Drawing.Brushes.Red, new System.Drawing.Point(10, pos + 85));

            BILLDGV.Rows.Clear();
            BILLDGV.Refresh();
            pos = 100;
            GrdTotal = 0;
            n = 0;
        }
    }
}