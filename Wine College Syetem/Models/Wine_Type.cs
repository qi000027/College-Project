using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wine_Collection.Models
{
    public class Wine_Type
    {
        public static List<Wine> GetAvailableWines()
        {
            List<Wine> wines = new List<Wine>();

            Wine wine = new Wine("451336", "Tom Gore", "Cabernet Sauvignon Blend", 2015);
            wine.Category = "Red";
            wines.Add(wine);

            wine = new Wine("13686", "Bread & Butter", "Pinot Noir", 2009);
            wine.Category = "Red";
            wines.Add(wine);

            wine = new Wine("580183", "Blu Giovello", "Pinot Grigio", 2018);
            wine.Category = "White";
            wines.Add(wine);

            wine = new Wine("35386", "Kim Crawford", "Sauvignon Blanc", 2020);
            wine.Category = "White";
            wines.Add(wine);

            wine = new Wine("342584", "Miraval Rosé", "Grenache", 2022);
            wine.Category = "Rose";
            wines.Add(wine);

            wine = new Wine("325076", "Caves d'Esclans", "Whispering Angel Rosé", 2022);
            wine.Category = "Rose";
            wines.Add(wine);

            return wines;
        }

        public static Wine GetWineByCode(string wineCode)
        {
            foreach (Wine c in GetAvailableWines())
            {
                if (c.WineCode == wineCode)
                {
                    return c;
                }
            }
            return null;
        }
    }
}