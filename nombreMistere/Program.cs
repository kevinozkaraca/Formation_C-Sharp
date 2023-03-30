// Nombre mistère
int nombreMystere = 0;
Random random = new Random();
nombreMystere = random.Next(1, 101);
Console.WriteLine("----- LE NOMBRE MYSTERE -----");
Console.WriteLine("Devinez le nombre mystère entre 1 et 100");
int nombreDeTentative = 0;
int nombreEntre = 0;
while (nombreEntre != nombreMystere)
{
    nombreDeTentative++;
    Console.WriteLine($"Essai n°{nombreDeTentative}");
    nombreEntre = int.Parse(Console.ReadLine());
    if (nombreEntre < nombreMystere)
    {
        Console.WriteLine("C'est plus");
    }
    else if (nombreEntre > nombreMystere)
    {
        Console.WriteLine("C'est moins");
    }
    else
    {
        Console.WriteLine("Bravo, vous avez trouvé le nombre mystère");
    }
}