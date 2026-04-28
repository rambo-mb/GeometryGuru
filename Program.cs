Console.Write("Birinchi sonni kiriting: ");
string firstString = Console.ReadLine();
decimal firstNumber = Convert.ToDecimal(firstString);

Console.Write("Ikkinchi sonni kiriting: ");
string secondString = Console.ReadLine();
decimal secondNumber = Convert.ToDecimal(secondString);

Console.WriteLine(firstString + " + " + secondString + " = " + (firstNumber + secondNumber));
Console.WriteLine(firstString + " - " + secondString + " = " + (firstNumber - secondNumber));
Console.WriteLine(firstString + " * " + secondString + " = " + (firstNumber * secondNumber));
Console.WriteLine(firstString + " / " + secondString + " = " + (firstNumber / secondNumber));

