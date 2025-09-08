namespace Day_2.Model;

public class ProductsManager
{
   List<Product> products;

   public ProductsManager()
   {
      List<Product> products = new List<Product>();
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