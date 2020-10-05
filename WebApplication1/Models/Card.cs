using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ATMAPI.Models
{
    public class Card
    {
        public long CardNumber { get; set; }

        public DateFormat ExpiryDate { get; set; }

        public string CardHolderName { get; set; }

        public long Pin { get; set; }


        public void setPin()
        {
            Pin = 1234;

        }

        public long getPin()
        {
            return Pin;
        }
      
    }
}
