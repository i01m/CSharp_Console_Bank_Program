using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram
{
    enum AccountState //creating enumerated type
    {
        New, Active, UnderAudit, Frozen, Closed
    };

    struct Account //creating structure Account
    {
        public AccountState State;
        public string Name;
        public string Address;
        public int AccountNumber;
        public int Balance;
        public int Overdraft;
    };
    class BankProgram
    {
        public static void PrintAccount (Account a)
        {
            Console.WriteLine("Name : " + a.Name);
            Console.WriteLine("Address : " + a.Address);
            Console.WriteLine("Balance : " + a.Balance);
            
        }

        public static void Main(string[] args)
        {
            Account RobsAccount;
            RobsAccount.Name = "Rob";
            RobsAccount.Balance = 1000000;
            RobsAccount.State = AccountState.Active;

            const int MAX_CUST = 100;
            Account[] Bank = new Account [MAX_CUST];
            Bank[0].Name = "Rob";
            Bank[0].Balance = 1000;
            Bank[0].State = AccountState.Active;
            Bank[0].Address = "Rob's house";
            Bank[1].Name = "Jim";
            Bank[1].State = AccountState.Frozen;
            Bank[1].Balance = 0;
            Bank[1].Address = "Jim's house";

            PrintAccount(Bank[0]);


            Console.ReadKey();
        }
    }
}
