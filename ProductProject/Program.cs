// See https://aka.ms/new-console-template for more information



using ProductProject;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int numberOfProducts = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numberOfProducts; i++)
{
    Console.Write("Common, used or imported (c/u/i)? ");
    char cui = Convert.ToChar(Console.ReadLine());

    Console.Write("Name:");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    double price = Convert.ToDouble(Console.ReadLine());

    if (cui == 'c' && name != null)
    {
        products.Add(new Product(name, price));
    }else if (cui == 'i' && name != null)
    {
        Console.Write("Customs fee: ");
        double customsFree = Convert.ToDouble(Console.ReadLine());

        products.Add(new ImportedProduct(name, price, customsFree));
    }
    else if(cui == 'u' && name != null)
    {
        Console.Write("Manufacture date: ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

        products.Add(new Usedproduct(name, price, manufactureDate));

    }
    else
    {
        Console.WriteLine("Invalid Option!");
    }


    
}
foreach (var product in products)
{
    Console.WriteLine(product.PriceTag());
}