using Microsoft.EntityFrameworkCore;
using Mirai_Paradise_Hotel;
using System;
using System.Collections.Generic;
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
            InitializeDataGridView();
            Load += Form1_Load;
            AccountTypeChecking();
            comboBoxRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBoxRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
            comboBoxFilterRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBoxFilterRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
            comboBoxRoomBedType.Items.AddRange(new object[] { "Double/Twin", "Queen", "King" });
        }

        public void AccountTypeChecking()
        {
            var currentUser = UserSession.CurrentUser;
            if (currentUser.AccountType != "Administator")
            {
                panel3.Visible = false;
                panel6.Visible = false;
                panel4.Visible = false;
                panelAddaGuest.Visible = false;
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            GridRead();
        }

        private void GridRead()
        {
            using (DataContext context = new DataContext())
            {
                // Retrieve rooms from the database including related status data
                DatabaseRooms = context.Rooms.OrderBy(r => r.Index).ToList();

                // Create a list of dynamic objects to hold the room properties
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

                // Display the rooms in the DataGridView
                dataGridViewRoom.DataSource = null;
                dataGridViewRoom.DataSource = roomDisplays;
            }
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
            // ignore this
            // refer to GradButtonAddRoom_Click instead
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
            buttonSaveEditRooms.Visible = true;
            buttonExitEditRooms.Visible = true;
            //  ColumnRoomRate.ReadOnly = false;
        }

        private void buttonExitEditRooms_Click(object sender, EventArgs e)
        {
            buttonSaveEditRooms.Visible = false;
            buttonExitEditRooms.Visible = false;
            //      ColumnRoomRate.ReadOnly = true;
        }

        private void buttonSaveEditRooms_Click(object sender, EventArgs e)
        {
            // Alter Information in Database and Save code starts here

            buttonSaveEditRooms.Visible = false;
            buttonExitEditRooms.Visible = false;
            //    ColumnRoomRate.ReadOnly = true;
            Dialogue_RoomUpdated roomUpdated = new Dialogue_RoomUpdated();
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
            if (comboBoxRoomType.SelectedIndex == 0)
            {
                textBoxRoomRate.Text = "100.00";
                comboBoxRoomBedType.Text = "Double/Twin";
                textBoxMaxCapacity.Text = "2";
            }
            else if (comboBoxRoomType.SelectedIndex == 1)
            {
                textBoxRoomRate.Text = "500.00";
                comboBoxRoomBedType.Text = "Queen";
                textBoxMaxCapacity.Text = "4";
            }
            else
            {
                textBoxRoomRate.Text = "1000.00";
                comboBoxRoomBedType.Text = "King";
                textBoxMaxCapacity.Text = "5";
            }
        }

        private void GradButtonAddRoom_Click(object sender, EventArgs e)
        {
            // Add Room to Database code starts here
            using (DataContext context = new DataContext())
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
                    // Convert string inputs to appropriate types
                    if (int.TryParse(roomNumberText, out int roomNumber) &&
                        decimal.TryParse(roomRateText, out decimal roomRate) &&
                        int.TryParse(floorNumberText, out int floorNumber) &&
                        int.TryParse(maxCapText, out int maxCap))
                    {
                        // Calculate the next available index
                        int nextIndex = context.Rooms.Any() ? context.Rooms.Max(r => r.Index) + 1 : 1;

                        // Create a new Room object and add it to the database
                        if (comboBoxRoomType.Text == "Standard")
                        {
                            var newRoom = new StandardRoom()
                            {
                                RoomNumber = roomNumber,
                                RoomStatus = roomStatus,
                                RoomPrice = roomRate,
                                RoomType = roomType,
                                BedType = bedType,
                                FloorNumber = floorNumber,
                                Capacity = maxCap,
                                Index = nextIndex
                            };
                            context.Rooms.Add(newRoom);
                            context.SaveChanges();
                        }
                        else if (comboBoxRoomType.Text == "Deluxe")
                        {
                            var newRoom = new DeluxeRoom()
                            {
                                RoomNumber = roomNumber,
                                RoomStatus = roomStatus,
                                RoomPrice = roomRate,
                                RoomType = roomType,
                                BedType = bedType,
                                FloorNumber = floorNumber,
                                Capacity = maxCap,
                                Index = nextIndex
                            };
                            context.Rooms.Add(newRoom);
                            context.SaveChanges();
                        }
                        else
                        {
                            var newRoom = new Suite()
                            {
                                RoomNumber = roomNumber,
                                RoomStatus = roomStatus,
                                RoomPrice = roomRate,
                                RoomType = roomType,
                                BedType = bedType,
                                FloorNumber = floorNumber,
                                Capacity = maxCap,
                                Index = nextIndex
                            };
                            context.Rooms.Add(newRoom);
                            context.SaveChanges();
                        }

                        // Reset input fields after successful addition
                        textBoxRoomNo.Clear();
                        textBoxRoomRate.Clear();
                        textBoxFloorNo.Clear();
                        textBoxMaxCapacity.Clear();
                        comboBoxRoomType.SelectedIndex = -1;
                        comboBoxRoomStatus.SelectedIndex = -1;
                        comboBoxRoomBedType.SelectedIndex = -1;

                        GridRead(); // Refresh the DataGridView after adding a new room
                    }
                    else
                    {
                        // Handle conversion errors (e.g., show an error message to the user)
                        MessageBox.Show("Please enter valid numerical values for Room Number, Room Rate, Floor Number, and Maximum Capacity.");
                    }
                }
                else
                {
                    // Handle empty field errors (e.g., show an error message to the user)
                    MessageBox.Show("Please fill in all fields.");
                }
            }
        }
        private void dataGridViewRoom_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            //This event is used to avoid the error of DataGridviewCombobox Cell 
            if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
                object value = dataGridViewRoom.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (!((DataGridViewComboBoxColumn)dataGridViewRoom.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)dataGridViewRoom.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void dataGridViewRoom_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var selectedRoomDisplay = dataGridViewRoom.Rows[e.RowIndex].DataBoundItem;
                if (selectedRoomDisplay != null)
                {
                    var selectedRoom = DatabaseRooms.FirstOrDefault(r => r.Index == (int)selectedRoomDisplay.GetType().GetProperty("Index").GetValue(selectedRoomDisplay));
                    if (selectedRoom != null)
                    {
                        // Create an instance of the Room_Update form
                        Room_Update updateForm = new Room_Update();

                        // Set the selected room data in the update form
                        updateForm.SetSelectedRoom(selectedRoom);

                        // Subscribe to the form's FormClosed event
                        updateForm.FormClosed += (s, args) => GridRead();

                        // Show the update form
                        updateForm.Show();


                    }

                }
            }
        }
    }
}