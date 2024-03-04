using ScaleUI.UI;
using TruckScale.Library.BLL;
using TruckScale.ScaleSerialPort;
using TruckScale.UI.HelperClass;
using TruckScale.UI.UserControls;


namespace TruckScale.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly IUIFactory _factory;
        public int weigherId { get; set; }
        public string? stringWeight { get; set; }

        private ApplicationService _service;

        private ScalePortCon _sp;

        private ScalePort sPort;

        delegate void SetWeight(string weighstring);

        public MainForm(IUIFactory factory)
        {
            InitializeComponent();
            InitializePort();

            _factory = factory;
        }

        private void InitializePort()
        {
            try
            {
                sPort = SettingsGetter.Get();
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
                var dLength = e.Data.Length;
                var newWeight = e.Data.Substring(sPort.StartIndex, sPort.EndIndex);

                SetWeightString(newWeight.ParseWeight());
            }
        }

        public void ClearPanelFromWeighing()
        {
            PanelMain.Controls.Clear();
            stringWeight = txtIndicator.Text;

            ShowTransactions();
        }

        private void ShowUserLogIn()
        {
            var frm = _factory.CreateForm<LogInForm>();
            frm.ShowDialog();

            if (!string.IsNullOrEmpty(GlobalProps.UserName))
            {
                ViewMenu.Enabled = true;
                stripMenuLogIn.Enabled = false;
                ShowTransactions();
            }
        }

        public void ShowTransactions()
        {
            PanelMain.Controls.Clear();
            var uc = _factory.CreateUC<TransactionsUC>();
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

        private void toolMenuUser_Click(object sender, EventArgs e)
        {
            var frm = _factory.CreateForm<WeigherManagementForm>();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
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
                GlobalProps.CurrentWeight = stringWeight;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMenu.Enabled = false;
            PanelMain.Controls.Clear();
            weigherId = 0;
            stripMenuLogIn.Enabled = true;
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
            var frm = _factory.CreateForm<CustomerForm>();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
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

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTransactions();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
