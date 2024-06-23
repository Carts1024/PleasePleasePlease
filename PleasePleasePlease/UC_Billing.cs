using Mirai_Paradise_Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PleasePleasePlease
{
    public partial class UC_Billing : UserControl
    {
        public List<User> DataBaseUsers { get; private set; }

        public UC_Billing()
        {
            InitializeComponent();
            comboBoxFilterPaymentStatus.Items.AddRange(new object[] { "Pending", "Paid" });

            using (DataContext context = new DataContext())
            {
                // Retrieve users from the database and store in DataBaseUsers list
                DataBaseUsers = context.Users.OrderBy(u => u.Index).ToList();
            }

            // Assign DataBaseUsers list to DataGridView DataSource
            guna2DataGridView1.DataSource = DataBaseUsers;

            // Optionally, refresh the DataGridView to display the data
            guna2DataGridView1.Refresh();
        }


        private void buttonGenerateInvoice_Click(object sender, EventArgs e)
        {
            // Code for Generating Invoice starts here
        }

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            // Code for Search starts here
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = true;
        }


    }
}
