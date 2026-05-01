
using ContactBuisnessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
public class Program
    {
    public static void FindContactByID(int ID)
    {
        clsContact Contact1 = clsContact.Find(ID);
        if (Contact1 != null)
        {
            Console.WriteLine(Contact1.FirstName + " " + Contact1.LastName);
            Console.WriteLine(Contact1.Email);
            Console.WriteLine(Contact1.Phone);
            Console.WriteLine(Contact1.Address);
            Console.WriteLine(Contact1.DateOfBirth);
            Console.WriteLine(Contact1.CountryID);
            Console.WriteLine(Contact1.ImagePath);
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }
    
        static void Main(string[] args)
        {
        FindContactByID(1);

        Console.ReadKey();
        }
    
}

