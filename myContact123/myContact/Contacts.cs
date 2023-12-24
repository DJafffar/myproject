using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace myContact
{
    public partial class Contacts : Form
    {
        private readonly func Con;
        private DataTable originalDataTable;
        private ErrorProvider errorProvider = new ErrorProvider();
        private bool searchButtonClicked = false;



        public Contacts()
        {
            InitializeComponent();
            Con = new func();
            ShowContacts();

            // Store the original data
            originalDataTable = (DataTable)ContactList.DataSource;

            // Handle the TextChanged event for the search TextBox
            tb_search.TextChanged += tb_search_TextChanged;
        }


        private void ShowContacts()
        {
            string query = "SELECT * FROM ContactTbl";
            ContactList.DataSource = Con.GetData(query);

            if (ContactList.Columns.Count > 0)
            {
                ContactList.Columns[0].Visible = false;
            }
        }

        private void AddOrUpdateContact(string name, string phoneNumber, string surname, string email, string action)
        {
            try
            {
                // Clear any previous error indicators
                errorProvider.Clear();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
                {
                    // Display an error icon and tooltip message for the required fields
                    if (string.IsNullOrEmpty(name))
                        errorProvider.SetError(ContactName, "Name is required");

                    if (string.IsNullOrEmpty(phoneNumber))
                        errorProvider.SetError(ContactPhoneNumber, "Phone Number is required");
                }
                else
                {
                    string query = $"INSERT INTO ContactTbl (ContactName, ContactPhoneNumber, ContactSurname, ContactEmail) VALUES (@ContactName, @ContactPhoneNumber, @ContactSurname, @ContactEmail)";

                    if (action == "Update")
                    {
                        // Modify the query for an update
                        query = $"UPDATE ContactTbl SET ContactPhoneNumber = @ContactPhoneNumber, ContactSurname = @ContactSurname, ContactEmail = @ContactEmail WHERE ContactName = @ContactName";
                    }

                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@ContactName", SqlDbType.NVarChar, 50) { Value = name },
                new SqlParameter("@ContactPhoneNumber", SqlDbType.NVarChar, 50) { Value = phoneNumber },
                new SqlParameter("@ContactSurname", SqlDbType.NVarChar, 50) { Value = surname },
                new SqlParameter("@ContactEmail", SqlDbType.NVarChar, 50) { Value = email }
            };

                    Con.SetData(query, parameters);
                    ShowContacts();

                    MessageBox.Show($"{action} Contact Successfully!");
                    ClearContactFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddOrUpdateContact(ContactName.Text, ContactPhoneNumber.Text, ContactSurname.Text, ContactEmail.Text, "Add");
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            AddOrUpdateContact(ContactName.Text, ContactPhoneNumber.Text, ContactSurname.Text, ContactEmail.Text, "Update");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ContactName.Text))
                {
                    MessageBox.Show("Enter Contact Name!");
                }
                else
                {
                    string contactNameToDelete = ContactName.Text;

                    string query = "DELETE FROM ContactTbl WHERE ContactName = @ContactName";
                    SqlParameter parameter = new SqlParameter("@ContactName", SqlDbType.NVarChar, 50) { Value = contactNameToDelete };

                    List<SqlParameter> parameters = new List<SqlParameter> { parameter };

                    int rowsAffected = Con.SetData(query, parameters);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Contact deleted successfully!");
                        ShowContacts();
                    }
                    else
                    {
                        MessageBox.Show("Contact not found or deletion failed.");
                    }

                    ClearContactFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearContactFields()
        {
            ContactName.Text = "";
            ContactEmail.Text = "";
            ContactSurname.Text = "";
            ContactPhoneNumber.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();

            // Show the Contact form
            loginForm.Show();

            // Hide the current form (Login form)
            this.Hide();

        }

        private void ContactList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            // If the search button is not clicked, do not perform the search
            if (!searchButtonClicked)
            {
                return;
            }

            // Get the search query from the TextBox
            string searchQuery = tb_search.Text;

            // Perform the search
            PerformSearch(searchQuery);
        }


        private void PerformSearch(string searchQuery)
        {
            // If the search query is empty, show all records
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                // If the search query is empty, show all records
                ContactList.DataSource = originalDataTable;
            }
            else
            {
                // Use the DefaultView.RowFilter property of the DataTable to perform the search
                originalDataTable.DefaultView.RowFilter = $"ContactName LIKE '%{searchQuery}%'";
                ContactList.DataSource = originalDataTable.DefaultView.ToTable();
            }
        }


        private void ClearSearch()
        {
            // If the search query is empty, reset the data source
            ContactList.DataSource = originalDataTable;
        }

        private void search_button_Click_1(object sender, EventArgs e)
        {
            // Set the flag to indicate that the search button is clicked
            searchButtonClicked = true;

            // Get the search query from the TextBox
            string searchQuery = tb_search.Text;

            // Perform the search
            PerformSearch(searchQuery);

            // Reset the flag after the search is performed
            searchButtonClicked = false;
        }
    }
}
