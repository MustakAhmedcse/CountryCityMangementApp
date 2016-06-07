using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EditorPractice.Model;

namespace EditorPractice.DAL
{
    public class CityGateway
    {
        private string connectionString = @"Server=MUSTAK-PC\SQLEXPRESS;Database=CountryCiry_DB;Integrated Security=true";
        public void InsertCity(City aCity)
        {
            string query = "INSERT INTO Citys values(@name,@about,@noOfDwellers,@location,@weather,@countryId)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            command.Parameters.Clear();
            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = aCity.Name;
            command.Parameters.Add("about", SqlDbType.VarChar);
            command.Parameters["about"].Value = aCity.About;
            command.Parameters.Add("noOfDwellers", SqlDbType.Int);
            command.Parameters["noOfDwellers"].Value = aCity.NoOfDwellors;
            command.Parameters.Add("location", SqlDbType.VarChar);
            command.Parameters["location"].Value = aCity.Location;
            command.Parameters.Add("weather", SqlDbType.VarChar);
            command.Parameters["weather"].Value = aCity.Weather;
            command.Parameters.Add("countryId", SqlDbType.Int);
            command.Parameters["countryId"].Value = aCity.CountryId;

            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<EntryCityViewModel> ShowEntryCityViews()
        {
            List<EntryCityViewModel> aListOfEntryCityView = new List<EntryCityViewModel>();
            string query = "SELECT * FROM EntryCityView ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string name = reader["CityName"].ToString();
                int noOfDwellors = Convert.ToInt32(reader["NoOfDwellers"]);
                string countryName = reader["CountryName"].ToString();
                EntryCityViewModel aEntryCityView = new EntryCityViewModel(id, name, noOfDwellors, countryName);

                aListOfEntryCityView.Add(aEntryCityView);
            }
            return aListOfEntryCityView;
        }

        public List<ViewCitiesViewModel> ShowAllCityAndCountry()
        {
            List<ViewCitiesViewModel> aViewCitiesViewModels = new List<ViewCitiesViewModel>();

            string query = "SELECT * FROM viewCitiesview ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string cityName = reader["CityName"].ToString();
                string aboutCity = reader["AboutCity"].ToString();
                int noOfDwellors = Convert.ToInt32(reader["NoOfDwellers"]);
                string location = reader["Location"].ToString();
                string weather = reader["Weather"].ToString();
                string countryName = reader["CountryName"].ToString();
                string aboutCountry = reader["AboutCountry"].ToString();
                ViewCitiesViewModel aModel = new ViewCitiesViewModel(id, cityName, aboutCity, noOfDwellors, location, weather, countryName, aboutCountry);

                aViewCitiesViewModels.Add(aModel);
            }
            return aViewCitiesViewModels;
        }

        public List<ViewCitiesViewModel> SeacrhResultForCountryInViewCity(string searchItem)
        {
            List<ViewCitiesViewModel> aViewCitiesViewModels = new List<ViewCitiesViewModel>();

            string query = "SELECT * FROM viewCitiesview ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string cityName = reader["CityName"].ToString();
                string aboutCity = reader["AboutCity"].ToString();
                int noOfDwellors = Convert.ToInt32(reader["NoOfDwellers"]);
                string location = reader["Location"].ToString();
                string weather = reader["Weather"].ToString();
                string countryName = reader["CountryName"].ToString();
                string aboutCountry = reader["AboutCountry"].ToString();
                ViewCitiesViewModel aModel = new ViewCitiesViewModel(id, cityName, aboutCity, noOfDwellors, location, weather, countryName, aboutCountry);

                if (countryName == searchItem)
                {
                    aViewCitiesViewModels.Add(aModel);
                }

            }
            return aViewCitiesViewModels;
        }

        public List<ViewCitiesViewModel> SeacrhResultForCityInViewCity(string searchItem)
        {
            List<ViewCitiesViewModel> aViewCitiesViewModels = new List<ViewCitiesViewModel>();

            string query = "SELECT * FROM viewCitiesview where CityName Like '%" + searchItem + "%'";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string cityName = reader["CityName"].ToString();
                string aboutCity = reader["AboutCity"].ToString();
                int noOfDwellors = Convert.ToInt32(reader["NoOfDwellers"]);
                string location = reader["Location"].ToString();
                string weather = reader["Weather"].ToString();
                string countryName = reader["CountryName"].ToString();
                string aboutCountry = reader["AboutCountry"].ToString();
                ViewCitiesViewModel aModel = new ViewCitiesViewModel(id, cityName, aboutCity, noOfDwellors, location, weather, countryName, aboutCountry);
                aViewCitiesViewModels.Add(aModel);
             }
            return aViewCitiesViewModels;
        }
    }
}