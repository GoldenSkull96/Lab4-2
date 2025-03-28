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
        public virtual void take_cash(double value)
        {
            if (isBlocked)
            {
                Console.WriteLine("Любые действие с счетом заблокированы \n\rСвяжитесь с службой поддержки по номеру: +38(095)-682-78-99");
                return;
            }
            balance -= value;
            Console.WriteLine($"Деньги были успешно извлечены \n\rТекущий баланс:{value:F2} грн");
        }
        public virtual void give_cash(double value)
        {
            if (isBlocked)
            {
                Console.WriteLine("Любые действие с счетом заблокированы \n\rСвяжитесь с службой поддержки по номеру: +38(095)-682-78-99");
                return;
            }
            balance += value;
            Console.WriteLine($"Деньги были успешно добавлены \n\rТекущий баланс:{value:F2} грн");
        }
    }
}
