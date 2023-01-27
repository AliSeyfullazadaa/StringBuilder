using StringHomeTask;
ProductDatabase db = new ProductDatabase();
Product product1 = new Product(1, "Coffee", 45);
Product product2 = new Product(2, "Chai", 4.5);
Product product3 = new Product(3, "Juice", 43);

db.AddProduct(product1);
db.AddProduct(product2);
db.AddProduct(product3);

start:
Console.WriteLine();
Console.WriteLine("------------PRODUCT MANAGEMENT----------");
Console.WriteLine();
Console.WriteLine("Select Operation:");
Console.WriteLine("1.Add New Product        2.Search Product         3.Show All Products      4.Exit");
Console.WriteLine();
string productName;
int choice=Convert.ToInt32(Convert.ToInt32(Console.ReadLine()));

switch (choice)
{

    case 1:
        AddProduct();
        AllProducts();
        goto start;
    case 2:
        SearchProduct();
        goto start;
    case 3:
        AllProducts();
        goto start;
    case 4:
        break;
    default :
        break;
}



void AddProduct()
{
    Console.Write("ID : ");
    int id=Convert.ToInt32(Console.ReadLine());
    Console.Write("Name : ");
    productName = Console.ReadLine();
    Console.Write("Price : ");
    double productPrice=Convert.ToDouble(Console.ReadLine());
    if (id>0 && productPrice>=0 && CheckName(productName))
    {
        Product product = new Product(id, productName, productPrice);
        db.AddProduct(product);
        
    }
    else
    {
        Console.WriteLine("Invalid ID,Price Or Name");
    }
}



void SearchProduct()
{
    Console.Write("Search by Product Name: ");
    string productName = Console.ReadLine();
    var products = db.SearchProduct(productName);
    if (products == null)
    {
        Console.WriteLine("Product doesn't exist");
    }
    foreach (var product in products)
    {
        Console.WriteLine($"{product.ProductId} ---- {product.ProductName} ---- {product.ProductPrice} AZN");
     
    }
  
}


void AllProducts()
{
    Console.WriteLine("ALL PRODUCTS");
    Console.WriteLine();
    db.AllProducts();
  
}


bool CheckName(string productName)
{
    bool statusName = false;

    for (int i = 0; i < productName.Length; i++)
    {
        if (char.IsLetter(productName[i]))
        {
            statusName = true;
        }
    }
    return statusName;
}



