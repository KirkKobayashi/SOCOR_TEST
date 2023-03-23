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

namespace TruckScale.UI.UserControls
{
    public partial class WeigherUC : UserControl
    {
        string emptyError = "Can not be empty.";
        ErrorProvider errorProvider = new ErrorProvider { };

        private IApplicationService _service;
        private bool readyToSave = false;

        public WeigherUC(IApplicationService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider.SetError(txtFirstName, emptyError);
                readyToSave = false;
            }
            else
            {
                errorProvider.SetError(txtFirstName, string.Empty);
                readyToSave = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateForm();


            if (readyToSave == true)
            {
                if (txtPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
                {
                    var encryptedPass = AES.EncryptString(Globals.myKey, txtPassword.Text.Trim());
                    Weigher weigher = new Weigher
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Password = encryptedPass,
                        UserName = txtUserName.Text
                    };

                    _service.InsertWeigher(weigher);

                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    txtUserName.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtConfirmPassword.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Truck Scale Application", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return;
                }
            }
            else
            {
                MessageBox.Show("Check empty fields");
            }
        }

    }
}
