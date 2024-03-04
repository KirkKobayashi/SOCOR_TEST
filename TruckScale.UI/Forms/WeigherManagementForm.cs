using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckScale.Library.BLL;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.UI.HelperClass;

namespace TruckScale.UI.Forms
{
    public partial class WeigherManagementForm : Form
    {
        private readonly IWeigherRepository _weigherService;
        private Weigher _weigher;
        public WeigherManagementForm(IWeigherRepository weigherService)
        {
            InitializeComponent();
            _weigherService = weigherService;
        }

        private void InsertWeigher()
        {
            try
            {
                var password = AES.EncryptString(Globals.myKey, txtPassword.Text.Trim());

                var newUser = new Weigher
                {
                    UserName = txtUsername.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Password = password
                };

                _weigherService.Insert(newUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while adding new weigher.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Weigher FindWeigher(string name)
        {
            return _weigherService.GetByName(name);
        }

        private void FillWeigherDetails()
        {
            _weigher = FindWeigher(txtUsername.Text.Trim());

            if (_weigher != null)
            {
                txtUsername.Text = _weigher.UserName;
                txtFirstName.Text = _weigher.FirstName;
                txtLastName.Text = _weigher.LastName;
            }
            else
            {
                txtUsername.Text = string.Empty;
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
            }
        }

        private void UpdateWeigher()
        {
            try
            {
                _weigher.UserName = txtUsername.Text;
                _weigher.FirstName = txtFirstName.Text;
                _weigher.LastName = txtLastName.Text;
                _weigher.Password = AES.EncryptString(Globals.myKey, txtPassword.Text.Trim());

                _weigherService.UpdateWeigher(_weigher);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured while updating record.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUserName(string name)
        {
            var _weigher = FindWeigher(name);

            if (_weigher != null)
            {
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username is empty.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Firs tname is empty.");
                txtFirstName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Last Name is empty.");
                txtLastName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is empty.");
                txtPassword.Focus();
                return;
            }
            var goodUsername = ValidateUserName(txtUsername.Text);
            if (txtPassword.Text == txtConfirm.Text)
            {
                if (_weigher == null)
                {
                    if (goodUsername)
                    {
                        InsertWeigher();
                    }
                    else
                    {
                        MessageBox.Show("Username already exists.");
                        return;
                    }
                }
                else
                {
                    UpdateWeigher();
                }

                MessageBox.Show("Record saved/updated.");
                this.Close();

            }
            else
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillWeigherDetails();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
