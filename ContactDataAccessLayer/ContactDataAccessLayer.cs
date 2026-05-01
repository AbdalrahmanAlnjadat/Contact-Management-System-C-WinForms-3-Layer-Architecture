using System;
using System.Data.SqlClient;
using System.Data;


namespace ContactDataAccessLayer
{
    public class ClsContactDataAccessLayer
    {

        public static bool FindContactsByID(int ID, ref string FirstName, ref string LastName,
            ref string Email, ref string Phone, ref string Address,
            ref DateTime DateOfBirth, ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection con = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Contacts WHERE ContactID = @ID";

            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    CountryID = (int)reader["CountryID"];
                    ImagePath = reader["ImagePath"] as string ?? "default.png";
                }
                else
                {
                    IsFound = false;
                }

            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine("An error  ss occurred: " + ex.Message);
                IsFound = false;
            }
            finally
            {
                con.Close();
            }

            return IsFound;
        }

        public static int AddNewContact(string FirstName, string LastName, string Email,
             string Phone, string Address, DateTime DateOfBirth,
             int CountryID, string ImagePath)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into Contacts (FirstName, LastName, Email, Phone, Address, DateOfBirth, CountryID, ImagePath) 
                values (@FirstName, @LastName, @Email, @Phone, @Address, @DateOfBirth, @CountryID, @ImagePath); 
                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ID = InsertedID;
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
            return ID;

        }




        public static bool UpdateContactData(int ID, string FirstName, string LastName, string Email, string Phone,
    string Address, DateTime DateValue, int CountryID, string ImagePath)
        {
            int RowsAffected = 0;

            string query = @"UPDATE Contacts  
                     SET FirstName = @FirstName, 
                         LastName = @LastName, 
                         Email = @Email, 
                         Phone = @Phone, 
                         Address = @Address, 
                         DateOfBirth = @DateOfBirth,
                         CountryID = @CountryID,
                         ImagePath = @ImagePath
                     WHERE ContactID = @ContactID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ContactID", SqlDbType.Int).Value = ID;
                    command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
                    command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
                    command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
                    command.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Phone;
                    command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
                    command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = DateValue;
                    command.Parameters.Add("@CountryID", SqlDbType.Int).Value = CountryID;

                    if (!string.IsNullOrWhiteSpace(ImagePath))
                        command.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = ImagePath;
                    else
                        command.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = DBNull.Value;

                    connection.Open();
                    RowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            

            return RowsAffected > 0;
        }


        public static bool DeleteContact(int ID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string qurey = @"Delete from Contacts where ContactID = @ContactID";
            SqlCommand command = new SqlCommand(qurey, connection);
            command.Parameters.AddWithValue("@ContactID", ID);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (RowsAffected > 0);
        }


        public static DataTable ListAllContacts()
        {
            DataTable tb = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string qurey = @"Select * from Contacts";
            SqlCommand command = new SqlCommand(qurey, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    tb.Load(reader);
                }
                reader.Close();
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
            return tb;
         }

       public static bool IsDataExists(int ID)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select found= 1 from Contacts where ContactID = @ContactID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ContactID", ID);
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
