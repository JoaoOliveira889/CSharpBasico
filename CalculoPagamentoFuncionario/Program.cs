using CalculoPagamentoFuncionario.Entities;
using CalculoPagamentoFuncionario.Entities.Enums;
using System.Globalization;

Console.WriteLine("Digite o nome do departamento: ");
string deptName = Console.ReadLine();
Console.WriteLine("Informe os dados do trabalhador");
Console.WriteLine("Nome: ");
string name = Console.ReadLine();
Console.WriteLine("Nível (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.WriteLine("Salario base: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department dept = new(deptName);
Worker worker = new(name, level, baseSalary, dept);

Console.WriteLine("Quantos contrados para esse trabalhador");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Entre com os dados do contrato #{i}");
    Console.WriteLine("Informe a data (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Valor por hora: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Duração (horas): ");
    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
}

Console.WriteLine();
Console.Write("Entre com o mes e ano (MM/YYYY)");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));
Console.WriteLine("Nome: " + worker.Name);
Console.WriteLine("Departamento: " + worker.Department.Name);
Console.WriteLine("Renda em: " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

