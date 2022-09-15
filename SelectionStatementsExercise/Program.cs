var r = new Random();
var favoriteNumber = r.Next(1, 10);
Console.WriteLine("Pick a number 1-1000.");
var userInput = int.Parse(Console.ReadLine());



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

