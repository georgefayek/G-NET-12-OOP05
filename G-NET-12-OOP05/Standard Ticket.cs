using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
    class StandardTicket : Ticket
    {
        public string Seat { get; set; }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketNumber}] {MovieName} | Standard | Seat: {Seat} | Price: {Price} | After Tax: {AfterTax()} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new StandardTicket
            {
                MovieName = this.MovieName,
                Seat = this.Seat,
                Price = this.Price,
                IsBooked = this.IsBooked
            };
        }
    }
}
