using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wine_Collection.Models;

namespace Wine_Collection
{
    public partial class Add_Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["customers"] == null) Session["customers"] = new List<Customer>();

            
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string type = customerType.SelectedValue;
            string name = customerName.Text;

            List<Customer> customers;

            if (customerName.Text != "" && customerType.SelectedValue != "0")
            {
                if (Session["customers"] != null)
                {
                    customers = Session["customers"] as List<Customer>;
                }
                else
                {
                    customers = new List<Customer>();
                }


                if (type == "GoldCard")
                {
                    GoldCard newCustomer = new GoldCard(name, type);
                    customers.Add(newCustomer);
                }

                if (type == "PlatinumCard")
                {
                    PlatinumCard newCustomer = new PlatinumCard(name, type);
                    customers.Add(newCustomer);
                }

                if (type == "DiamondCard")
                {
                    DiamondCard newCustomer = new DiamondCard(name, type);
                    customers.Add(newCustomer);
                }

                Session["customers"] = customers;

                foreach (Customer customer in customers)
                {
                    TableRow rowNew = new TableRow();
                    TableCell cell = new TableCell();

                    tblCustomers.Rows.Add(rowNew);

                    rowNew.Cells.Add(cell);
                    cell.Text = customer.Id.ToString();

                    cell = new TableCell();
                    rowNew.Cells.Add(cell);
                    cell.Text = customer.CusromerName;

                }

                customerName.Text = "";
                customerType.SelectedValue = "0";


            }
        }
    }
}