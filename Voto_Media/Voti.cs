using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voto_Media
{
    class Voti
    {
        static void Main(string[] args)
        {
            int Voto = 1, Voto_Finale, Voto_temp = 0, max = 0, min = 0, cicli = 0;
            string language;
            bool insert_error = false, error = false, language_bool = false;

            do
            {
                if (language_bool)
                {
                    Console.WriteLine("You haven't inserted a valid number try 'Italian' or 'English'");
                }
                Console.Write("What language would you let the app to run (Italian and English 'work') ");
                language = Console.ReadLine().ToLower();
            } while (language_bool = !(language == "it" || language == "italian" || language == "english" || language == "en"));

            switch (language)
            {
                case "it":
                case "italian":
                    do
                    {
                        Console.Write("Inserire il voto ");
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
                    break;
                case "en":
                case "english":
                    do
                    {
                        Console.Write("Insert you're grade ");
                        do
                        {
                            if (insert_error)
                            {
                                Console.WriteLine("The inserted grade isn't a grade or isn't valid retry");
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
                            Console.WriteLine($"You inserted {cicli} numbers");
                            Console.Write($"The average is {Voto_Finale} ");
                            if (Voto_Finale < 6)
                            {
                                Console.WriteLine("You are insufficient >:/");
                            }
                            if (Voto_Finale >= 6 && Voto_Finale < 8)
                            {
                                Console.WriteLine("You're sufficent :D");
                            }
                            if (Voto_Finale >= 8)
                            {
                                Console.WriteLine("You are very sufficient :O ");
                            }
                            Console.WriteLine($"{min} this how are many insufficent numbers you got \nWhile this {max} are how many sufficent grades you got");
                        }
                        cicli++;
                    } while (!(Voto == 0));
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
