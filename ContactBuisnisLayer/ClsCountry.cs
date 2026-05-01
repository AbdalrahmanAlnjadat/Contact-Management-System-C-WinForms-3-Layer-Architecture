using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ContactDataAccessLayer;
namespace ContactBuisnisLayer
{
    public class ClsCountry
    {
        
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public string CountryName { get; set; }
        public int CountryID { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }

        public ClsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
            this.Code="";
            this.PhoneCode = "";
            Mode = enMode.AddNew;
        }
        private ClsCountry(int CountryID, string CountryName,string Code,string PhoneCode)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.Code=Code;
            this.PhoneCode=PhoneCode;
            Mode = enMode.Update;
        }

        public static ClsCountry Find(int ID)
        {
            string CountryName = "";
            string Code = "";
            string PhoneCode = "";

            if (CountryDataLayer.FindContryByID(ID, ref CountryName,ref Code,ref PhoneCode))
            {
                return new ClsCountry(ID, CountryName,Code,PhoneCode);
            }
            else
            {
                return null;
            }
        }
        public static ClsCountry Find(string Name)
        {
            int ID = -1;
            string Code = "";
            string PhoneCode = "";
            if (CountryDataLayer.FindCountryByName(ref ID, Name,ref Code,ref PhoneCode))
            {
                return new ClsCountry(ID,Name,Code,PhoneCode);
            }
            else
            {
                return null;
            }
        }

        private  bool _AddNewCountry()
        {
            this.CountryID = CountryDataLayer.AddNewCountry( this.CountryName,this.Code,this.PhoneCode);
            return this.CountryID > 0;

        }

        public  bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    case enMode.Update:
                      return _UpdateCountry();
            }
            return false;
        }

        public static bool DeleteCountyByID(int ID)
        {
          return CountryDataLayer.DeleteCountryByID(ID);
        }
        private bool _UpdateCountry()
        {
            return CountryDataLayer.UpdateCountryInfo(this.CountryName, this.CountryID,this.Code,this.PhoneCode);
        }
        public static bool IsCountryExistsByName(string Name)
        {
            return CountryDataLayer.IsCountryExistsByName1(Name);
        }

        public static DataTable ListAllCountries()
        {
            return CountryDataLayer.GetAllCountries();
        }

    }
}
