using HotelManagement.Core.Enums;

namespace HotelManagement.Core.Models;

public class PentHouse:Room
{
    public PentHouse()
    {
        Type = RoomType.Penthouse;
        BasePricePerNight = 500m;
        Capacity = 6;
    }
    public override string GetAmenities()
    {
        return "Pent House";
    }
}