using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infastructure;
using Reservation.API.Models;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        public readonly IReservationService reservationService;
        public ReservationController(IReservationService ReservationService)
        {
            reservationService = ReservationService;     
        }

        [HttpGet("{bkgNumber}")]
        public ReservationDTO Get(int bkgNumber)
        {
            return reservationService.GetResByBkgNumber(bkgNumber);
        }
    }
}
