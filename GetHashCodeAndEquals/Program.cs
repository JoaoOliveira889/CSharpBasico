using GetHashCodeAndEquals.Entities;

string a = "João";
string b = "Maria";

string c = "Pedro";
string d = "Pedro";

Console.WriteLine(a.Equals(b));
Console.WriteLine(c.Equals(d));
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());

Client a1 = new Client { Name = "João", Email = "joao@email.com" };
Client a2 = new Client { Name = "Maria", Email = "maria@email.com" };
Client a3 = new Client { Name = "João", Email = "joao@email.com" };

Console.WriteLine(a1.Equals(a2));
Console.WriteLine(a1.Equals(a3));