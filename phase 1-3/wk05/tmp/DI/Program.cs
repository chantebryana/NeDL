// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace DI
{

	class Order 
{
    public int Id { get; set; }
    public decimal Total { get; set; }
}

class OrderAccessor
{
    static Order[] Orders = 
        new Order[] { new Order() { Id = 1, Total = 100.00M }};

    public Order Find(int id)
    {
        return Orders.First(o => o.Id == id);
    }
}

class EmailAccessor
{
    public void SendEmail(Order order)
    {
        Console.WriteLine($"Email for {order.Id}");
    }
}

class OrderManager
{
		private OrderAccessor OrderAccessor { get;set; }
    private EmailAccessor EmailAccessor { get;set; }
    public OrderManager(OrderAccessor orderAccessor,      
        EmailAccessor emailAccessor)
    {
        OrderAccessor = orderAccessor;
        EmailAccessor = emailAccessor;
    }

		public void SendNotification(int id)
{
    var order = OrderAccessor.Find(id);
    EmailAccessor.SendEmail(order);
}


}

class Program
{
    static void Main(string[] args)
{
    var manager = new OrderManager(
        new OrderAccessor(), new EmailAccessor());
    manager.SendNotification(1);
}

}

}
