using System.Text;

namespace DesignPatterns.CreationalPattern.Singleton;

public class ShoppingCart
{
    private static ShoppingCart? instance;
    public List<ShoppingCartProduct> Products { get; set; } = new();
    public static ShoppingCart GetInstance() => instance ??= new();


    public ShoppingCart()
    {

    }

    public void Add(ShoppingCartProduct product)
    {
        this.Products.Add(product);
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        foreach (var product in Products)
        {
            builder.Append("Product: ");
            builder.Append(product.Name);

            builder.Append("Price: ");
            builder.Append(product.Price.ToString("##.##"));
        }

        return builder.ToString();
    }

}

public record ShoppingCartProduct(string Name, decimal Price);

