using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki.Core
{
    /* ### INFO ###
     * Ta strona będzie poświęcona nauce fiszek.
     * Składowe elementy:
     * - pytanie typu  4 odpowiedzi abcd/uzupełnij lukę 
     * - przycisk, aby przejść dalej
     * - przycisk, aby zakończyć naukę i powrócić do menu głównego
     * - przycisk, aby zakończyć naukę i powrócić do listy zestawów      
     * - przycisk, aby zacząć naukę od nowa 
     * - pasek postępu
     * Przy zakończeniu:
     * - będzie gratulował ukończenia nauki zestawu 
     * - będzie pokazywał procent ukończonej części zestawu (pasek postępu)
     * - - przycisk powrotu do strony głównej
     * - przysik: zacznij naukę zestawu od nowa
     * - przycisk: ustawienia/edytuj zestaw
     */    
    public class LearningSection_PageViewModel
    {
        Zestaw_ViewModel zestaw;
        public LearningSection_PageViewModel(ref Zestaw_ViewModel zestaw)
        {
            this.zestaw = zestaw;
        }
        public void Rozpocznij_Nauke()
        {            
            //mieszamy nasze fiszki z całego zesatwu
            Random random_number = new Random();
            int l = zestaw.lista_fiszek.Count;            
            while (l > 1)
            {
                int k = random_number.Next(l--);
                Fiszka_ViewModel temp = zestaw.lista_fiszek[l];
                zestaw.lista_fiszek[l] = zestaw.lista_fiszek[k];
                zestaw.lista_fiszek[k] = temp;
            }
            bool wszystkie_nauczone = false;
            int i = 0;//indeksator po całym zestawie fiszek
            while (wszystkie_nauczone != true)
            {
                //tworzymy pojedynczy zestaw do nauki w rundzie
                List<Fiszka_ViewModel> runda = new List<Fiszka_ViewModel>();
                int licznik = 0;//indeksator po całym zestawie fiszek z rundy            
                while (licznik < 10)
                {
                    //w przypadku, gdy tablica zostanie cała przeszukana, a program nie znajdzie 10 fiszek do rundy
                    if (i == zestaw.lista_fiszek.Count) break;
                    if (zestaw.lista_fiszek[i].poziom_nauczenia < 3)
                    {
                        runda.Add(zestaw.lista_fiszek[i]);
                        licznik++;
                    }
                    i++;
                }
                //rozpoczynamy rundę
                bool zaliczona_runda = false;
                int numer_rundy = 0;
                while(zaliczona_runda != true)
                {                    
                    zaliczona_runda = true;
                    for (int j = 0; j < runda.Count; j++)
                    {
                        var fiszka = runda[j];
                        if (fiszka.poziom_nauczenia == 0)
                        {
                            Pytanie_0(fiszka, runda);
                            zaliczona_runda = false;
                        }
                        else if (fiszka.poziom_nauczenia == 1)
                        {
                            Pytanie_1(fiszka);
                            zaliczona_runda = false;
                        }
                        else if (fiszka.poziom_nauczenia == 2)
                        {
                            Pytanie_2(fiszka);
                            zaliczona_runda = false;
                        }                        
                    }        
                }
                //podsumowanie rundy
                Console.WriteLine($"Gratuluję, udało ci się ukończyć {numer_rundy+1} rundę!");
                Console.WriteLine("Kliknij dowolny przycisk, aby kontynuować naukę zestawu");
                Console.ReadKey();
                Console.Clear();
                //sprawdzam, czy w zestawie są jeszcze jakieś fiszki nienauczone (poz < 3)            
                wszystkie_nauczone = true;
                foreach (Fiszka_ViewModel f in zestaw.lista_fiszek)
                {
                    if (f.poziom_nauczenia < 3)
                    {
                        wszystkie_nauczone = false;
                        break;
                    }
                }
            }
            Console.WriteLine("Gratuluję, udało Ci się ukończyć naukę całego zestawu!");
        }
        public static void Pytanie_0(Fiszka_ViewModel fiszka, List<Fiszka_ViewModel> runda)
        {
            //mieszamy zestaw do rundy
            Random random_number = new Random();
            int l = runda.Count;
            while (l > 1)
            {
                int k = random_number.Next(l--);
                Fiszka_ViewModel temp = runda[l];
                runda[l] = runda[k];
                runda[k] = temp;
            }            
            //tworzymy odpowiedzi
            int i = 1;
            string[] odpowiedzi = new string[4];
            odpowiedzi[0] = fiszka.druga_strona;
            while (i < runda.Count)
            {
                if (i == 4) break;
                if(runda[i].druga_strona != fiszka.druga_strona)
                {
                    odpowiedzi[i] = runda[i].druga_strona;
                    i++;
                }
            }
            //mieszamy kolejność odpowiedzi
            l = odpowiedzi.Length;
            while (l > 1)
            {
                int k = random_number.Next(l--);
                string temp = odpowiedzi[l];
                odpowiedzi[l] = odpowiedzi[k];
                odpowiedzi[k] = temp;
            }
            //mamy odpowiedzi:
            int litera = 65;
            Console.WriteLine($"{fiszka.pierwsza_strona}:");
            for (int m = 0; m < odpowiedzi.Length; m++)
            {
                Console.WriteLine($"{(char)(litera+m)}. {odpowiedzi[m]}");
            }
            Console.WriteLine("Wpisz poprawną odpowiedź:");
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
            else if (odp != fiszka.druga_strona && fiszka.poziom_nauczenia >= 0)
            {
                Console.WriteLine("-> Źle");
            }
            Console.WriteLine("----------------------------------------");
            return;
        }
        public static void Pytanie_1(Fiszka_ViewModel fiszka)
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
            else if(odp != fiszka.druga_strona && fiszka.poziom_nauczenia >0)
            {
                fiszka.poziom_nauczenia--;
                Console.WriteLine("-> Źle");                   
            }
            else if (odp != fiszka.druga_strona && fiszka.poziom_nauczenia >= 0)
            {                
                Console.WriteLine("-> Źle");
            }
            Console.WriteLine("----------------------------------------");                       
        }
        public static void Pytanie_2(Fiszka_ViewModel fiszka)
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
            else if (odp != fiszka.pierwsza_strona && fiszka.poziom_nauczenia >= 0)
            {
                Console.WriteLine("-> Źle");
            }
            Console.WriteLine("----------------------------------------");            
        }
    }
}
