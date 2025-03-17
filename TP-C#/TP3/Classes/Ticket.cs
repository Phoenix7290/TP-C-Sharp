using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_C_.TP3.Classes
{
    internal class Ticket
    {
        // Cada atributo abaixo define o Ticket. Pois, um ticket precisa de nome, preço e quantidade de ingressos disponíveis.
        public String NameOfEvent { get; set; }
        public double Price { get; set; }
        public int AvailableTickets { get; set; }

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

        // Get e Set são úteis para acessar e modificar atributos privados de uma classe.
        // Especialmente útil para garantir a segurança dos dados.

        private String nameOfEventToGet;
        public string GetNomeDoShow()
        {
            return nameOfEventToGet;
        }

        private double priceToGet;

        public double GetPreco()
        {
            return priceToGet;
        }

        private int availableTicketsToGet;
        public int GetQuantidadeDisponivel()
        {
            return availableTicketsToGet;
        }

        public void SetShowName(string newName)
        {
            nameOfEventToGet = newName;
        }

        public void SetPrice(double newPrice)
        {
            priceToGet = newPrice;
        }

        public void SetAvaliableTickets(int newQtd)
        {
            availableTicketsToGet = newQtd;
        }

        public void ShowTicketGetSet()
        {
            Console.WriteLine("Show: " + GetNomeDoShow());
            Console.WriteLine("Preço: " + GetPreco());
            Console.WriteLine("Ingressos disponíveis: " + GetQuantidadeDisponivel());
        }
    }
}
