using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wine_Collection.Models;

namespace Wine_Collection
{
    public partial class Collection_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;

            if (!IsPostBack)
            {
                List<Customer> customers;
                customers = (List<Customer>)Session["customers"];
                
                foreach (Customer c in customers)
                {
                    List<Wine> wines = c.StoredWines;
                    foreach (Wine w in wines)
                    {
                        if (c == null) continue;
                        TableRow rowNew = new TableRow();
                        tblWine.Rows.Add(rowNew);

                        TableCell cell = new TableCell();
                        rowNew.Cells.Add(cell);
                        cell.Text = localDate.ToString();

                        cell = new TableCell();
                        rowNew.Cells.Add(cell);
                        cell.Text = c.Id.ToString();

                        cell = new TableCell();
                        rowNew.Cells.Add(cell);
                        cell.Text = c.CusromerName;

                        cell = new TableCell();
                        rowNew.Cells.Add(cell);
                        cell.Text = c.CustomerType;

                        cell = new TableCell();
                        rowNew.Cells.Add(cell);
                        cell.Text = w.WineCode;

                        cell = new TableCell();
                        rowNew.Cells.Add(cell);
                        cell.Text = w.Category;

                        cell = new TableCell();
                        rowNew.Cells.Add(cell);
                        cell.Text = w.Brand;

                        cell = new TableCell();
                        rowNew.Cells.Add(cell);
                        cell.Text = w.Varietal;


                    }
                                        
                }
            }
        }
    }
}