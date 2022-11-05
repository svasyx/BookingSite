using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class Payment
    {
        protected string _dateOfPayment { get; set; } = "05.11.2022";
        protected double _amountOfPayment { get; set; } = 0.00;
        protected string _accountID { get; set; } = "a01";

        public Payment()
        {
            _dateOfPayment = String.Empty;
            _amountOfPayment = 0.00;
            _accountID = String.Empty;
        }

        public Payment(string dateOfPayment, double amountOfPayment, string accountID)
        {

            if (!(String.IsNullOrEmpty(dateOfPayment) && String.IsNullOrEmpty(accountID)))
            {
                _dateOfPayment = dateOfPayment;
                _amountOfPayment = amountOfPayment;
                _accountID = accountID;
            }
        }




        public string GetDateOfPayment()
        {
            string dateOfPayment = String.Empty;
            dateOfPayment = _dateOfPayment;
            return dateOfPayment;
        }

        public string GetAccountID()
        {
            string accountID = String.Empty;
            accountID = _accountID;
            return accountID;
        }

        public double GetAmmountOfPAyment()
        {
            return _amountOfPayment;
        }

        public void SetDateOfPayment(string DateOfPayment)
        {
            _dateOfPayment = DateOfPayment;
        }
        public void SetAmmountOfPayment(double AmmountOfPayment)
        {
            _amountOfPayment = AmmountOfPayment;
        }
        public void SetAccountIDOfPayment(string accountID)
        {
            _accountID = accountID;
        }

        public string GetPaymentInfo()
        {
            return $"Payment info: Date:{_dateOfPayment}, ammount:{_amountOfPayment}, accID:{_accountID}";
        }



    }
}
