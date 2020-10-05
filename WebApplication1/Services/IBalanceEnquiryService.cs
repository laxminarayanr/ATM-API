using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using ATMAPI.Models;

namespace ATMAPI.Services
{
    public class IBalanceEnquiryService
    {
        private Account _account = new Account();

        public void setAccountNumber(long AccountNumber)
        {
            _account.setAccountNumber(AccountNumber);
        }
        
        public string BalanceEnquiry(long Pin)
        {
            

            bool isPinValid;

            IPinValidationService pinValidationService = new IPinValidationService();            

            isPinValid = pinValidationService.ValidatePin(Pin);           

            if (isPinValid)
            {
                return "Account Balance =" + _account.getAccountBalance();
            }
            else
            {
                return "ACCOUNT_ERR" + "401: Unauthorized";
            }
        }
    }
}
