Console.WriteLine("Geron formulasi yordamida uchburchak yuzasini \nhisoblovchi dasturga xush kelibsiz!");

Console.Write("Uchburchak a tomoni: ");
string? aSideStr = Console.ReadLine();
int aSide = Convert.ToInt32(aSideStr);

Console.Write("Uchburchak b tomoni: ");
string? bSideStr = Console.ReadLine();
int bSide = Convert.ToInt32(bSideStr);

Console.Write("Uchburchak c tomoni: ");
string? cSideStr = Console.ReadLine();
int cSide = Convert.ToInt32(cSideStr);

int s = (aSide + bSide + cSide) / 2;
decimal areaTriangle = (decimal) Math.Sqrt(s * (s - aSide) * (s - bSide) * (s - cSide));

Console.WriteLine($"Uchburchak yuzi: {areaTriangle}");