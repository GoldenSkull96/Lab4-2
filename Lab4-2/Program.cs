using Lab4_2;

User user1 = new User("Valera");
user1.addCredit(1000, 1);
user1.addDeposit(1000, 1);
user1.print_credit_balance(2);
user1.print_deposit_balance(2);
user1.printAllCard();
Console.WriteLine();
Console.WriteLine("Удалить счет по id");
user1.removeCredit(int.Parse(Console.ReadLine()));
Console.WriteLine();
Console.WriteLine("Удалить счет по id");
user1.removeDeposit(int.Parse(Console.ReadLine()));
Console.WriteLine();
Console.WriteLine("Опустошить депозитный счет"); 
user1.take_deposit_cash(10000, int.Parse(Console.ReadLine()));
Console.WriteLine();
Console.WriteLine("Пополнить кредитный счет"); 
user1.give_credit_cash(10000, int.Parse(Console.ReadLine()));
Console.WriteLine();
Console.WriteLine("Удалить счет по id");
user1.removeCredit(int.Parse(Console.ReadLine()));
Console.WriteLine();
Console.WriteLine("Удалить счет по id");
user1.removeDeposit(int.Parse(Console.ReadLine()));

