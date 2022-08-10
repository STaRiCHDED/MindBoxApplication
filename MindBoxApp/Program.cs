using MindBoxApp.SQLApplication;

var dataBase = new SqlApplication();

// var products = new List<Product>()
// {
//     new ("table"),
//     new ("fridge"),
//     new ("apple"),
//     new ("sofa"),
//     new ("stick"),
//     new ("cucumber"),
//     new ("tomato"),
//     new ("laptop"),
//     new ("washing machine")
// };
// var categories = new List<Category>()
// {
//     new ("furniture"),
//     new ("bathroom"),
//     new ( "kitchen"),
//     new ("food"),
//     new ("living_room"),
//     new ("fruits"),
//     new ("vegetables"),
//     new ("electronics"),
//     new ("bedroom")
// };
// var categoriesByProduct = new List<CategoryByProduct>()
// {
//     new (1,1),
//     new (3,1),
//     new (5,1),
//     new (3,2),
//     new (8,2),
//     new (4,3),
//     new (6,3),
//     new (1,4),
//     new (5,4),
//     new (9,4),
//     new (4,6),
//     new (7,6),
//     new (4,7),
//     new (7,7),
//     new (8,8),
//     new (2,9),
//     new (8,9),
// };
// dataBase.CategoriesByProduct.AddRange(categoriesByProduct);
// dataBase.Categories.AddRange(categories);
// dataBase.Products.AddRange(products);
// dataBase.SaveChanges();

Console.WriteLine("Select: Product Name - Category Name");
var products = dataBase.Products.ToList();
foreach (var product in products)
{
    var categoriesByProducts = dataBase.CategoriesByProduct
        .Where(categoryByProduct => categoryByProduct.ProductId == product.Id)
        .ToList();
    if (categoriesByProducts.Count == 0)
    {
        Console.WriteLine($"{product.Name} - ");
    }
    else
    {
        foreach (var categoryByProduct in categoriesByProducts)
        {
            var category = dataBase.Categories.Find(categoryByProduct.CategoryId);
            Console.WriteLine($"{product.Name} - {category.Name}");
        }
    }
}

// Реализация с помощью SQL:
//SELECT Products.Name, Category = 
//    CASE
//WHEN CategoriesByProduct.ProductId = Products.Id THEN Categories.Name
//    ELSE ''
//END
//    FROM Products full join CategoriesByProduct on Products.Id = CategoriesByProduct.ProductId 
//full join Categories on Categories.Id = CategoriesByProduct.CategoryId
