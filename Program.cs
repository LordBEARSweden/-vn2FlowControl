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
            //Console.WriteLine(GetChoise(0));

            static string GetChoise (int ChoiseNum)
            {
                string ChoiseName;

                switch (ChoiseNum)
                {
                    case 0:
                        ChoiseName = "Exit";
                        break;
                  
                    default:
                        ChoiseName = "Felaktig input";
                        break;

                }
                return ChoiseName;
            }

            
            Console.ReadLine();
        }
    }
}