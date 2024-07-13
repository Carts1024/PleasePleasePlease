using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Mirai_Paradise_Hotel;
using Mirai_Paradise_Hotel.DB_MODELS;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

        protected List<InvoiceModel> DataBaseInvoice { get; private set; }

        public UC_Billing(Booking booking, Guest guest)
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
            _booking = booking;
            _guest = guest;
            InitializeGuestInfo();
            CheckGuestInfo();
            LoadData();
            comboBoxFilterPaymentStatus.Items.AddRange(new object[] { "Pending", "Paid" });

            // Initialize DataContext and CheckoutService
            _context = new DataContext();
            _checkoutService = new CheckoutService(_context);
        }

        private void CheckGuestInfo()
        {
            if (_guest != null)
            {
                labelCheckOutUnclicked_Click(this, EventArgs.Empty);
            }
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
                var invoiceData = context.Invoices
                    .Join(context.Guests,
                          invoice => invoice.GuestID,
                          guest => guest.GuestID,
                          (invoice, guest) => new InvoiceViewModel
                          {
                              GuestName = guest.FirstName + " " + guest.LastName,
                              InvoiceNumber = invoice.InvoiceNumber,
                              IssueDate = invoice.IssueDate,
                              DueDate = invoice.DueDate,
                              PaymentStatus = invoice.PaymentStatus,
                              PaymentMethod = invoice.PaymentMethod,
                              TotalAmount = invoice.TotalAmount
                          })
                    .OrderBy(i => i.IssueDate)
                    .ToList();

                dataGridViewRoom.DataSource = null;
                dataGridViewRoom.DataSource = invoiceData;

                // Configure DataGridView columns if necessary
                dataGridViewRoom.Columns["GuestName"].HeaderText = "Guest Name";
                dataGridViewRoom.Columns["InvoiceNumber"].HeaderText = "Invoice Number";
                dataGridViewRoom.Columns["IssueDate"].HeaderText = "Issue Date";
                dataGridViewRoom.Columns["DueDate"].HeaderText = "Due Date";
                dataGridViewRoom.Columns["PaymentStatus"].HeaderText = "Payment Status";
                dataGridViewRoom.Columns["PaymentMethod"].HeaderText = "Payment Method";
                dataGridViewRoom.Columns["TotalAmount"].HeaderText = "Total Amount";
            }
        }

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim().ToLower();

            using (DataContext context = new DataContext())
            {
                var invoiceData = context.Invoices
                    .Join(context.Guests,
                          invoice => invoice.GuestID,
                          guest => guest.GuestID,
                          (invoice, guest) => new InvoiceViewModel
                          {
                              GuestName = guest.FirstName + " " + guest.LastName,
                              InvoiceNumber = invoice.InvoiceNumber,
                              IssueDate = invoice.IssueDate,
                              DueDate = invoice.DueDate,
                              PaymentStatus = invoice.PaymentStatus,
                              PaymentMethod = invoice.PaymentMethod,
                              TotalAmount = invoice.TotalAmount
                          })
                    .Where(i =>
                        i.GuestName.ToLower().Contains(searchText) ||
                        i.PaymentStatus.ToLower().Contains(searchText) ||
                        i.PaymentMethod.ToLower().Contains(searchText))
                    .OrderBy(i => i.IssueDate)
                    .ToList();

                dataGridViewRoom.DataSource = null;
                dataGridViewRoom.DataSource = invoiceData;

                // Configure DataGridView columns if necessary
                dataGridViewRoom.Columns["GuestName"].HeaderText = "Guest Name";
                dataGridViewRoom.Columns["InvoiceNumber"].HeaderText = "Invoice Number";
                dataGridViewRoom.Columns["IssueDate"].HeaderText = "Issue Date";
                dataGridViewRoom.Columns["DueDate"].HeaderText = "Due Date";
                dataGridViewRoom.Columns["PaymentStatus"].HeaderText = "Payment Status";
                dataGridViewRoom.Columns["PaymentMethod"].HeaderText = "Payment Method";
                dataGridViewRoom.Columns["TotalAmount"].HeaderText = "Total Amount";
            }
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = true;
        }

        private void buttonEditBillings_Click(object sender, EventArgs e)
        {
            // Add edit functionality here
        }

        private void buttonExitEditBookings_Click(object sender, EventArgs e)
        {
            // Add exit functionality here
        }

        private void ButtonGenerateInvo_Click(object sender, EventArgs e)
        {
            GenerateQuotation();
            LoadData();
        }

        private void labelCheckOutUnclicked_Click(object sender, EventArgs e)
        {
            earpanelCheckOutClicked.Visible = true;
            panelBaseCheckOut.Visible = true;
            earpanelInvoiceUnclicked.Visible = true;
            ButtonGenerateQuotation.Visible = true;
            ButtonExportInvoice.Visible = false;
            ButtonImportInvoice.Visible = false;
        }

        private void labelInvoiceUnclicked_Click(object sender, EventArgs e)
        {
            earpanelCheckOutClicked.Visible = false;
            panelBaseCheckOut.Visible = false;
            earpanelInvoiceUnclicked.Visible = false;
            ButtonGenerateQuotation.Visible = false;
            ButtonExportInvoice.Visible = true;
            ButtonImportInvoice.Visible = true;
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
                using (DataContext context = new DataContext())
                {
                    // Validate foreign key references
                    var validGuestIds = context.Guests.Select(g => g.GuestID).ToHashSet();
                    var validBookingIds = context.Bookings.Select(b => b.BookingID).ToHashSet();

                    if (!validBookingIds.Contains(_booking.BookingID))
                    {
                        MessageBox.Show($"Error: Booking ID {_booking.BookingID} does not exist in the database.");
                        return;
                    }

                    if (!validGuestIds.Contains(_guest.GuestID))
                    {
                        MessageBox.Show($"Error: Guest ID {_guest.GuestID} does not exist in the database.");
                        return;
                    }

                    var billingService = new BillingService(context);
                    var invoice = billingService.GenerateInvoice(_booking.BookingID, "GenerateQuotation");
                    billingService.SaveQuotation(invoice, $"Invoice_{_booking.BookingID}.pdf");
                    MessageBox.Show("Quotation generated successfully.");
                }
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

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ExportButton.Visible = true;
            ImportButton.Visible = false;
            ButtonImportInvoice.Visible = true;
            ButtonExportInvoice.Visible = false;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportButton.Visible = false;
            ImportButton.Visible = true;
            ButtonImportInvoice.Visible = false;
            ButtonExportInvoice.Visible = true;
        }

        private void ButtonImportInvoice_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void Import()
        {
            ImportRecords();
        }

        private void ImportRecords()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName; // Get the selected file path

                var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    PrepareHeaderForMatch = args => args.Header.ToLower(),
                    HeaderValidated = null, // Disable header validation
                };

                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, csvConfig))
                {
                    csv.Context.TypeConverterCache.AddConverter<DateTime>(new CustomDateTimeConverter());
                    csv.Context.RegisterClassMap<InvoiceMap>();

                    var records = csv.GetRecords<InvoiceModel>().ToList();  // Get the records from the CSV file

                    using (DataContext context = new DataContext())
                    {
                        // Validate foreign key references
                        var validGuestIds = context.Guests.Select(g => g.GuestID).ToHashSet();
                        var validBookingIds = context.Bookings.Select(b => b.BookingID).ToHashSet();
                        var invalidGuestRecords = records.Where(r => !validGuestIds.Contains(r.GuestID)).ToList();
                        var invalidBookingRecords = records.Where(r => !validBookingIds.Contains(r.BookingID)).ToList();

                        if (invalidGuestRecords.Any() || invalidBookingRecords.Any())
                        {
                            var invalidGuestIds = invalidGuestRecords.Select(r => r.GuestID).Distinct();
                            var invalidBookingIds = invalidBookingRecords.Select(r => r.BookingID).Distinct();

                            var errorMessage = "Error: The following IDs do not exist in the database:";
                            if (invalidGuestIds.Any())
                            {
                                errorMessage += $"\nGuest IDs: {string.Join(", ", invalidGuestIds)}";
                            }
                            if (invalidBookingIds.Any())
                            {
                                errorMessage += $"\nBooking IDs: {string.Join(", ", invalidBookingIds)}";
                            }
                            MessageBox.Show(errorMessage);
                            return;
                        }

                        List<InvoiceModel> validRecords = new List<InvoiceModel>();
                        List<string> errors = new List<string>();

                        foreach (var record in records)
                        {
                            try
                            {
                                // Ensure Comments is not null
                                if (record.Comments == null)
                                {
                                    record.Comments = string.Empty;
                                }

                                // Check the booking status
                                var booking = context.Bookings.FirstOrDefault(b => b.BookingID == record.BookingID);
                                if (booking != null && booking.BookingStatus == "Check-Out")
                                {
                                    record.PaymentStatus = "Paid";
                                }

                                var existingInvoice = context.Invoices.FirstOrDefault(b => b.InvoiceNumber == record.InvoiceNumber);
                                if (existingInvoice != null)
                                {
                                    // Update existing record
                                    existingInvoice.Index = record.Index;
                                    existingInvoice.InvoiceNumber = record.InvoiceNumber;
                                    existingInvoice.IssueDate = record.IssueDate;
                                    existingInvoice.DueDate = record.DueDate;
                                    existingInvoice.PaymentStatus = record.PaymentStatus;
                                    existingInvoice.PaymentMethod = record.PaymentMethod;
                                    existingInvoice.TotalAmount = record.TotalAmount;
                                    existingInvoice.Comments = record.Comments;
                                }
                                else
                                {
                                    // Add new record
                                    context.Invoices.Add(record);
                                }
                                validRecords.Add(record);
                            }
                            catch (DbUpdateException ex) when ((ex.InnerException as SqliteException)?.SqliteErrorCode == 19)
                            {
                                errors.Add($"Error importing Invoice ID {record.InvoiceNumber}: Foreign key constraint failed.");
                            }
                            catch (Exception ex)
                            {
                                errors.Add($"Error importing Invoice ID {record.InvoiceNumber}: {ex.Message}");
                            }
                        }

                        if (errors.Any())
                        {
                            var errorMessage = string.Join(Environment.NewLine, errors);
                            MessageBox.Show($"The following errors occurred during import:\n{errorMessage}");
                        }

                        if (validRecords.Any())
                        {
                            try
                            {
                                context.SaveChanges();
                            }
                            catch (DbUpdateException ex) when ((ex.InnerException as SqliteException)?.SqliteErrorCode == 19)
                            {
                                MessageBox.Show("Error saving records: Foreign key constraint failed. Please ensure all foreign keys are valid.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred while saving records: {ex.Message}");
                            }
                        }
                    }

                    // Update the DataGridView to reflect the newly imported records
                    LoadData();
                }
            }
        }




        private class CustomDateTimeConverter : DateTimeConverter
        {
            private readonly string[] formats = { "dd/MM/yyyy", "MM/dd/yyyy", "yyyy-MM-dd" };

            public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
            {
                foreach (var format in formats)
                {
                    if (DateTime.TryParseExact(text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
                    {
                        return date;
                    }
                }
                return base.ConvertFromString(text, row, memberMapData);
            }
        }

        private void ExportRecords()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveDialog.FileName; // Get the selected file path

                using (var writer = new StreamWriter(filePath))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    try
                    {
                        using (var context = new DataContext())
                        {
                            var invoices = context.Invoices.Select(i => new InvoiceExport
                            {
                                Index = i.Index,
                                InvoiceNumber = i.InvoiceNumber,
                                IssueDate = i.IssueDate,
                                DueDate = i.DueDate,
                                PaymentStatus = i.PaymentStatus,
                                PaymentMethod = i.PaymentMethod,
                                TotalAmount = i.TotalAmount,
                                Comments = i.Comments,
                                GuestID = i.GuestID,
                                BookingID = i.BookingID
                            }).ToList();

                            csvWriter.WriteRecords(invoices);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error writing CSV file: " + ex.Message);
                    }
                }
            }
        }

        private void ButtonExportInvoice_Click(object sender, EventArgs e)
        {
            ExportRecords();
        }

    }
}
