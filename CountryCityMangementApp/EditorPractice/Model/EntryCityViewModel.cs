using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EditorPractice.Model
{
    public class EntryCityViewModel
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int NoOfDwellers { get; set; }
        public string CountryName { get; set; }

        public EntryCityViewModel()
        {
            
        }

        public EntryCityViewModel(int id, string cityName, int noOfDwellers, string countryName)
        {
            Id = id;
            CityName = cityName;
            NoOfDwellers = noOfDwellers;
            CountryName = countryName;
        }
    }
}