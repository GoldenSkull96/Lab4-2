using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class Deposit : Bank
    {
        private static double coef = 0.01;
        public Deposit(string name, string id, double value, int day) : base(name, id, value, day)
        {
            
        }
        private void days(int day)
        {
            balance += balance * coef * (this.day - day);
        }
        public void check_balance(int day)
        {
            days(day);
            Console.WriteLine($"За прошедшие {this.day-day} дней ваш баланс составляет:{balance:f2} грн");
            this.day = day;
        }

    }
}
