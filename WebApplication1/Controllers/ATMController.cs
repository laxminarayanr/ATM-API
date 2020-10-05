using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ATMAPI.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ATMAPI.Services;
using Microsoft.AspNetCore.Authentication;

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


        // PUT: Used to update the account balance based on the withdrawal amount entered
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
     

     
    

