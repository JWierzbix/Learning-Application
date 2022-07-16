using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Models
{
    public class Zestaw
    {
        public string nazwa_zestawu { get; set; }
        public List<Fiszka> lista_fiszek;
        public DateTime data_utworzenia;
        public DateTime data_używania;
        public DateTime data_edytowania;
        public Zestaw(string nazwa_zestawu, List<Fiszka> lista_fiszek)
        {
            this.nazwa_zestawu = nazwa_zestawu;//ważne aby zestaw przy tworzeniu miał unikalną nazwę
            this.lista_fiszek = lista_fiszek;//może zostać dodana pusta lista fiszek
            data_utworzenia = DateTime.Now;
            data_używania = DateTime.Now;
            data_edytowania = DateTime.Now;
        }
        public int Poziom_Ukończenia()//zwracany w procentach 
        {
            int licznik = 0;
            foreach (Fiszka f in lista_fiszek)
            {
                if (f.poziom_nauczenia == 3) licznik++;
            }
            double procent = (double)licznik / lista_fiszek.Count;
            return (int)(procent * 100);
        }

        /* STREFA TWORZENIA/EDYTOWANIA */
        public void WyczyśćPostępy()//poziom każdej wiszki ustawiany jest na 0
        {
            foreach (Fiszka f in lista_fiszek)
            {
                f.poziom_nauczenia = 0;
            }
        }
        public void Dodaj_Fiszkę(Fiszka fiszka) 
        {
            lista_fiszek.Add(fiszka);
            data_edytowania = DateTime.Now;
        }
        public void Usuń_Fiszkę(string pierwsza_strona, string druga_strona)
        {
            int i = 0;
            for (i = 0; i < lista_fiszek.Count; i++)
            {
                if(lista_fiszek[i].pierwsza_strona==pierwsza_strona && lista_fiszek[i].druga_strona == druga_strona)
                {
                    lista_fiszek.RemoveAt(i);
                    break;
                }
            }            
            data_edytowania = DateTime.Now;
        }
        public void Edytuj_Fiszkę(int indeks, string pierwsza_strona, string druga_strona)
        {
            lista_fiszek[indeks].pierwsza_strona = pierwsza_strona;
            lista_fiszek[indeks].druga_strona = druga_strona;
            data_edytowania = DateTime.Now;
        }
        public void Zmień_Nazwę(string nowa_nazwa)
        {
            nazwa_zestawu = nowa_nazwa;
            data_edytowania = DateTime.Now;
        }

        /* STREFA NAUKI */
        public void Rozpocznij_Nauke()
        {
            if (lista_fiszek.Count < 4) return; //naukę zestawu możemy rozpocząć, jeżeli jest w nim więcej niż 4 fiszki
            //mieszamy nasze fiszki z całego zesatwu
            
            data_używania = DateTime.Now; //uaktualniamy datę używania

            Random random_number = new Random();
            int l = lista_fiszek.Count;
            while (l > 1)
            {
                int k = random_number.Next(l--);
                Fiszka temp = lista_fiszek[l];
                lista_fiszek[l] = lista_fiszek[k];
                lista_fiszek[k] = temp;
            }
            bool wszystkie_nauczone = false;
            int i = 0;//indeksator po całym zestawie fiszek
            while (wszystkie_nauczone != true)
            {
                //tworzymy pojedynczy zestaw do nauki w rundzie
                List<Fiszka> runda = new List<Fiszka>();
                int licznik = 0;//indeksator po całym zestawie fiszek z rundy            
                while (licznik < 10)
                {
                    //w przypadku, gdy tablica zostanie cała przeszukana, a program nie znajdzie 10 fiszek do rundy
                    if (i == lista_fiszek.Count) break;
                    if (lista_fiszek[i].poziom_nauczenia < 4)
                    {
                        runda.Add(lista_fiszek[i]);
                        licznik++;
                    }
                    i++;
                }
                //rozpoczynamy rundę
                bool zaliczona_runda = false;
                int numer_rundy = 0;
                while (zaliczona_runda != true)
                {
                    zaliczona_runda = true;
                    for (int j = 0; j < runda.Count; j++)
                    {
                        var fiszka = runda[j];
                        if (fiszka.poziom_nauczenia == 0)
                        {
                            Pytanie_0(fiszka, lista_fiszek);
                            zaliczona_runda = false;
                        }
                        else if (fiszka.poziom_nauczenia == 1)
                        {
                            Pytanie_1(fiszka, lista_fiszek);
                            zaliczona_runda = false;
                        }
                        else if (fiszka.poziom_nauczenia == 2)
                        {
                            Pytanie_2(fiszka);
                            zaliczona_runda = false;
                        }
                        else if (fiszka.poziom_nauczenia == 3)
                        {
                            Pytanie_3(fiszka);
                        }
                    }
                }
                //podsumowanie rundy
                Console.WriteLine($"Gratuluję, udało ci się ukończyć {numer_rundy + 1} rundę!");
                Console.WriteLine("Kliknij dowolny przycisk, aby kontynuować naukę zestawu");
                Console.ReadKey();
                Console.Clear();
                //sprawdzam, czy w zestawie są jeszcze jakieś fiszki nienauczone (poz < 3)            
                wszystkie_nauczone = true;
                foreach (Fiszka f in lista_fiszek)
                {
                    if (f.poziom_nauczenia < 4)
                    {
                        wszystkie_nauczone = false;
                        break;
                    }
                }
            }
            Console.WriteLine("Gratuluję, udało Ci się ukończyć naukę całego zestawu!");
        }
        public static void Pytanie_0(Fiszka fiszka, List<Fiszka> lista_fiszek)
        {
            Random random = new Random();
            lista_fiszek = lista_fiszek.OrderBy(x => random.Next()).ToList();
            string[] odpowiedzi = new string[4];
            odpowiedzi[0] = fiszka.druga_strona;
            int licznik = 1; //indeksator po tablicy odpowiedzi
            for (int i = 0; i < lista_fiszek.Count; i++)
            {
                if (licznik == 4) break;
                if (lista_fiszek[i].druga_strona != fiszka.druga_strona)
                {
                    odpowiedzi[licznik] = lista_fiszek[i].druga_strona;
                    licznik++;
                }
            }
            odpowiedzi = odpowiedzi.OrderBy(x => random.Next()).ToArray();
            int liczba = 65;
            Console.WriteLine($"{fiszka.pierwsza_strona}:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{(char)(liczba + i)}. {odpowiedzi[i]}");
            }
            string odp = Console.ReadLine();
            if (odp == fiszka.druga_strona)
            {
                fiszka.poziom_nauczenia++;
                Console.WriteLine("-> Dobrze");
            }
            else
            {
                Console.WriteLine("-> Źle");
            }
            Console.WriteLine("----------------------------------------");
        }
        public static void Pytanie_1(Fiszka fiszka, List<Fiszka> lista_fiszek)
        {
            Random random = new Random();
            lista_fiszek = lista_fiszek.OrderBy(x => random.Next()).ToList();
            string[] odpowiedzi = new string[4];
            odpowiedzi[0] = fiszka.pierwsza_strona;
            int licznik = 1; //indeksator po tablicy odpowiedzi
            for (int i = 0; i < lista_fiszek.Count; i++)
            {
                if (licznik == 4) break;
                if (lista_fiszek[i].pierwsza_strona != fiszka.pierwsza_strona)
                {
                    odpowiedzi[licznik] = lista_fiszek[i].pierwsza_strona;
                    licznik++;
                }
            }
            odpowiedzi = odpowiedzi.OrderBy(x => random.Next()).ToArray();
            int liczba = 65;
            Console.WriteLine($"{fiszka.druga_strona}:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{(char)(liczba + i)}. {odpowiedzi[i]}");
            }
            string odp = Console.ReadLine();
            if (odp == fiszka.pierwsza_strona)
            {
                fiszka.poziom_nauczenia++;
                Console.WriteLine("-> Dobrze");
            }
            else if (odp != fiszka.pierwsza_strona && fiszka.poziom_nauczenia > 0)
            {//zmniejszamy poziom bo jesteśmy na 1 poziomie (czyli >0)
                fiszka.poziom_nauczenia--;
                Console.WriteLine("-> Źle");
            }
            else if (odp != fiszka.pierwsza_strona && fiszka.poziom_nauczenia == 0)
            {
                Console.WriteLine("-> Źle");
            }
            Console.WriteLine("----------------------------------------");
        }
        public static void Pytanie_2(Fiszka fiszka)
        {
            Console.WriteLine($"{fiszka.pierwsza_strona}:");
            string odp = Console.ReadLine();
            //jeżeli dobrze odpowie na pytanie to fiszka wskakuje na poziom wyżej
            if (odp == fiszka.druga_strona)
            {
                fiszka.poziom_nauczenia++;
                Console.WriteLine("-> Dobrze");
            }
            //jeżeli źle poziom spada o jeden poziom niżej
            else if (odp != fiszka.druga_strona && fiszka.poziom_nauczenia > 0)
            {
                fiszka.poziom_nauczenia--;
                Console.WriteLine("-> Źle");
            }
            else if (odp != fiszka.druga_strona && fiszka.poziom_nauczenia == 0)
            {
                Console.WriteLine("-> Źle");
            }
            Console.WriteLine("----------------------------------------");
        }
        public static void Pytanie_3(Fiszka fiszka)
        {
            Console.WriteLine($"{fiszka.druga_strona}:");
            string odp = Console.ReadLine();
            //jeżeli dobrze odpowie na pytanie to fiszka wskakuje na poziom wyżej
            if (odp == fiszka.pierwsza_strona)
            {
                fiszka.poziom_nauczenia++;
                Console.WriteLine("-> Dobrze");
            }
            //jeżeli źle poziom spada o jeden poziom niżej
            else if (odp != fiszka.pierwsza_strona && fiszka.poziom_nauczenia > 0)
            {
                fiszka.poziom_nauczenia--;
                Console.WriteLine("-> Źle");
            }
            else if (odp != fiszka.pierwsza_strona && fiszka.poziom_nauczenia == 0)
            {
                Console.WriteLine("-> Źle");
            }
            Console.WriteLine("----------------------------------------");
        }        
    }
}
