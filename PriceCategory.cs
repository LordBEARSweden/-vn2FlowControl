using System;
using System.Collections.Generic;
using System.Text;
//En priskategoriklass med get set av statiska priser då dessa används i fler än ett moment i preogrammet.
namespace Övn2FlowControl
{
    public class PriceCategory
    {
        public static int Senior { get; set; } = 90;
        public static int Junior { get; set; } = 80;
        public static int Adult { get; set; } = 120;
    }



    //Exempel av Dimitris som jag sparat för jämförelse
   /* public enum PriceCategory2
    {
        Senior = 90,
        Junior = 80,
        Adult = 120

    }*/
}
   