using HotelManagement.Core.Enums;

namespace HotelManagement.Core.Models;

public abstract class Room
{
    public int Id { get; set; }
    public string RoomNumber { get; set; }
    
    public RoomType Type { get; protected set; }
    public decimal BasePricePerNight { get; protected set; }
    public int Capacity { get;protected set; }

    public abstract string GetAmenities();

    public virtual bool IsAvailable(DateTime checkin, DateTime checkout)
    {
        return true;
    }

    public override string ToString()
    {
        return $"{RoomNumber} ({Type}) - ${BasePricePerNight}/night";
    }
}