

using System.ComponentModel;

namespace ATMAPI.Models
{
    public class Account
    {
       
        private double _AccountBalance { get; set; }

        private long _AccountNumber { get; set; }

        private double _Overdraft { get; set; }

       
        private string _AccountHolderName { get; set; }     

       

        public double getAccountBalance()
        {
            return _AccountBalance;
        }

        public void setAccountBalance(double Value)
        {
            _AccountBalance = Value;
        }

        public void setAccountNumber(long AccountNumber)
        {
            _AccountNumber = AccountNumber;
        }

        //This method returns the Account Number
        public long getAccountNumber()
        {
            return _AccountNumber;
        }
        public void setOverdraft(double Overdraft)
        {
            _Overdraft = Overdraft;
        }

        public double getOverDraft()
        {
            return _Overdraft;
        }

        public void setAccountHolderName(string Name)
        {
            _AccountHolderName = Name;
        }

        public string getAccountHolderName()
        {
            return _AccountHolderName;
        }
    }
}
