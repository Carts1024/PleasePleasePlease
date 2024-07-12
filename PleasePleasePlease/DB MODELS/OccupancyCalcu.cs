using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mirai_Paradise_Hotel
{
    public class RoomOccupancyCalculator
    {
        private readonly DataContext _context;

        public RoomOccupancyCalculator(DataContext context)
        {
            _context = context;
        }

        public int CalculateStandardRoomOccupancyPercentage()
        {
            var standardRooms = _context.Set<StandardRoom>().ToList();
            var occupiedStandardRooms = standardRooms.Count(room => room.RoomStatus == "Occupied");
            return CalculatePercentage(occupiedStandardRooms, standardRooms.Count);
        }

        private int CalculatePercentage(int occupiedRooms, int totalRooms)
        {
            if (totalRooms == 0) return 0;
            return (occupiedRooms * 100) / totalRooms;
        }
    }
}
