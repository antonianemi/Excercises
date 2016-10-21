using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    class Program
    {

        static Excersice obj;

        static void Main(string[] args)
        {

            obj = new Excersice();

            for (int i=0; i<6; i++)
            {

                Console.WriteLine(obj.GetNextQuestion(i));

                string answer=Console.ReadLine();

                if (answer == "1"){break;}

                if (answer == "2") { Hold(i); }
                else
                { 
                obj.SetAnswer(answer);

                if (!obj.IsCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("BAD!!!");
                }
                }
            }
            Console.WriteLine("THE END!!!");
        }

        static void Hold(int position)
        {
            while (true)
            { 
            Console.WriteLine(obj.GetNextQuestion(position));
            string answer = Console.ReadLine();
            if(answer == "3") { break; }
            obj.SetAnswer(answer);
            if (!obj.IsCorrect)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("BAD!!!");
            }
            }
        }





    }
}
