using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EditorPractice.MLL;

namespace EditorPractice.UI
{
    public partial class ViewCities1 : System.Web.UI.Page
    {
        CityManager aCityManager=new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoodCountryNameDropDownList();
            }
            LoodGridView();
        }

        private void LoodGridView()
        {
            viewCityGridView.DataSource = aCityManager.ShowAllCityAndCountry();
            viewCityGridView.DataBind();
        }

        private void LoodCountryNameDropDownList()
        {
            countryNameDropDownList.DataSource = aCityManager.GetAllCountryName();
            countryNameDropDownList.DataValueField = "Id";
            countryNameDropDownList.DataTextField = "Name";
            countryNameDropDownList.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            
            if (cityNameRadioButton.Checked)
            {
                string searchItem = cityNameTextBox.Text;
                viewCityGridView.DataSource = aCityManager.SeacrhResultForCityInViewCity(searchItem);
                viewCityGridView.DataBind();
            }
            if (countryNameRadioButton.Checked)
            {
                string searchItem = countryNameDropDownList.SelectedItem.Text;
                viewCityGridView.DataSource = aCityManager.SeacrhResultForCountryInViewCity(searchItem);
                viewCityGridView.DataBind();
            }
        }
    }
}