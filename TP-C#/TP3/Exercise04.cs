using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_C_.TP3.Classes;

namespace TP_C_.TP3
{
    internal class Exercise04
    {
        public static void Run()
        {
            Ticket ticket = new Ticket();
            ticket.NameOfEvent = "Teatro Clássico";
            ticket.Price = 500;
            ticket.AvailableTickets = 200;

            ticket.UpdatePrice(700);
            ticket.UpdateAvailableTickets(100);
            ticket.ShowTicket();
        }
    }
}
