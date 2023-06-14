using ChocolateShop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ChocolateShop.Logic
{
    public class ChocolateOrder : IDisposable
    {

        private ChocolateContext dbcontext= new ChocolateContext();

        public void Order(int id)
        {
            var chocolate = (from DataRow in dbcontext.Chocolates
                             where DataRow.ChocolateId == id
                             select DataRow).SingleOrDefault();

            chocolate.Stock--;
            dbcontext.SaveChanges();
        }
        public void Dispose()
        {
            if (dbcontext != null)
            {
                dbcontext.Dispose();
                dbcontext = null;   
            }
        }

    }
}