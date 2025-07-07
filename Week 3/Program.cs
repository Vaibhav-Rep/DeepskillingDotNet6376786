using RetailInventory.Data;
using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

// Lab 4 Exercise for inserting initial data 

/* Console.WriteLine("Seeding initial data...");

using var context = new AppDbContext();

// Add Categories
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

await context.Categories.AddRangeAsync(electronics, groceries);

// Add Products
var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

await context.Products.AddRangeAsync(product1, product2);
await context.SaveChangesAsync();

Console.WriteLine("Data inserted!"); */




// Lab 5 Exercise for reading data from the database

Console.WriteLine("Reading data...");

using var context = new AppDbContext();

// fetch all products with their categories
var products = await context.Products.Include(p => p.Category).ToListAsync();
foreach (var p in products)
    Console.WriteLine($"{p.Name} - ₹{p.Price} - Category: {p.Category?.Name}");

// finding a product by its ID eg. 1
var found = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {found?.Name}");

// getting first expensive product with the threshold of ₹50,000
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
Console.WriteLine($"Expensive: {expensive?.Name}");