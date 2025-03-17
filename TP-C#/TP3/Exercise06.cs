using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_C_.TP3.Classes;

namespace TP_C_.TP3
{
    internal class Exercise06
    {
        public static void Run()
        {
            TicketContructor ticket = new TicketContructor("Show", 100.00, 1000);
            ticket.ShowTicket();
        }
    }
}
