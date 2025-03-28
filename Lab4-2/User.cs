using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class User
    {
        private string name;
        public string Name { get { return name; } }
        private int id;
        private List<Credit> credits_balance;
        public List<Credit> Credits_balance { get { return credits_balance; } }
        private List<Deposit> deposits_balance;
        public List<Deposit> Deposits_balance { get { return deposits_balance; } }
        public void printAllCard()
        {
            Console.WriteLine("Credit");
            foreach (var credit in credits_balance) 
            {
                Console.WriteLine(credit.ID);
            }
            Console.WriteLine("Deposit");
            foreach (var deposit in deposits_balance)
            {
                Console.WriteLine(deposit.ID);
            }
        }
        public void print_deposit_balance(int day)
        {
            date(day);
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
            for(int id = 0; id < credits_balance.Count; id++)
            {
                Console.WriteLine($"{credits_balance[id].ID}");
                credits_balance[id].check_balance(day);
            }
            for(int id = 0; id < deposits_balance.Count; id++)
            {
                Console.WriteLine($"{credits_balance[id].ID}");
                deposits_balance[id].check_balance(day);
            }
        }
        public void addCredit(double value,int day)
        {
            var credit = new Credit("credit", credits_balance.Count, Name + credits_balance.Count, id, value, day);
            credits_balance.Add(credit);
        }
        public void addDeposit(double value, int day)
        {
            var deposit = new Deposit("deposit", deposits_balance.Count, Name + deposits_balance.Count, id, value, day);
            deposits_balance.Add(deposit);
        }
        public void removeCredit(int Id)
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
                Console.WriteLine("Счет не найден");
                return;
            }
            if (credits_balance[curentId].Balance == 0)
            { 
                credits_balance.RemoveAt(curentId);
                Console.WriteLine($"Счет {curentId} был успешно удален");
                return;
            }
            else
            {
                Console.WriteLine("Погасите кредит");
                return;
            }
        }
        public void removeDeposit(int Id)
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
                Console.WriteLine("Счет не найден");
                return;
            }
            if (deposits_balance[curentId].Balance == 0)
            {
                deposits_balance.RemoveAt(curentId);
                Console.WriteLine($"Счет {curentId} был успешно удален");
                return;
            }
            else
            {
                Console.WriteLine("Опустошите счет");
                return;
            }
        }
        public void take_deposit_cash(double value, int Id)
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
                Console.WriteLine("Данный баланс не найден");
                return;
            }
                deposits_balance[curentId].take_cash(value);
        }
        public void take_credit_cash(double value, int Id)
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
                Console.WriteLine("Данный баланс не найден");
                return;
            }
                credits_balance[curentId].take_cash(value);
        }
        public void give_deposit_cash(double value, int Id)
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
                Console.WriteLine("Данный баланс не найден");
                return;
            }
                deposits_balance[curentId].give_cash(value);
        }
        public void give_credit_cash(double value, int Id)
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
                Console.WriteLine("Данный баланс не найден");
                return;
            }
                credits_balance[curentId].give_cash(value);
        }
        public User(string name)
        {
            Random r = new Random();
            this.name = name;
            id = r.Next(1, 15001);
            credits_balance = new List<Credit>();
            deposits_balance = new List<Deposit>();
        }
    }
}
