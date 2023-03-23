using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckScale.Library.BLL;
using TruckScale.UI.Forms;
using TruckScale.UI.HelperClass;

namespace TruckScale.UI.UserControls
{
    public partial class LogInUC : UserControl
    {
        public event EventHandler<EventArgs> LogIn;

        private readonly ApplicationService _service;
        private readonly MainForm _mainForm;

        public LogInUC(ApplicationService service, MainForm mainForm)
        {
            InitializeComponent();
            _service = service;
            _mainForm = mainForm;
        }

        private bool UserLogIn()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    MessageBox.Show("User name is empty.");
                    txtUserName.Focus();
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password is empty.");
                    txtPassword.Focus();
                    return false;
                }

                var weigher = _service.GetWeigherByName(txtUserName.Text.Trim());

                if (weigher != null)
                {
                    if (weigher.Password == AES.EncryptString(Globals.myKey, txtPassword.Text.Trim()))
                    {
                        _mainForm.weigherId = weigher.Id;
                        return true;
                    }
                }
                MessageBox.Show("Username or password not found");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"User log in error \n\n{ex.Message}", "Truck scale application", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var success = UserLogIn();

            if (success)
            {
                _mainForm.LogIn();
            }
        }
    }
}
