namespace Day_2.Model;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    
    // Constructors
    public Product() { }
    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
    
    // Methods 
    public override string ToString()
    {
        return $"{Id},{Name}, {Price}";
    }
}