using PleasePleasePlease;
using Practice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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

        public List<User> DataBaseUsers { get; private set; }
        private Guest _selectedGuest;
        private Booking _selectedBooking;

        //    private User currentUser; // Assume this holds the current logged-in user

        // Constructor
        public Dashboard()
        {
            InitializeComponent();
            //       this.currentUser = user; // Initialize the current user
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
                    currentButton.BackColor = SelectThemeColor();
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

        public void ActivateBookingButton()
        {
            ActivateButton(buttonBooking);
        }

        public void ActivateBillingButton()
        {
            ActivateButton(buttonBilling);
        }

        // Public method to set the selected guest
        public void SetSelectedGuest(Guest guest)
        {
            _guest = guest;
        }

        public void SetSelectedBooking(Booking booking)
        {
            _selectedBooking = booking;
        }
        public void ClearSelectedGuest()
        {
            _selectedGuest = null;
        }

        public void ClearSelectedBooking()
        {
            _selectedBooking = null;
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
            var currentUser = UserSession.CurrentUser;
            // Disable the settings button if the user is a manager
            if (currentUser.AccountType == "Administrator")
            {
                buttonAccounts.Visible = true;
                buttonAnalytics.Visible = true;
                buttonRooms.Visible = true;
            }
            else if (currentUser.AccountType == "Manager")
            {
                buttonAnalytics.Visible = true;
                buttonRooms.Visible = true;
            }

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
        private Button _bookingButton;       
        private Guest _guest;
        private Booking _booking;
        private void buttonGuests_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Guest1(this, panelContainer));
            ActivateButton(sender);
        }
        private void buttonRooms_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Room1());
            ActivateButton(sender);
        }

 
        private void buttonBooking_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Booking1(_selectedGuest, this, panelContainer));
            ActivateButton(sender);
        }
            
    
        private void buttonBilling_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Billing(_selectedBooking, _selectedGuest));
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
