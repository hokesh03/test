using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82

{
    public class Program

    {
        public class BankAccount
        {
            private double balance;
            private string name;
            public BankAccount(double balance,string name)
            {
                this.balance = balance;
                this.name = name;
            }
            public double GetBalance()
            {
                return this.balance;
            }
            private string GetName()
            {
                return this.name;
            }
            private void setBalance(double balance)
            {
                this.balance = balance;
            }
            private void setName(string name)
            {
                this.name = name;
            }
            public void Add(double amount)
            {
                if (amount <= 0)
                    throw new Exception("error");
                else
                    this.balance += amount;

            }
            public void Remove(double amount)
            {
                if (this.balance-amount <= 0)
                    throw new Exception("error");
                else
                {
                    this.balance -= amount;
                    Console.WriteLine("done");
                }

                

            }

        }
        static void Main(string[] args)
        {
            

       
        }
    }
}
