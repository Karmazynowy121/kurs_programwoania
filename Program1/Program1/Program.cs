using System;
using System.Collections.Generic;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// zmienne liczbowe w rogramowaniu 
            //int liczba = 4 / 3;
            //float liczbaZmiennoprzecinkowa = 4.0f / 3;
            //double liczbaZmiennoprzecinkowaPodwojnejDokladnosci = 4.0 / 3;

            //bool wartoscBoolowska = false;
            //bool isSleep = true;

            //Console.WriteLine($"Moje liczby: ");
            //Console.WriteLine($"{nameof(liczba)} = {liczba}");
            //Console.WriteLine($"{nameof(liczbaZmiennoprzecinkowa)} = {liczbaZmiennoprzecinkowa}");
            //Console.WriteLine($"{nameof(liczbaZmiennoprzecinkowaPodwojnejDokladnosci)} = {liczbaZmiennoprzecinkowaPodwojnejDokladnosci}");
            //Console.WriteLine($"{nameof(wartoscBoolowska)} = {wartoscBoolowska}");


            //// zmienne przechowujące znaki

            char znak = 'c';
            string ciagZnakow = "RAV 4";
            float pojSil = 2.0f;


            Console.WriteLine($"Moje znaki: ");
            Console.WriteLine($"{nameof(znak)} = {znak}");
            Console.WriteLine($"{nameof(ciagZnakow)} = {ciagZnakow}");


            // tablice i kolekcje

            //int[] zbiorLiczb = { 7, 10, 22, 3, 5 };
            //Console.WriteLine(zbiorLiczb[2]);

            char[] tablicaCharow = { 'n', 'i', 'e', 'c', 'h', ' ', 'm', 'o', 'c', ' ', 'b', 'ę', 'd', 'z', 'i', 'e', ' ', 'z', ' ', 't', 'o', 'b', 'ą' };
            //Console.WriteLine(tablicaCharow);

            //List<string> listaZdan = new List<string>();

            //listaZdan.Add(ciagZnakow);

            //Console.WriteLine(listaZdan[1]);  

            //for (int i = 0; i < tablicaCharow.Length; i++) // i++ => i = i + 1; | ++i 
            //{
            //    Console.Write(tablicaCharow[i]);
            //}


            //int i = 0;
            //while (i < tablicaCharow.Length)
            //{
            //    Console.Write(tablicaCharow[i]);
            //    i++;
            //}

            foreach (char cc in tablicaCharow)
            {
                Console.Write(cc);
            }



        }
    }
}
