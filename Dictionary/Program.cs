Dictionary<string, string> cookies = new();
cookies["user"] = "joão";
cookies["email"] = "joao@email.com";
cookies["phone"] = "9999999";
cookies["phone"] = "888888";


Console.WriteLine(cookies["phone"]);
Console.WriteLine(cookies["email"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There is no 'email' key");
}

Console.WriteLine("size " + cookies.Count);

Console.WriteLine("All cookies");
foreach (var item in cookies)
{
    Console.WriteLine(item.Key + ": " + item.Value);
}