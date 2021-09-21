


using ProjetDLL;
using System;
using System.IO;

namespace ProjetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test c#");

            Tools.MethodeDLL();

            //ceci est un commentaire sur une seule ligne

            /*
             * Ceci est un commentaire sur plusieurs 
             * lignes.............
             */

            #region Les Variables
            Console.WriteLine("*******************VARIABLES****************");

            //Variable: zone mémoire contanant une valeur typée
            //Types simples (types valeur): entiers, réels, boolean, char
            //Types complèxes (types réference): Arrray, string, enum, classe et objet

            //entiers: byte(1 o), shrt(2 o), int(4 o), long(8 o)
            //Pour déclarerune variable: Type Nom_Variable = valeur;

            int myInt = 10;
            int myInt2 = myInt;
            myInt = 20;
            Console.WriteLine("Contenu de la variable myInt = " +myInt); //+: une concaténation

            char myChar = 'c';
            string chaine = "ceci est une chaine";
            string chaine2 = chaine;

            chaine = "nouvelle chaine";

            chaine = chaine.ToUpper();
            chaine = null;
            

            //Appel explicite du garbage collector: cet appel explicite l'implique pas le passage immédiat du garbage collector
            GC.Collect();
            

            //réel: float(4 o), double (8 o), decimal(16 o)
            double myDouble = 10.5;

            bool myBool = true;

            //le mot clé var: inférence du type - le compilateur détermine le type de la variable selon la valeur qui lui a été affectée
            var maVariable = "10.5";

            // maVariable = 10; - Erreur de compilation

            //Contante: une variable qui une valeur typée qu'on ne peut pas modifier: par convention les noms des contantes sont en majuscule
            const double MA_CONSTANTE = 10.5;

            #endregion

            #region Opérateurs
            Console.WriteLine("*******************OPERATEURS****************");

            //Opérateurs arithmétiques: +,*,-,/,% (Modulo - reste de la division entière)
            double resultat = 9 / 2;
            Console.WriteLine("9 divisé par: "+resultat); //4.5

            int mod = 9 % 2;
            Console.WriteLine("Reste de la division de 9 sur 2: " +mod); //1

            //Opérateurs d'incrémentation et de décrémentation:
            int i = 5;
            i++; // i = i + 1;
            i--; //i = i - 1;

            //Opérateurs combinés: +=, -=, *=, /=
            i += 5; //i = i + 5;

            //Opérateurs de comparaison: ==(égalité), <, >, <=, >=, !=(différent)
            //Opérateurs logiques: && (et), || (ou), ^ (ou exclusif), ! (non logique)
            int v1 = 10, v2 = 15;

            Console.WriteLine((v2 > v1) && (v2 < v1)); //false
            //Table logique
            //A     B    (A&&b)     (A||B)      (A^B)
            //v     v       v          v           f
            //v     f       f          v           v
            //f     v       f          v           v
            //f     f       f          f           f
            //

            //Caractères d'echappement:
            Console.WriteLine("\tBonjour, \nje suis en formation chez Dawan.\nFormation c#.");
            string chemin = "c:\\test";

            //Chaine verbatim
            string chemin2 = @"c:\test";

            string paragraph = @"   Bonjour,
Je suis chez Dawan.
Formation c#";

            //Formattage de chaines en utilisant l'intérpolation
            int x = 20, y = 30;
            Console.WriteLine("x = "+x+" y= "+y); //concaténation
            Console.WriteLine("x = {0} y = {1}", x,y); //interpolation v1
            Console.WriteLine($"x = {x} y = {y}"); //interpolation v2

            #endregion

            #region Conversion de types
            Console.WriteLine("*******************CONVERSION DE TYPES****************");

            //conversion implicite: concerne le passage d'un type inférieur à un type supérieur
            byte myByte = 10;
            int myInteger = myByte;

            //Conversion explicite: concerne le passage d'un type sup à un type inf
            //1- Utilisation d'un CAST : (byte), (int), (double)......risque de perte de données
            //2- Utilisation de la classe Convert
            //3- Utilisation de la méthode parse
            int myInteger2 = 10;
            byte myByte2 = (byte)myInteger2;
            byte myByte3 = Convert.ToByte(myInteger2);
            // byte myByte4 = byte.Parse(myInteger2); - la méthode Parse concerne les conversions en types non compatibles

            string str = "20";
            int chiffre = int.Parse(str);
            int chiffre2 = Convert.ToInt32(str);

            Console.WriteLine("Merci de saisir votre:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Votre age est: {age}");

            #endregion

            #region Conditions
            Console.WriteLine("*******************CONDITIONS****************");

            //if(condition est vraie) {instru1} else {instruc1}
            int nb = 5;
            if (nb > 0)
            {
                Console.WriteLine("nb est positif");
            }
            else if(nb == 0)
            {
                Console.WriteLine("nb est null");
            }
            else
            {
                Console.WriteLine("nb est négatif");
            }

            //Swicth: une variante de la condition if
            int note = 10;
            switch (note)
            {
                case 0:
                    Console.WriteLine("recalé");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Juste la moyenne: 10, 11, 12");
                    break;
                default:
                    Console.WriteLine("Réussite garantie");
                    break;
            }

            //Opérateur ternaire:
            //resultat = (condition)? expression1 : expression2 --- si la condition est vraie : resultat = expression1 sinon resultat = expression2

            bool myBoolean = (10 > 5) ? false : true; //myBoolean = false;

            #endregion

            #region Boucles
            Console.WriteLine("*******************BOUCLES****************");

            //Boucles conditionnelles: while, do while
            //Boucles itératives: for, for each

            //for: connaitre le nombre d'itérations

            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine($"Passage n°: {index}");
            }

            //for each: permet de faire un parcours complet d'une collection
            int[] tab = { 1, 2, 3, 4, 5 };

            foreach (int item in tab) //pour chaque entier item contenu dans le tableau tab
            {
                Console.WriteLine(item);
            }

            //While
            int valeur = 1;
            while (valeur < 5) //tant que valeur est inférieure à 5 tu fais:
            {
                Console.WriteLine($"Passage n°: {valeur}");
                valeur++;

                //sortir de la boucle while si valeur == 3
                if (valeur == 3)
                {
                    break;
                    //break nous permet de sortir de la boucle while
                }
            }

            //Do - While: fais tant que condition est vraie
            do
            {
                Console.WriteLine($"Passage n°: {valeur}");
                valeur++;
            } while (valeur < 10);
            #endregion

            #region Tableaux

            Console.WriteLine("*******************TABLEAUX****************");

            //Tableau: ensemble d'éléments - de taille fixe

            //1 dimension
            int[] monTbleau = new int[3]; //tableau de 3 cases
            monTbleau[0] = 10;
            monTbleau[1] = 20;
            monTbleau[2] = 30;

            int[] monTableau2 = { 10, 20, 30 };

            Console.WriteLine("Taille du tableau2: "+monTableau2.Length); //3
            //lister le contenu du tableau
            foreach (var item in monTableau2)
            {
                Console.WriteLine(item);
            }

            for (int indice = 0; indice < monTableau2.Length; indice++)
            {
                Console.WriteLine(monTableau2[indice]);
            }

            //Tableau à 2 dimensions
            int[,] matrice = new int[2, 3];
            matrice[0, 0] = 10;
            matrice[0, 1] = 15;
            matrice[0, 2] = 20;
            matrice[1, 0] = 25;
            matrice[1, 1] = 30;
            matrice[1, 2] = 35;
            
            int[   ,   ] matrice2 = { {10,20,30 },{40,50,60 } };
            Console.WriteLine(matrice2[1,0]); //40

            Console.WriteLine("Nombre de lignes de matrice2: "+matrice2.GetLength(0)); //2
            Console.WriteLine("Nombre de colonnes de matrice2: "+matrice2.GetLength(1)); //3
            Console.WriteLine("Nombre d'éléments de la matrice2: "+matrice2.Length);//6
            Console.WriteLine("Nombre de dimensions de matrice2: "+matrice2.Rank);//2

            //Lister le contenu de matrice2
            for (int ligne = 0; ligne < matrice2.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < matrice2.GetLength(1); colonne++)
                {
                    Console.WriteLine(matrice2[ligne,colonne]);
                }
            }
            #endregion

            #region Méthodes

            //Méthode: ensemble d'instructions réutilisables
            //en Programmation objet, 2 types de méthodes possibles:
            //Procédure: méthode qui ne renvoie aucun résultat
            //Fonction: méthode un résultat

            Console.WriteLine("*******************METHODES****************");

            int res = MesMethodes.Somme(10, 20);

            Console.WriteLine($"Somme de 10 et 20 est {res}");

            MesMethodes.Somme(10, 20, 30);

            MesMethodes.Afficher("test de chaine");

            int[] tableau = { 10, 0, 20, 15 };

            Console.WriteLine("Tableau1:");
            MesMethodes.Afficher(tableau);

            int[] tableau2 = { 10, 0, 20, 15,70,80,10 };

            Console.WriteLine("Tableau2:");
            MesMethodes.Afficher(tableau2);


            int somElement = MesMethodes.SommeElement(tableau);
            Console.WriteLine($"Somme des éléments de tableau: {somElement}");

            Console.WriteLine($"La moyenne des éléments du tableau: {MesMethodes.Moyenne(tableau)}");

            Console.WriteLine($"L'élément min du tableau: {MesMethodes.Minimum(tableau)}");

            //Appel de la méthode qui prend des params optionnels
            MesMethodes.SommeOptional(10, 20); //40
            MesMethodes.SommeOptional(10, 20, 40); //70


            int valeur1 = 10, valeur2 = 20;

            Console.WriteLine($"Avant permutation: valeur1={valeur1} - valeur2={valeur2}"); //10 - 20
            MesMethodes.Permuter(ref valeur1, ref valeur2);

            Console.WriteLine($"Après permutation: valeur1={valeur1} - valeur2={valeur2}");

            //Appel de la méthode avec des param en sortie

            double a = 10, b = 20;
            double sommeSortie = 0, moyenneSortie = 0;
            double produit = MesMethodes.Calculer(a, b, out sommeSortie, out moyenneSortie);

            Console.WriteLine($"Produit = {produit}");
            Console.WriteLine($"Somme en sortie = {sommeSortie}");
            Console.WriteLine($"Moyenne en sortie = {moyenneSortie}");


            string number = "20";
            int numConvert = 0;
            bool conversion = int.TryParse(number, out numConvert);
            if (conversion)
            {
                Console.WriteLine($"Conversion réussie - numConvert = {numConvert}");
            }
            else
            {
                Console.WriteLine("Echec de la conversion");
            }



            #endregion

            //maintenir la console active
            Console.ReadLine();
        }
    }
}
