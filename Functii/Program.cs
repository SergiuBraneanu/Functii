using System;

namespace Functii
{
    class Program
    {
        static int DeterminareMax(int a,int b)
        {
            if (a > b) return a;
            else return b;
        }
        static int DeterminareMini(int a,int b)
        {
            if (a < b) return a;
            else return b;
        }
        static void UrmPrim(int n)
        {
            int p = 2;
            int i = 1;
            while(i<=n)
            {
                if (Prim(p) == 1) { Console.WriteLine(p); p++; i++; }
                else p++;
            }
        }
        static int Prim(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    s = s + 1;
            if (s == 2)
                return 1;
            else return 0;

        }
        static void Prim2(int n)
        {
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    if (Prim(i) == 1)
                        Console.WriteLine($"{i}");
 

        }
        static int NumarTriunghi(int n)
        {
            int a = 0;
            for (int i = 1; i <= n; i++) a = a + i;
            return a;

        }
        static void Main(string[] args)
        {
            /*int a, b, c;
            Console.WriteLine("Introduceti 3 numere:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximul dintre numere este {0}", DeterminareMax(DeterminareMax(a, b), c));
            Console.WriteLine("Minimul dintre numere este {0}", DeterminareMini(DeterminareMini(a, b), c));
            // 1*/

            /*int n;
            Console.WriteLine("Citeste n:");
            n = int.Parse(Console.ReadLine());
            UrmPrim(n);
            //2
            int nr;
            Console.Write("Introduceti numarul:");
            nr=int.Parse (Console.ReadLine());
            Console.WriteLine("Numarul triunghi este {0}", NumarTriunghi(nr));*/

            int n2;
            Console.WriteLine("Citeste n:");
            n2 = int.Parse(Console.ReadLine());
            Prim2(n2);





        }
    }
}
