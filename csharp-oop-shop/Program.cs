using csharp_oop_shop;

internal class Program
{
    private static void Main()
    {
        Product[] products = {
         new Product("Penne al sugo", "Buonissime penne al sugo", 12.00m),
         new Product("Linguine ai frutti di mare", "Buonissime linguine ai frutti di mare", 18.00m),
         new Product("Spaghetti alla bolognese", "Buonissimi spaghetti alla bolognese", 17.00m),
        };

        Console.WriteLine("Elenco Prodotti\r\n");

        for (int i = 0; i < products.Length; i++)
        {
            products[i].PrintInfo();
        }

    }
}