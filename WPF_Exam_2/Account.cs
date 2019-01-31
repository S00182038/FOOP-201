using System;

namespace WPF_Exam_2
{
    class Account
    {
        #region properties
        public string AccountHolder { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
        public static DateTime? Date { get; set; } = null;
        #endregion

        #region Constructors
        public Account(string holder, string number,  string type, decimal balance)
        {
            this.AccountHolder = holder;
            this.AccountNumber = number;
            this.Balance = balance;
            this.AccountType = type;
        }
        public Account()
        {

        }
        #endregion

        //override method
        public override string ToString()
        {
            return string.Format($"{AccountHolder} - {AccountNumber}");
        }

        //method to display the member details in the text block
        public String DisplayAccountDetails()
        {
            return String.Format("{0}\t\t{1}\n{2}\t\t{3}\n{4}\t\t{5}\n{6}\t\t{7}\n{8}\t\t{9}\n",
                "Name :",
                AccountHolder,
                "Number:",
                AccountNumber,
                "Type:",
                AccountType,
                "Balance :",
                Balance.ToString(),
                "Date :",
                Date
                );
        }
    }
}
