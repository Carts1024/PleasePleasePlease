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
    public partial class UC_Accounts : UserControl
    {
        public UC_Accounts()
        {
            InitializeComponent();
        }

        private void buttonAddAcc_Click(object sender, EventArgs e)
        {
            CreateAccount createAcc = new CreateAccount();
            createAcc.Show();
        }
    }
}
