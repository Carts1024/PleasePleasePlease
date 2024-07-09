using CsvHelper.Configuration.Attributes;

public class BookingExportDto
{
    [Name("Index")]
    public int Index { get; set; }

    [Name("Booking Id")]
    public int BookingID { get; set; }

    [Name("Check In Date")]
    public DateTime CheckInDate { get; set; }

    [Name("Check In Time")]
    public TimeSpan CheckInTime { get; set; }

    [Name("Check Out Date")]
    public DateTime CheckOutDate { get; set; }

    [Name("Check Out Time")]
    public TimeSpan CheckOutTime { get; set; }

    [Name("Guest Id")]
    public int GuestID { get; set; }

    [Name("Room Number")]
    public int RoomNumber { get; set; }
}
