using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using ATMAPI.Models;

namespace ATMAPI.Services
{
    public class IPinValidationService
    {
        

        public bool ValidatePin(long Pin)
        {
            Card card = new Card();

            card.setPin();

            if(Pin == card.getPin())
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
