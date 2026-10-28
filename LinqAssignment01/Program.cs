
using static LinqAssignment01.Source;


// 1. Get all products from the "Seafood" category. Print each product's name and price. 

// Answer 01

//var seafoodProducts = ProductList.Where(p => p.Category == "Seafood");

//foreach (var p in seafoodProducts)
//{
//    Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice:C}");
//}

// 2. Get a list of only the product names from ProductList. Print each name. 

// Answer 02

//var ProductName = ProductList.Select(P => P.ProductName);

//foreach (var name in ProductName)
//{
//    Console.WriteLine(name);
//}


// 3. Sort all products by UnitPrice (ascending). Print each product's name and price. 

// Answer 03

//var sortedByPrice = ProductList.OrderBy(p => p.UnitPrice);

//foreach (var p in sortedByPrice)
//{
//    Console.WriteLine($"Name: {p.ProductName}, Price: {p.UnitPrice:C}");
//}


// 4. Get all products where UnitPrice is between 10 and 30 

// Answer 04

//var ProductUnitPrice10To30 = ProductList.Where(P => P.UnitPrice >= 10 && P.UnitPrice <= 30);

//foreach (var item in ProductUnitPrice10To30)
//{
//    Console.WriteLine(item);
//}


// 5. Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category. 

// Answer 05

//var ProductInStockCondimentsCategory = ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Condiments");

//foreach (var item in ProductInStockCondimentsCategory)
//{
//    Console.WriteLine(item);
//}


// 6. Create a new anonymous type with three properties: 
// ● Name → the product name 
// ● Price → the unit price 
// ● StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock" 
// ● Print the result. 

// Answer 06

//var SpesificProductInformation = ProductList.Select(p => new
//    {
//        Name = p.ProductName,
//        Price = p.UnitPrice,
//        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"});

//foreach (var item in SpesificProductInformation)
//{
//    Console.WriteLine(item);
//}


// 7. Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc.

// Answer 07

//var productsWithItsPosition = ProductList.Select((p, index) => $"{index + 1}. {p.ProductName}");

//Console.WriteLine(string.Join(", ", productsWithItsPosition));


// 8.Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending. 

// Answer 08

//var ProductByCategoryThenUnitPrice = ProductList.OrderBy(P => P.Category).ThenByDescending(P => P.UnitPrice);

//foreach (var item in ProductByCategoryThenUnitPrice)
//{
//    Console.WriteLine(item);
//}


// 9. Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

// Answer 09

//var ProductBeveragesByUnitInStock = ProductList.Where(P => P.Category == "Beverages").OrderByDescending(P => P.UnitPrice);

//foreach (var P in ProductBeveragesByUnitInStock)
//{
//    Console.WriteLine($"Name: {P.ProductName}, Stock: {P.UnitsInStock}");
//}

// 10. Using QUERY SYNTAX with a compound from clause, list  all orders placed in 1997 or later showing CustomerID and OrderDate. 

// Answer 10

//var ordersFrom1997 =
//    from c in CustomerList
//    from o in c.Orders
//    where o.OrderDate.Year >= 1997
//    select new
//    {
//        c.CustomerID,
//        o.OrderDate
//    };

//foreach (var item in ordersFrom1997)
//{
//    Console.WriteLine($"Customer: {item.CustomerID}, Order Date: {item.OrderDate:yyyy-MM-dd}");
//}

// 11. Show position number alongside ProductName.

// Answer 11

//var indexedProducts = ProductList.Select((p, index) => new
//    {
//        Position = index + 1,
//        p.ProductName
//    });

//foreach (var item in indexedProducts)
//{
//    Console.WriteLine($"{item.Position}. {item.ProductName}");
//}


// 12. Sort first by-word length and then by a case-insensitive sort of the words in an array. 
//String [] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

//string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

// Answer 12

//var sortedWords = Arr .OrderBy(w => w.Length)
//    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

//foreach (var word in sortedWords)
//{
//    Console.WriteLine(word);
//}


// 13.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.

// Answer 13

//string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

//var result = digits .Where(d => d.Length > 1 && char.ToLower(d[1]) == 'i').Reverse();

//foreach (var d in result)
//{
//    Console.WriteLine(d); // Prints: nine, eight, six, five
//}