/*
Console.WriteLine("Enter a integer number between 5-10: ");

int number = 0;
bool isNumber = false;
string? userInput;

do
{
    userInput = Console.ReadLine();
    isNumber = int.TryParse(userInput, out number);
    if (!isNumber)
    {
        Console.WriteLine("You need to enter a number, try again: ");
        continue;
    }
    else
    {
        if (number < 5 || number > 10)
        {
            Console.WriteLine("The number is not between 5-10, try again: ");
        }
    }

} while (number < 5 || number > 10);

Console.WriteLine("Your number is: " + number + ", You shall pass.");


Console.WriteLine("Are you: Administrator, Manager or User?");

string? userInput = null;

while (userInput == null)
{
    userInput = Console.ReadLine();
    if (userInput != null)
    {
        userInput = userInput.ToLower();
        userInput = userInput.Trim();
        if (userInput == "administrator" || userInput == "manager" || userInput == "user")
        {
            break;
        }
        else
        {
            Console.WriteLine("You need to enter: Adminstrator, Manager or User");
            userInput = null;
        }
    }
}

Console.WriteLine("You are: " + userInput + ", You shall pass.");

string[] myString = new string[2] { "I like pizza. I like roast chicken. I like salad.", "I like all three of the menu choices" };

for (int i = 0; i < myString.Length; i++)
{
    int periodLocation = myString[i].IndexOf('.');
    while (periodLocation != -1)
    {
        string sentence = myString[i].Substring(0, periodLocation);

        sentence = sentence.Insert(periodLocation, "\n");
        myString[i] = myString[i].Remove(0, periodLocation + 1).TrimStart();

        Console.Write(sentence);

        periodLocation = myString[i].IndexOf('.');
    }
    Console.Write(myString[i].TrimStart());
}
*/