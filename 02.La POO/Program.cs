/*
---------  LES OBJETS 
un objet est une instance d'une classe.
Un objet est une variable particulière dont le type est une classe.
Une classe est un type abstrait (exemple : un compte bancaire en général), 
un objet est un exemplaire concret d'une classe (exemple : le compte bancaire de Jean).
Tout le code écrit dans la section de base est écrit dans la class Program.
*/

// Voir le fichier exemplePOO.cs
using ExemplePOO;
Console.WriteLine("Calculatrice");
Console.WriteLine("------------");
Console.WriteLine("Entrez un nombre");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrez un autre nombre");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrez un opérateur");
string operateur = Console.ReadLine();
ProgramPOO maCalculatrice = new ProgramPOO();
if (operateur == "+")
{
    Console.WriteLine("Le résultat est : " + maCalculatrice.Addition(a, b));
}
else if (operateur == "-")
{
    Console.WriteLine("Le résultat est : " + maCalculatrice.Soustraction(a, b));
}
else if (operateur == "*")
{
    Console.WriteLine("Le résultat est : " + maCalculatrice.Multiplication(a, b));
}
else if (operateur == "/")
{
    Console.WriteLine("Le résultat est : " + maCalculatrice.Division(a, b));
}
else
{
    Console.WriteLine("Opérateur non reconnu");
}