using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP3.Classes
{
    public class TicketContructor
    {
        public String NameOfEvent { get; set; }
        public double Price { get; set; }
        public int AvailableTickets { get; set; }

        // Um constructor facilita a criação de objetos, pois permite que você passe os valores iniciais para a classe.
        // Como pode ser verificado abaixo:
        public TicketContructor(string nameOfEvent, double price, int availableTickets)
        {
            NameOfEvent = nameOfEvent;
            Price = price;
            AvailableTickets = availableTickets;
        }

        public void UpdatePrice(double price)
        {
            Price = price;
        }

        public void UpdateAvailableTickets(int tickets)
        {
            AvailableTickets += tickets;
        }

        public void ShowTicket()
        {
            Console.WriteLine("Show: " + NameOfEvent);
            Console.WriteLine("Preço: " + Price);
            Console.WriteLine("Ingressos disponíveis: " + AvailableTickets);
        }
    }
}
