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
    public partial class Index : System.Web.UI.Page
    {
        CountryManager aCountryCityManager=new CountryManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
                LoodCountryInGridView();
           
            
        }

        private void LoodCountryInGridView()
        {
            List<Country> aListOfCities = new List<Country>();
            aListOfCities = aCountryCityManager.GetAllCity();
            showCountryGridView.DataSource = aListOfCities;
            showCountryGridView.DataBind();
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Country aCity = new Country();
            aCity.Name = countryNameTextBox.Text;
            aCity.About = Request.Form["edit"];
            aCountryCityManager.InsertCity(aCity);
           
        }

        protected void calcleButton_Click(object sender, EventArgs e)
        {
         Response.Redirect("Index.aspx");
        }

    }
}