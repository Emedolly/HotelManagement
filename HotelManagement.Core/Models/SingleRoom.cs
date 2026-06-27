using HotelManagement.Core.Enums;

namespace HotelManagement.Core.Models;

public class SingleRoom : Room
{
    public SingleRoom()
    {
        Type = RoomType.Single;
        BasePricePerNight = 100;
        Capacity = 1;
    }

    public override string GetAmenities()
    {
        return "Free wi-fi, TV, Single bed, workdesk";
    }
}