using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textadventure
{
    /*
     * ------------------------------------------------------------------------------------------
     * @copy     Ivara Software 2016, all rights reserved
     * @project  TextAdventure
     * @author   Luca Kiebel, Luca Hartmann
     * @version  0.0.1 Closed Alpha
     * ------------------------------------------------------------------------------------------
     */
    public static class GlobalVars
    {
        /*
         * Alle Variblen außer i, j, k, l, m hier rein (Incrementer)
        */
        public static int usercount_user;
        public static string singleUsername_user;
        public static string multiUsername1_user;
        public static string multiUsername2_user;
        //public static string globalVarTest = "test erfolgreich";

    }

    class Program
    {
       public static void Main()
        {
            //Console.WriteLine("Ist der Test erfolgreich?: " + GlobalVars.globalVarTest);
            Console.WriteLine("TEXTADVENTURE");
            Console.WriteLine("Retrolutscher by Ivara Software");
            Console.WriteLine("-------------------------------");
            System.Threading.Thread.Sleep(500);
        Spieleranzahl:
            Console.Write("Bist du allein oder seid ihr zu zweit, Abenteurer? (1/2) ");
            int usercount_user = int.Parse(Console.ReadLine());
            if (usercount_user == 1)
            {
               EinzelSpieler.ESMain();

            }else if (usercount_user == 2)
            {
                ZweiSpieler.ZSMain();
            }else
            {
                Console.Clear();
                Console.WriteLine("TEXTADVENTURE");
                Console.WriteLine("Retrolutscher by Ivara Software");
                Console.WriteLine("-------------------------------");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Bitte gib eine Zahl zwischen 1 und 2 an!");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("TEXTADVENTURE");
                Console.WriteLine("Retrolutscher by Ivara Software");
                Console.WriteLine("-------------------------------");
                System.Threading.Thread.Sleep(500);
                goto Spieleranzahl;
            }

        }

        static void GameCore()
        {
            //genereller Code für das Game, wie Dialoge ohne die besonderheiten pro Spieleranzahl

        }
    }

    public class EinzelSpieler
    {
        /*
         * Einzelspieler, anredeForm = du
         */
        public static void ESMain()
        {
            //code nur für EinzelSpieler
            //Namen des Spielers abspeichern
            Console.Write("Abenteurer, bitte wähle einen Namen: ");
            string singleUsername_user = Console.ReadLine();
            System.Threading.Thread.Sleep(50000);
        }

    }

    public class ZweiSpieler
    {

        /*
       * Zweispieler, anredeform = ihr
       */
        public static void ZSMain()
        {
            //code nur für ZweiSpieler
            //Namen der Spieler abspeichern
            Console.Write("Spieler 1, bitte wähle einen Namen: ");
            string multiUsername1_user = Console.ReadLine();

            Console.Write("Spieler 2, bitte wähle einen Namen: ");
            string multiUsername2_user = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("TEXTADVENTURE");
            Console.WriteLine("Retrolutscher by Ivara Software");
            Console.WriteLine("-------------------------------");
            System.Threading.Thread.Sleep(500);

            //usertest
            //Console.WriteLine("Spieler 1 heißt " + multiUsername1_user);
            //Console.WriteLine("Spieler 2 heißt " + multiUsername2_user);
            System.Threading.Thread.Sleep(50000);
        }
    }

}
