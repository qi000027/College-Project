using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wine_Collection.Models
{
    public class Wine
    {        
        public string WineCode { get; }

        public string Brand { get; }

        public string Varietal { get; }

        public string Category { get; set ; }

        public int Year { get; }

        public Wine(string wineCode, string brand, string varietal, int year)
        {
            WineCode = wineCode;
            Brand = brand;
            Year = year;
            Varietal = varietal;
        }

        
    }
}