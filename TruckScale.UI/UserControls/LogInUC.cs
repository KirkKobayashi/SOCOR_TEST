using TruckScale.Library.BLL;
using TruckScale.Library.Data.Models;
using TruckScale.UI.Forms;
using TruckScale.UI.HelperClass;

namespace TruckScale.UI.UserControls
{
    public partial class LogInUC : UserControl
    {
        private readonly ApplicationService _service;
        private readonly MainForm _mainForm;

        public LogInUC(ApplicationService service, MainForm mainForm)
        {
            InitializeComponent();
            _service = service;
            _mainForm = mainForm;

            SeedWeigher();
            txtUserName.Focus();
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
                MessageBox.Show($"Error adding admin account \n\n{ex.Message}");
            }
            finally { Cursor.Current = Cursors.Default; }
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

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }
    }
}
