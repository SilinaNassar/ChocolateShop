using ChocolateShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChocolateShop
{
    public partial class ChocolateList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        public IQueryable<Chocolate> ChocolateList_GetData()
        {
            var dbContext = new ChocolateContext();
            IQueryable<Chocolate> query = dbContext.Chocolates;
            return query;

        }

        protected void chocList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}