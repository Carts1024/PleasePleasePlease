using Microsoft.EntityFrameworkCore;
using Mirai_Paradise_Hotel;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PleasePleasePlease
{
    public partial class UC_Billing : UserControl
    {
        private Guest _guest;
        private Booking _booking;
        private DataContext _context;
        private CheckoutService _checkoutService;

        public List<InvoiceModel> DataBaseInvoice { get; private set; }

        public UC_Billing(Booking booking, Guest guest)
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;

            // Guard clauses to prevent re-assignment
            if (_booking != null || _guest != null)
            {
                throw new InvalidOperationException("UC_Billing already has a booking and guest assigned.");
            }

            _booking = booking;
            _guest = guest;
            InitializeGuestInfo();
            LoadData();
            comboBoxFilterPaymentStatus.Items.AddRange(new object[] { "Pending", "Paid" });

            // Initialize DataContext and CheckoutService
            _context = new DataContext();
            _checkoutService = new CheckoutService(_context);
        }

        private void InitializeGuestInfo()
        {
            if (_guest != null)
            {
                name_lbl.Visible = true;
                GuestName_lbl.Text = $"{_guest.FirstName} {_guest.LastName}";
            }
            else
            {
                name_lbl.Visible = false;
                GuestName_lbl.Visible = false;
            }
        }

        private void LoadData()
        {
            using (DataContext context = new DataContext())
            {
                DataBaseInvoice = context.Invoices.OrderBy(u => u.Index).ToList();
                dataGridViewRoom.DataSource = null;
                dataGridViewRoom.DataSource = DataBaseInvoice;
            }
        }

        private void buttonGenerateInvoice_Click(object sender, EventArgs e)
        {
            // ignore this
        }

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            // Code for Search starts here
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = true;
        }

        private void buttonEditBillings_Click(object sender, EventArgs e)
        {
            buttonSaveEditBillings.Visible = true;
            buttonExitEditBillings.Visible = true;
        }

        private void buttonExitEditBookings_Click(object sender, EventArgs e)
        {
            buttonSaveEditBillings.Visible = false;
            buttonExitEditBillings.Visible = false;
        }

        private void buttonSaveEditBillings_Click(object sender, EventArgs e)
        {
            // Alter Information in Database and Save code starts here
            buttonSaveEditBillings.Visible = false;
            buttonExitEditBillings.Visible = false;
            Dialogue_BillingUpdated billUpdated = new Dialogue_BillingUpdated();
            billUpdated.Show();
        }

        private void ButtonGenerateInvo_Click(object sender, EventArgs e)
        {
            var billingService = new BillingService(_context);
            var invoice = billingService.GenerateInvoice(_booking.BookingID, "ButtonGenerateInvo_Click");
            LoadData();
        }

        private void labelCheckOutUnclicked_Click(object sender, EventArgs e)
        {
            earpanelCheckOutClicked.Visible = true;
            panelBaseCheckOut.Visible = true;
            earpanelInvoiceUnclicked.Visible = true;
            ButtonGenerateQuotation.Visible = false;
        }

        private void labelInvoiceUnclicked_Click(object sender, EventArgs e)
        {
            earpanelCheckOutClicked.Visible = false;
            panelBaseCheckOut.Visible = false;
            earpanelInvoiceUnclicked.Visible = false;
            ButtonGenerateQuotation.Visible = true;
        }

        private void GradButtonCheckOut_Click(object sender, EventArgs e)
        {
            var billingService = new BillingService(_context);
            var invoice = billingService.GenerateInvoice(_booking.BookingID, "GradButtonCheckOut_Click");
            Checkout();
        }

        private void GenerateQuotation()
        {
            try
            {
                var billingService = new BillingService(_context);
                var invoice = billingService.GenerateInvoice(_booking.BookingID, "GenerateQuotation");
                billingService.SaveInvoice(invoice, $"Invoice_{_booking.BookingID}.pdf");
                MessageBox.Show("Invoice generated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating invoice: {ex.Message}");
            }
        }

        private void Checkout()
        {
            try
            {
                _checkoutService.Checkout(_booking.BookingID);
                MessageBox.Show("Checkout process completed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during checkout: {ex.Message}");
            }
        }
    }
}
