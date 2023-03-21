using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckScale.Library.Data.DBContext;
using TruckScale.Library.Repositories;

namespace TruckScale.UI.UserControls
{
    public partial class WeighingUC : UserControl
    {
        public WeighingUC()
        {
            InitializeComponent();
            
            CustomerRepository db = new CustomerRepository(new ScaleDbContext());

            db.Insert(new Library.Data.Models.Customer { Name = "Test Customer" });
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
