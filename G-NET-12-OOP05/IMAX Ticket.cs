using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
    class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketNumber}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {AfterTax()} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override object Clone()
        {
            return new IMAXTicket
            {
                MovieName = this.MovieName,
                Is3D = this.Is3D,
                Price = this.Price,
                IsBooked = this.IsBooked
            };
        }
    }
}
