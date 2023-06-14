using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace ChocolateShop.Models
{
    public class ChocolateLoad :DropCreateDatabaseIfModelChanges<ChocolateContext>
    {
        protected override void Seed(ChocolateContext context)
        {
            foreach(var item in ReadChocolate())
            {
                context.Chocolates.Add(item);
            }
        }

        private static List<Chocolate> ReadChocolate()
        {
            StreamReader streamReader = File.OpenText(HttpContext.Current.Server.MapPath("~/App_Data/chocolates.txt"));


            List<Chocolate> chocolates = new List<Chocolate>();
            Chocolate chocolate;
            string[] datarow;

            while (!streamReader.EndOfStream)
            {
                datarow = streamReader.ReadLine().Split(';');

                chocolate = new Chocolate()
                {
                    ChocolateName = datarow[0],
                    Stock = int.Parse(datarow[1]),
                    Image = datarow[2],

                };
                chocolates.Add(chocolate);
            }

            streamReader.Close();
            return chocolates;
        }
    }
}