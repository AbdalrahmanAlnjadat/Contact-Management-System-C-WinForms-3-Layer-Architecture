using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ClsValidation
    {
        Form1 form1 = new Form1();
        public static bool   IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }


        public static bool IsCountryIDValid(string countryIDText)
        {
            if (!int.TryParse(countryIDText.Trim(), out int countryID))
            {
                MessageBox.Show("Please enter a valid number.");
               
                return false;
            }

            if (countryID < 1 || countryID > 10)
            {
                MessageBox.Show("Please enter a valid Country ID between 1 and 10.");
             
                return false;
            }

            return true;
        }

        public static bool IsValidJordanPhone(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            string pattern = @"^(07[7-9]\d{7}|(\+962|962)7[7-9]\d{7})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public static bool IsValidDateOfBirth(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age))
                age--;
            return age >= 18 && age <= 120;
        }
       

    }
}
