using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voto_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            int Voto = 1, Voto_Finale, Voto_temp = 0, max = 0, min = 0, cicli = 0;
            bool insert_error = false;
            Console.WriteLine("Questo programma calcola la media");

            do
            {
                Console.Write("Inserire il primo voto ");
                do
                {
                    if (insert_error)
                    {
                        Console.WriteLine("Il numero inserito non è valido riprova");
                    }
                    Voto_temp = Voto_temp + Voto;
                } while (insert_error = !int.TryParse(Console.ReadLine(), out Voto));

                if (Voto >= 6)
                {
                    max++;
                }
                if (Voto < 6 && Voto > 0)
                {
                    min++;
                }

                if (Voto == 0)
                {
                    Voto_Finale = Voto_temp / cicli;
                    Console.WriteLine($"Hai Inserito {cicli} numeri");
                    Console.Write($"Il voto che hai preso è {Voto_Finale} ");
                    if (Voto_Finale < 6)
                    {
                        Console.WriteLine("sei insufficente >:/");
                    }
                    if (Voto_Finale >= 6 && Voto_Finale < 8)
                    {
                        Console.WriteLine("sei sufficente :D");
                    }
                    if (Voto_Finale >= 8)
                    {
                        Console.WriteLine("sei molto sufficente :O ");
                    }
                    Console.WriteLine($"{min} sono quanti voti insufficenti hai preso \nMentre {max} sono quanti voti sufficenti hai preso");
                }
                cicli++;
            } while (!(Voto == 0));
            Console.ReadKey();
        }
    }
}
