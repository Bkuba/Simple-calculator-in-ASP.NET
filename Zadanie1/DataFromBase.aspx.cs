using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadanie1
{
    public partial class DataFromBase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShowAllData_Click(object sender, EventArgs e)
        {
            GetData gd = new GetData();
            List<string> CollectData = gd.GetMany();

            foreach (var item in CollectData)
            {
                tbAllData.Text = tbAllData.Text + " " + item.ToString() + "\n";
            }
        }

        protected void btnNumOfEntries_Click(object sender, EventArgs e)
        {
            Response.Redirect("NumOfEntries.aspx");
        }

        protected void btnLatesEntry_Click(object sender, EventArgs e)
        {
            Response.Redirect("LatestEnterWebSite.aspx");
        }
    }
}