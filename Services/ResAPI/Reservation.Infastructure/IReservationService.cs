using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Infastructure
{
  public  interface IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int bkgNumber);
    }
}
