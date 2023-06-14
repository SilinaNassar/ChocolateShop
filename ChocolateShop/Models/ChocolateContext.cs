using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace ChocolateShop.Models
{
    public class ChocolateContext: DbContext
    {

        public DbSet<Chocolate> Chocolates { get; set; }

        public ChocolateContext():base("name=ChocolateDBConn")
        {

        }
    }
}