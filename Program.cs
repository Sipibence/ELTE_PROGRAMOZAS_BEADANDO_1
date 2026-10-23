using System;

namespace N4NHR8_Beadando
{
    /*
     * Név: Sipos Bence
     * Neptun: N4NHR8
     * e-mail: siposbence975@gmail.com
     * 
     * Feladat:
     * Ismerjük Magyarország összes településének távolságát Kukutyintól és Piripócstól.
     * Készíts programot, amely megadja azon települések számát, amelyek közelebb vannak
     * Kukutyinhoz, mint Piripócshoz!
     * 
     * Előfeltétel (Ef):
     * 1 <= n <= 100
     * Minden i in [1..n]: 1 <= t[i].k <= 300 és 1 <= t[i].p <= 300
     */

    internal class Program
    {
        struct Telepules
        {
            public int k;
            public int p;
        }

        static void Main()
        {
            // DEKLARÁCIO
            int n;
            Telepules[] t;
            int db;
            int i;

            // BEOLVASÁS
            Console.Error.Write("Adja meg a települések számát: ");
            n = int.Parse(Console.ReadLine());

            t = new Telepules[n];

            for (i = 0; i < n; i++)
            {
                Console.Error.Write($"{i + 1}. település távolságai: ");
                string[] adatok = Console.ReadLine().Split();
                t[i].k = int.Parse(adatok[0]);
                t[i].p = int.Parse(adatok[1]);
            }

            // AlGORITMUS (Megszámolás tétel)
            db = 0;
            for (i = 0; i < n; i++)
            {
                if (t[i].k < t[i].p)
                {
                    db++;
                }
            }

            // KIÍRÁS
            Console.Error.WriteLine("\nKukutyinhoz közelebb lévő települések száma:");
            Console.Write(db);
        }
    }
}