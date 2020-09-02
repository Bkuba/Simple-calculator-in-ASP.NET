using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadanie1
{
    public partial class NumOfEntries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData gd = new GetData();
            int numOfData = gd.GetValue();

            labNumOfEntries.Text = numOfData.ToString();
        }
    }
}