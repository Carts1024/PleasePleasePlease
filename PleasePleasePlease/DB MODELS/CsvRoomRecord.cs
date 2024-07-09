 using CsvHelper.Configuration.Attributes;

public class RoomExportBluePrint
{
    [Name("Index")]
    public int Index { get; set; }

    [Name("Room Number")]
    public int RoomNumber { get; set; }

    [Name("Room Status")]
    public string RoomStatus { get; set; }

    [Name("Room Type")]
    public string RoomType { get; set; }

    [Name("Room Price")]
    public decimal RoomPrice { get; set; }

    [Name("Floor Number")]
    public int FloorNumber { get; set; }

    [Name("Bed Type")]
    public string BedType { get; set; }

    [Name("Capacity")]
    public int Capacity { get; set; }
}
 