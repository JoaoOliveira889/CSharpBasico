using ProjetoPedidos.Entities;
using ProjetoPedidos.Entities.Enums;

Order order = new()
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

string txt = OrderStatus.PendingPayment.ToString();

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(txt);
Console.WriteLine(os);