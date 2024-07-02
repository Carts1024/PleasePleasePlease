using System;
using System.Linq;
using System.Windows.Forms;

namespace Mirai_Paradise_Hotel
{
    public partial class Room_Update : Form
    {
        private Room _selectedRoom;
        public Room_Update()
        {
            InitializeComponent();
            comboBoxRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBoxRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance" });
            comboBoxRoomBedType.Items.AddRange(new object[] { "Double/Twin", "Queen", "King" });

        }

        public void SetSelectedRoom(Room selectedRoom)
        {
            _selectedRoom = selectedRoom;

            if (selectedRoom != null)
            {
                textBoxRoomNo.Text = selectedRoom.RoomNumber.ToString();
                comboBoxRoomType.SelectedItem = selectedRoom.RoomType;
                comboBoxRoomType.Enabled = false;
                comboBoxRoomStatus.SelectedItem = selectedRoom.RoomStatus;
                textBoxRoomRate.Text = selectedRoom.RoomPrice.ToString();
                textBoxFloorNo.Text = selectedRoom.FloorNumber.ToString();

                if (selectedRoom is StandardRoom standardRoom)
                {
                    comboBoxRoomBedType.Text = standardRoom.BedType;
                    textBoxMaxCapacity.Text = standardRoom.Capacity.ToString();
                }
                else if (selectedRoom is DeluxeRoom deluxeRoom)
                {
                    comboBoxRoomBedType.Text = deluxeRoom.BedType;
                    textBoxMaxCapacity.Text = deluxeRoom.Capacity.ToString();
                }
                else if (selectedRoom is Suite suite)
                {
                    comboBoxRoomBedType.Text = suite.BedType;
                    textBoxMaxCapacity.Clear();  // Suites don't have capacity?
                }
            }
        }

        private void GradButtonAddRoom_Click(object sender, EventArgs e)
        {
            UpdateRoom(_selectedRoom);
        }

        private void UpdateRoom(Room selectedRoom)
        {
            using (DataContext context = new DataContext())
            {
                Room room = context.Rooms.Find(selectedRoom.RoomNumber);
                if (room != null)
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
                            room.RoomNumber = roomNumber;
                            room.RoomStatus = roomStatus;
                            room.RoomPrice = roomRate;
                            room.RoomType = roomType;
                            room.FloorNumber = floorNumber;
                            // Update properties specific to room types
                            if (room is StandardRoom standardRoom)
                            {
                                standardRoom.BedType = bedType;
                                standardRoom.Capacity = maxCap;
                            }
                            else if (room is DeluxeRoom deluxeRoom)
                            {
                                deluxeRoom.BedType = bedType;
                                deluxeRoom.Capacity = maxCap;
                            }
                            else if (room is Suite suiteRoom)
                            {
                                suiteRoom.BedType = bedType;
                                suiteRoom.Capacity = maxCap; // Suites might have a capacity, depending on your model
                            }

                            context.SaveChanges();
                            this.Close();
                        }
                    }
                }
                else
                {
                    // Room not found, handle this case appropriately (e.g., show an error message)
                    MessageBox.Show("Room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

