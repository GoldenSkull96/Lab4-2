using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class Credit : Bank
    {
        private static double coef = 0.1;
        private bool credit;
        public void take_credit(double count)
        {
            if (!credit)
            {
                Console.WriteLine("");
                return;
            }
            credit = true;
            this.balance += count;
            Console.WriteLine();
        }
        public void payoff(double count)
        {
            if (credit)
            {
                Console.WriteLine();
                return;
            }
            balance -= count;
            if (balance == 0)
            {
                credit = false;
                Console.WriteLine();
                return;
            }
            Console.WriteLine();
        }
        public void date(int day)
        {
            int days = day - this.day;
            balance += balance * coef * days;
        }
        public Credit(string name, string id, double value, int day) : base(name, id, value, day)
        {

        }
    }
}
