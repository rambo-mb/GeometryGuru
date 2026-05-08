string confirmation = string.Empty;

do 
{
  Console.Clear();
  Console.WriteLine("\n=== GeometryGuru v2 ===\n");
  Console.WriteLine("1. Arifmetik amallar \n2. Geometrik amallar \n0. Chiqish \n");
  Console.Write("Tanlovni kiriting: ");
  string? menuOption = Console.ReadLine();

  switch(menuOption)
  {
    case "1":
      {
        Console.WriteLine("\n=== Arifmetik amallar ===\n");
        Console.WriteLine("1. Qo‘shish \n2. Ayirish \n3. Ko‘paytirish \n4. Bo‘lish \n5. Kvadrat \n6. Kub \n7. Kvadrat ildiz \n8. Darajaga oshirish \n9. Qoldiq\n10. 1 dan N gacha bo'lgan tub sonlarni topish");
        Console.Write("Tanlovni kiriting: ");
        string? arifmeticOption = Console.ReadLine();
        
        switch(arifmeticOption)
        {
          case "1":
            {
              Add();
              break;
            }
          case "2":
            {
              Subtract();
              break;
            }
          case "3":
            {
              Multiply();
              break;
            }
          case "4":
            {
              Divide();
              break;
            }
          case "9":
            {
              Modulo();
              break;
            }
          case "5":
            {
              Square();
              break;
            }
          case "6":
            {
              Cube();
              break;
            }
          case "7":
            {
              SquareRoot();
              break;
            }
          case "10":
            {
              FindPrimes();
              break;
            }
          case "8":
            {
              Power();
              break;  
            }
          default:
            {
              Console.WriteLine("\nNoto'g'ri buyruq kiritdingiz! Iltimos dasturni qayta ishga tushiring.");
              return;
            }
        }

        break;	
      }
    case "2":
      {
        Console.WriteLine("\n=== Geometrik amallar ===\n");
        Console.WriteLine("1. Uchburchak yuzasi — Heron formulasi \n2. Aylana uzunligi va yuzasi \n3. Shar hajmi \n4. Silindr hajmi \n5. Konus hajmi \n6. Pifagor teoremasi\n");
        Console.Write("Tanlovni kiriting: ");
        string? geometricOption = Console.ReadLine(); 

        switch(geometricOption)
        {
          case "1":
            {
              TriangleArea();
              break;
            }
          case "2":
            {
              CircleProperties();
              break;
            }
          case "3":
            {
              SphereVolume();
              break;
            }
          case "4":
            {
              CylinderVolume();
              break;
            }
          case "5":
            {
              ConeVolume();
              break;
            }
          case "6":
            {
              PythagoreanTheorem();
              break;
            }
          default:
            {
              Console.WriteLine("\nNoto'g'ri buyruq kiritdingiz! Iltimos dasturni qayta ishga tushiring.");
              break;
            }
        }
        break;
      }
    case "0":
      {
        Console.WriteLine("\nDasturdan foydalanganingiz uchun rahmat. Ko'rishguncha!");
        break;
      }
    default:
      {
        Console.WriteLine("\nNoto'g'ri buyruq kiritdingiz! Iltimos dasturni qayta ishga tushiring.");
        break;
      }
  }

  Console.Write("\nDavom ettiramizmi? ");
  confirmation = Console.ReadLine()!;

} while(confirmation.ToLower() == "ha");


static (decimal firstNumber, decimal secondNumber) InputTwoNumbers()
{
  Console.Write("\nBirinchi sonni kiriting: ");
  string? firstString = Console.ReadLine();
  decimal firstNumber = Convert.ToDecimal(firstString);
  Console.Write("Ikkinchi sonni kiriting: ");
  string? secondString = Console.ReadLine();
  decimal secondNumber = Convert.ToDecimal(secondString);
  return (firstNumber, secondNumber);
}

static decimal InputOneNumber()
{
  Console.Write("\nSonni kiriting: ");
  string? firstString = Console.ReadLine();
  decimal firstNumber = Convert.ToDecimal(firstString);

  return firstNumber;
}

static void Add()
{
  (decimal firstNumber, decimal secondNumber) = InputTwoNumbers();
  Console.WriteLine($"\n{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
}

static void Subtract()
{
  (decimal firstNumber, decimal secondNumber) = InputTwoNumbers();
  Console.WriteLine($"\n{firstNumber} - {secondNumber} = {firstNumber-secondNumber}");
}

static void Multiply()
{
  (decimal firstNumber, decimal secondNumber) = InputTwoNumbers();
  Console.WriteLine($"\n{firstNumber} * {secondNumber} = {firstNumber*secondNumber}");
}

static void Divide()
{
  (decimal firstNumber, decimal secondNumber) = InputTwoNumbers();

  if(secondNumber == 0)
  {
    Console.WriteLine("\n0 ga bo'lib bo'lmaydi!");
    return;
  }
  Console.WriteLine($"\n{firstNumber} / {secondNumber} = {firstNumber/secondNumber}");
}

static void Modulo()
{
  (decimal firstNumber, decimal secondNumber) = InputTwoNumbers();
  Console.WriteLine($"\n{firstNumber} % {secondNumber} = {firstNumber%secondNumber}");
}

static void Square()
{
  decimal number = InputOneNumber();
  Console.WriteLine($"\n{number} sonining kvadrati: {Math.Pow((int) number, 2)}");
}

static void Cube()
{
  decimal number = InputOneNumber();
  Console.WriteLine($"\n{number} sonining kubi: {Math.Pow((int) number, 3)}");
}

static void SquareRoot()
{
  decimal number = InputOneNumber();
  Console.WriteLine($"\n{number} sonining ikkilik ildizi: {Math.Sqrt((int) number)}");
}

static void FindPrimes()
{
  decimal number = InputOneNumber();
  int sum = 0;
  int counter = 0;
  for(int i = 1; i < number; i++)
  {
    for(int j = 1; j < number; j++)
    {
      if(i % j == 0) counter++;
    }

    if(counter == 2) 
    {
      Console.Write($"-{i}-");
      sum += i;
    }
    counter = 0;
  }

  Console.WriteLine($"\n1 dan {number} orasidagi tub sonlar yig'indisi: {sum}");
}

static void Power()
{
  Console.Write("\nSonni kiriting: ");
  string? firstString = Console.ReadLine();
  double firstNumber = Convert.ToDouble(firstString);
  Console.Write("Darajani kiriting: ");
  string? secondString = Console.ReadLine();
  double secondNumber = Convert.ToDouble(secondString);

  Console.WriteLine($"\n{firstNumber} sonining {secondNumber}-darajasi: {Math.Pow(firstNumber, secondNumber)}");
}

static void TriangleArea()
{
  Console.Write("\nUchburchak a tomoni: ");
  string? aSideStr = Console.ReadLine();
  int aSide = Convert.ToInt32(aSideStr);

  Console.Write("Uchburchak b tomoni: ");
  string? bSideStr = Console.ReadLine();
  int bSide = Convert.ToInt32(bSideStr);

  Console.Write("Uchburchak c tomoni: ");
  string? cSideStr = Console.ReadLine();
  int cSide = Convert.ToInt32(cSideStr);

  int sumOfSides = (aSide + bSide + cSide) / 2;
  decimal areaTriangle = (decimal) Math.Sqrt(sumOfSides * (sumOfSides - aSide) * (sumOfSides - bSide) * (sumOfSides - cSide));

  Console.WriteLine($"\nUchburchak yuzi: {areaTriangle}");
}

static void CircleProperties()
{
  Console.Write("\nAylana yoki doira radiusi: ");
  string? radiusStr = Console.ReadLine();
  double radius = Convert.ToDouble(radiusStr);

  Console.WriteLine($"\nAylana uzunligi: {(2 * Math.PI * radius):0.##}");
  Console.WriteLine($"\nDoira yuzi: {(Math.PI * Math.Pow(radius, 2)):0.##}");
}

static void SphereVolume()
{
  Console.Write("\nShar radiusi: ");
  string? radiusStr = Console.ReadLine();
  double radius = Convert.ToDouble(radiusStr);

  Console.WriteLine($"\nShar hajmi: {(4 * Math.PI * Math.Pow(radius, 3) / 3):0.##}");
}

static void CylinderVolume()
{
  Console.Write("\nSilindr radiusi: ");
  string? radiusStr = Console.ReadLine();
  double radius = Convert.ToDouble(radiusStr);
  Console.Write("Silindr balandligi: ");
  string? heightStr = Console.ReadLine();
  double height = Convert.ToDouble(heightStr);

  Console.WriteLine($"\nSilindr hajmi: {(Math.PI * Math.Pow(radius, 2) * height):0.##}");
}

static void ConeVolume()
{
  Console.Write("\nKonus radiusi: ");
  string? radiusStr = Console.ReadLine();
  double radius = Convert.ToDouble(radiusStr);
  Console.Write("Konus balandligi: ");
  string? heightStr = Console.ReadLine();
  double height = Convert.ToDouble(heightStr);


  Console.WriteLine($"\nKonus hajmi: {(Math.PI * Math.Pow(radius, 2) * height / 3):0.##}");
}

static void PythagoreanTheorem()
{
  Console.Write("\nKichik katet: ");
  string? aSideStr = Console.ReadLine();
  double aSide = Convert.ToDouble(aSideStr);
  Console.Write("Katta katet: ");
  string? bSideStr = Console.ReadLine();
  double bSide = Convert.ToDouble(bSideStr);

  Console.WriteLine($"\nGippotenuza: {Math.Sqrt(Math.Pow(aSide, 2) + Math.Pow(bSide, 2))}");
}