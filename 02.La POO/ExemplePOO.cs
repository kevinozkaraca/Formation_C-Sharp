// Le fichier de base est le program.cs !
// using est un ensemble de fonctionnalité
using System;
// namespace est l’espace de travail
namespace ExemplePOO
{   // public est portée de la classe
    public class ProgramPOO
    {
        string parametre = "Bonjour";
        public int Addition(int a, int b)
        {
            return a + b;
            // ou int result = a + b;
            // et return result
        }
        public int Soustraction(int a, int b)
        // Il est possible de créer plusieurs méthodes avec le même nom mais avec des paramètres différents
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            int result = 0;
            if (b != 0)
            {
                result = a / b;
            }
            return result;
        }
    }
}

/*
Nous avons ici defini un modele de classe qui s'appelle ProgramPOO. Mais qui
n'est pas utilisable. Pour l'utiliser, il faut l'instancier. 
 Maclass maVariable = new MaClass();
 using ProgramPOO pour utiliser la classe ProgramPOO
*/