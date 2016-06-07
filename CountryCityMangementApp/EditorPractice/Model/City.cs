using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EditorPractice.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public int NoOfDwellors { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int CountryId { get; set; }

        public City(int id, string name, string about, int noOfDwellors, string location, string weather, int countryId)
        {
            Id = id;
            Name = name;
            About = about;
            NoOfDwellors = noOfDwellors;
            Location = location;
            Weather = weather;
            CountryId = countryId;
        }

        public City()
        {
            
        }
    }
}