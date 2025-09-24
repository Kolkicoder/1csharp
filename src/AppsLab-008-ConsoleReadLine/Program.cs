Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();
Console.WriteLine($"Ahoj,{meno}! Kolko mas rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Aha, mas teda 15 rokov");