// See https://aka.ms/new-console-template for more information

using OOP1;

Product product1 = new Product();
product1.ID = 1;
product1.CategoryID = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;
Product product2 = new Product { 
    ID = 2, 
    CategoryID = 5, 
    UnitsInStock = 5, 
    ProductName = "Kalem", 
    UnitPrice = 35 
    };
ProductManager productManager = new ProductManager(); 
productManager.Add(product1);
productManager.Add(product2);


