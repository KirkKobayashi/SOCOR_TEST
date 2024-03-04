

using TruckScale.Library.BLL;
using TruckScale.Library.Data.Models;
using TruckScale.Library.Interfaces;
using TruckScale.UI.HelperClass;

namespace ScaleUI.UI
{
    public partial class LogInForm : Form
    {
        private readonly IApplicationServiceExtensions _service;
        private readonly IWeigherRepository _weigherService;

        public LogInForm(IApplicationServiceExtensions applicationServiceExtensions, IWeigherRepository weigherService)
        {
            InitializeComponent();
            _service = applicationServiceExtensions;
            _weigherService = weigherService;
            SeedWeigher();
        }

        private void SeedWeigher()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                Weigher weigher = new Weigher
                {

                    FirstName = "admin",
                    LastName = "admin",
                    UserName = "admin",
                    Password = AES.EncryptString(Globals.myKey, "admin")
                };

                _service.SeedWeigher(weigher);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error base account \n\n{ex.Message}");
            }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LogInUser()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    MessageBox.Show("User name is empty.");
                    txtUserName.Focus();
                }

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Password is empty.");
                    txtPassword.Focus();
                }

                var weigher = _weigherService.GetByName(txtUserName.Text.Trim());

                if (weigher != null)
                {
                    if (weigher.Password == AES.EncryptString(Globals.myKey, txtPassword.Text.Trim()))
                    {
                        GlobalProps.UserName = weigher.UserName;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Username or password invalid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"User log in error \n\n{ex.Message}", "Truck scale application", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogInUser();
        }
    }
}
