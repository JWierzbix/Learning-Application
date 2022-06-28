using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiszki.Core;
namespace testy
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new Fiszka_ViewModel("hen", "kogut");
            var f2 = new Fiszka_ViewModel("chicken", "kurczak");
            var f3 = new Fiszka_ViewModel("cat", "kot");
            var f4 = new Fiszka_ViewModel("dog", "pies");
            var f5 = new Fiszka_ViewModel("turkey", "indyk");
            var f6 = new Fiszka_ViewModel("cow", "krowa");
            var f7 = new Fiszka_ViewModel("apple", "jabłko");
            var f8 = new Fiszka_ViewModel("red", "czerwony");
            var f9 = new Fiszka_ViewModel("black", "czarny");
            var f10 = new Fiszka_ViewModel("white", "biały");
            var f11 = new Fiszka_ViewModel("car", "samochód");
            var f12 = new Fiszka_ViewModel("eye", "oko");
            var Z = new Zestaw_ViewModel();
            Z.Dodaj_Fiszkę(f1);
            Z.Dodaj_Fiszkę(f2);
            Z.Dodaj_Fiszkę(f3);
            Z.Dodaj_Fiszkę(f4);
            Z.Dodaj_Fiszkę(f5);
            Z.Dodaj_Fiszkę(f6);
            Z.Dodaj_Fiszkę(f7);
            Z.Dodaj_Fiszkę(f8);
            Z.Dodaj_Fiszkę(f9);
            Z.Dodaj_Fiszkę(f10);
            Z.Dodaj_Fiszkę(f11);
            Z.Dodaj_Fiszkę(f12);            
            var L = new LearningSection_PageViewModel(ref Z);
            L.Rozpocznij_Nauke();

            Console.ReadKey();
        }
    }
}
