using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionActivity_2
{
    internal abstract class ATM
    {
        public abstract void WithdrawMoney(decimal amount);
        public abstract void CheckBalance();
        public abstract void DepositMoney(decimal amount);
    }
     internal class BankATM:ATM
    {
        private decimal balance;
        public BankATM(decimal initialbalance)
        {
            balance = initialbalance;
        }
        public override void WithdrawMoney(decimal amount)
        {
            if (amount < balance && amount > 0)
            {
                balance = balance - amount;
                Console.WriteLine($"You have Withdrawn {amount} Available Balance is {balance}");
            }
            else
            {
                Console.WriteLine("Insufficiant Balance orInvalid amount");
            }
        }
        public override void CheckBalance()
        {
            Console.WriteLine($"Your balance is:{balance}");
        }
        public override void DepositMoney(decimal amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
                Console.WriteLine($"You have deposited {amount} Your Current Balance is {balance}");
            }
            else
            {
                Console.WriteLine("Invalid Deposit amount");
            }
        }

    }
}
