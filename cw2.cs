﻿using System;
namespace Akcesory
{
    class Hours
    {
        private int hour; // ta zmienna posiada właściwość
        private int second;
        private string Przyrostek;

        public int Hour // Definicja właściwość
        {
            get
            { return hour ; }
            set
            {
                if (value >= 0 && value <= 12)
                { hour = value; second = value * 3600; Przyrostek ="am" ; }

                if (value >= 13 && value <= 24)
                { hour = value; second = value * 3600; Przyrostek = "pm"; }
            }

          
        }
        public override string ToString()
        { return "Godzina " + hour + " " + Przyrostek+ "; " + second + " sekunda tej doby." ; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hours godz = new Hours();
           
          godz.Hour = 3; //dostęp do zmiennej prywatnej poprzez właściwość
                           //przypisanie możliwe dzięki sekcji set we własności Hour
            Console.WriteLine(godz);
            //sekcja set nie tylko umożliwia bezpośredni dostęp do zmiennej
            //prywatnej hour, ale sprawuje kontrolę nad jej zakresem i
            //pozwala ustalić wartości innych zmiennych prywatnych
            Console.ReadKey();
        }
    }
}
