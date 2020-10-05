using Microsoft.VisualBasic;

namespace ATMAPI.Models
{
    public class Card
    {
        //TODO: implementation of getter and setter methods for the Card Number
        public long CardNumber { get; set; }

        //TODO: implementation of getter and setter methods for the Card expiry date
        public DateFormat ExpiryDate { get; set; }

        //TODO" implementation of getter and setter methods for the Card Holder name
        public string CardHolderName { get; set; }

        public long Pin { get; set; }


        public void setPin()
        {
            Pin = 1234;

        }

        //Method to get the PIN set for an ATM card
        public long getPin()
        {
            return Pin;
        }
      
    }
}
