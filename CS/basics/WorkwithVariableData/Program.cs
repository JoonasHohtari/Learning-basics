/*
string[] values = { "12,3", "45", "ABC", "11", "DEF" };
float total = 0;
string message = "";
foreach (string value in values)
{
    float number;
    if (float.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");


int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / (int)value2;
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine($"Sorted...");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine($"Reversed...");
Array.Reverse(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length} ");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
//string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}


string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramArray = pangram.Split(' ');
string[] reversedWords = new string[pangramArray.Length];

for (int i = 0; i < pangramArray.Length; i++)
{
    char[] wordArray = pangramArray[i].ToCharArray();
    Array.Reverse(wordArray);
    reversedWords[i] = new string(wordArray);
}

string reverse = String.Join(" ", reversedWords);
Console.WriteLine(reverse);


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orders = orderStream.Split(',');

Array.Sort(orders);

for (int i = 0; i < orders.Length; i++)
{
    if (orders[i].Length == 4)
    {
        Console.WriteLine(orders[i]);
    }
    else
    {
        Console.WriteLine($"{orders[i]} - Error");
    }
}


string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");


decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

decimal price = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
yourDiscount += $"A discount of {((price - salePrice) / price):P2}!";
Console.WriteLine(yourDiscount);

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3} Product");
Console.WriteLine($"        Sub Total: {subtotal:C}");
Console.WriteLine($"            Tax: {taxPercentage:P2}");
Console.WriteLine($"        Total Billed: {total:C}");

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769C";
string payee = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payee.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
*/
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.Write($"As a customer of our {currentProduct} offering we are excited to tell you about a new ");
Console.WriteLine($"financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.Write($"Our new product, {newProduct} offers a return of {newReturn:P2}.");
Console.WriteLine($" Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");



string comparisonMessage = "";
comparisonMessage += $"{currentProduct.PadRight(20)}{currentReturn,-10:P2}{currentProfit:C} \n";
comparisonMessage += $"{newProduct.PadRight(20)}{newReturn,-10:P2}{newProfit:C} \n";
Console.WriteLine(comparisonMessage);