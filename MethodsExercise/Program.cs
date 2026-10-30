using MethodsExercise;

// Try your methods here. Change the values and run the program
// (dotnet run, or Ctrl+F5 in Visual Studio) to see what they return.
// The tests in MethodsExercise.Tests check every method for you.

// Backyard Basketball
int winningPercentage = BackyardBasketball.CalculateWinningPercentage(7, 3);
Console.WriteLine("Winning percentage: " + winningPercentage);

// Claire's Cookies
decimal total = ClairesCookies.CalculateTotal(2);
Console.WriteLine("Two dozen cookies, with tax: $" + total);

// Elliot's Yard Care
decimal price = ElliotsYardCare.CalculatePrice(100, 50, true);
Console.WriteLine("Price for a 100 x 50 yard, with trimming: $" + price);
