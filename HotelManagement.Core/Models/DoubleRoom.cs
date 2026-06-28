using HotelManagement.Core.Enums;

namespace HotelManagement.Core.Models;

public class DoubleRoom : Room
{
    public DoubleRoom()
    {
        Type = RoomType.Double;
        BasePricePerNight = 150m;
        Capacity = 2;
    }
    public override string GetAmenities()
    {
        return "Free wi-fi, TV, double bed, workdesk";
    }
}