using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration des variables
            string choix = "";
            int valeur1 = 0, valeur2 = 0;

            //Affichage d'un menu
            Console.WriteLine("************CALCULATRICE CONSOLE************");
            Console.WriteLine(" Addition: tapez a");
            Console.WriteLine(" Soustraction: tapez s");
            Console.WriteLine(" Multiplication: tapez m");
            Console.WriteLine(" Division: tapez d");

            //récupérer le choix: tant que le choix saisi est invalid - inviter le user à faire un nouveau choix

            do
            {
                Console.WriteLine("Merci de faire votre choix:");
                choix = Console.ReadLine();
            } while (!(choix == "a" || choix == "m"|| choix == "s" || choix == "d"));

            //Tant que les valeurs saisies ne sont pas valides: le user doit saisir de nouvelles valeurs
            //récupérer valeur1: 
            do
            {
                Console.WriteLine("Merci de saisir la première valeur:");
                try
                {
                    valeur1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    
                }
                
            } while (true);


            //récupérer valeur2
            do
            {
                Console.WriteLine("Merci de saisir la deuxième valeur:");
                try
                {
                    valeur2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {


                }

            } while (true);

            //Affichage du résultat
            //Swicth sur le choix
            switch (choix)
            {
                case "a":
                    Console.WriteLine(valeur1 + "+" + valeur2 + "=" +(valeur1+valeur2));
                    break;
                case "s":
                    Console.WriteLine(valeur1 + "-" + valeur2 + "=" + (valeur1 - valeur2));
                    break;
                case "m":
                    Console.WriteLine(valeur1 + "*" + valeur2 + "=" + (valeur1 * valeur2));
                    break;
                case "d":
                    Console.WriteLine(valeur1 + "/" + valeur2 + "=" + (valeur1 / valeur2));
                    break;

            }


            //maintenir la console active
            Console.ReadLine();
        }
    }
}
