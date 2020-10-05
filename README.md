# ATM-API

This is a Visual Studio project built using .Net Core 3.1, which contains the following components:

Services:
- IBalanceEnquiryService.cs: This service class contains the methods to get the balance for an account, based on the ATM PIN number provided.
- ICashWithdrawalService.cs: This service class contains the methods to withdraw amount from the ATM machine
- IPinValidationService.cs: This service class contains a method for verifying the PIN entered by the user

Models:
- Account.cs: Class to store the details of an Account such as Account Number, Overdraft limit, Account Balance etc.
- Card.cs: Class to store the card details:  Card Number, Expiry Date, Card Holder name and PIN

Controller:
- ATMController.cs: This class contains the wrapper methods corresponding to HttpGet, HttpPush and HttpPut. The methods defined within this class have not yet been used within the respective step definitions.

