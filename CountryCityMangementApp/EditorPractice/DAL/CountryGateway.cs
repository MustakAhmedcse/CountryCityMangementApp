using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using EditorPractice.Model;

namespace EditorPractice.DAL
{
    public class CountryGateway
    {
        private string connectionString = @"Server=MUSTAK-PC\SQLEXPRESS;Database=CountryCiry_DB;Integrated Security=true";

        public void InsertCountry(Country aCountry)
        {
            string query = "INSERT INTO Countrys (CountryName,AboutCountry) values(@name,@about)";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Clear();
            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = aCountry.Name;
            command.Parameters.Add("about", SqlDbType.VarChar);
            command.Parameters["about"].Value = aCountry.About;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<Country> GetAllCountry()
        {
            List<Country> aListOfCity = new List<Country>();
            string query = "SELECT * FROM Countrys ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string name = reader["CountryName"].ToString();
                string about = reader["AboutCountry"].ToString();
                Country anewCity = new Country(id, name, about);
                aListOfCity.Add(anewCity);
            }
            return aListOfCity;
        }

        public List<Country> GetAllCountryName()
        {
            List<Country> aCountryList =new List<Country>();
            string query = "SELECT * FROM Countrys ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string name = reader["CountryName"].ToString();
               Country anewCity = new Country();
                anewCity.Id = id;
                anewCity.Name = name;
                aCountryList.Add(anewCity);
            }
            return aCountryList;
        } 


    }
}