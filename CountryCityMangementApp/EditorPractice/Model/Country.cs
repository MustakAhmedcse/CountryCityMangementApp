using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;

namespace EditorPractice.Model
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }

        public Country()
        {
            
        }

        public Country(int id, string name, string about)
        {
            Id = id;
            Name = name;
            About = about;
        }
    }
}