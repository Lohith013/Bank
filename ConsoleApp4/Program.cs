using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
       public static void Main(string[] args)
        {
            Bank test = new Bank();


            /*             ------ create an new account-------------------------------             */
            AccountHolder accountInfo = new AccountHolder();
            Console.WriteLine("Enter the Account Holder Name");
            accountInfo.Name = Console.ReadLine();
            Console.WriteLine("Enter the Account Holder Address");
            accountInfo.Address = Console.ReadLine();
            Console.WriteLine("Enter the Account Number");
            accountInfo.AccountId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Account Type");
            accountInfo.AccountType = Console.ReadLine();
           // Console.WriteLine("Enter the Account Balance");
           // accountInfo.Balance = Convert.ToDecimal(Console.ReadLine());

            test.AddAccountHolder(accountInfo);
            //Console.WriteLine(test.AccountHoldersList.Count);
            //Console.WriteLine(test.AccountHoldersList[0].Balance);
            /*            ---------------------------- create an new account      ends here--------------------------------------------            */



            /*            ---------------------------- deposit starts here--------------------------------------------            */
            Console.WriteLine("Enter the account number");
            int acNo = Convert.ToInt32(Console.ReadLine());
               
            Console.WriteLine("enter the amount to be deposited");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            test.Deposit(acNo, amount);



            /*            ---------------------------- deposit   ends here--------------------------------------------            */



            /*----------------------------Withdraw starts here----------------*/
            test.Withdraw(acNo, amount);

            /*----------------------------Withdraw ends here here----------------*/


            /*----------------------Fund Transfer starts here----------------------------------*/
            Sbi sbiobj = new Sbi();

            Console.WriteLine("enter the bank");
            string bank = Console.ReadLine();
            Console.WriteLine("enter the account number from which money to transfered");
            int AccNo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the account number which receives amount");
            int AccNo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount to be transfered");
            decimal transfreAmount = Convert.ToDecimal(Console.ReadLine());
            test.FundTransfer(sbiobj, AccNo1, AccNo2, transfreAmount);

            /*----------------------Fund Transfer ends here----------------------------------*/

        }

    }
}