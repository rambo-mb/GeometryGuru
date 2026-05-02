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
			
			break;	
		}
	case "2":
		{
			Console.WriteLine("\n=== Geometrik amallar ===\n");
			Console.WriteLine("1. Uchburchak yuzasi — Heron formulasi \n2. Aylana uzunligi va yuzasi \n3. Shar hajmi \n4. Silindr hajmi \n5. Konus hajmi \n6. Pifagor teoremasi\n");
			Console.Write("Tanlovni kiriting: ");
			string? geometricOption = Console.ReadLine(); 

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