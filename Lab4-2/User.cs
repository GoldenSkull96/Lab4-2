using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class User
    {
        public string Name;
        public string id;
        private List<Credit> credits_balance;
        private List<Deposit> deposits_balance;
        public void print_deposit_balance()
        {
            double sum = 0;
            foreach (Deposit deposit in deposits_balance)
            {
                sum += deposit.Balance;
            }
            Console.WriteLine($"{sum:F2}");

        }
        public void print_credit_balance(int day)
        {
            date(day);
            double sum = 0;
            foreach (Credit credit in credits_balance)
            {
                sum += credit.Balance;
            }
            Console.WriteLine($"{sum:F2}");
        }
        private void date(int day)
        {
            Console.WriteLine($"{day}");
            for(int id = 0; id< credits_balance.Count; id++)
            {
                credits_balance[id].date(day);
            }
            for(int id = 0; id < deposits_balance.Count; id++)
            {
                deposits_balance[id].date(day);
            }
        }
        public void addCredit(double value,int day)
        {
            credits_balance.Add(new Credit(Name + credits_balance.Count, id, value, day));
        }
        public void addDeposit(double value, int day)
        {
            deposits_balance.Add(new Deposit(Name + deposits_balance.Count, id, value, day));
        }
        public void removeCredit(string Id)
        {
            int curentId = 0;
            bool contains = false;
            for (int id = 0; id < credits_balance.Count; id++)
            {
                if (credits_balance[id].ID == Id)
                {
                    contains = true;
                    curentId = id;
                    break;
                }
            }
            if (!contains)
            {
                Console.WriteLine();
                return;
            }
            if (credits_balance[curentId].Balance == 0)
            { 
                credits_balance.RemoveAt(curentId);
                return;
            }
            else
            {
                Console.WriteLine("Погасите кредит");
                return;
            }
        }
        public void removeDeposit(string Id)
        {
            int curentId = 0;
            bool contains = false;
            for (int id = 0; id < deposits_balance.Count; id++)
            {
                if (deposits_balance[id].ID == Id)
                {
                    contains = true;
                    curentId = id;
                    break;
                }
            }
            if (!contains)
            {
                Console.WriteLine();
                return;
            }
            if (deposits_balance[curentId].Balance == 0)
            {
                deposits_balance.RemoveAt(curentId);
                return;
            }
            else
            {
                Console.WriteLine("Опустошите счет");
                return;
            }
        }
    }
}
