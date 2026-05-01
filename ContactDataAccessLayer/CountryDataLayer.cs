using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContactDataAccessLayer
{
    public class CountryDataLayer
    {
        public static bool FindContryByID(int ID,ref string Name,ref string Code,ref string PhoneCode)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT CountryName, Code, PhoneCode 
                 FROM Countries 
                 WHERE CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Name =(string) reader["CountryName"];
                    if(reader["Code"] != DBNull.Value)
                        Code = (string)reader["Code"];
                    else
                    {
                        Code = "";
                    }
                    if (reader["PhoneCode"] != DBNull.Value)
                        PhoneCode = (string)reader["PhoneCode"];
                    else
                    {
                        PhoneCode = "";
                    }
                        isfound = true;
                }
                else
                {
                    isfound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine("An error occurred: " + ex.Message);
                isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }
        public static bool FindCountryByName(ref int ID, string CountryName,ref string Code,ref string PhoneCode)
        {
            bool IsFound = false;
            SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select *from Countries WHere CountryName=@CountryName";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    ID = (int)reader["CountryID"];
                   if(reader["Code"] != DBNull.Value)
                        Code = (string)reader["Code"];
                    else { 
                    Code = "";
                    }
                   if (reader["PhoneCode"] != DBNull.Value)
                        PhoneCode = (string)reader["PhoneCode"];
                    else
                    {
                        PhoneCode = "";
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
                return IsFound;
            }
        public static int AddNewCountry( string Name,string Code,string PhoneCode)
        {
            int countryId = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"insert into Countries (CountryName,Code,PhoneCode)
                         Values (@CountryName,@Code,@PhoneCode);
                         select SCOPE_IDENTITY();";
            SqlCommand command =new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", Name);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@PhoneCode", PhoneCode);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    countryId = insertedID;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine("An error occurred: " + ex.Message);
               
            }
            finally
            {
                connection.Close();
            }
            return countryId;
        }

        public static bool UpdateCountryInfo(string CountryName,int ID,string Code,string PhoneCode)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update Countries set CountryName = @CountryName, 
                           Code = @Code, PhoneCode = @PhoneCode
                           where CountryID = @CountryID";
            SqlCommand command =new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            command.Parameters.AddWithValue("@CountryID", ID);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@PhoneCode", PhoneCode);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine("An error occurred: " + ex.Message);
                RowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }
            return RowsAffected > 0;
        }

        public static bool DeleteCountryByID(int ID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            int RowsAffected = 0;
            string query = @"delete from Countries where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", ID);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine("An error occurred: " + ex.Message);
                RowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }
            return RowsAffected > 0;
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select *from Countries";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
               
                dt.Load(reader);
                
                reader.Close();

            }
            catch (Exception ex)
            {

             

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool IsCountryExistsByName1(string Name)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select found=1 from Countries where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", Name);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isfound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine("An error occurred: " + ex.Message);
                isfound = false;
            }
            finally
            {
                connection.Close();

            }
            return isfound;
        }
    }
}
