using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadanie1
{
    public partial class LatestEnterWebSite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData gd = new GetData();
            List<string> LatesEnter = gd.GetMany();

            tbLatestEnter.Text = LatesEnter.Last().ToString();

            //foreach (var item in LatesEnter)
            //{
            //    tbLatestEnter.Text = item.Last<>();
            //}
            

        }
    }
}