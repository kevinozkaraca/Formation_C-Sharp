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

    Les fichiers ont une extension .cs et s'ouvre avec Visual Studio ou VScode 
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
    WriteLine affiche du texte en utilisant toute une ligne Write «affiche 
    du texte sans prendre une ligne entière (évite le saut de ligne)
*/

Console.WriteLine("----- LES VARIABLES -----");
Console.WriteLine(homme);
Console.WriteLine(age1);
Console.WriteLine(taille);
Console.WriteLine(prenom);

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
string concatenation1 = "Je suis " + prenomDePaul + ", j'ai " + ageDePaul + " ans.";
string concatenation2 = $"Je suis {prenomDePaul} et j'ai {ageDePaul} ans.";

string lien1 = "C:\\docs\\dossier\\text.txt";
string lien2 = @"C:\docs\dossier\text.txt";
string echapement = "Je suis l\' espace entre le temps.";
string copyright = "\u00A9";

Console.WriteLine("----- LA CONCATENATION -----");
Console.WriteLine(concatenation1);
Console.WriteLine(concatenation2);
Console.WriteLine(lien1);
Console.WriteLine(lien2);
Console.WriteLine(echapement);
Console.WriteLine(copyright);

string questionPourReadline = "Quel est votre prénom ?";
Console.WriteLine(questionPourReadline);
string prenomDeReadLine = Console.ReadLine();
Console.WriteLine($"Bonjour {prenomDeReadLine}");

/*
    ReadLine renvoie toujours une variable de type string « prénom » 
    ne peut donc pas être un int et il va falloir convertir la donnée en cas de besoin
    int.Parse(Console.ReadLine())
*/

/*
---------  LES CALCULS
    Il est important de respecter l’ordre d’incrémentation 
    « nombre1++ » n’est pas comme « ++nombre1 »

    Int 9 – int 2 = 4 (car il ne prend pas les décimales)  
 */

Console.WriteLine("----- LES CALCULS -----");
int nombreCalcul1 = 20;
int nombreCalcul2 = 25;
int resultatCalcul;
Console.WriteLine(nombreCalcul1 + 25);
Console.WriteLine(20 + nombreCalcul2);
resultatCalcul = nombreCalcul1 + nombreCalcul2;
Console.WriteLine(resultatCalcul);
nombreCalcul1 = nombreCalcul1 + 1;
nombreCalcul2++;
Console.WriteLine($"nombre1Calcul1 +1 = {nombreCalcul1} et nombre2Calcul2++ = {nombreCalcul2}");
Console.WriteLine($"Maintenant nombre1Calcul1 + nombre2Calcul2 = {nombreCalcul1 + nombreCalcul2}");
nombreCalcul1 += 22;
Console.WriteLine($"nombreCalcul1 += 22 = {nombreCalcul1}");
++nombreCalcul1;
++nombreCalcul2;
Console.WriteLine($"++nombre1Calcul1 = {nombreCalcul1} et ++nombre2Calcul2 = {nombreCalcul2}");
Console.WriteLine($"Maintenant nombre1Calcul1 + nombre2Calcul2 = {nombreCalcul1 + nombreCalcul2}");


/*
---------  LES COMPARAISONS
On utilise avec les conditions, les opérateurs suivants :
	égalité ==
	diffèrent !=
	supérieur à >
	inferieur à <
	supérieur ou égal >=
	inférieur ou égal <=
	et  && (si on met une seul & la condition suivante sera évalué)
	ou ||
	négation (n’est pas) !
    ou exclusif ^ (si une des deux est vrai, mais pas les deux)
*/

/*
---------  LA CONDITION (if/else if/else)
    Il est possible d’écrire !true qui sera égale à false 
    Les accolades ne sont pas obligatoire en cas d’une seule instruction
*/
Console.WriteLine("----- LA CONDITION (if/else if/else) -----");
if (nombreCalcul1 == nombreCalcul2)
{
    Console.WriteLine("nombreCalcul1 est égal à nombreCalcul2");
}
if (nombreCalcul1 != nombreCalcul2)
{
    Console.WriteLine("nombreCalcul1 est différent de nombreCalcul2");
}
if (nombreCalcul1 > nombreCalcul2)
{
    Console.WriteLine("nombreCalcul1 est supérieur à nombreCalcul2");
}
if (nombreCalcul1 < nombreCalcul2)
{
    Console.WriteLine("nombreCalcul1 est inférieur à nombreCalcul2");
}
if (nombreCalcul1 >= nombreCalcul2)
{
    Console.WriteLine("nombreCalcul1 est supérieur ou égal à nombreCalcul2");
}
else if (nombreCalcul1 <= nombreCalcul2)
{
    Console.WriteLine("nombreCalcul1 est inférieur ou égal à nombreCalcul2");
}
else
{
    Console.WriteLine("nombreCalcul1 et nombreCalcul2 sont égaux");
}

/*
---------  LES COLLECTIONS
    Les collections sont des structures de données qui permettent de stocker plusieurs valeurs.
    
*/