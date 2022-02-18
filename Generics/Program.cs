using Generics.Entities;
using Generics.Services;
using System.Globalization;

#region Exemplo basico
//PrintService<int> printService = new();

//Console.WriteLine("How many values? ");
//int n = int.Parse(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    int x = int.Parse(Console.ReadLine());
//    printService.AddValue(x);
//}

//printService.Print();
//Console.WriteLine("First: " + printService.First());

//PrintService<string> printServiceString = new();
//for (int i = 0; i < n; i++)
//{
//    string x = Console.ReadLine();
//    printServiceString.AddValue(x);
//}

//printService.Print();
//Console.WriteLine("First: " + printService.First());
#endregion

#region Restrições em Generics
List<Product> list = new();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] vect = Console.ReadLine().Split(",");
    string name = vect[0];
    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

    list.Add(new Product(name, price));
}

CalculationService calculationService = new();

Product max = calculationService.Max(list);

Console.WriteLine("Max:");
Console.WriteLine(max);
#endregion