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
        
        public Credit(string name, string id, double value, int day) : base(name, id, value, day)
        {

        }
        private void days(int day)
        {
            balance += balance * coef * (this.day - day);
        }
        public override void take_cash(double value)
        {
            if (isBlocked)
            {
                Console.WriteLine("Любые действие с счетом заблокированы \n\rСвяжитесь с службой поддержки по номеру: +38(095)-682-78-99");
            }
            if (credit)
            {
                Console.WriteLine($"Вы уже взяли кредит. Для открытия нового погасите старый, ваш долг составляет {balance:F2}");
                return;
            }
            balance += value;
            Console.WriteLine("Кредит успешно оформлен, ваш долг будет расти в процентном соотношении 10% за сутки");
            credit = true;
        }
        public override void give_cash(double value)
        {
            if (isBlocked)
            {
                Console.WriteLine("Любые действие с счетом заблокированы \n\rСвяжитесь с службой поддержки по номеру: +38(095)-682-78-99");
            }
            if (!credit)
            {
                Console.WriteLine($"У вас нет задолжности. Для хранения средств используйте депозитный счет");
                return;
            }
            balance += value;
            Console.WriteLine($"Кредит успешно уменьшен, ваш долг составляет {balance:F2} грн");
            if ( balance == 0.0)
            {
                credit = true;
                Console.WriteLine("Ваш кредит успешно закрыт");
            }
        }
        public void check_balance(int day)
        {
            days(day);
            Console.WriteLine($"За прошедшие {this.day - day} дней ваш долг составляет:{balance:f2} грн");
            this.day = day;
        }
    }
}
