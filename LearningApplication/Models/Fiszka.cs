using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Models
{
    public class Fiszka
    {
        public string pierwsza_strona { get; set; }//zobaczy jak aplikacja się rozwinie, w razie czego zmieni się klasę object
        public string druga_strona { get; set; }
        /* 
         * Poziomy postępu w nauce będą w skali: 0-3
         * Poziom 0 - Użytkownik nie zna słówka.
         * Poziom 1 - Użytkownik odpowiedział raz dobrze na pytanie dotyczące fiszki
         * Poziom 2 - Użytkownik drugi raz odpowiedział dobrze na pytanie dotyczące fiszki
         * Poziom 3 - Użytkownik odpowiedział 3 razy dobrze na pytanie dotyczące fiszki
         * Za każdym razem kiedy użytkownik źle odpowie na konkretne słówko, poziom znajomości spada o jeden w dół, maks do 0.
        */
        public int poziom_nauczenia { get; set; }
        public Fiszka(string pierwsza_strona, string druga_strona)
        {
            this.pierwsza_strona = pierwsza_strona;
            this.druga_strona = druga_strona;
        }
        public override string ToString()
        {
            return $"1 strona: {pierwsza_strona}, 2 strona: {druga_strona}, poziom: {poziom_nauczenia} ";
        }
    }
}
