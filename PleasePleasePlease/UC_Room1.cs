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
    public partial class UC_Room1 : UserControl
    {
        public UC_Room1()
        {
            InitializeComponent();
            comboBoxRoomType.Items.AddRange(new object[] {"Standard", "Deluxe", "Suite"});
            comboBoxRoomStatus.Items.AddRange(new object[] {"Available", "Occupied", "Under Maintenance"});
            comboBoxFilterRoomType.Items.AddRange(new object[] { "Standard", "Deluxe", "Suite" });
            comboBoxFilterRoomStatus.Items.AddRange(new object[] { "Available", "Occupied", "Under Maintenance"});
        }

        private void labelListofRoom_Click(object sender, EventArgs e)
        {
            panelListofRoom.Visible = true;
        }

        private void labelAddRoom_Click(object sender, EventArgs e)
        {
            panelListofRoom.Visible = false;
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            // Add Room to Database code starts here

            textBoxRoomNo.Clear();
            comboBoxRoomType.SelectedIndex = -1;
            comboBoxRoomStatus.SelectedIndex = -1;
            textBoxRoomRate.Clear();
            textBoxFloorNo.Clear();
            textBoxMaxCapacity.Clear();

            Dialogue_RoomAdded roomAdded = new Dialogue_RoomAdded();
            roomAdded.Show();
        }

        private void buttonSearchIcon_Click(object sender, EventArgs e)
        {
            // Code for search starts here
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            panelFilters.Visible = true;
        }

    }
}
