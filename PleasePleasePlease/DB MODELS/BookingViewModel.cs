using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirai_Paradise_Hotel.DB_MODELS
{
    public class BookingViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckOutDate { get; set; }
        public TimeSpan CheckOutTime { get; set; }
    }

}
