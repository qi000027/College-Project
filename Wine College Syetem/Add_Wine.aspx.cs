using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wine_Collection.Models;

namespace Wine_Collection
{
    public partial class Add_Wine : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                foreach (Wine c in Wine_Type.GetAvailableWines())
                {
                    string ss = c.Brand + " - " + c.Varietal + " - " + c.Year;
                    chklst.Items.Add(new ListItem(ss, c.WineCode));
                }

                List<Customer> customers;
                customers = (List<Customer>)Session["customers"];

                foreach (Customer customer in customers)
                {
                    CustomerList.Items.Add(new ListItem(customer.ToString(), Convert.ToString(customer.Id)));
                }
            }

        }

        public void RadioButtonSelectedIndexChanged(object sender, System.EventArgs e)
        {
            //Add index validation to each radio button
            List<int> indexList = new List<int>();
            if (RadioButtonList1.SelectedValue == this.r1.Value) //Red Wine
            {
                indexList.AddRange(new int[] { 2, 3, 4, 5 });
            }
            else if (RadioButtonList1.SelectedValue == this.r2.Value) //White Wine
            {
                indexList.AddRange(new int[] { 0, 1, 4, 5 });
            }
            else if (RadioButtonList1.SelectedValue == this.r3.Value) //Rose Wine
            {
                indexList.AddRange(new int[] { 0, 1, 2, 3 });
            }

            //Check redio if it is in indexList and add disable
            for (int i = 0; i < chklst.Items.Count; i++)
            {
                ListItem item = chklst.Items[i];
                bool isEnabled = !indexList.Contains(i);
                item.Enabled = isEnabled;
                if (!isEnabled)
                {
                    item.Attributes.CssStyle.Add("color", "lightgray");
                    item.Selected = false;
                }
                else item.Attributes.CssStyle.Remove("color");
            }

        }

        protected void save_Click(object sender, System.EventArgs e)
        {
            secceedMsg.Text = "";
            ErrorMsg.Text = "";

            List<Wine> wList = new List<Wine>();

            
            foreach (ListItem lstItem in chklst.Items)
            {
                if (lstItem.Selected == true)
                {
                    Wine selectedWine = Wine_Type.GetWineByCode(lstItem.Value);
                    wList.Add(selectedWine);
                }
            }
            Session["wList"] = wList;

            int selectedId = Convert.ToInt32(CustomerList.SelectedValue);
            List<Customer> customers = (List<Customer>)Session["customers"];

            //Add the selected wine to selectedWine
            foreach (Customer customer in customers)
            {
                if (customer.Id == selectedId)
                {
                    customer.StoreWines(wList);
                }
            }

            secceedMsg.Text = "Stored succeed!";


        }

        protected void Change_Customer(object sender, EventArgs e)
        {
            secceedMsg.Text = "";

            int selectedId = Convert.ToInt32(CustomerList.SelectedValue);
            List<Customer> customers = (List<Customer>)Session["customers"];

            foreach (ListItem wineItem in chklst.Items)
            {
                wineItem.Selected = false;
            }

            foreach (Customer customer in customers)
            {
                if (customer.Id == selectedId)
                {

                    List<Wine> wines = customer.StoredWines;
                    foreach (Wine wine in wines)
                    {
                        foreach (ListItem wineItem in chklst.Items)
                        {
                            if (wine.WineCode == wineItem.Value)
                            {
                                wineItem.Selected = true;
                            }
                        }
                    }

                    break;
                }
            }
        }

    }
}