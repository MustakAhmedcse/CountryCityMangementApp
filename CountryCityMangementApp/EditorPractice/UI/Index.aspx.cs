using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EditorPractice.DAL
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void countryAddButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CountryAddUI.aspx");
        }

        protected void cityAddButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CityAddUI.aspx");
        }

        protected void cityViewButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCities.aspx");
        }
    }
}