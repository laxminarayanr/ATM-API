using ATMAPI.Models;

namespace ATMAPI.Services
{
    public class IBalanceEnquiryService
    {
        private Account _account = new Account();

        //set the Account Number 
        public void setAccountNumber(long AccountNumber)
        {
            _account.setAccountNumber(AccountNumber);
        }
        
        public string BalanceEnquiry(long Pin)
        {
            

            bool isPinValid;

            IPinValidationService pinValidationService = new IPinValidationService();            

            //Verify if the entered PIN number is valid
            isPinValid = pinValidationService.ValidatePin(Pin);           

            if (isPinValid)
            {
                return "Account Balance =" + _account.getAccountBalance(); //return Account balance if entered PIN is valid
            }
            else
            {
                return "ACCOUNT_ERR" + "401: Unauthorized"; //return 401 (Unauthorized) error code, if the entered PIN is invalid
            }
        }
    }
}
