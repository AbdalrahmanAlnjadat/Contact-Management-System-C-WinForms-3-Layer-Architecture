using ContactBuisnessLayer;
using ContactBuisnisLayer;
using System.Data;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int _currentID = -1;
        private int _currentCountryID = -1;
        public enum FindContactMode
        {
            Add = 'A',
            Update = 'U',

        }
        public enum FindCountryMode
        {
            Add = 'A',
            Update = 'U',
        }


        public Form1()
        {
            InitializeComponent();
        }
        private bool FillUpdateCountryInfo(ClsCountry Country)
        {
            //if (!int.TryParse(UtxtIdSearch.Text.Trim(), out int countryId))
            //{
            //    MessageBox.Show("Invalid Country ID");
            //    return false;
            //}
            if (string.IsNullOrWhiteSpace(UtxtCountryName.Text))
            {
                MessageBox.Show("Please enter a Country Name.");
                UtxtCountryName.Focus();
                return false;
            }

            // Validate Country Code (2–3 uppercase letters)
            string codePattern = @"^[A-Z]{2,3}$";
            if (!Regex.IsMatch(UtxtCode.Text, codePattern))
            {
                MessageBox.Show("Country Code must be 2–3 uppercase letters (e.g., US, UK).");
                UtxtCode.Focus();
                return false;
            }

            // Validate Phone Code (+ followed by digits)
            string phone = UtxtPhoneCode.Text.Trim().Replace('＋', '+');

            if (!Regex.IsMatch(phone, @"^\+\d{1,4}$"))
            {
                MessageBox.Show("Phone Code must start with + and contain 1–4 digits (e.g., +962).");
                UtxtPhoneCode.Focus();
                return false;
            }
            Country.CountryName = UtxtCountryName.Text;
            Country.Code = UtxtCode.Text.Trim().ToUpper();
            Country.PhoneCode = UtxtPhoneCode.Text.Trim();

            // Assign values AFTER validation
            return true;
        }

        private void FillUpdateFieldsForCountry(ClsCountry Country)
        {

            UtxtCountryName.Text = Country.CountryName;
            UtxtCode.Text = Country.Code;
            UtxtPhoneCode.Text = Country.PhoneCode;
        }
        public bool UpdateCountryInfo(int ID)
        {

            if (ID == -1)
            {
                MessageBox.Show("Please enter a valid Country ID.");
                return false;
            }
            ClsCountry cls = ClsCountry.Find(ID);

            if (cls == null)
            {
                MessageBox.Show("Country not found.");
                return false;
            }

            if (!FillUpdateCountryInfo(cls))
                return false;

            if (cls.Save())
            {
                MessageBox.Show("Country updated successfully.");
                UtxtIdSearch.Clear();
                lblCountryIDU.Text = "";
                btnUpdateCountry.Enabled = false;
                ListCountries();
                return true;
            }
            else
            {
                MessageBox.Show("Failed to update country.");
            }
            return false;

        }


        //=========================  Country Methods====================
        public void ListCountries()
        {

            DataTable dataTable = ClsCountry.ListAllCountries();

            LvListAllCountries.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                LvListAllCountries.Items.Add(CreateCountriesItem(row));
            }

            LvListAllCountries.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            LvListAllCountries.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        public ListViewItem CreateCountriesItem(DataRow row)
        {
            ListViewItem newItem = new ListViewItem(row["CountryID"].ToString());

            newItem.SubItems.Add(row["CountryName"].ToString());
            newItem.SubItems.Add(row["PhoneCode"] == DBNull.Value ? "" :
            Convert.ToString(row["PhoneCode"]));


            newItem.SubItems.Add(row["Code"] == DBNull.Value ? "" :
            row["Code"].ToString());
            return newItem;
        }

        public void PrintFindCountryInfo(ClsCountry c)
        {
            ListViewItem newItem = new ListViewItem(c.CountryID.ToString());
            newItem.SubItems.Add(c.CountryName);
            newItem.SubItems.Add(c.PhoneCode);
            newItem.SubItems.Add(c.Code);
            LvListAllCountries.Items.Add(newItem);
            LvListAllCountries.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            LvListAllCountries.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void findCountryByID(int ID, FindCountryMode EnMode)
        {
            ClsCountry c = ClsCountry.Find(ID);
            LvListAllCountries.Items.Clear();
            if (ID == -1)
            {
                MessageBox.Show("Please enter a valid Country ID.");
                return;
            }
            if (c == null)
            {
                MessageBox.Show("Country not found.");
                ListCountries();
                return;
            }
            _currentCountryID = c.CountryID;

            if (EnMode == FindCountryMode.Add)
            {
                PrintFindCountryInfo(c);
                btnDeleteCountry.Enabled = true;

            }
            else if (EnMode == FindCountryMode.Update)
            {
                FillUpdateFieldsForCountry(c);
                btnUpdateCountry.Enabled = true;
            }

        }

        public void DeleteCountry(int ID)
        {
            if (!ConfirmDelteing("Are you sure you want to Delete this Country?"))
            {
                return;
            }

            if (ClsCountry.DeleteCountyByID(ID))
            {
                MessageBox.Show("Country Deleted Successfully.");
                LvListAllCountries.Items.Clear();
                btnDeleteCountry.Enabled = false;
                ListCountries();
            }
            else
            {
                MessageBox.Show("Failed to Delete Country.");
            }


        }

        private ClsCountry FillCountryInfo()
        {

            if (string.IsNullOrWhiteSpace(txtCountryName.Text))
            {
                MessageBox.Show("Please enter a Country Name.");
                txtCountryName.Focus();
                return null;
            }

            // Validate Country Code (2–3 uppercase letters)
            string codePattern = @"^[A-Z]{2,3}$";
            if (!Regex.IsMatch(TxtCode.Text, codePattern))
            {
                MessageBox.Show("Country Code must be 2–3 uppercase letters (e.g., US, UK).");
                TxtCode.Focus();
                return null;
            }

            // Validate Phone Code (+ followed by digits)
            string phone = txtPhoneCode.Text.Trim().Replace('＋', '+');

            if (!Regex.IsMatch(phone, @"^\+\d{1,4}$"))
            {
                MessageBox.Show("Phone Code must start with + and contain 1–4 digits (e.g., +962).");
                txtPhoneCode.Focus();
                return null;
            }

            // Assign values AFTER validation
            return new ClsCountry
            {
                CountryName = txtCountryName.Text.Trim(),
                Code = TxtCode.Text.Trim().ToUpper(),
                PhoneCode = txtPhoneCode.Text.Trim()
            };
        }
        public void AddNewCountry()
        {

            ClsCountry c1 = FillCountryInfo();

            if (c1 == null)
            {
                return;
            }

            if (c1.Save())
            {
                MessageBox.Show("Country saved successfully." + c1.CountryID);

                LblCountryID.Text = c1.CountryID.ToString();
                ListCountries();
                tabControl3.SelectedTab = tabPage7;
                LvListAllCountries.Items[LvListAllCountries.Items.Count - 1].Selected = true;
            }
            else
            {
                MessageBox.Show("Failed to save country.");
            }
        }

        //=========================Contact Methods========================

        public void IsContactExist(int ID)
        {
            if (clsContact.IsDataExists(ID))
            {
                MessageBox.Show("Contact exists.");
            }
            else
            {
                MessageBox.Show("Contact does not exist.");
            }
        }

        public ListViewItem CreateContactItem(DataRow row)
        {
            ListViewItem newItem = new ListViewItem(row["ContactID"].ToString());

            newItem.SubItems.Add(row["FirstName"] + " " + row["LastName"]);
            newItem.SubItems.Add(row["Phone"].ToString());
            newItem.SubItems.Add(row["Email"].ToString());
            newItem.SubItems.Add(row["Address"].ToString());
            newItem.SubItems.Add(row["DateOfBirth"] == DBNull.Value ? "" :
                Convert.ToDateTime(row["DateOfBirth"]).ToShortDateString());
            newItem.SubItems.Add(row["CountryID"].ToString());
            newItem.SubItems.Add(row["ImagePath"] == DBNull.Value ? "" : row["ImagePath"].ToString());
            return newItem;
        }

        public void ListAllContacts()
        {
            DataTable contactsTable = clsContact.GetAllContacts();


            LvListAllContacts.Items.Clear();
            foreach (DataRow row in contactsTable.Rows)
            {
                LvListAllContacts.Items.Add(CreateContactItem(row));
            }
            LvListAllContacts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            LvListAllContacts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private ListViewItem CreateContactItem(clsContact c)
        {
            ListViewItem newItem = new ListViewItem(c.ID.ToString());
            newItem.SubItems.Add(c.FirstName + " " + c.LastName);
            newItem.SubItems.Add(c.Phone);
            newItem.SubItems.Add(c.Email);
            newItem.SubItems.Add(c.Address);
            newItem.SubItems.Add(c.DateOfBirth.ToShortDateString());
            newItem.SubItems.Add(c.CountryID.ToString());
            newItem.SubItems.Add(c.ImagePath);
            return newItem;
        }

        public void PrintFindInfo(clsContact c)
        {
            LvFindContacts.Items.Add(CreateContactItem(c));

            LvFindContacts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            LvFindContacts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lblID.Text = "Contact ID :" + c.ID.ToString();
        }

        public void FindContactByID(int ID, FindContactMode FindIndex)
        {
            clsContact c = clsContact.Find(ID);

            LvFindContacts.Items.Clear();

            if (c == null)
            {
                MessageBox.Show("Contact not found.");
                return;
            }
            _currentID = c.ID;

            if (FindIndex == FindContactMode.Add)
            {
                PrintFindInfo(c);
            }
            else if (FindIndex == FindContactMode.Update)
            {
                FillUpdateFields(c);
            }
        }

        private clsContact BuildContactFromInputs()
        {
            if (!int.TryParse(txtCountryID.Text, out int countryId))
            {
                MessageBox.Show("Invalid Country ID");
                return null;
            }

            return new clsContact
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = TxtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                DateOfBirth = DateField.Value,
                CountryID = countryId,
                ImagePath = txtImagePath.Text.Trim()
            };
        }

        public void AddNewContact()
        {

            clsContact c1 = BuildContactFromInputs();

            if (c1 == null)
            {
                return;
            }
            if (c1.Save())
            {
                MessageBox.Show("Contact saved successfully." + c1.ID);
                lblID.Text = c1.ID.ToString();
                _currentID = c1.ID;

                ClearForm();
                tabControl1.SelectedTab = tabPage6; // Switch to the "List All Contacts" tab after adding a new contact
                LvListAllContacts.Items[LvListAllContacts.Items.Count - 1].Selected = true;
            }
            else
            {
                MessageBox.Show("Failed to save contact.");
            }
            ListAllContacts();

        }

        private void FillUpdateFields(clsContact c)
        {
            _currentID = c.ID;
            UTXTFirstName.Text = c.FirstName;
            UTXTLastName.Text = c.LastName;
            UTXTEmail.Text = c.Email;
            UTXTPhone.Text = c.Phone;
            UTXTAddress.Text = c.Address;
            UTXTDateTime.Value = c.DateOfBirth;
            UTXTCountryID.Text = c.CountryID.ToString();
            UTXTImagePath.Text = c.ImagePath;
        }

        private bool FillUpdateFieldsForContact(clsContact contact)
        {
            if (!int.TryParse(UTXTCountryID.Text.Trim(), out int countryId))
            {
                MessageBox.Show("Invalid Country ID");
                return false;
            }

            contact.FirstName = UTXTFirstName.Text;
            contact.LastName = UTXTLastName.Text;
            contact.Email = UTXTEmail.Text;
            contact.Phone = UTXTPhone.Text.Trim();
            contact.Address = UTXTAddress.Text;
            contact.DateOfBirth = UTXTDateTime.Value;
            contact.CountryID = countryId;
            contact.ImagePath = UTXTImagePath.Text.Trim();

            return true;
        }

        public bool UpdateContact()
        {
            if (_currentID == -1)
            {
                MessageBox.Show("No contact selected.");
                return false;
            }

            clsContact Contact1 = clsContact.Find(_currentID);
            if (Contact1 == null)
            {
                MessageBox.Show("Contact not found for update.");
                return false;
            }

            if (!FillUpdateFieldsForContact(Contact1))
                return false;

            if (Contact1.Save())
            {
                MessageBox.Show("Contact updated successfully.");

                ListAllContacts();
                return true;
            }
            return false;
        }

        public void DeleteContact(int ID)
        {
            if (!ConfirmDelteing("Are you sure you want to Delete this contact ?"))
            {
                return;
            }

            if (!clsContact.DeleteContact(ID))
            {
                MessageBox.Show("Delete failed or contact not found.");
                return;
            }
            LvFindContacts.Items.Clear();
            MessageBox.Show("Deleted successfully.");
            ListAllContacts();


        }



        //functions for All Methods
        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            TxtPhone.Clear();
            txtAddress.Clear();
            txtCountryID.Clear();
            txtImagePath.Clear();
            DateField.Value = DateTime.Now;

            UTXTEmail.Clear();
            UTXTFirstName.Clear();
            UTXTLastName.Clear();
            UTXTPhone.Clear();
            UTXTAddress.Clear();
            UTXTCountryID.Clear();
            UTXTImagePath.Clear();

            UTXTDateTime.Value = DateTime.Now;
            _currentID = -1;
            //lblID.Text = "";
            

        }
        private void ClearCountryForm()
        {


            UtxtCountryName.Clear();
            UtxtCode.Clear();
            UtxtPhoneCode.Clear();
            _currentCountryID = -1;
            LblCountryID.Text = "";
            
            btnUpdateCountry.Enabled = false;
        }
        public bool ConfirmAdding(string confirmText)
        {
            DialogResult result = MessageBox.Show(confirmText,
                "Confirm Add",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        public bool ConfirmDelteing(string ConfirmText)
        {
            DialogResult result = MessageBox.Show(ConfirmText,
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }
        private void SetDetailsDisplay()
        {
            LvFindContacts.Columns.Add("ID", 50);            // small fixed ID
            LvFindContacts.Columns.Add("Name", 150);         // medium (names vary)
            LvFindContacts.Columns.Add("Phone", 110);        // needs space for country code
            LvFindContacts.Columns.Add("Email", 200);        // emails are long
            LvFindContacts.Columns.Add("Address", 220);      // usually longest text
            LvFindContacts.Columns.Add("DateOfBirth", 100);  // date format needs space
            LvFindContacts.Columns.Add("CountryID", 80);     // small numeric value
            LvFindContacts.Columns.Add("ImagePath", 250);

            // paths are always long
            LvListAllContacts.Columns.Add("ID", 50);            // small fixed ID
            LvListAllContacts.Columns.Add("Name", 150);         // medium (names vary)
            LvListAllContacts.Columns.Add("Phone", 110);        // needs space for country code
            LvListAllContacts.Columns.Add("Email", 200);        // emails are long
            LvListAllContacts.Columns.Add("Address", 220);      // usually longest text
            LvListAllContacts.Columns.Add("DateOfBirth", 100);  // date format needs space
            LvListAllContacts.Columns.Add("CountryID", 80);     // small numeric value
            LvListAllContacts.Columns.Add("ImagePath", 250);    // paths are always long

            // For the countries list, we can use narrower columns since the data is more concise
            LvListAllCountries.Columns.Add("CountryID", 80);
            LvListAllCountries.Columns.Add("CountryName", 200);
            LvListAllCountries.Columns.Add("Code", 80);
            LvListAllCountries.Columns.Add("PhoneCode", 80);
        }

        // Event handler for the Add button click event
        private void Form1_Load(object sender, EventArgs e)
        {

            SetDetailsDisplay();
            LvFindContacts.View = View.Details;
            LvListAllContacts.View = View.Details;
            LvListAllCountries.View = View.Details;
            lblID.Text = "";
            LblCountryID.Text = "";
            lblCountryIDU.Text = "";
            ListAllContacts();
            ListCountries();
            btnUpdateCountry.Enabled = false;
            //BtnUpdate.Enabled = false;

            btnDeleteCountry.Enabled = false;

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIDNum.Text.Trim(), out int id))
            {
                FindContactByID(id, FindContactMode.Add);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer ID.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
            string.IsNullOrWhiteSpace(txtLastName.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(TxtPhone.Text) ||
             string.IsNullOrWhiteSpace(txtAddress.Text) ||
              string.IsNullOrWhiteSpace(txtCountryID.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validate country ID
            if (!ClsValidation.IsCountryIDValid(txtCountryID.Text))
            {
                MessageBox.Show("Invalid CountryID ");
                txtCountryID.Focus();
                return;
            }
            //validate email
            if (!ClsValidation.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email address");
                txtEmail.Focus();
                return;
            }
            //validate phone number
            if (!ClsValidation.IsValidJordanPhone(TxtPhone.Text))
            {
                MessageBox.Show("Enter a valid Jordan phone number");
                TxtPhone.Focus();
                return;
            }
            //validate date of birth not in the future
            if (DateField.Value > DateTime.Now)
            {
                MessageBox.Show("Date of Birth cannot be in the future");
                DateField.Focus();
                return;
            }
            //validate date of birth based on age limit (e.g., at least 18 years old)
            if (!ClsValidation.IsValidDateOfBirth(DateField.Value))
            {
                MessageBox.Show("Invalid Date of Birth");
                DateField.Focus();
                return;
            }
            //validate user confirmation before adding the contact
            if (!ConfirmAdding("Are you sure you want to add this contact?")) return;



            AddNewContact();
            //reset form fields after adding the contact

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIDNum.Text.Trim(), out int id))
            {
                MessageBox.Show("Please enter a valid integer ID.");
                txtIDNum.Focus();
                return;
            }
            DeleteContact(id);
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtFirstName.Focus();
        }

        private void UBtnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(UtxtID.Text.Trim(), out int id))
            {
                FindContactByID(id, FindContactMode.Update);
            }
            else
            {
                MessageBox.Show("Please enter a valid integer ID.");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!UpdateContact())
            {
                return;
            }

            _currentID = -1;
            ClearForm();
            tabControl1.SelectedTab = tabPage6; // Switch to the "List All Contacts" tab after updating a contact
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ListAllContacts();
        }

        private void RefreshBtnCountries_Click(object sender, EventArgs e)
        {
            ListCountries();
            TxtCountryID1.Clear();
            btnDeleteCountry.Enabled = false;
        }


        private void BtnFindCountryByID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtCountryID1.Text.Trim(), out int id))
            {
                MessageBox.Show("Please enter a valid Country ID.");
                TxtCountryID1.Focus();
                return;
            }
            findCountryByID(id, FindCountryMode.Add);

        }


        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            if (TxtCountryID1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a Country ID.");
                TxtCountryID1.Focus();
                return;
            }

            if (!int.TryParse(TxtCountryID1.Text.Trim(), out int id))
            {
                MessageBox.Show("Please enter a valid Country ID.");
                TxtCountryID1.Focus();
                return;
            }
            DeleteCountry(id);
        }


        private void BtnAddNewCountry_Click(object sender, EventArgs e)
        {
            if (ClsCountry.IsCountryExistsByName(txtCountryName.Text.Trim()))
            {
                MessageBox.Show("Country already exists. Please enter a different name.");
                txtCountryName.Clear();
                txtCountryName.Focus();
                return;
            }

            if (!ConfirmAdding("Are you sure you want to add this Country?")) return;
            AddNewCountry();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCountryName.Clear();
            TxtCode.Clear();
            txtPhoneCode.Clear();
        }

        private void btnUpdateCountry_Click(object sender, EventArgs e)
        {
            if (!UpdateCountryInfo(_currentCountryID))
            {

                return;
            }
            ClearCountryForm();
            tabControl3.SelectedTab = tabPage7;

        }

        private void UbtnClear_Click(object sender, EventArgs e)
        {
            ClearCountryForm();
            UtxtCountryName.Focus();
        }

        private void btnSearchCountryID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(UtxtIdSearch.Text.Trim(), out int id))
            {
                lblCountryIDU.Text = "Country ID: " + id.ToString();
                findCountryByID(id, FindCountryMode.Update);
                
            }
            else
            {
                MessageBox.Show("Please enter a valid integer ID.");
            }
        }

       
    }
}
