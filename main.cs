// Formation C#

/*

---------  INFORMATION ET PRERECQUIS :

    Le c# est un langage de programmation compilé qui se transforme en code 
    I.L (Intermediate Language) qui est un code commun à plusieurs langages,

    Le code I.L est ensuite interprété par une machine virtuelle (C.L.R) qui 
    le transforme en instruction machine. Le code est donc vérifié et optimisé 
    par le compilateur avant son exécution.

    .NET est un ensemble d’outils pour codé en c#. Il faut installer SDK.net 
    avant de pouvoir l’utiliser

    Pour utiliser c# dans visual studio code, il faut installer c# dans les 
    extension et suivre les instructions suivantes :

    Ouvrir le terminal
        C:\> dotnet new console –n NomDeMonProjet (console pour projet console)
        C:\NomDeMonProjet> dotnet run (pour tester le projet)

    Lors duprojet si l’autocomplétion ne s’affiche pas fait CTRL+ MAJ + P

*/


/*

---------  LES BASES ET LA SYNTAXES

    Les fichiers ont une extension .cs et s'ouvre avec Visual Studio ou CScode 
    avec des extentions. (c# / VS Sharper)

    Les instructions se terminent toujours avec ;

    Il est important de respecter la casse : "AAA" n'est pas "aaa"

 */

/*
---------  LES VARIABLES

    Les variables se caractèrisent pas un type, un nom et une valeur.
    
 */

bool homme = true;
int age1 = 40;
float taille = 2.05f; // Le float fini par un f
string prenom = "Kevin";

/* 

    Il est possible de réassigner la valeur d’une variable 
    après son assignation sans avoir à rappeler son type

    Les variables se nomment en « camelcase » (sans espace entre les mots 
    qui la compose, une majuscule à chaque mot) « jeSuisUnExemple » (convention)

    Il est possible de déclarer des variables de type implicite 
    (le compilateur devinera le type) en tapant : var Nom = Valeur
    La valeur ici est obligatoire contrairement aux autres typages

*/

/* 
    liste des types de variables les plus couramment utilisés dans 
    le langage C#, ainsi qu'un exemple pour chacun d'entre eux:
*/

/*

bool: représente une valeur booléenne qui peut être true ou false.
byte: représente les entiers non signés de 8 bits.
sbyte: représente les entiers signés de 8 bits.
char: représente un seul caractère Unicode.
decimal: représente les nombres décimaux avec une précision élevée.
double: représente les nombres décimaux à virgule flottante avec une précision double.
float: représente les nombres décimaux à virgule flottante avec une précision simple.
int: représente les nombres entiers, positifs ou négatifs.
uint: représente les nombres entiers non signés.
long: représente les entiers signés de 64 bits.
ulong: représente les entiers non signés de 64 bits.
object: représente tout type d'objet.
short: représente les entiers signés de 16 bits.
ushort: représente les entiers non signés de 16 bits.
string: représente une chaîne de caractères Unicode.
dynamic: représente un type de variable dynamique qui 
peut être déterminé au moment de l'exécution.

    Il existe également des types définis par l'utilisateur, 
    qui sont des types de données définis par 
    le programmeur. Ces types peuvent être créés à l'aide de 
    la classe class ou de la structure struct.
    On appelle les types de variables qui acceptent des valeurs négatives les types signés
    Pour déclarer des valeurs qui ne change pas (dans des constantes) :
        const TYPE NOM  = VALEUR
    Il est possible d’utiliser des séparateur : int unMilliard = 1_000_000_000
    Il est possible de stocker un seul caractère avec : char a = ‘a’
    (apostrophes pas guillemets) 
*/

/*
---------  LA CONCATENATION

    Pour mettre des guillements dans une chaine de caractère :
        "Je suis \'' Pas  une"

    Pour une accès fichier :
        "C:\\docs\\dossier\\text.txt"
    Ou avec l’@ :
        @"C:\docs\dossier\text.txt"
    Pour une code unicode :
        "\u00A9"
  
 */

string prenomDePaul = "paul";
int ageDePaul = 45;
string concatenation1 = "Je suis " + prenomDePaul + " , j'ai " + ageDePaul + " ans.";
string concatenation2 = $" Je suis {prenomDePaul} et j'ai {ageDePaul} ans."

string lien1 = "C:\\docs\\dossier\\text.txt";
string lien2 = @"C:\docs\dossier\text.txt";
string echapement = "Je suis l\'' espace entre le temps.";
string copyright = "\u00A9";

