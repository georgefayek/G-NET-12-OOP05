using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_12_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 01 : Theoretical Questions

            // Q1: What is an interface in C#? 

            //    An interface in C# defines a contract that a class must follow.
            //    It specifies what a class can do, not how it does it.

            //    Any class that implements an interface must implement all the methods defined in that interface.

            //    Example from the lecture:

            //    interface IShape
            //{
            //    void Draw();
            //}

            //Why Interfaces Exist

            //Interfaces are used to:

            //1️⃣ Enable Polymorphism without Inheritance

            //Different classes can implement the same interface and provide different behaviors.

            //Example:
            //    public interface ILogger
            //{
            //    void Log(string message);
            //}

            //Implementation:

            //    public class FileLogger : ILogger
            //{
            //    public void Log(string message)
            //    {
            //        Console.WriteLine($"File: {message}");
            //    }
            //}

            //Q2 : Look at the following code and answer the questions below ?

            //    a) What is the problem in the current design?

            //    The class Translator implements two interfaces:

            //    IEnglishSpeaker

            //    IArabicSpeaker

            //    Both interfaces contain the same method:

            //    Greet()

            //    If the class implements the method normally, both interfaces will call the same implementation.

            //    Example:
            //    class Translator : IEnglishSpeaker, IArabicSpeaker
            //    {
            //        public void Greet()
            //        {
            //            Console.WriteLine("Hello / Ahlan");
            //        }
            //     }


            //b) How can we fix this?

            //    We fix this problem using Explicit Interface Implementation.

            //    This allows each interface to have its own implementation of the same method.

            //    Example:

            //    interface IEnglishSpeaker
            //        {
            //            void Greet();
            //        }

            //        interface IArabicSpeaker
            //        {
            //            void Greet();
            //    }

            //    Class implementation:

            //    class Translator : IEnglishSpeaker, IArabicSpeaker
            //        {
            //            void IEnglishSpeaker.Greet()
            //            {
            //                Console.WriteLine("Hello");
            //            }

            //            void IArabicSpeaker.Greet()
            //            {
            //                Console.WriteLine("Ahlan");
            //            }
            //        }

            //    c) Can we call translator.Greet() directly?

            //        No.

            //        Because the methods are implemented explicitly, they can only be accessed through the interface reference.

            //        Example:

            //        Translator t = new Translator();

            //            ((IEnglishSpeaker) t).Greet();
            //            ((IArabicSpeaker) t).Greet();

            //            Output:

            //        Hello
            //        Ahlan
            //Q3 — Object Copying
            //     There are three types of copying explained in the lecture.

            //    1:Reference Copy

            //    Both variables point to the same object in memory.

            //    Example:

            //    Person p2 = p1;

            //        Any change to p2 also affects p1.

            //    2: Shallow Copy

            //    A new object is created, but reference fields are shared.

            //    Usually done using:

            //    MemberwiseClone()

            //    Meaning:

            //    Value types → copied

            //    Reference types → shared

            //    3:Deep Copy

            //    A deep copy creates a completely independent object, including nested objects.

            //    Changes in the copy do not affect the original object.

            //    Using ICloneable

            //    Interface used:

            //    ICloneable

            //    Example:

            //    class Person : ICloneable
            //        {
            //            public string Name;

            //            public object Clone()
            //            {
            //                return this.MemberwiseClone();
            //            }
            //    }

            //    Method used:

            //    Clone()


            //    Q4 — Output Explanation

            //        Example code:

            //        var e2 = e1.ShallowCopy();

            //            e2.Title = "QA";
            //        e2.Dept.Name = "Testing";

            //        Output:

            //        Dev - Testing
            //        QA - Testing
            //        Explanation

            //        ShallowCopy() uses:

            //        MemberwiseClone()

            //        So:

            //        e1.Dept and e2.Dept reference the SAME object

            //        When we change:

            //        e2.Dept.Name = "Testing"

            //        The change affects both objects.

            //        Final values:

            //        e1.Title = Dev
            //        e1.Dept.Name = Testing
            //        e2.Title = QA
            //        e2.Dept.Name = Testing

            //        Output:

            //        Dev - Testing
            //        QA - Testing
            #endregion

            #region Part 02 : Practical (Extending the Movie Ticket Booking System

            //Cinema cinema = new Cinema();

            //cinema.Open();

            //StandardTicket t1 = new StandardTicket
            //{
            //    MovieName = "Inception",
            //    Seat = "A5",
            //    Price = 80
            //};

            //VIPTicket t2 = new VIPTicket
            //{
            //    MovieName = "Avengers",
            //    LoungeAccess = true,
            //    Fee = 50,
            //    Price = 200
            //};

            //IMAXTicket t3 = new IMAXTicket
            //{
            //    MovieName = "Dune",
            //    Is3D = true,
            //    Price = 130
            //};

            //t1.Book();
            //t2.Book();
            //t3.Book();

            //cinema.AddTicket(t1);
            //cinema.AddTicket(t2);
            //cinema.AddTicket(t3);

            //cinema.PrintAllTickets();

            //Console.WriteLine("\n--- Clone Test ---");

            //VIPTicket clone = (VIPTicket)t2.Clone();
            //clone.MovieName = "Interstellar";

            //Console.Write("Original : ");
            //t2.Print();

            //Console.Write("Clone    : ");
            //clone.Print();

            //Console.WriteLine("\n--- After Cancellation ---");

            //t1.Cancel();
            //t1.Print();

            //BookingHelper.PrintAll(new IPrintable[] { t1, t2, t3 });

            //cinema.Close();
        }
            #endregion
    }
    }

