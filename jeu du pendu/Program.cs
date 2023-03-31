// Le jeu du pendu
// Version 1.0
// 2016-10-10
// Auteur: Jean-Philippe Giguère
// Description: Le jeu du pendu
// ====================================================================================================
// Historique des modifications
// ====================================================================================================
// Auteur: Jean-Philippe Giguère
// Date: 2016-10-10
// Description: Version initiale



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
string[] mots = { "ordinateur", "programmation", "jeu", "pendu", "csharp", "visualstudio", "jeanphilippegiguere" };
string mot = mots[new Random().Next(0, mots.Length)];
string motCache = new string('*', mot.Length);
int nbErreurs = 0;
Console.WriteLine("Bienvenue au jeu du pendu!");
Console.WriteLine("Le mot à deviner est: " + motCache);
while (nbErreurs < 10 && motCache.Contains('*'))
{
    Console.Write("Entrez une lettre: ");
    string lettre = Console.ReadLine();
    if (mot.Contains(lettre))
    {
        for (int i = 0; i < mot.Length; i++)
        {
            if (mot[i] == lettre[0])
            {
                motCache = motCache.Remove(i, 1);
                motCache = motCache.Insert(i, lettre);
            }
        }
    }
    else
    {
        nbErreurs++;
    }
    Console.WriteLine("Le mot à deviner est: " + motCache);
}