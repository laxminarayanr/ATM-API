using ATMAPI.Models;

namespace ATMAPI.Services
{
    public class ICashWithdrawalService
    {

        Account account = new Account();

        public void setOverDraft(double Overdraft)
        {
            account.setOverdraft(Overdraft);
        }

        public string WithdrawAmount(long Pin, double WithdrawalAmount, double ATMBalance)
        {

            IPinValidationService pinValidationService = new IPinValidationService();

            if (pinValidationService.ValidatePin(Pin))
            {

                if (WithdrawalAmount <= (account.getAccountBalance() + account.getOverDraft()))
                {
                    if (WithdrawalAmount <= ATMBalance)
                    {
                        account.setAccountBalance(account.getAccountBalance() - WithdrawalAmount);

                        return "Current Account Balance = " + account.getAccountBalance();
                    }
                    else
                    {
                        return "ATM_ERR; status code: status code: 412";
                    }

                }
                else
                {
                    return "FUNDS_ERR; status code: 412";
                }
            }

            else
            {

                return "ACCOUNT_ERR" + "401: Unauthorized";

            }
        }
    }
}
