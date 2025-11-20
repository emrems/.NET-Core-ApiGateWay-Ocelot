using Rezervation.API.Infrastructure;
using RezervationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervationAPI.Service
{
    public class RezervationService : IRezervationService
    {
        public RezervationDto getRezervationByBkgNumber(int bkgNumber)
        {
            return new RezervationDto
            {
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(100),
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(39),
                BkgNumber = bkgNumber
            };
        }
    }
}
