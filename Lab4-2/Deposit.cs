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
        public void withdrawal(double count)
        {
            Console.WriteLine($"Вы сняли с карты {count:f2} грн");
            this.balance -= count;
            Console.WriteLine($"Остаток на карте {balance:F2} грн");
        }
        public void deposit(double count)
        {
            Console.WriteLine($"Вы положили на карту {count:F2} грн");
            this.balance += count;
            Console.WriteLine($"Остаток на карте {balance:F2} грн");
        }
        public void date(int day)
        {
            int days = day - this.day;
            balance += balance * coef * days;
        }
        public Deposit(string name, string id, double value, int day) : base(name, id, value, day)
        {

        }
    }
}
