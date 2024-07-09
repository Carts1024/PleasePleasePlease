using CsvHelper.Configuration;

public class CsvRoomRecord
{
    public int Index { get; set; }
    public int RoomNumber { get; set; }
    public string RoomStatus { get; set; }
    public string RoomType { get; set; }
    public decimal RoomPrice { get; set; }
    public int FloorNumber { get; set; }
    public string BedType { get; set; }
    public int Capacity { get; set; }
}

public class CsvRoomRecordMap : ClassMap<CsvRoomRecord>
{
    public CsvRoomRecordMap()
    {
        Map(m => m.Index).Name("Index");
        Map(m => m.RoomNumber).Name("Room Number");
        Map(m => m.RoomStatus).Name("Room Status");
        Map(m => m.RoomType).Name("Room Type");
        Map(m => m.RoomPrice).Name("Room Price");
        Map(m => m.FloorNumber).Name("Floor Number");
        Map(m => m.BedType).Name("Bed Type");
        Map(m => m.Capacity).Name("Capacity");
    }
}