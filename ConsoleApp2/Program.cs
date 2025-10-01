
// nacitam prve cislo (konverziu na cislo)
// nacitam operaciu (nacitam ako string)
// nacitam druhe cislo (konverziu na cislo)
// vykonam operaciu
// vypisem vysledok

Console.WriteLine("Vitaj v kalkulacke");
Console.WriteLine("Zadaj prve cislo: ");
int cislo1 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadaj druhe cislo: ");
int cislo2 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadaj operaciu (+,-,*,/,%):");
string operacia = Console.ReadLine();

int vyskedok = operacia switch
{
    "+" => (cislo1 + cislo2),
    "-" => (cislo1 - cislo2),
    "*" => (cislo1 * cislo2),
    "/" => (cislo1 / cislo2),
    "%" => (cislo1 % cislo2),
};
Console.WriteLine($"Vysledok je: {vyskedok}");
Console.WriteLine("Stlac ENTER pre spustenie kalkulacky");




