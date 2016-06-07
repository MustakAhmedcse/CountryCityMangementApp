using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EditorPractice.DAL;
using EditorPractice.Model;

namespace EditorPractice.MLL
{
    public class CountryManager
    {
       CountryGateway aCountryCityGatwey=new CountryGateway();

        public void InsertCity(Country aCity)
        {
            aCountryCityGatwey.InsertCountry(aCity);
        }

        public List<Country> GetAllCity()
        {
            return aCountryCityGatwey.GetAllCountry();
        }

        public List<Country> GetAllCountryName()
        {
            return aCountryCityGatwey.GetAllCountryName();
        }
    }
}