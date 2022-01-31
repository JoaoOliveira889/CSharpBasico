using Inheritance.Entities;
using System.Globalization;

#region UpCasting and DownCasting
//Account acc = new(200, "John", 0.0);
//BusinessAccount bacc = new(109, "Leonard", 0.0, 890.90);

////UpCasting
//Account acc1 = bacc;
//Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 320.32);
//Account acc3 = new SavingsAccount(2098, "Anna", 0.0, 0.01);

////DownCasting
//BusinessAccount acc4 = (BusinessAccount)acc2;
//acc4.Loan(100.0);

//if(acc3 is BusinessAccount)//Testa se o acc3 e uma instancia de BusinessAccount
//{
//    BusinessAccount acc5 = (BusinessAccount)acc3;
//    acc5.Loan(200.0);
//    Console.WriteLine("Loan!");
//}

//if(acc3 is SavingsAccount)//Testa se o acc3 e uma instancia de SavingsAccount
//{
//    SavingsAccount acc5 = (SavingsAccount)acc3;
//    acc5.UpdateBalance();
//    Console.WriteLine("Update Balance!");
//}
#endregion

#region Sobreposição, virtual e override
//Remover o abstrat a classe Account

//Account acc1 = new(2090, "John", 400.00);
//Account acc2 = new SavingsAccount(1009, "Anna", 400.00, 0.01);

//acc1.Withdraw(10.0);
//acc2.Withdraw(10.0);

//Console.WriteLine(acc1.Balance);
//Console.WriteLine(acc2.Balance);
#endregion

#region classes Abstratas
//Mudar a classe Account para abstrat
//abstract class Account
List<Account> list = new();

list.Add(new SavingsAccount(2000, "João", 400.0, 0.01));
list.Add(new BusinessAccount(2001, "Maria", 400.0, 500.00));
list.Add(new SavingsAccount(2002, "Bob", 400.0, 0.01));
list.Add(new BusinessAccount(2003, "Anna", 400.0, 500.00));

double sum = 0.0;
foreach (Account acc in list)
{
    sum += acc.Balance;
}

Console.WriteLine("Total balance " + sum.ToString("F2"));

foreach (Account acc in list)
{
    acc.Withdraw(10.0);
}

foreach (Account acc in list)
{
    Console.WriteLine("Updated balance for account "
        + acc.Number
        + ": "
        + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
        );
}
#endregion