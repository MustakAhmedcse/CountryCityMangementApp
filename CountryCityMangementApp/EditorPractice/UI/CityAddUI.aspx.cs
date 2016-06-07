using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EditorPractice.MLL;
using EditorPractice.Model;

namespace EditorPractice
{
    public partial class CityAddUI : System.Web.UI.Page
    {
        CityManager aCityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 LoodCountryDropDownList();
            }
            LoodGridView();
        }

        private void LoodGridView()
        {
            showCityGridView.DataSource = aCityManager.ShowEntryCityViews();
            showCityGridView.DataBind();
        }

        private void LoodCountryDropDownList()
        {
            List<Country> aCountryList = aCityManager.GetAllCountryName();
            countryDropDownList.DataSource = aCountryList;
            countryDropDownList.DataValueField = "Id";
            countryDropDownList.DataTextField = "Name";
            countryDropDownList.DataBind();
        }


        protected void saveButton_Click(object sender, EventArgs e)
        {

            City anewCity = new City();
            anewCity.Name = cityNameTextBox.Text;
            anewCity.About = Request.Form["edit"];
            anewCity.NoOfDwellors = Convert.ToInt32(noOfDwallorsTextBox.Text);
            anewCity.Location = locationTextBox.Text;
            anewCity.Weather = weatherTextBox.Text;
            anewCity.CountryId = Convert.ToInt32(countryDropDownList.SelectedItem.Value);
            aCityManager.InsertCity(anewCity);
        }

        protected void calcleButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}