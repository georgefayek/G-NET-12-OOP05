using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
    class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public double Fee { get; set; }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketNumber}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {Fee} | Price: {Price} | After Tax: {AfterTax()} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new VIPTicket
            {
                MovieName = this.MovieName,
                LoungeAccess = this.LoungeAccess,
                Fee = this.Fee,
                Price = this.Price,
                IsBooked = false
            };
        }
    }
}
