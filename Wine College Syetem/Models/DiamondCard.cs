using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wine_Collection.Models
{
    public class DiamondCard : Customer
    {
        public DiamondCard(string name, string type)
            : base(name, type)
        {

        }

        public override string ToString()
        {
            string customer = Id + " - " + CusromerName + " (Diamond)";
            return customer;
        }
    }
}