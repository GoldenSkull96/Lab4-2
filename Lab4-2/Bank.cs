using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class Bank
    {
        protected int day;
        private string id;
        public string ID { get { return id; } }
        protected double balance;
        public double Balance { get { return balance; } }
        public bool isBlocked;
        public Bank(string name, string id, double value, int day)
        {
            this.id = id + name;
            balance = value;
            this.day = day;
        }
        public virtual void take_cash()
        {
            if (isBlocked)
            {
                Console.WriteLine("");
            }
        }
    }
}
