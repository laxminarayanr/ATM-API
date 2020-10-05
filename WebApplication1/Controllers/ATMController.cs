
using Microsoft.AspNetCore.Mvc;

using ATMAPI.Services;
using Microsoft.AspNetCore.Authentication;

//TODO: using methods created within this class in the ATM step definitions. This is currently throwing an Assembly version mismatch error

namespace ATMAPI.Controllers
{
    [Route("controller")]
    [ApiController]
    public class ATMController : ApiControllerAttribute
    {
        private IBalanceEnquiryService _balanceEnquiryService; 
        private ICashWithdrawalService _cashWithdrawalService;
        private IPinValidationService _pinValidationService;

           

        // GET: used to get the account balance
        [HttpGet]
        public string BalanceEnquiry(long Pin)

        {
            _balanceEnquiryService = new IBalanceEnquiryService();

            string Balance = _balanceEnquiryService.BalanceEnquiry(Pin);

            return Balance;
        }


        // PUT: Used to update the account balance based on the withdrawal amount entered, ATM Balance and PIN
       [HttpPut]
        public string CashWithdrawal(long Pin, double Amount, double ATMBalance)
        {
            _cashWithdrawalService = new ICashWithdrawalService();

            return _cashWithdrawalService.WithdrawAmount(Pin, Amount, ATMBalance);
        }


        // Get: Used to validate the entered PIN
       [HttpGet]
        public string ValidatePin(long pinID)
        {
            _pinValidationService = new IPinValidationService();

            if(_pinValidationService.ValidatePin(pinID) == true)
              {
                return "Valid Pin";
              }

            else
            {
                return "Invalid Pin";
            }

        }


    }
}
     

     
    

