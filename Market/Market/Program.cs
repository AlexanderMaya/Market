using Market;

Console.WriteLine("PRODUCTS");
Console.WriteLine("-------------------------------------------------");

Product product1 = new FixedPriceProduct()
{
    Description = "Vino Gato Negro",
    Id = 1010,
    Price = 46000M,
    Tax = 0.19F
};
Console.WriteLine(product1);
Product product2 = new VariablePriceProduct()
{
    Description = "Queso Holandes",
    Id = 3030,
    Measurement = "Kilo",
    Price = 32000M,
    Quantity = 0.536F,
    Tax = 0.19F
};
Console.WriteLine(product2);