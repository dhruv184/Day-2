namespace Day_2.Model;

public class ProductsManager
{
   List<Product> products;

   public ProductsManager()
   {
      products = new List<Product>();
      
      products.Add(new Product() { Id = 1, Name = "Apple", Price = 100 });
      products.Add(new Product() { Id = 2, Name = "Samsung", Price = 100 });
   }

   public void AddProduct(Product product)
   {
      products.Add(product);
   }

   public List<Product> GetProducts()
   {
      return products;
   }
   public void RemoveProduct(Product product)
   {
      
   }
   
}