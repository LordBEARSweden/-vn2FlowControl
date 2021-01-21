using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övn2FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till hvudmenyn!");
            Console.WriteLine("Härifrån kommer du att använda siffror för att navigera vidare och testa olika funktioner ");
            Console.WriteLine("Menyval 0) Avsluta program ");
            Console.WriteLine("Menyval 1) Bio biljetter");
            Console.WriteLine("Menyval 2) Upprepa tio gånger");
            Console.WriteLine("Menyval 3) Det tredje ordet");
            string result = Console.ReadLine();

        }
        static string GetChoise (int ChoiseNum)
        { 
            string ChoiseName;

            switch (ChoiseNum)
            {
                case 0:
                    ChoiseName = "Exit";
                    break;

                case 1:
                    ChoiseName = "bio biljetter";
                    break;

                case 2:
                    ChoiseName = "Upprepa tio gånger";
                    break;

                case 3:
                    ChoiseName = "Det tredje ordet";
                    break;


                default:
                    ChoiseName = "Felaktig input";
                    break;


            }
                return ChoiseName;
        }
    }
}

             /*int num01 = 0;
             while (num01 < 10)
             {
                 Console.WriteLine("loop nr " + num01);
                 num01++;
             }
            */

//Console.WriteLine(GetChoise(0));
