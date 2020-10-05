using ATMAPI.Models;

namespace ATMAPI.Services
{
    public class ICashWithdrawalService
    {
        //create a constructor for the Account class
        Account account = new Account();

        //set the Overdraft limit for the particular account
        public void setOverDraft(double Overdraft)
        {
            account.setOverdraft(Overdraft);
        }

        //This method performs the withdrawal transaction based on the Withdrawal amount, ATM Balance and PIN number provided
        public string WithdrawAmount(long Pin, double WithdrawalAmount, double ATMBalance)
        {
            //IPinValidationService constructor call
            IPinValidationService pinValidationService = new IPinValidationService();

            //Verifying the entered PIN number is correct
            if (pinValidationService.ValidatePin(Pin))
            {
                //Verify if the Withdrawal amount entered is less than or equal to the sum of Balance and Overdraft, proceed
                if (WithdrawalAmount <= (account.getAccountBalance() + account.getOverDraft()))
                {
                    //Verify if the Withdrawal amount is less than or equal to the available ATM Balance
                    if (WithdrawalAmount <= ATMBalance)
                    {
                        account.setAccountBalance(account.getAccountBalance() - WithdrawalAmount);

                        return "Current Account Balance = " + account.getAccountBalance();
                    }
                    else
                    {
                        //return error code 412 (one or more conditions failed) along with ATM_ERR, if the ATM does not have enough balance
                        return "ATM_ERR; status code: status code: 412";
                    }

                }
                else
                { //return error code 412 along with FUNDS_ERR: if adequate funds are not available
                    return "FUNDS_ERR; status code: 412";
                }
            }

            else
            {
                //return error code 401 (Unauthorized) if the PIN number entered is incorrect
                return "ACCOUNT_ERR" + "401: Unauthorized";

            }
        }
    }
}
