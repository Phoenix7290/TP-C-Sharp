using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_C_.TP3.Classes;

namespace TP_C_.TP3
{
    internal class Exercise05
    {
        public static void Run()
        {
            Ticket ticket = new Ticket();
            ticket.SetShowName("The Phantom of the Opera");
            ticket.SetPrice(100);
            ticket.SetAvaliableTickets(1000);

            ticket.ShowTicketGetSet();
        }
    }
}
