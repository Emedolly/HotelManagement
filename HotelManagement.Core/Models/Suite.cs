using HotelManagement.Core.Enums;

namespace HotelManagement.Core.Models;

public class Suite:Room
{
    public Suite()
    {
        Type = RoomType.Suite;
        BasePricePerNight = 300m;
        Capacity = 4;
    }
    public override string GetAmenities()
    {
        return "Free wi-fi, TV, Single bed, workdesk";
    }
}