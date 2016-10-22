using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1

            Console.WriteLine("Mata in ett heltal");
            string inmatat;
            inmatat = Console.ReadLine();
            int mittHeltal = int.Parse(inmatat);
            Console.WriteLine("Mata in ett heltal:");
            inmatat = Console.ReadLine();
            double mittDecimaltal = double.Parse(inmatat);
            Console.WriteLine("summan av talen blir: " + (mittHeltal + mittDecimaltal));
            Console.WriteLine("produkten av talen blir: " + (mittHeltal * mittDecimaltal));
            Console.WriteLine("kvoten av talen blir: " + (mittHeltal / mittDecimaltal));
            Console.ReadLine();

            //Övning 2 

            Console.WriteLine("Mata in ditt förnamn:");
            string fnamn;
            fnamn = Console.ReadLine();
            Console.WriteLine("Mata in ditt efternamn:");
            string enamn;
            enamn = Console.ReadLine();
            Console.WriteLine("Hej " + (fnamn + enamn) + ("!"));

            //Övning 3

            Console.WriteLine("Mata in grader i celsius:");
            string grader;
            grader = Console.ReadLine();
            int degcel = int.Parse(grader);
            Console.WriteLine("Det blir " + (degcel + 1.8 * +32) + (" farenheit"));

            //Övning 4

            Console.Write("Mata in grader i celsius:");
            string grader1;
            grader1 = Console.ReadLine();
            int degcel1 = int.Parse(grader);
            Console.Write("Det blir " + (degcel1 + 1.8 * +32) + (" farenheit"));
            Console.WriteLine();

            //Övning 5

            Console.WriteLine("Cirkelns radie: ");
            string tal = Console.ReadLine();
            int radie = int.Parse(tal);
            double pi = Math.PI;
            Console.WriteLine("Area: " + radie*radie*pi );
            Console.WriteLine("Omkrets: " + radie * pi * 2);
            

        }
    }
}
