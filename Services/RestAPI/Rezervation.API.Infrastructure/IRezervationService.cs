using RezervationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervation.API.Infrastructure
{
    public interface IRezervationService
    {
        public RezervationDto getRezervationByBkgNumber(int bkgNumber);
    }
}
