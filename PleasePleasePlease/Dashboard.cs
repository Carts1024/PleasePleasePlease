using PleasePleasePlease;
using Practice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirai_Paradise_Hotel
{
    public partial class Dashboard : Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;

        // Constructor
        public Dashboard()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
            this.FormClosed += Dashboard_FormClosed; // Handle form closed event
            random = new Random();
        }

        // Methods
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null && btnSender is Button)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Padding = new Padding(35, 0, 0, 0);
                    currentButton.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    currentButton.BackColor = SelectThemeColor(); // Set random background color
                }
            }
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void DisableButton()
        {
            if (panelBase == null) return;

            foreach (Control previousBtn in panelBase.Controls)
            {
                if (previousBtn is Button)
                {
                    previousBtn.BackColor = Color.FromArgb(45, 106, 79);
                    previousBtn.ForeColor = Color.Transparent;
                    previousBtn.Padding = new Padding(13, 0, 0, 0);
                    previousBtn.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                }
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            buttonDashboard.Click += buttonDashboard_Click;
            buttonGuests.Click += buttonGuests_Click;
            buttonRooms.Click += buttonRooms_Click;
            buttonBooking.Click += buttonBooking_Click;
            buttonBilling.Click += buttonBilling_Click;
            buttonAnalytics.Click += buttonAnalytics_Click;
            buttonAccounts.Click += buttonSettings_Click;

            // Load the default page
            LoadUserControl(new UC_Dashboard());
        }

        private void LoadUserControl(UserControl userControl)
        {
            if (panelContainer == null) return;

            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Dashboard());
            ActivateButton(sender);
        }

        private void buttonGuests_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Guest1());
            ActivateButton(sender);
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Room1());
            ActivateButton(sender);
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Booking1());
            ActivateButton(sender);
        }

        private void buttonBilling_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Billing());
            ActivateButton(sender);
        }

        private void buttonAnalytics_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ReportAnalytics());
            ActivateButton(sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Accounts());
            ActivateButton(sender);
        }

        // for ear panels
        private void lblListofGuest_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Guest2());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // ignore this
            // refer to GradButtonLogOut instead
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Perform any necessary cleanup here

            // Ensure the application exits completely
            Application.Exit();
        }

        private void GradButtonLogOut_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            login.Show();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
    }
}
