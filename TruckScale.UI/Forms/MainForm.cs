using DocumentFormat.OpenXml.Office2019.Drawing.Model3D;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models;
using TruckScale.Library.BLL;
using TruckScale.Library.Data.Models;
using TruckScale.ScaleSerialPort;
using TruckScale.UI.HelperClass;
using TruckScale.UI.UserControls;

namespace TruckScale.UI.Forms
{
    public partial class MainForm : Form
    {
        public int weigherId { get; set; }
        public string? stringWeight { get; set; }

        private ApplicationService _service;

        private ScalePortCon _sp;

        private ScalePort sPort;

        delegate void SetWeight(string weighstring);

        public MainForm()
        {
            InitializeComponent();

            _service = Factory.GetApplicationService();

            SeedWeigher();
            //InitializePort();
        }

        private void InitializePort()
        {
            try
            {
                sPort = PortGetter.Get();
                _sp = new ScalePortCon(sPort);
                _sp.SerialDataReceieved += _sp_SerialDataReceieved;
                _sp.OpenPort();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening serial port \n\n{ex.Message}");
            }
        }

        private void SetWeightString(string weight)
        {
            if (txtIndicator.InvokeRequired)
            {
                SetWeight d = new SetWeight(SetWeightString);
                this.BeginInvoke(d, new object[] { weight });
            }
            else
            {
                txtIndicator.Text = string.Format(weight, "00");
            }
        }

        private void _sp_SerialDataReceieved(object? sender, SerialDataEventArgs e)
        {
            if (e.Data != null)
            {
                var newWeight = e.Data.TrimStart('0');

                if (newWeight.Length == 0)
                {
                    SetWeightString("0");
                    return;
                }
                SetWeightString(newWeight);
            }
        }

        public void ClearPanelFromWeighing()
        {
            PanelMain.Controls.Clear();
            stringWeight = txtIndicator.Text;

            ShowTransactions();
        }

        public void LogIn()
        {
            PanelMain.Controls.Clear();
            ViewMenu.Enabled = true;
            stripMenuLogIn.Enabled = false;
            ShowTransactions();
        }

        private void ShowUserLogIn()
        {
            PanelMain.Controls.Clear();
            LogInUC logInUC = new LogInUC(_service, this);
            PanelMain.Controls.Add(logInUC);
            logInUC.Dock = DockStyle.Fill;
            logInUC.Show();
        }

        private void ShowUserManagement()
        {
            PanelMain.Controls.Clear();
            WeigherUC weigherUC = new WeigherUC(_service, this);
            PanelMain.Controls.Add(weigherUC);
            weigherUC.Dock = DockStyle.Fill;
            weigherUC.Show();
        }

        public void ShowTransactions()
        {
            PanelMain.Controls.Clear();
            TransactionsUC uc = new TransactionsUC(_service, this);
            PanelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowWeighing(true, 0);
        }

        public void ShowWeighing(bool newTrans, int transId)
        {
            WeighingUC uc;
            if (transId == 0)
            {
                uc = new WeighingUC(_service, this, newTrans);

            }
            else
            {
                uc = new WeighingUC(_service, this, newTrans, transId);
            }

            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ShowTransactions();
        }

        private void toolMenuUser_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            ShowUserManagement();
        }

        private void stripMenuLogIn_Click(object sender, EventArgs e)
        {
            ShowUserLogIn();
        }

        private void txtIndicator_TextChanged(object sender, EventArgs e)
        {
            if (txtIndicator.TextLength > 2)
            {
                stringWeight = txtIndicator.Text.Trim();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMenu.Enabled = false;
            PanelMain.Controls.Clear();
            weigherId = 0;
            stripMenuLogIn.Enabled = true;
        }

        private void SeedWeigher()
        {
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

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sPort != null && sPort.IsOpen)
            {
                _sp.Dispose();
                sPort.Close();
            }
        }

        private void productMgtMenu_Click(object sender, EventArgs e)
        {
            ProductCrudUC uc = new ProductCrudUC();
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }

        private void customerMgtMenu_Click(object sender, EventArgs e)
        {
            CustomerCrudUC uc = new CustomerCrudUC(this);
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }

        private void supplierMgtMenu_Click(object sender, EventArgs e)
        {
            SupplierCrudUC uc = new SupplierCrudUC();
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }

        private void txtIndicator_DoubleClick(object sender, EventArgs e)
        {
            txtIndicator.ReadOnly = false;
        }

        private void txtIndicator_Leave(object sender, EventArgs e)
        {
            txtIndicator.ReadOnly = true;
        }
    }
}
