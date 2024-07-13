using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PleasePleasePlease;

namespace Mirai_Paradise_Hotel
{
    public class RoomOccupancyCalculator
    {
        private readonly DataContext _context;

        public RoomOccupancyCalculator(DataContext context)
        {
            _context = context;
        }

        public int CalculateRoomOccupancyPercentage()
        {
            var Rooms = _context.Set<Room>().ToList();
            var occupiedRooms = Rooms.Count(room => room.RoomStatus == "Occupied");
            return CalculatePercentage(occupiedRooms, Rooms.Count);
        }

        public int CalculateRoomMaintenancePercentage()
        {
            var Rooms = _context.Set<Room>().ToList();
            var maintenanceRooms = Rooms.Count(room => room.RoomStatus == "Maintenance");
            return CalculatePercentage(maintenanceRooms, Rooms.Count);
        }

        public int CalculateRoomAvailablePercentage()
        {
            var Rooms = _context.Set<Room>().ToList();
            var availableRooms = Rooms.Count(room => room.RoomStatus == "Available");
            return CalculatePercentage(availableRooms, Rooms.Count);
        }

        public int CalculateStandardRoomOccupancyPercentage()
        {
            var standardRooms = _context.Set<StandardRoom>().ToList();
            var occupiedStandardRooms = standardRooms.Count(room => room.RoomStatus == "Occupied");
            return CalculatePercentage(occupiedStandardRooms, standardRooms.Count);
        }

        public int CalculateStandardRoomAvailablePercentage()
        {
            var standardRooms = _context.Set<StandardRoom>().ToList();
            var availableStandardRooms = standardRooms.Count(room => room.RoomStatus == "Available");
            return CalculatePercentage(availableStandardRooms, standardRooms.Count);
        }

        public int CalculateStandardRoomMaintenancePercentage()
        {
            var standardRooms = _context.Set<StandardRoom>().ToList();
            var maintenanceStandardRooms = standardRooms.Count(room => room.RoomStatus == "Maintenance");
            return CalculatePercentage(maintenanceStandardRooms, standardRooms.Count);
        }
        public int CalculateDeluxeRoomOccupancyPercentage()
        {
            var deluxeRooms = _context.Set<DeluxeRoom>().ToList();
            var occupiedDeluxeRooms = deluxeRooms.Count(room => room.RoomStatus == "Occupied");
            return CalculatePercentage(occupiedDeluxeRooms, deluxeRooms.Count);
        }

        public int CalculateDeluxeRoomAvailablePercentage()
        {
            var deluxeRooms = _context.Set<DeluxeRoom>().ToList();
            var availableDeluxeRooms = deluxeRooms.Count(room => room.RoomStatus == "Available");
            return CalculatePercentage(availableDeluxeRooms, deluxeRooms.Count);
        }

        public int CalculateDeluxeRoomMaintenancePercentage()
        {
            var deluxeRooms = _context.Set<DeluxeRoom>().ToList();
            var maintenanceDeluxeRooms = deluxeRooms.Count(room => room.RoomStatus == "Maintenance");
            return CalculatePercentage(maintenanceDeluxeRooms, deluxeRooms.Count);
        }

        public int CalculateSuiteOccupancyPercentage()
        {
            var suiteRooms = _context.Set<Suite>().ToList();
            var occupiedSuiteRooms = suiteRooms.Count(room => room.RoomStatus == "Occupied");
            return CalculatePercentage(occupiedSuiteRooms, suiteRooms.Count);
        }

        public int CalculateSuiteAvailablePercentage()
        {
            var suiteRooms = _context.Set<Suite>().ToList();
            var availableSuiteRooms = suiteRooms.Count(room => room.RoomStatus == "Available");
            return CalculatePercentage(availableSuiteRooms, suiteRooms.Count);
        }

        public int CalculateSuiteMaintenancePercentage()
        {
            var suiteRooms = _context.Set<Suite>().ToList();
            var maintenanceSuiteRooms = suiteRooms.Count(room => room.RoomStatus == "Maintenance");
            return CalculatePercentage(maintenanceSuiteRooms, suiteRooms.Count);
        }
        private int CalculatePercentage(int occupiedRooms, int totalRooms)
        {
            if (totalRooms == 0) return 0;
            return (occupiedRooms * 100) / totalRooms;
        }
    }
}
