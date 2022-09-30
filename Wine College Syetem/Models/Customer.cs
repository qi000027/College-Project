using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wine_Collection.Models
{
    public class Customer
    {
        public int Id { get; }
        public string CusromerName { get; }
        public string CustomerType { get; }

        
        public List<Wine> StoredWines { get; set; }
        public Customer(string name, string type)
        {
            Id = new Random().Next(100000, 999999);
            CusromerName = name;
            CustomerType = type;
            StoredWines = new List<Wine>();
        }
        public virtual void StoreWines(List<Wine> storedWines)
        {
            StoredWines.Clear();

            foreach (var wine in storedWines)
            {
                StoredWines.Add(wine);
            }
        }
    }
}