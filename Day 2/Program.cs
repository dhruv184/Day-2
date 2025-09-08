using Day_2.Model;

Console.WriteLine("C# Review");

ProductsManager productsManager = new ProductsManager();

Console.WriteLine("Welcome");

var done = false;

while (!done)
{
    Console.WriteLine("Select one of options:-");
    
    Console.WriteLine("1) Display List of products");
    
    Console.WriteLine("2) Add product");
    
    Console.WriteLine("3) Find product by Id");
    
    Console.WriteLine("4) Exit");
    
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1: Console.WriteLine("List of products\n");

            foreach (Product products in productsManager.GetProducts())
            {
                Console.WriteLine(products.ToString());
            }
            Console.WriteLine("\n\n");
            
            break;
        
        case 2: Console.WriteLine("Add product\n");
            
            Console.Write("Enter product id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter product name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter product price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            
            Product p = new Product(id, name, price);
            productsManager.AddProduct(p);
            
            Console.WriteLine("\n\n");
            
            break;
        
        case 3: Console.WriteLine("Find product by Id\n");
            
            Console.Write("Enter product id: ");
            
            id = Convert.ToInt32(Console.ReadLine());
            Product prod = productsManager.GetProducts().Where(p => p.Id == id).FirstOrDefault();
            
            if (prod != null)
            {
                Console.WriteLine(prod);
            }
            
            Console.WriteLine("\n\n");
            
            break;
        
        case 4: Console.WriteLine("Exit\n");
            done = true;
            break;
    }
}
