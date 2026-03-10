using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP05
{
    abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private static int counter = 1;

        public int TicketNumber { get; set; }
        public string MovieName { get; set; }
        public double Price { get; set; }
        public bool IsBooked { get; set; }

        public Ticket()
        {
            TicketNumber = counter++;
        }

        public double AfterTax()
        {
            return Price * 1.14;
        }

        public bool Book()
        {
            if (IsBooked)
                return false;

            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
                return false;

            IsBooked = false;
            return true;
        }

        public abstract void Print();

        public abstract object Clone();
    }
}
