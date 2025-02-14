using System;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer("Alice", new Address("123 Main St", "Anytown", "Alabama", "USA"));
        Customer c2 = new Customer("Brian", new Address("R. Tokio 24", "Manaus", "Amazonas", "Brazil"));
        Customer c3 = new Customer("Anderson", new Address("R. Saporo 12", "Manaus", "Amazonas", "Brazil"));

        List<Order> orders = new List<Order>();
        orders.Add(new Order(c1, new List<Product> { new Product("C# Tutorial", 10, 10, 1), new Product("Java Tutorial", 11, 12, 1) }));
        orders.Add(new Order(c2, new List<Product> { new Product("Python Tutorial", 12, 13, 1), new Product("C++ Tutorial", 13, 14, 1), new Product("Assembly Tutorial", 14, 13, 1) }));

        foreach (Order o in orders)
        {
            Console.WriteLine("=========================================================");
            Console.WriteLine("Packing Label: ");
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine("Shipping Label: ");
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine("Total Cost: ");
            Console.WriteLine(o.TotalCost());
            Console.WriteLine("Shipping Cost: ");
            Console.WriteLine(o.GetShippingCost());
            Console.WriteLine("=========================================================");
        }
    }
}