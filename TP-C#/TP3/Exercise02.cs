﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_C_.TP3.Classes;

namespace TP_C_.TP3
{
    internal class Exercise02
    {
        public static void Run()
        {
            Ticket ticket = new Ticket();
            ticket.NameOfEvent = "Show";
            ticket.Price = 100;
            ticket.AvailableTickets = 1000;
            ticket.ShowTicket();
        }
    }
}
