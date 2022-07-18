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
        private DateTime data_utworzenia;
        public DateTime Data_Utworzenia { get => data_używania; }
        private DateTime data_używania;
        public DateTime Data_Używania { get => data_używania; }
        private DateTime data_edytowania;
        public DateTime Data_Edytowania { get => data_edytowania; }
        public Zestaw(string nazwa_zestawu, List<Fiszka> lista_fiszek)
        {
            this.nazwa_zestawu = nazwa_zestawu;//ważne aby zestaw przy tworzeniu miał unikalną nazwę
            this.lista_fiszek = lista_fiszek;//może zostać dodana pusta lista fiszek
            data_utworzenia = DateTime.Now;
            data_używania = DateTime.Now;
            data_edytowania = DateTime.Now;
            Pula_Fiszek = new List<Fiszka>();
            Runda = new List<Fiszka>();
            _odpowiedź = "";
            pojęcie = "";
            licznik_rundy = 0;
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
            Pula_Fiszek = new List<Fiszka>();
            Runda = new List<Fiszka>();
        }                    
        public void Zmień_Nazwę(string nowa_nazwa)
        {
            nazwa_zestawu = nowa_nazwa;
            data_edytowania = DateTime.Now;
        }
        public void EdytowanoZestaw()
        {
            data_edytowania = DateTime.Now;
        }

        /* STREFA NAUKI */
        private List<Fiszka> Pula_Fiszek; //zawiera wszystkie fiszki
        private List<Fiszka> Runda; //zawiera max 10 fiszek
        private int licznik_rundy;
        private Fiszka fiszka;//fiszka, którą obecnie się uczysz     
        private string pojęcie;    
        private string _odpowiedź;
        public string Pojęcie => pojęcie;
        public bool UdzielOdpowiedź(string odpowiedź)
        {
            if (_odpowiedź == odpowiedź)//uaktualniamy poziom znajomości fiszki w każdej kolekcji
            {
                foreach(var item in lista_fiszek)
                {
                    if(item.pierwsza_strona==fiszka.pierwsza_strona && item.druga_strona == fiszka.druga_strona)
                    {
                        item.poziom_nauczenia++;
                        break;
                    }
                }
                foreach (var item in Pula_Fiszek)
                {
                    if (item.pierwsza_strona == fiszka.pierwsza_strona && item.druga_strona == fiszka.druga_strona)
                    {
                        item.poziom_nauczenia++;
                        break;
                    }
                }
                foreach (var item in Runda)
                {
                    if (item.pierwsza_strona == fiszka.pierwsza_strona && item.druga_strona == fiszka.druga_strona)
                    {
                        item.poziom_nauczenia--;
                        break;
                    }
                }
                return true;
            }
            else if (fiszka.poziom_nauczenia > 0)
            {
                foreach (var item in lista_fiszek)
                {
                    if (item.pierwsza_strona == fiszka.pierwsza_strona && item.druga_strona == fiszka.druga_strona)
                    {
                        item.poziom_nauczenia--;
                        break;
                    }
                }
                foreach (var item in Pula_Fiszek)
                {
                    if (item.pierwsza_strona == fiszka.pierwsza_strona && item.druga_strona == fiszka.druga_strona)
                    {
                        item.poziom_nauczenia--;
                        break;
                    }
                }
                foreach (var item in Runda)
                {
                    if (item.pierwsza_strona == fiszka.pierwsza_strona && item.druga_strona == fiszka.druga_strona)
                    {
                        item.poziom_nauczenia--;
                        break;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        private int Licznik_Rundy()//generowanie numeru fiszki, która jeszcze nie jest nauczona
        {
            while(Runda[licznik_rundy].poziom_nauczenia == 4)
            {
                licznik_rundy++;
                if (licznik_rundy >= Runda.Count) { licznik_rundy = 0; }                               
            }
            int licznik = licznik_rundy;
            licznik_rundy++;
            if (licznik_rundy >= Runda.Count) { licznik_rundy = 0; }
            return licznik;
        }        
        //OZNACZENIA
        // 0-elementowa tablica znaczy pytanie poziomu 0,1 
        // 4-elementowa tablica znaczy pytanie poziomu 2,3 
        // 2-elementowa tablica znaczy zakończenie rundy
        // 3-elementowa tablica znaczy zakończenie zestawu
        public string[] GenerujEtap()
        {
            //w zestawie muszą się znajdować przynajmniej 4 fiszki, ponieważ odpowiedzi abcd musza być 4
            if (lista_fiszek.Count < 4) throw new Exception("Aby uczyć się zestawu muszą znajdować się w nim więcej niż 4 fiszki");

            UaktualnijPulęFiszek();
            if(Runda.Count == 0) { GenerujRundę(); }

            if (!ZaliczonaRunda()) //jeżeli nie jest zaliczona runda to pobieramy fiszkę z rundy
            {
                fiszka = Runda[Licznik_Rundy()];
                return GenerujPytanie();
            }
            else if(!ZaliczonyZestaw()) //jeżeli jest zaliczona runda ale nie zestaw to generujemy nową rundę 
            {                
                GenerujRundę();
                return new string[2];
            }
            else //jeżeli zaliczona jest runda i zestaw to kończymy naukę zestawu
            {
                return new string[3];
            }            
            }
        private void UaktualnijPulęFiszek()
        {
            //czyścimy pulę fiszek
            Pula_Fiszek = new List<Fiszka>();
            //przenosimy fiszki z ogólnej kolekcji zestawu
            foreach(var item in lista_fiszek)
            {
                Pula_Fiszek.Add(item);
            }
            //mieszamy kolejność fiszek
            Random random = new Random();
            Pula_Fiszek = Pula_Fiszek.OrderBy(x => random.Next()).ToList();
        }        
        private void GenerujRundę() //generując rundę przenosimy fiszki z puli do rundy
        {
            licznik_rundy = 0;
            Runda = new List<Fiszka>();
            int i = 0;
            foreach(var item in Pula_Fiszek)
            {
                if (i == 10) break;
                if(item.poziom_nauczenia < 4)
                {
                    Runda.Add(item);
                    i++;
                }
            }
        }
        private string[] GenerujPytanie()
        {
            Random random = new Random();
            Pula_Fiszek = Pula_Fiszek.OrderBy(x => random.Next()).ToList();
            if (fiszka.poziom_nauczenia == 0)//pierwsza strona
            {
                pojęcie = fiszka.druga_strona;
                _odpowiedź = fiszka.pierwsza_strona;
                string[] odpowiedzi = new string[4];
                odpowiedzi[0] = fiszka.pierwsza_strona;
                int i = 1;
                foreach (var item in Pula_Fiszek)
                {
                    if (i == 4) break;
                    if(fiszka.pierwsza_strona != item.pierwsza_strona && fiszka.druga_strona != item.druga_strona)
                    {
                        odpowiedzi[i] = item.pierwsza_strona;
                        i++;
                    }
                }
                odpowiedzi = odpowiedzi.OrderBy(x => random.Next()).ToArray();
                return odpowiedzi;
            }
            else if (fiszka.poziom_nauczenia == 1)//druga strona
            {
                pojęcie = fiszka.pierwsza_strona;
                _odpowiedź = fiszka.druga_strona;
                string[] odpowiedzi = new string[4];
                odpowiedzi[0] = fiszka.druga_strona;
                int i = 1;
                foreach (var item in Pula_Fiszek)
                {
                    if (i == 4) break;
                    if (fiszka.pierwsza_strona != item.pierwsza_strona && fiszka.druga_strona != item.druga_strona)
                    {
                        odpowiedzi[i] = item.druga_strona;
                        i++;
                    }
                }
                odpowiedzi = odpowiedzi.OrderBy(x => random.Next()).ToArray();
                return odpowiedzi;
            }
            else if (fiszka.poziom_nauczenia == 2)//pierwsza strona
            {
                pojęcie = fiszka.druga_strona;
                _odpowiedź = fiszka.pierwsza_strona;
                return new string[0];
            }
            else//poziom 3, druga strona
            {
                pojęcie = fiszka.pierwsza_strona;
                _odpowiedź = fiszka.druga_strona;
                return new string[0];
            }
        }
        private bool ZaliczonaRunda()
        {
            bool zaliczona = true;
            foreach(var item in Runda)
            {
                if(item.poziom_nauczenia != 4)
                {
                    zaliczona = false;
                    break;
                }
            }
            return zaliczona;
        }
        private bool ZaliczonyZestaw()
        {
            bool zaliczony = true;
            foreach(var item in Pula_Fiszek)
            {
                if(item.poziom_nauczenia < 4)
                {
                    zaliczony = false;
                    break;
                }
            }
            return zaliczony;
        }
    }
}
