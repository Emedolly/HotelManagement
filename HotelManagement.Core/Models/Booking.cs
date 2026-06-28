using HotelManagement.Core.Enums;

namespace HotelManagement.Core.Models;

public class Booking
{
   public int Id { get; set; }
   public Room Room { get; set; }//Room being booked
   public Guest Guest { get; set; } //Guest who booked 
   public DateTime CheckInDate { get; set; }
   public DateTime CheckOutDate { get; set; }
   public BookingStatus Status { get; set; }

   public Booking()
   {
      Status = BookingStatus.Pending;
   }

   public int GetTotalNights()
   {
      return (CheckOutDate - CheckInDate).Days;
   }

   public decimal CalculateTotalPrice()
   {
      return GetTotalNights() * Room.BasePricePerNight;
   }
}