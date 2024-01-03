using System;

namespace Pizaa_Shop
{
    public partial class Settings
    {
        Functions Con;
        public Settings()
        {
            InitializeComponent();
            Con = new Functions();
        }


        private void Label6_Click(object sender, EventArgs e)
        {
            var obj = new Billing();
            obj.Show();
            Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string Key;
            try
            {
                int Pr = Convert.ToInt32(PriceTb.Text);
              if(PizzaCb.SelectedIndex == -1)
                {
                    System.Windows.Forms.MessageBox.Show("Please Select a Pizza !!");
                }else if (PizzaCb.SelectedIndex == 0)
                {
                    Key = "Extra Large";
                    string Query = "Update PizzaTbl set Price = {0} where item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    System.Windows.Forms.MessageBox.Show("Price Updated !!!");
                }
                else if(PizzaCb.SelectedIndex == 1)
                {
                    Key = "Large";
                    string Query = "Update PizzaTbl set Price = {0} where item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    System.Windows.Forms.MessageBox.Show("Price Updated !!!");
                }
                else if (PizzaCb.SelectedIndex == 2)
                {
                    Key = "Medium";
                    string Query = "Update PizzaTbl set Price = {0} where item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    System.Windows.Forms.MessageBox.Show("Price Updated !!!");
                }
                else if (PizzaCb.SelectedIndex == 3)
                {
                    Key = "Small";
                    string Query = "Update PizzaTbl set Price = {0} where item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    System.Windows.Forms.MessageBox.Show("Price Updated !!!");
                }
            }
            catch(Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message);
            }
        }

        private void PizzaCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}