using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Setul_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ex_1();
            ex_2();
            ex_3();
            ex_4();
            ex_5();
            ex_6();
            ex_7();
            ex_8();
            ex_9();
            ex_10();
            ex_11();
            ex_12();
            ex_13();
            ex_14();
            ex_15();
            ex_16();
            ex_17();


            Console.ReadKey();
        }
        private static void ex_1()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir,");
            int n = int.Parse(Console.ReadLine()), x, pare = 0;
            Console.WriteLine($"cititi {n} termeni de la tastatura si aflati cati dintre acestia sunt pari");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    pare++;
            }
            Console.WriteLine($"Numarul de nr pare din sir este {pare}");
            Console.WriteLine();
        }
        private static void ex_2()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir,");
            int n = int.Parse(Console.ReadLine()), x, zero = 0, neg = 0, poz = 0;
            Console.WriteLine($"cititi {n} termeni de la tastatura si aflati cati dintre acestea sunt zero, negativi si pozitivi");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                    neg++;
                else
                    if (x == 0)
                    zero++;
                else
                    poz++;
            }
            Console.WriteLine($"Numarul de nr negative este: {neg}, zero: {zero} si pozitive: {poz}");
            Console.WriteLine();
        }
        private static void ex_3()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir,");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"si aflati suma, respectiv produsul nr de la 1 la {n}");
            long P = 1;
            for (int i = 0; i < n; i++)
                P *= (i + 1);
            Console.WriteLine($"Suma este {n * (n + 1) / 2}, produsul este {P}");///suma lui Gauss, respectiv n!
            Console.WriteLine();

        }
        private static void ex_4()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir");
            int n = int.Parse(Console.ReadLine()), x, i = 0;
            Console.WriteLine($"un numar intreg a, cititi {n} termeni de la tastatura si aflati pe ce pozitie din sir este a. In caz ca nu este gasit, pozitia sa va fi -1");
            int a = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == a)
                {
                    Console.WriteLine($"Pozitia din sir a lui {a} este {i}");
                    break;
                }
            }
            if (i == n)
                Console.WriteLine($"Pozitia din sir a lui {a} este -1");
            Console.WriteLine();

        }
        private static void ex_5()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir,");
            int n = int.Parse(Console.ReadLine()), x, nr = 0;
            Console.WriteLine($"cititi {n} termeni de la tastatura si aflati cati termeni din sir sunt egali cu pozitia sa");
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == i)
                    nr++;
            }
            Console.WriteLine();
            Console.WriteLine($"Numarul de termeni din sir ce sunt egali cu pozitia sa este {nr}");
            Console.WriteLine();
        }
        private static void ex_6()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir");
            int n = int.Parse(Console.ReadLine()), x, y;

            Console.WriteLine($"cititi {n} termeni de la tastatura si aflati daca sirul este crescator");
            x = int.Parse(Console.ReadLine()); bool ok = true;
            for (int i = 1; i < n && ok; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x > y)
                    ok = false;
                else
                    x = y;
            }
            Console.WriteLine();
            if (!ok)
                Console.WriteLine("Numerele NU sunt ordonate crescator");
            else
                Console.WriteLine("Numerele SUNT ordonate crescator");
            Console.WriteLine();
        }
        private static void ex_7()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"cititi {n} termeni de la tastatura si aflati valoarea minima, respectiv maxima din sir");
            int x = int.Parse(Console.ReadLine()); ///primul termen din sir
            int min = x, max = x;
            for (int i = 0; i < n - 1; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x > max)
                    max = x;
                else
                    if (x < min)
                    min = x;
            }
            Console.WriteLine();
            if (min == max)
                Console.WriteLine($"minimul este egal cu maximul: {min}");
            else
                Console.WriteLine($"minimul este: {min}, maximul este: {max}");
            Console.WriteLine();
        }
        private static void ex_8()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"si aflati al {n}-lea termen din sirul numerelor lui Fibbonaci");
            int f0 = 0, f1 = 0, f2 = 1;

            for (int i = 0; i < n - 1; i++)
            {
                f0 = f1;
                f1 = f2;
                f2 = f0 + f1;

            }
            Console.WriteLine();
            Console.WriteLine($"Al {n}-lea termen din sirul numerelor lui Fibbonaci este: {f2}");
            Console.WriteLine();

        }
        private static void ex_9()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir,");
            int n = int.Parse(Console.ReadLine()), x, y, i = 1;
            Console.WriteLine($"cititi {n} nr de la tastatura si aflati daca secventa de nr este monotona");
            int cresc = 0, descresc = 0; ///secventa este monotona 
            x = int.Parse(Console.ReadLine());///primul termen din sir
            bool ok = true;

            do
            {
                y = int.Parse(Console.ReadLine());
                if (x > y)
                    descresc++;
                else
                    if (x < y)
                    cresc++;

                if (cresc >= 1 && descresc >= 1)
                {
                    ok = false;
                    break;
                }

                else
                {
                    x = y;
                    i++;
                }
            } while (i < n);

            Console.WriteLine();
            if (ok)///pt cresc = descresc = 0, sirul e compus din n termeni identici, deci sirul e monoton
                Console.WriteLine("Sirul ESTE monoton");
            else
                Console.WriteLine("Sirul NU este monoton");

            Console.WriteLine();
        }
        private static void ex_10()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir,");
            int n = int.Parse(Console.ReadLine()), x, y, nr = 1, max = 1;
            Console.WriteLine($"cititi {n} termeni de la tastatura si aflati lungimea maxima formata din termeni identici");
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x == y)
                {
                    nr++;
                    if (nr > max)
                        max = nr;
                }
                else
                {
                    nr = 1;
                    x = y;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Lungimea maxima formata din termeni identici este {max}");
            Console.WriteLine();

        }
        private static void ex_11()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"cititi {n} termeni de la tastatura si aflati suma inverselor nr");
            double Sum = 0, x;
            for (int i = 0; i < n; i++)
            {
                x = double.Parse(Console.ReadLine());
                if (x != 0)
                    Sum += 1 / x;
            }
            Console.WriteLine();
            Console.WriteLine($"suma inverselor nr este {Sum}");
            Console.WriteLine();
        }
        private static void ex_12()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir");
            int n = int.Parse(Console.ReadLine()), x, nr = 0;
            Console.WriteLine($"cititi {n} termeni de la tastatura si aflati cate grupuri de nr nenule sunt delimitate de 0");
            bool zero;
            x = int.Parse(Console.ReadLine());

            if (x != 0)
            {
                zero = false;
                nr++;
            }
            else
                zero = true;

            for (int i = 0; i < n - 1; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x != 0 && zero)///inceput de sir ce consista dintr unul sau mai multe nr nenule
                {
                    zero = false;
                    nr++;
                }
                else
                    if (x == 0 && !zero)
                    zero = true;

            }
            Console.WriteLine();
            Console.WriteLine($"Numarul de grupuri de nr nenule delimitate de 0 este: {nr}");
            Console.WriteLine();
        }
        private static void ex_13()
        {

            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir,");
            int n = int.Parse(Console.ReadLine()), x, y = -1, i = 1, stg;
            Console.WriteLine($"cititi {n} nr de la tastatura si aflati daca secventa data este o <secventa crescatoare rotita>");

            x = int.Parse(Console.ReadLine());///primul termen din sir
            stg = x;

            bool ok = true;
            while (i < n)
            {
                y = int.Parse(Console.ReadLine());
                if (x > y)
                {
                    x = y;///y trebuie sa fie cel mai mic element din sir                
                    break;
                }

                x = y;
                i++;

            }
            if (stg < y)
                ok = false;
            else
            {

                i++;
                while (i < n)
                {
                    y = int.Parse(Console.ReadLine());
                    if (x > y || y > stg) ///sir amestecat
                    {
                        ok = false;
                        break;
                    }

                    x = y;
                    i++;

                }

            }
            Console.WriteLine();
            if (!ok)
                Console.WriteLine("Secventa de nr NU este o <secventa crescatoare rotita>");
            else
                Console.WriteLine("Secventa de nr ESTE o <secventa crescatoare rotita>");
            Console.WriteLine();

        }
        private static bool ex_14_verif_secv_cresc_rotita(int n, int x, int pivot)
        {
            int y = -1, i = 1;

            bool caz2 = true;///caz_2 devine false in cazul in care se gasesc mai mult de o pereche de nr crescatoare
            while (i < n - 1)
            {
                y = int.Parse(Console.ReadLine());
                if (x > y)///y trebuie sa fie cel mai mic element din sir
                    break;

                else
                {
                    i++;
                    if (x != y)
                    {
                        caz2 = false;
                        x = y;
                    }

                }
            }


            if (i == n - 1)/// sir cresc sau sir constant
                return true;///EX: 1 2 2 3 4 5 5 8 

            if (!caz2)
            {

                if (y > pivot)
                    return false;
                else
                {
                    i++;
                    x = y;

                    while (i < n - 1)
                    {
                        y = int.Parse(Console.ReadLine());

                        if (x > y || y > pivot)

                            return false; ///EX: caz 1: 2 3 3 4 6 1 0...; caz 2: 2 3 3 4 6 0 0 1 4...
                                          

                        i++;
                        x = y;

                    }
                    return true; /// 1 2 2 3 4 0 0 1 1

                }
            }
            
                i++;
                x = y;

                while (i < n - 1)
                {

                    y = int.Parse(Console.ReadLine());
                    if (x < y || y < pivot)
                        return false;///EX: caz 1: 1 6 5 4 4 2 3...; caz 2: 2 6 5 4 3 2 1...

                    x = y;
                    i++;

                }
                return true;///EX: 2 6 5 4 4 3

        }
        private static bool ex_14_verif_secv_descresc_rotita(int n, int x, int pivot)
        {

            int y = -1, i = 1;

            bool caz2 = true;///caz_2 ajunge false in cazul in care se gasesc mai mult de o pereche de nr descrescatoare
            while (i < n - 1)
            {
                y = int.Parse(Console.ReadLine());
                if (x < y)///y trebuie sa fie cel mai mare element din sir
                    break;

                else
                {
                    i++;
                    if (x != y)
                    {
                        caz2 = false;
                        x = y;
                    }

                }
            }


            if (i == n - 1)/// sir descrescator, ce nu i rotit
                return true;///EX:  8 5 5 4 3 2 1 1

            if (!caz2)
            {

                if (y < pivot)
                    return false; ///EX: 5 4 4 3 2 4 3 2 1... 
                else
                {
                    i++;
                    x = y;

                    while (i < n - 1)
                    {
                        y = int.Parse(Console.ReadLine());

                        if (x < y || y < pivot)

                            return false; /// caz 1: 4 3 2 1 9 9 7 8...; caz 2: 4 3 2 1 9 9 8 5 3...
                                          ///sir amestecat

                        i++;
                        x = y;

                    }
                    return true; /// 4 3 2 1 9 9 8 6 6 5

                }
            }
            
                i++;
                x = y;

                while (i < n - 1)
                {

                    y = int.Parse(Console.ReadLine());
                    if (x > y || y > pivot)
                        return false;///EX: caz 1: 6 6 1 2 3 3 2...; caz 2: 6 6 1 2 3 3 4 7...
                    x = y;
                    i++;

                }
                return true;///EX: 6 6 1 2 3 3 4 5 5

        }
        private static void ex_14()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir,");
            int n = int.Parse(Console.ReadLine());
           if(n < 1)
                Console.WriteLine("Date gresite date de la tastatura");
            else

            if (n >= 1 && n <= 2)
                Console.WriteLine("Secventa de nr ESTE o <secventa monotona rotita>");
            else
            {
                Console.WriteLine($"cititi {n} nr de la tastatura si aflati daca secventa data este o <secventa monotona rotita>");
                int x, y, i = 1;

                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                while (x == y && i != n - 1)
                {
                    y = int.Parse(Console.ReadLine());
                    i++;
                }
                if (i == n - 1)
                    Console.WriteLine("Secventa de nr ESTE o <secventa monotona rotita>"); ///sir constant
                else
                {
                    n = n - i + 1;/// in caz ca sirul incepe cu termeni identici, ignoram primii i - 1 termeni

                    if (x < y)
                    {
                        if (!ex_14_verif_secv_cresc_rotita(n, y, x))
                            Console.WriteLine("Secventa de nr NU este o <secventa monotona rotita>");
                        else
                            Console.WriteLine("Secventa de nr ESTE o <secventa monotona rotita>");
                    }
                    else
                         if (!ex_14_verif_secv_descresc_rotita(n, y, x))
                            Console.WriteLine("Secventa de nr NU este o <secventa monotona rotita>");
                        else
                            Console.WriteLine("Secventa de nr ESTE o <secventa monotona rotita>");
                }

            }
            Console.WriteLine();
        }

        private static void ex_15()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir,");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"cititi {n} nr de la tastatura si aflati daca secventa de nr este bitonica");
            bool ok = true;


            if (n < 1)//sirul nu contine destule nr ca sa se verifice
                ok = false;

            else
            if(n >= 2)
            {
                int x, y;
                x = int.Parse(Console.ReadLine());///primul termen din sir
                y = int.Parse(Console.ReadLine());///al doilea termen din sir
                if (x > y)//sir ce incepe descrescator
                { 
                    x = y;
                    int i = 1;
                    do
                    {
                        y = int.Parse(Console.ReadLine());
                        if (x < y)///din cresc in descres
                            break;///conditie de stop

                        x = y;
                        i++;

                    } while (i < n - 1);

                    if (i != n - 1)
                        ok = false;
                
                 }
                else
                {
                    x = y;
                    int i = 1;
                    do
                    {
                        y = int.Parse(Console.ReadLine());
                        if (x > y)///din cresc in descres
                            break;///conditie de stop

                        x = y;
                        i++;

                    } while (i < n - 1);

                    if (i != n - 1)
                    
                    {
                        i++;
                        x = y;
                        do
                        {
                            y = int.Parse(Console.ReadLine());
                            if (x < y)///sir amestecat
                            {
                                ok = false;
                                break;
                            }

                            x = y;
                            i++;


                        } while (i < n - 1);

                    }
                }
            }
            Console.WriteLine();
            if (!ok)
                Console.WriteLine("Secventa de nr NU este bitonica sau date gresite date de la tastatura");
            else
                Console.WriteLine("Secventa de nr ESTE bitonica");
            Console.WriteLine();

        }
        private static bool ex_16_secv_bitonica_rotita_cresc_descresc_sau_cresc_descresc_cresc(int pivot, int x, int n)
        {
            bool caz_2 = false;  ///secv rotita cresc -> descresc -> cresc pt caz_2 = true

            int y, i = 1;
            do
            {
                y = int.Parse(Console.ReadLine());
                if (x > y)///din cresc in descres
                    break;///conditie de stop

                x = y;
                i++;


            } while (i < n - 1);

            if (i == n - 1)
                return true;///sir crescator 

            i++;
            x = y;

            do
            {
                y = int.Parse(Console.ReadLine());
                if (x < y)///sir amestecat
                {
                    caz_2 = true;
                    break;
                }

                x = y;
                i++;

            } while (i < n - 1);


            if (!caz_2)
                return true;/// EX: 4 5 5 7 6 6 5 4 3
            x = y;
            i++;
            do
            {
                y = int.Parse(Console.ReadLine());
                if (x > y || y > pivot) ///EX: caz 1:  3 5 8 9 7 6 2 3 1...; caz 2 : 3 5 8 9 7 6 2 3 3 4...
                    return false;

                x = y;
                i++;


            } while (i < n - 1);

            return true;///EX: 4 5 8 9 7 6 0 1 2 3

        }
        private static bool ex_16_secv_bitonica_rotita_descresc_cresc_sau_descresc_cresc_descresc(int pivot, int x, int n)
        {
            bool caz_2 = false; ///secv rotita descresc -> cresc -> descresc pt caz_2 = true

            int y, i = 1;
            do
            {
                y = int.Parse(Console.ReadLine());
                if (x < y)///din descresc in cres
                    break;///conditie de stop

                x = y;
                i++;


            } while (i < n - 1);

            if (i == n - 1)
                return true;///sir descrescator

            i++;
            x = y;

            do
            {
                y = int.Parse(Console.ReadLine());
                if (x > y)///sir amestecat
                {

                    caz_2 = true;
                    break;
                }

                x = y;
                i++;

            } while (i < n - 1);


            if (!caz_2)
                return true;///EX: 9 8 8 7 4 4 5 6
            x = y;
            i++;
            do
            {
                y = int.Parse(Console.ReadLine());
                if (x < y || y < pivot)///EX: caz 1: 9 8 3 5 6 4 3 10...; caz 2: 4 3 3 1 2 5 4 2...
                    return false;

                x = y;
                i++;


            } while (i < n - 1);

            return true;///EX: 4 3 3 1 2 3 5 9 8 8 7
        }
        private static void ex_16()
        {
            Console.WriteLine("Dati un numar natural nenul n de la tastatura, lungimea finita a unui sir,");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"cititi {n} nr de la tastatura si aflati daca secventa de nr este rotita bitonic");

            Console.WriteLine();
            Console.WriteLine();
            if(n < 1)
                Console.WriteLine("Date gresite date de la tastatura");
            else

            if (n <= 2 && n >= 1 )
                Console.WriteLine("Secventa de nr ESTE rotita bitonic");
            else
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int i = 1;
                while (x == y && i != n - 1)
                {
                    y = int.Parse(Console.ReadLine());
                    i++;
                }
                if (i == n - 1)///sir constant
                   Console.WriteLine("Secventa de nr ESTE rotita bitonic");
                else
                {
                    n = n - i + 1;/// in caz ca sirul incepe cu termeni identici, ignoram primii i - 1 termeni
                    int pivot = x;
                    if (x < y)
                    {
                        if (!ex_16_secv_bitonica_rotita_cresc_descresc_sau_cresc_descresc_cresc(pivot, y, n))
                            Console.WriteLine("Secventa de nr NU este rotita bitonic");
                        else
                            Console.WriteLine("Secventa de nr ESTE rotita bitonic");
                    }
                    else
                        if (!ex_16_secv_bitonica_rotita_descresc_cresc_sau_descresc_cresc_descresc(pivot, y, n))
                            Console.WriteLine("Secventa de nr NU este rotita bitonic");
                        else
                            Console.WriteLine("Secventa de nr ESTE rotita bitonic");
                }
            }


            Console.WriteLine();
        }
        private static void ex_17()
        {
            Console.WriteLine("Aflati daca secv urmatoare compusa din paranteze deschise si inchise este corecta, cat si numarul de incuibare al acestora");
            bool stop = false, ok = true;
            int inchis = 0, deschis = 1, x;
            x = int.Parse(Console.ReadLine());


            if (x == 1 || x == -1)
                ok = false;

            else
            {
                deschis = 1;
                do
                {
                    x = int.Parse(Console.ReadLine());
                    if (x == -1)
                        stop = true;
                    else
                        if (x == 1)
                    {
                        if (deschis == inchis)///nu mai sunt paranteze de inchis
                        {
                            ok = false;
                            stop = true;
                        }
                        else
                            inchis++;
                    }

                    else
                        deschis++;

                } while (!stop);
            }



            if (!ok || deschis > inchis)
                Console.WriteLine("Secventa gresita");
            else
            {
                Console.WriteLine("Secventa corecta");
                Console.WriteLine();
                Console.WriteLine($"Nr-ul maxim de incuibare a parantezelor este:  {inchis}");
            }

            Console.WriteLine();

        }
    }
}
