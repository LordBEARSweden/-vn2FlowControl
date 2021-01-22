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
            int num = 0;
            do 
            {

                Console.WriteLine("Welcome to the main menu!");
                Console.WriteLine("From here you will use numbers to navigate further and test different functions ");
                Console.WriteLine("Option 0) Exit program ");
                Console.WriteLine("Option 1) Cinema tickets 1 person");
                Console.WriteLine("Option 2) Cinema tickets more than one person");
                Console.WriteLine("Option 3) Repeat ten times");
                Console.WriteLine("Option 4) The third word");

                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("You will now exit the program");

                        break;

                    case "1":
                        Console.WriteLine("Welcome to the Cinema!");
                        Console.WriteLine("How old are you?");
                        string Ticket = Console.ReadLine();
                        int ticket = Int32.Parse(Ticket);
                        if (ticket >= 60)
                        {
                            Console.WriteLine("You will pay senior price of 90 kr");
                        }
                        else if (ticket <= 20)
                        {
                            Console.WriteLine("You will pay junior price of 80 kr");
                        }
                        else
                        {
                            Console.WriteLine("You will pay adult price of 120 kr");
                        }
                        break;

                      case "2":
                        Console.WriteLine("Welcome to the Cinema!");
                        Console.WriteLine("How many tickets do you want?");
                        string ticketNum = Console.ReadLine();
                        int TicketNum = Int32.Parse(ticketNum);
                        
                        for (int x  = 0; x < TicketNum; x++)
                        {
                            Console.WriteLine("How old is the person");
                            Console.ReadLine();
                            if (TicketNum >= 60)
                            {
                                Console.WriteLine("You will pay senior price of 90 kr for this person");
                            }
                            else if (TicketNum <= 20)
                            {
                                Console.WriteLine("You will pay junior price of 80 kr for this person");
                            }
                            else
                            {
                                Console.WriteLine("You will pay adult price of 120 kr for this person");
                            }
                         
                        }

                        break;
                        

                           
                    case "3":
                        break;
                }

            } while (num != 0);
        }
    }
}


