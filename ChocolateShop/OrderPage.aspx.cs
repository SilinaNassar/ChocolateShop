
using ChocolateShop.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChocolateShop.Logic;

namespace ChocolateShop
{
    public partial class OrderPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            String rowId = Request.QueryString["chococode"];
            int id;
            if(!string.IsNullOrEmpty(rowId) && int.TryParse(rowId,out id)){
                using(ChocolateOrder order = new ChocolateOrder())
                {
                    order.Order(id);
                }

            }
            else
            {

            }
            Response.Redirect("ChocolateList.aspx");

        }
    }
}