using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Windows.Forms;

namespace Mirai_Paradise_Hotel
{
    public partial class Details_AvailRooms : Form
    {
        public Details_AvailRooms()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadAvailableRooms();
        }

        private void LoadAvailableRooms()
        {
            using (var context = new DataContext())
            {
                var availableRooms = context.Rooms
                    .Where(r => r.RoomStatus == "Available")
                    .ToList();

                var roomDisplays = availableRooms.Select(room => new
                {
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

                guna2DataGridViewDetailsAvailRooms.DataSource = null;
                guna2DataGridViewDetailsAvailRooms.DataSource = roomDisplays;
            }
        }

        private void InitializeDataGridView()
        {
            guna2DataGridViewDetailsAvailRooms.AutoGenerateColumns = false;

            guna2DataGridViewDetailsAvailRooms.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomNumber",
                HeaderText = "Room Number"
            });

            guna2DataGridViewDetailsAvailRooms.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomStatus",
                HeaderText = "Room Status"
            });

            guna2DataGridViewDetailsAvailRooms.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomType",
                HeaderText = "Room Type"
            });

            guna2DataGridViewDetailsAvailRooms.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomPrice",
                HeaderText = "Room Price"
            });

            guna2DataGridViewDetailsAvailRooms.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FloorNumber",
                HeaderText = "Floor Number"
            });

            guna2DataGridViewDetailsAvailRooms.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BedType",
                HeaderText = "Bed Type"
            });

            guna2DataGridViewDetailsAvailRooms.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Capacity",
                HeaderText = "Capacity"
            });
        }
    }
}
