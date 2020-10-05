using ATMAPI.Models;

namespace ATMAPI.Services
{
    public class IPinValidationService
    {
        

        public bool ValidatePin(long Pin)
        {
            Card card = new Card();

            //setter method called to set the correct PIN for the card
            card.setPin();

            //validation if the PIN entered by the user matches the correct PIN, return true or false accordingly
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
