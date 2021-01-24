using System;


namespace Övn2FlowControl
{
    class Program
    {


        static void Main(string[] args)
        {
            //While-loop med bool för att styra main menyn, Detta så att programmet forsätter att rulla även om ett en del
            //är avslutad.
            bool displayMenu = true;
            
            while (displayMenu) 
            {
                

                MainMeny();
                //switch för menyn med cases till de olika submenyerna.
                switch (Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("You will now exit the program");
                        displayMenu = false;
                        //även om detta kanske inte är nödvändingt så ville jag ändå skriva att prorammet kommer att avslutas.
                        break;

                    case "1":
                        //case 1 bio för 1 person där jag lagt till ålder för att avgöra priset på en biljett.
                        //även kopplat till en klass innehhållande prislista. Console.Clear för att städa upp konsollen.
                        Console.Clear();
                        Console.WriteLine("Welcome to the Cinema!");
                        Console.WriteLine("How old are you?");
                        string Ticket = Console.ReadLine();
                        int ticket;
                        bool ok = int.TryParse(Ticket, out ticket); 
                        int price = GetPriceForPerson(ticket);       
                        Console.WriteLine(price);
                        break;

                    case "2":
                        //case 2 bio biljetter till flera personer, med samma grundfunktion som case 1,
                        //men här räknas även antalet personer och totalpriset för samtliga biljetter räknas ut.
                        Console.Clear();
                        Console.WriteLine("Welcome to the Cinema!");
                        Console.WriteLine("How many tickets do you want?");
                        string ticketNum = Console.ReadLine();
                        int TicketNum = Int32.Parse(ticketNum);
                        int sum = 0;                            //Kanske inte det mest effektiva sättet, men jag ville
                        for (int x = 0; x < TicketNum; x++)     //ge mig själv en en liten utmaning och se om jag kunde få
                        {                                       //igång en for loop
                            Console.WriteLine("How old is the person");

                            string Age = Console.ReadLine();
                            int age = Int32.Parse(Age);

                            int price2 = GetPriceForPerson(age);
                            sum += price2;


                            if (age >= 60)
                            {
                            }
                            else if (age <= 20)
                            {
                            }
                            else
                            {
                            }
                            Console.WriteLine(sum);
                        }
                        break;



                    case "3":
                        //Detta var en liten nötknäckare då jag först tänke mycket mer avancerat än det behövde vara.
                        //Deklarerat texten som läses in i consolen och loopar det tio gånger med for loop.
                        //ändrade om från Console.WriteLine till Console.Write för att få allt på samma rad.
                        Console.Clear();
                        Console.WriteLine("Type a word or text and have it repeated ten times");
                        Console.WriteLine("What do you want to be repeated? ");
                        string text = Console.ReadLine();
                       
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write(text);
                        }
                        break;

                    case "4":
                        //med hjälp av var och arrays så gick det att lösa tredje ordet med hjälp av split och räkna white space
                        // Dock så försökte jag utöka till 6,9,12 orden också, men kom inte riktigt så långt.
                        //skulle gärna vilja ha lite tips om detta.
                        Console.Clear();
                        Console.WriteLine("Type a sentence and this will pick out the third word");
                        Console.WriteLine("Write a sentence or more");
                        var sentence = Console.ReadLine();
                        sentence.Split();
                        string[] wordArray = sentence.Split(" ");
                        
                        Console.WriteLine(wordArray[2]);
                        break;
                }
            }
            
        }

        private static int GetPriceForPerson(int ticket)
        {
            //if och else if för att säkra biobiljetterna till rätt av de tre ålderskategorierna, priserna är kopplade till kalassen.
            int price = 0;
            if (ticket >= 60)
            {
                price = PriceCategory.Senior;
                Console.WriteLine($"You will pay senior price of {PriceCategory.Senior} kr");
            }
            else if (ticket <= 20)
            {
                price = PriceCategory.Junior;
                Console.WriteLine($"You will pay junior price of {PriceCategory.Junior} kr");
            }
            else
            {
                price = PriceCategory.Adult;
                Console.WriteLine($"You will pay adult price of {PriceCategory.Adult} kr");
            }
            return price;
        }
        // välkommst meny med sifferval för att komma vidare.
        private static void MainMeny()
        {
            
            Console.WriteLine("Welcome to the main menu!");
            Console.WriteLine("From here you will use numbers to navigate further and test different functions ");
            Console.WriteLine("Option 0) Exit program ");
            Console.WriteLine("Option 1) Cinema tickets 1 person");
            Console.WriteLine("Option 2) Cinema tickets more than one person");
            Console.WriteLine("Option 3) Repeat ten times");
            Console.WriteLine("Option 4) The third word");
        }
    }
}



