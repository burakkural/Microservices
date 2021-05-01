using Reservation.API.Infastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int bkgNumber)
        {
            return new ReservationDTO 
            { 
                BkgNumber = bkgNumber,
                BkgDate = DateTime.Now,
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(10000), 
                CheckinDate = DateTime.Now.AddDays(30),
                CheckoutDate = DateTime.Now.AddDays(37)
            };
        }
    }
}
