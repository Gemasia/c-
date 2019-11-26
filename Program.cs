using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Losowaczka___zgadnij_liczbe
{
    class Program
    {
        static void Main(string[] args)
        {
            Game losowaczka = new Game();
            losowaczka.AddNumber();



            Console.ReadKey();
            
        }
    }
    class Game
    {
        private int max;
        private int min;
        public int number;
        public int drawn;
        private int count;

        Random drawing = new Random();
        
        
        
        public void AddNumber()
        {
            string userInput;

            do
            {
                Console.WriteLine("Podaj liczbę z zakresu 1-50, następnie komputer spróbuje ją odgadnąć.");
                userInput = Console.ReadLine();
            } while (!(int.TryParse(userInput, out number)));

            if (number>=1 && number<=50)
            {
                Guesser();
            }
            else
            {
                Console.WriteLine("Podana przez Ciebie liczba nie znajduje się w obowiązującym zakresie. Spróbuj jeszcze raz.");
                Console.ReadKey();
                Console.Clear();
                AddNumber();
            }
        }

        

        private void Guesser()
        {
            min = 1;
            max = 50;

            while (!(drawn == number))
            {
                int drawn = drawing.Next(min+1,max-1);
                count++;
                Console.WriteLine("Moja propozycja to {0}", drawn);
                
                if (drawn == number)
                {
                    Console.WriteLine("Odgadłem Twoją liczbę za {0} powtórzeniem! Wybrana przez Ciebie liczba to {1}.", count, drawn);
                }
                else
                {
                    Console.WriteLine("Naciśnij dowolnu klawisz, aby rozpocząć kolejne losowanie.");
                    Console.ReadKey();
                    Guesser();
                }
            }
        }
        private void SizeOfNumber(int drawn)
        {
            drawn = this.drawn;

        }

    }
}
