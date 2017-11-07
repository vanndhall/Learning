using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaMnożenia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, wiersz, kolumna;
            Console.WriteLine("Program wyświetla tabliczkę mnożenia dla liczb od 1 do 100.");
            Console.WriteLine();
            wiersz = 1; //wartosć początkowa

            do
            {
                kolumna = 1;  //wartość początkowa 
                do
                {
                    Console.Write(wiersz * kolumna + "\t)");
                    kolumna++;
                }
                while (kolumna <= n);

                wiersz++;
                Console.WriteLine();
            }
            while (wiersz <= n);

            Console.Read();
        }
    }
}
