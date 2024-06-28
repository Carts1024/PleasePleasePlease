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
            GridRead();

            comboBoxRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBoxRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
            comboBoxFilterRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBoxFilterRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
        }

        public void GridRead()
        {
            using (DataContext context = new DataContext())
            {
                // Retrieve rooms from the database including related status data
                DatabaseRooms = context.Rooms
             //                          .Include(r => r.RoomStatus)
                                       .OrderBy(r => r.Index)
                                       .ToList();

                // Display the rooms in the DataGridView
                dataGridViewRoom.DataSource = null;
                dataGridViewRoom.DataSource = DatabaseRooms;
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
                        // Create a new Room object and add it to the database
                        var newRoom = new Room()
                        {
                            RoomNumber = roomNumber,
                            RoomType = roomType,
                            RoomPrice = roomRate,
                            FloorNumber = floorNumber,
                            Capacity = maxCap,
                   //         RoomStatusID = roomStatus // Ensure RoomStatusID is correctly set
                        };

                        context.Rooms.Add(newRoom);
                        context.SaveChanges();

                        // Clear input fields
                        textBoxRoomNo.Clear();
                        comboBoxRoomType.SelectedIndex = -1;
                        comboBoxRoomStatus.SelectedIndex = -1;
                        textBoxRoomRate.Clear();
                        textBoxFloorNo.Clear();
                        textBoxMaxCapacity.Clear();

                        // Show confirmation dialog
                        Dialogue_RoomAdded roomAdded = new Dialogue_RoomAdded();
                        roomAdded.Show();
                        GridRead();
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

        private void dataGridViewRoom_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
    }
}
