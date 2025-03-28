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
        public Deposit(string type, int count, string name, int id, double value, int day) : base(type, count, name, id, value, day)
        {
            Console.WriteLine("Счет был успешно оформлен");
        }
        private void days(int day)
        {
            if (Math.Abs(day) <this.day)
            {
                throw new ArgumentException("не корректная дата");
            }
            balance += balance * coef * (Math.Abs(day) - this.day);
        }
        public void check_balance(int day)
        {
            days(day);
            Console.WriteLine($"За прошедшие {Math.Abs(day) - this.day} дней ваш баланс составляет:{balance:f2} грн");
            this.day = day;
        }

    }
}
