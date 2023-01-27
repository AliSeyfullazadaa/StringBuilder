namespace StringHomeTask
{
    public class ProductDatabase
    {
        Product[] products = new Product[5];

        public void AddProduct(Product product)
        {
            if (products[products.Length - 1] == null)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == null)
                    {
                        products[i] = product;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Database is full");
            }


        }

        public Product[] SearchProduct(string searchingName)
        {
            Product[] products = new Product[0];
            foreach (var product in this.products)
            {
                if (product != null)
                {
                    if (product.ProductName.ToLower() == searchingName.ToLower())
                    {
                        Array.Resize(ref products, products.Length + 1);
                        products[products.Length - 1] = product;
                    }
                }
            }
            return products;
        }

        public void ShowProduct(int id)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    if (products[i].ProductId == id)
                    {
                        Console.WriteLine($"{products[i].ProductId} ---- {products[i].ProductName} ---- {products[i].ProductPrice} AZN");

                    }
                  
                }

            }
        }


        public void AllProducts()
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    Console.WriteLine($"{products[i].ProductId} ---- {products[i].ProductName} ---- {products[i].ProductPrice} AZN");
                }

            }
        }


    }
}
