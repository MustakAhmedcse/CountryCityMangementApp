using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EditorPractice.DAL;
using EditorPractice.Model;

namespace EditorPractice.MLL
{
    public class CityManager
    {
        CityGateway aCityGateway=new CityGateway();
        CountryManager aCountryManager=new CountryManager();

        public void InsertCity(City aCity)
        {
           aCityGateway.InsertCity(aCity);
        }

        public List<Country> GetAllCountryName()
        {
            return aCountryManager.GetAllCountryName();
        }

        public List<EntryCityViewModel> ShowEntryCityViews()
        {
            return aCityGateway.ShowEntryCityViews();
        }

        public List<ViewCitiesViewModel> ShowAllCityAndCountry()
        {
            return aCityGateway.ShowAllCityAndCountry();
        }

        public List<ViewCitiesViewModel> SeacrhResultForCountryInViewCity(string searchItem)
        {
            return aCityGateway.SeacrhResultForCountryInViewCity(searchItem);
        }

        public List<ViewCitiesViewModel> SeacrhResultForCityInViewCity(string searchItem)
        {
            return aCityGateway.SeacrhResultForCityInViewCity(searchItem);
        }
    }
}