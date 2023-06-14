using ChocolateShop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChocolateShop
{
    public partial class StockListaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         
        public List<Chocolate> GrdStock_GetData()
        {
            var dbcontext = new ChocolateContext();
            var query=(from DataRow in dbcontext.Chocolates
                       where DataRow.Stock>=0
                       select DataRow).ToList();
            return query;
        }
    }
}