var r = new Random();
var favoriteNumber = r.Next(1, 10);
//var favoriteNumber = 17;

Console.WriteLine("Pick a number 1-1000.");
int userInput
    /*= int.Parse(Console.ReadLine())*/;

do
{
    if (userInput < favoriteNumber)
    {
        Console.WriteLine($" {userInput} is too low!");
    }

    else if (userInput > favoriteNumber)
    {
        Console.WriteLine($" {userInput} is too high!");
    }
    else
    {
        Console.WriteLine(" Go big money!!!! ");
    }

} while (userInput != favoriteNumber);
