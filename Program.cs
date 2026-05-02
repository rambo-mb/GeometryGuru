Console.WriteLine("\n=== GeometryGuru v2 ===\n");
Console.WriteLine("1. Arifmetik amallar \n2. Geometrik amallar \n0. Chiqish \n");
Console.Write("Tanlovni kiriting: ");
string? menuOption = Console.ReadLine();

switch(menuOption)
{
	case "1":
		{
			Console.WriteLine("\n=== Arifmetik amallar ===\n");
			Console.WriteLine("1. Qo‘shish \n2. Ayirish \n3. Ko‘paytirish \n4. Bo‘lish \n5. Kvadrat \n6. Kub \n7. Kvadrat ildiz \n8. Darajaga oshirish \n9. Qoldiq\n");
			Console.Write("Tanlovni kiriting: ");
			string? arifmeticOption = Console.ReadLine();
			
			switch(arifmeticOption)
      {
        case "1":
        case "2":
        case "3":
        case "4":
        case "9":
          {
            Console.Write("\nBirinchi sonni kiriting: ");
            string? firstString = Console.ReadLine();
            decimal firstNumber = Convert.ToDecimal(firstString);
            Console.Write("Ikkinchi sonni kiriting: ");
            string? secondString = Console.ReadLine();
            decimal secondNumber = Convert.ToDecimal(secondString);

            switch(arifmeticOption)
            {
              case "1":
                {
                  Console.WriteLine($"\n{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
                  break;
                }
              case "2":
                {
                  Console.WriteLine($"\n{firstNumber} - {secondNumber} = {firstNumber-secondNumber}");
                  break;
                }
              case "3":
                {
                  Console.WriteLine($"\n{firstNumber} * {secondNumber} = {firstNumber*secondNumber}");
                  break;
                }
              case "4":
                {
                  Console.WriteLine($"\n{firstNumber} / {secondNumber} = {firstNumber/secondNumber}");
                  break;
                }
              case "9":
                {
                  Console.WriteLine($"\n{firstNumber} % {secondNumber} = {firstNumber%secondNumber}");
                  break;
                }
            }
            break;
          }
        case "5":
        case "6":
        case "7":
          {
            Console.Write("\nSonni kiriting: ");
            string? firstString = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstString);

            switch (arifmeticOption)
            {
              case "5":
                {
                  Console.WriteLine($"\n{firstNumber} sonining kvadrati: {Math.Pow(firstNumber, 2)}");
                  break;
                }
              case "6":
                {
                  Console.WriteLine($"\n{firstNumber} sonining kubi: {Math.Pow(firstNumber, 3)}");
                  break;
                }
              case "7":
                {
                  Console.WriteLine($"\n{firstNumber} sonining ikkilik ildizi: {Math.Sqrt(firstNumber)}");
                  break;
                }
            }
            break;
          }
        case "8":
          {
            Console.Write("\nSonni kiriting: ");
            string? firstString = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstString);
            Console.Write("Darajani kiriting: ");
            string? secondString = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondString);

            Console.WriteLine($"\n{firstNumber} sonining {secondNumber}-darajasi: {Math.Pow(firstNumber, secondNumber)}");
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
            break;
          }
        case "2":
          {
            Console.Write("\nAylana yoki doira radiusi: ");
            string? radiusStr = Console.ReadLine();
            double radius = Convert.ToDouble(radiusStr);

            Console.WriteLine($"\nAylana uzunligi: {2 * Math.PI * radius}");
            Console.WriteLine($"\nDoira yuzi: {Math.PI * Math.Pow(radius, 2)}");
            break;
          }
        case "3":
          {
            Console.Write("\nShar radiusi: ");
            string? radiusStr = Console.ReadLine();
            double radius = Convert.ToDouble(radiusStr);

            Console.WriteLine($"\nShar hajmi: {(4 / 3) * Math.PI * Math.Pow(radius, 3)}");
            break;
          }
        case "4":
          {
            Console.Write("\nSilindr radiusi: ");
            string? radiusStr = Console.ReadLine();
            double radius = Convert.ToDouble(radiusStr);
            Console.Write("Silindr balandligi: ");
            string? heightStr = Console.ReadLine();
            double height = Convert.ToDouble(heightStr);


            Console.WriteLine($"\nSilindr hajmi: {Math.PI * Math.Pow(radius, 2) * height}");
            break;
          }
        case "5":
          {
            Console.Write("\nKonus radiusi: ");
            string? radiusStr = Console.ReadLine();
            double radius = Convert.ToDouble(radiusStr);
            Console.Write("Konus balandligi: ");
            string? heightStr = Console.ReadLine();
            double height = Convert.ToDouble(heightStr);


            Console.WriteLine($"\nKonus hajmi: {(1 / 3) * Math.PI * Math.Pow(radius, 2) * height}");
            break;
          }
        case "6":
          {
            Console.Write("\nKichik katet: ");
            string? aSideStr = Console.ReadLine();
            double aSide = Convert.ToDouble(aSideStr);
            Console.Write("Katta katet: ");
            string? bSideStr = Console.ReadLine();
            double bSide = Convert.ToDouble(bSideStr);

            Console.WriteLine($"\nGippotenuza: {Math.Sqrt(Math.Pow(aSide, 2) + Math.Pow(bSide, 2))}");
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