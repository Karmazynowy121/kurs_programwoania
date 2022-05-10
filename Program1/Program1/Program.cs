using System;
using System.Collections.Generic;
using System.Drawing;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Zajęcia pierwsze 
            ////// zmienne liczbowe w rogramowaniu 
            ////int liczba = 4 / 3;
            ////float liczbaZmiennoprzecinkowa = 4.0f / 3;
            ////double liczbaZmiennoprzecinkowaPodwojnejDokladnosci = 4.0 / 3;

            ////bool wartoscBoolowska = false;
            ////bool isSleep = true;

            ////Console.WriteLine($"Moje liczby: ");
            ////Console.WriteLine($"{nameof(liczba)} = {liczba}");
            ////Console.WriteLine($"{nameof(liczbaZmiennoprzecinkowa)} = {liczbaZmiennoprzecinkowa}");
            ////Console.WriteLine($"{nameof(liczbaZmiennoprzecinkowaPodwojnejDokladnosci)} = {liczbaZmiennoprzecinkowaPodwojnejDokladnosci}");
            ////Console.WriteLine($"{nameof(wartoscBoolowska)} = {wartoscBoolowska}");


            ////// zmienne przechowujące znaki

            //char znak = 'c';
            //string ciagZnakow = "RAV 4";
            //float pojSil = 2.0f;


            //Console.WriteLine($"Moje znaki: ");
            //Console.WriteLine($"{nameof(znak)} = {znak}");
            //Console.WriteLine($"{nameof(ciagZnakow)} = {ciagZnakow}");


            //// tablice i kolekcje

            ////int[] zbiorLiczb = { 7, 10, 22, 3, 5 };
            ////Console.WriteLine(zbiorLiczb[2]);

            //char[] tablicaCharow = { 'n', 'i', 'e', 'c', 'h', ' ', 'm', 'o', 'c', ' ', 'b', 'ę', 'd', 'z', 'i', 'e', ' ', 'z', ' ', 't', 'o', 'b', 'ą' };
            ////Console.WriteLine(tablicaCharow);

            ////List<string> listaZdan = new List<string>();

            ////listaZdan.Add(ciagZnakow);

            ////Console.WriteLine(listaZdan[1]);  

            ////for (int i = 0; i < tablicaCharow.Length; i++) // i++ => i = i + 1; | ++i 
            ////{
            ////    Console.Write(tablicaCharow[i]);
            ////}


            ////int i = 0;
            ////while (i < tablicaCharow.Length)
            ////{
            ////    Console.Write(tablicaCharow[i]);
            ////    i++;
            ////}




            //// ai = a1 + (i - 1) × d

            //int n = 20;
            //double a1 = 0.0;
            //double score;
            //double d = 10;

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i == 1)
            //    {
            //        a1 =  (i - 1) * d;
            //    }

            //    score = a1 + (i - 1) * d;
            //    Console.WriteLine(score);
            //}

            #endregion

            // funkcje 

            //if (args.Length > 0)
            //{
            //    foreach (string arg in args)
            //    {
            //        Console.WriteLine(arg);
            //    }
            //}

            //ObliczCiag();

            Pingwin pingwinAdolf = new Pingwin();
            Pingwin pingiwnJaroslaw = new Pingwin("",4, 0, 2);

            pingiwnJaroslaw.ShowMeWhatYouGot();
            pingwinAdolf.ShowMeWhatYouGot();

            pingiwnJaroslaw.Dance();
            pingwinAdolf.Dance();

            

        }

        static void ObliczCiag()
        {
            int n = 20;
            double a1 = 0.0;
            double score;
            double d = 10;

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    a1 = (i - 1) * d;
                }

                score = LiczElementCiagu(a1, i, d);
                Console.WriteLine(score);
            }

        }

        static double LiczElementCiagu(double a1, int index, double d)
        {
            return a1 + (index - 1) * d;
        } 

    }



    public class User
    {

    }

    public class Post
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public User Admin { get; set; }

    }




    public class Zwierze
    {
        public string Imie { get; set; }

    }

    public class Pingwin : Zwierze
    {
        public int IloscNog { get; set; }
        public int IloscSkrzydel { get; set; }
        public int LiczbaWansow { get; }
        public int Age { get; set; }

        private bool isChild;

        public Pingwin()
        {
            Imie = SetName("Adolf");
            IloscNog = 2;
            IloscSkrzydel = 3;
            LiczbaWansow = 1;
            Age = 6;

            CheckIfIsChild();
        }

        public Pingwin(string name, int legs, int wings, int mustache)
        {
            Imie = SetName(name);
            IloscNog = legs;    
            IloscSkrzydel = wings;
            LiczbaWansow = mustache;
            Age = 4;
            
            CheckIfIsChild();
        }

        public void ShowMeWhatYouGot()
        {
            Console.WriteLine(Imie);
            Console.WriteLine(IloscNog);
            Console.WriteLine(IloscSkrzydel);
            Console.WriteLine(LiczbaWansow);
        }

        public void Dance()
        {
            string onlyChildSay = "";
            
            if (isChild)
            {
                onlyChildSay = "Pislkiwym głosem podśpiewując";
            }

            Console.WriteLine($"Pingwin {Imie} tańczy! Łubu dunbu jebać fubu! {onlyChildSay}");
        }

        private string SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Jan";
            }

            return name;
        }

        private void CheckIfIsChild()
        {
            if (Age < 6)
            {
                isChild = true;
            }
            else
            {
                isChild = false;
            }
        }

    }
}
