using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
     class Cinema
    {
        List<Ticket> tickets = new List<Ticket>();

        public void Open()
        {
            Console.WriteLine("=== Cinema Opened ===");
        }

        public void Close()
        {
            Console.WriteLine("\n=== Cinema Closed ===");
        }

        public void AddTicket(Ticket t)
        {
            tickets.Add(t);
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("\n--- All Tickets ---");

            foreach (var t in tickets)
                t.Print();
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
        }
    }
}
