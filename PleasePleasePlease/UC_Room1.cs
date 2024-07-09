using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Mirai_Paradise_Hotel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace PleasePleasePlease
{
    public partial class UC_Room1 : UserControl
    {
        public List<Room> DatabaseRooms { get; private set; }

        public UC_Room1()
        {
            InitializeComponent();
            InitializeUI();
            AccountTypeChecking();
        }

        private void InitializeUI()
        {
            InitializeDataGridView();
            InitializeComboBoxes();
            Load += Form1_Load;
        }

        private void InitializeComboBoxes()
        {
            comboBoxRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBoxRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
            comboBoxFilterRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBoxFilterRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
            comboBoxRoomBedType.Items.AddRange(new object[] { "Double/Twin", "Queen", "King" });
        }

        private void InitializeDataGridView()
        {
            dataGridViewRoom.AutoGenerateColumns = false;

            dataGridViewRoom.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Index",
                HeaderText = "Index"
            });

            dataGridViewRoom.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomNumber",
                HeaderText = "Room Number"
            });

            dataGridViewRoom.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomStatus",
                HeaderText = "Room Status"
            });

            dataGridViewRoom.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomType",
                HeaderText = "Room Type"
            });

            dataGridViewRoom.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomPrice",
                HeaderText = "Room Price"
            });

            dataGridViewRoom.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FloorNumber",
                HeaderText = "Floor Number"
            });

            dataGridViewRoom.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BedType",
                HeaderText = "Bed Type"
            });

            dataGridViewRoom.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Capacity",
                HeaderText = "Capacity"
            });
        }

        private void AccountTypeChecking()
        {
            var currentUser = UserSession.CurrentUser;
            if (currentUser.AccountType != "Administrator")
            {
                panel3.Visible = false;
                panel6.Visible = false;
                panel4.Visible = false;
                panelAddaGuest.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridRead();
        }

        private void GridRead()
        {
            using (var context = new DataContext())
            {
                DatabaseRooms = context.Rooms.OrderBy(r => r.Index).ToList();

                var roomDisplays = DatabaseRooms.Select(room => new
                {
                    room.Index,
                    room.RoomNumber,
                    room.RoomStatus,
                    room.RoomType,
                    room.RoomPrice,
                    room.FloorNumber,
                    BedType = (room is StandardRoom standardRoom) ? standardRoom.BedType :
                              (room is DeluxeRoom deluxeRoom) ? deluxeRoom.BedType :
                              (room is Suite suite) ? suite.BedType : null,
                    Capacity = (room is StandardRoom standardRooms) ? standardRooms.Capacity :
                               (room is DeluxeRoom deluxeRooms) ? deluxeRooms.Capacity :
                               (room is Suite suites) ? suites.Capacity : (int?)null
                }).ToList();

                dataGridViewRoom.DataSource = null;
                dataGridViewRoom.DataSource = roomDisplays;
            }
        }

        private void AddRoom()
        {
            using (var context = new DataContext())
            {
                var roomNumberText = textBoxRoomNo.Text;
                var roomType = comboBoxRoomType.Text;
                var roomStatus = comboBoxRoomStatus.Text;
                var roomRateText = textBoxRoomRate.Text;
                var floorNumberText = textBoxFloorNo.Text;
                var bedType = comboBoxRoomBedType.Text;
                var maxCapText = textBoxMaxCapacity.Text;

                if (!string.IsNullOrEmpty(roomNumberText) &&
                    !string.IsNullOrEmpty(roomType) &&
                    !string.IsNullOrEmpty(roomStatus) &&
                    !string.IsNullOrEmpty(roomRateText) &&
                    !string.IsNullOrEmpty(floorNumberText) &&
                    !string.IsNullOrEmpty(maxCapText))
                {
                    if (int.TryParse(roomNumberText, out int roomNumber) &&
                        decimal.TryParse(roomRateText, out decimal roomRate) &&
                        int.TryParse(floorNumberText, out int floorNumber) &&
                        int.TryParse(maxCapText, out int maxCap))
                    {
                        int nextIndex = context.Rooms.Any() ? context.Rooms.Max(r => r.Index) + 1 : 1;

                        Room newRoom = roomType switch
                        {
                            "Standard" => new StandardRoom()
                            {
                                RoomNumber = roomNumber,
                                RoomStatus = roomStatus,
                                RoomPrice = roomRate,
                                RoomType = roomType,
                                BedType = bedType,
                                FloorNumber = floorNumber,
                                Capacity = maxCap,
                                Index = nextIndex
                            },
                            "Deluxe" => new DeluxeRoom()
                            {
                                RoomNumber = roomNumber,
                                RoomStatus = roomStatus,
                                RoomPrice = roomRate,
                                RoomType = roomType,
                                BedType = bedType,
                                FloorNumber = floorNumber,
                                Capacity = maxCap,
                                Index = nextIndex
                            },
                            "Suite" => new Suite()
                            {
                                RoomNumber = roomNumber,
                                RoomStatus = roomStatus,
                                RoomPrice = roomRate,
                                RoomType = roomType,
                                BedType = bedType,
                                FloorNumber = floorNumber,
                                Capacity = maxCap,
                                Index = nextIndex
                            },
                            _ => null
                        };

                        if (newRoom != null)
                        {
                            context.Rooms.Add(newRoom);
                            context.SaveChanges();
                            ResetInputFields();
                            GridRead();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid numerical values for Room Number, Room Rate, Floor Number, and Maximum Capacity.");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.");
                }
            }
        }

        private void ResetInputFields()
        {
            textBoxRoomNo.Clear();
            textBoxRoomRate.Clear();
            textBoxFloorNo.Clear();
            textBoxMaxCapacity.Clear();
            comboBoxRoomType.SelectedIndex = -1;
            comboBoxRoomStatus.SelectedIndex = -1;
            comboBoxRoomBedType.SelectedIndex = -1;
        }

        private void UpdateRoom(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRoomDisplay = dataGridViewRoom.Rows[e.RowIndex].DataBoundItem;
                if (selectedRoomDisplay != null)
                {
                    var selectedRoom = DatabaseRooms.FirstOrDefault(r => r.Index == (int)selectedRoomDisplay.GetType().GetProperty("Index").GetValue(selectedRoomDisplay));
                    if (selectedRoom != null)
                    {
                        var updateForm = new Room_Update();
                        updateForm.SetSelectedRoom(selectedRoom);
                        updateForm.FormClosed += (s, args) => GridRead();
                        updateForm.Show();
                    }
                }
            }
        }

        // Event handlers
        private void GradButtonAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom();

        }

        private void dataGridViewRoom_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            UpdateRoom(sender, e);
        }

        private void labelListofRoom_Click(object sender, EventArgs e)
        {
            panelListofRoom.Visible = true;
            panel3.Visible = true;
            panel5.Visible = true;
        }

        private void labelAddRoom_Click(object sender, EventArgs e)
        {
            panelListofRoom.Visible = false;
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            // Ignore this
            // Refer to GradButtonAddRoom_Click instead
        }

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            // Code for search starts here
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = true;
        }

        private void buttonEditRooms_Click(object sender, EventArgs e)
        {

            buttonExitEditRooms.Visible = true;
            // ColumnRoomRate.ReadOnly = false;
        }

        private void buttonExitEditRooms_Click(object sender, EventArgs e)
        {

            buttonExitEditRooms.Visible = false;
            // ColumnRoomRate.ReadOnly = true;
        }

        private void buttonSaveEditRooms_Click(object sender, EventArgs e)
        {
            // Alter Information in Database and Save code starts here
            buttonExitEditRooms.Visible = false;
            // ColumnRoomRate.ReadOnly = true;
            var roomUpdated = new Dialogue_RoomUpdated();
            roomUpdated.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panelListofRoom.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxRoomType.SelectedIndex)
            {
                case 0:
                    textBoxRoomRate.Text = "100.00";
                    comboBoxRoomBedType.Text = "Double/Twin";
                    textBoxMaxCapacity.Text = "2";
                    break;
                case 1:
                    textBoxRoomRate.Text = "500.00";
                    comboBoxRoomBedType.Text = "Queen";
                    textBoxMaxCapacity.Text = "4";
                    break;
                case 2:
                    textBoxRoomRate.Text = "1000.00";
                    comboBoxRoomBedType.Text = "King";
                    textBoxMaxCapacity.Text = "5";
                    break;
            }
        }

        private void dataGridViewRoom_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                var value = dataGridViewRoom.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridViewRoom.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridViewRoom.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void ButtonImportRooms_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = dialog.FileName; // Get the selected file path
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<CsvRoomRecordMap>();

                    var records = csv.GetRecords<CsvRoomRecord>().ToList();  // Get the records from the CSV file

                    using (DataContext context = new DataContext())
                    {
                        var existingRooms = context.Rooms.ToDictionary(r => r.RoomNumber); // Fetch existing rooms

                        foreach (var record in records)
                        {
                            Room newRoom = record.RoomType switch
                            {
                                "Standard" => new StandardRoom()
                                {
                                    RoomNumber = record.RoomNumber,
                                    RoomStatus = record.RoomStatus,
                                    RoomPrice = record.RoomPrice,
                                    RoomType = record.RoomType,
                                    BedType = record.BedType,
                                    FloorNumber = record.FloorNumber,
                                    Capacity = record.Capacity,
                                    Index = record.Index
                                },
                                "Deluxe" => new DeluxeRoom()
                                {
                                    RoomNumber = record.RoomNumber,
                                    RoomStatus = record.RoomStatus,
                                    RoomPrice = record.RoomPrice,
                                    RoomType = record.RoomType,
                                    BedType = record.BedType,
                                    FloorNumber = record.FloorNumber,
                                    Capacity = record.Capacity,
                                    Index = record.Index
                                },
                                "Suite" => new Suite()
                                {
                                    RoomNumber = record.RoomNumber,
                                    RoomStatus = record.RoomStatus,
                                    RoomPrice = record.RoomPrice,
                                    RoomType = record.RoomType,
                                    BedType = record.BedType,
                                    FloorNumber = record.FloorNumber,
                                    Capacity = record.Capacity,
                                    Index = record.Index
                                },
                                _ => null
                            };

                            if (newRoom != null)
                            {
                                if (existingRooms.TryGetValue(record.RoomNumber, out var existingRoom))
                                {
                                    // Update existing room
                                    existingRoom.RoomStatus = record.RoomStatus;
                                    existingRoom.RoomType = record.RoomType;
                                    existingRoom.RoomPrice = record.RoomPrice;
                                    existingRoom.FloorNumber = record.FloorNumber;

                                    if (existingRoom is StandardRoom && newRoom is StandardRoom)
                                    {
                                        ((StandardRoom)existingRoom).BedType = ((StandardRoom)newRoom).BedType;
                                        ((StandardRoom)existingRoom).Capacity = ((StandardRoom)newRoom).Capacity;
                                    }
                                    else if (existingRoom is DeluxeRoom && newRoom is DeluxeRoom)
                                    {
                                        ((DeluxeRoom)existingRoom).BedType = ((DeluxeRoom)newRoom).BedType;
                                        ((DeluxeRoom)existingRoom).Capacity = ((DeluxeRoom)newRoom).Capacity;
                                    }
                                    else if (existingRoom is Suite && newRoom is Suite)
                                    {
                                        ((Suite)existingRoom).BedType = ((Suite)newRoom).BedType;
                                        ((Suite)existingRoom).Capacity = ((Suite)newRoom).Capacity;
                                    }

                                    context.Rooms.Update(existingRoom);
                                }
                                else
                                {
                                    // Add new room
                                    context.Rooms.Add(newRoom);
                                }
                            }
                        }

                        context.SaveChanges();
                    }

                    // Update the DataGridView to reflect the newly imported records
                    GridRead();
                }
            }
        }




        private void ImportButton_Click(object sender, EventArgs e)
        {
            ExportButton.Visible = true;
            ImportButton.Visible = false;
            ButtonImportRooms.Visible = true;
            ButtonExportRooms.Visible = false;
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportButton.Visible = false;
            ImportButton.Visible = true;
            ButtonImportRooms.Visible = false;
            ButtonExportRooms.Visible = true;
        }

        private void ButtonExportRooms_Click(object sender, EventArgs e)
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
                            // Fetch the rooms first
                            var rooms = context.Rooms.ToList();

                            // Transform the rooms after fetching
                            var roomRecords = rooms
                                .Select(r => new CsvRoomRecord
                                {
                                    Index = r.Index,
                                    RoomNumber = r.RoomNumber,
                                    RoomStatus = r.RoomStatus,
                                    RoomType = r.RoomType,
                                    RoomPrice = r.RoomPrice,
                                    FloorNumber = r.FloorNumber,
                                    BedType = r is StandardRoom standardRoom ? standardRoom.BedType :
                                              r is DeluxeRoom deluxeRoom ? deluxeRoom.BedType :
                                              r is Suite suite ? suite.BedType : null,
                                    Capacity = r is StandardRoom standardRooms ? standardRooms.Capacity :
                                               r is DeluxeRoom deluxeRooms ? deluxeRooms.Capacity :
                                               r is Suite suites ? suites.Capacity : 0 // Default to 0 if null
                                })
                                .ToList();

                            csvWriter.Context.RegisterClassMap<CsvRoomRecordMap>();
                            csvWriter.WriteRecords(roomRecords);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error writing CSV file: " + ex.Message);
                    }
                }
            }
        }

    }
}