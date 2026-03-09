using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Assigment_OOP_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1: Theoretical Questions
            #region Qouestion 1
            //        /*
            //        Q1: What is abstraction in OOP? How is it different from encapsulation?
            //        Give a real-world example (not from the session) that shows the difference.
            //        */

            //        Answer:

            //            Abstraction is the concept of hiding complex implementation details and showing
            //            only the essential features of an object.It focuses on what an object does
            //instead of how it does it.

            //Encapsulation is the concept of wrapping data and methods together inside a
            //class and restricting direct access to some of the object's data using
            //access modifiers like private or protected.

            //Difference:
            //- Abstraction hides complexity.
            //- Encapsulation protects data.

            //Real-world example:
            //A coffee machine.

            //Abstraction:
            //A user presses the "Make Coffee" button without knowing how the machine heats
            //water or mixes coffee.

            //Encapsulation:
            //The internal components like the heater and pump are hidden inside the machine
            //and cannot be accessed directly by the user.
            //*/
            #endregion
            #region Question 2
            /*
            Q2: What is the difference between an abstract class and an interface?
            Give at least four differences. When would you choose one over the other?
            */

            //        Answer:

            // 1.Implementation
            //Abstract Class:Can contain both implemented methods and abstract methods.

            //Interface:
            //Contains only method declarations(no implementation).

            //2. Constructors
            //Abstract Class:Can have constructors.

            //Interface:Cannot have constructors.

            //3. Fields
            //Abstract Class: Can have fields and properties.

            //Interface: Cannot contain fields.

            //4. Inheritance
            //Abstract Class:A class can inherit from only one abstract class.

            //Interface:A class can implement multiple interfaces.

            //When to use:

            //Use an Abstract Class when:
            // Classes share common code. You want to provide base functionality

            //Use an Interface when:
            //You want to define a contract. Multiple unrelated classes must follow the same behavior
            //
            #endregion

            #region Qouestion 3
            /*
            Look at the following code and answer the questions.
            */

            ///code part:

            //public abstract class Appliance
            //        {
            //            public string Brand { get; set; }

            //            protected Appliance(string brand) { Brand = brand; }

            //            public abstract double PowerConsumption();

            //            public virtual string Status() => "Standby";

            //            public string Label() => $"{Brand} - {PowerConsumption()}W";
            //        }

            //        public class WashingMachine : Appliance
            //        {
            //            public WashingMachine(string brand) : base(brand) { }
            //            public override double PowerConsumption() => 500;
            //            public override string Status() => "Washing";
            //        }

            //        public class Toaster : Appliance
            //        {
            //            public Toaster(string brand) : base(brand) { }
            //            public override double PowerConsumption() => 800;
            //        }

            /*
            a) Can you write:
            Appliance a = new Appliance("LG") ?

            Answer:
            No. Because Appliance is an abstract class and abstract classes cannot
            be instantiated directly. They are meant to be inherited by other classes.
            */

            /*
            b) Difference between PowerConsumption(), Status(), and Label().

            PowerConsumption():
            Abstract method.
            Every child class MUST implement its own version.

            Status():
            Virtual method.
            Child classes may override it but they are not required to.

            Label():
            Concrete method.
            It already has full implementation and child classes use it as-is.

            Reason for design:
            PowerConsumption depends on appliance type.
            Status may change depending on device state.
            Label is common functionality shared by all appliances.
            */

            /*
            c) If you call Status() on a Toaster object, what will it return?

            Answer:
            It will return "Standby".

            Reason:
            Toaster does not override the Status() method,
            so it uses the default implementation from the base class.
            */
            #endregion

            #region Qouestion 4
            /*
            Look at the following code and answer the questions.
            */

            /*
            a) What is a partial class?

            A partial class allows a class definition to be split across multiple
            files. All parts are combined by the compiler into one class.

            Why split Calculator?
            To organize large classes. For example:
            - One file for logic
            - One file for logging
            - One file for utilities
            */

            /*
            b) What is a partial method?

            A partial method is a method that can be declared in one part of a partial
            class and optionally implemented in another.

            If the implementation is deleted:
            The code will still compile.

            Reason:
            If a partial method has no implementation, the compiler removes
            both the declaration and its calls.
            */

            /*
            c) What is an extension method?

            An extension method allows you to add new methods to an existing class
            without modifying its source code.

            Three rules:
            1. It must be inside a static class.
            2. The method itself must be static.
            3. The first parameter must use the "this" keyword.
            */

            /*
            d) What will this code print?

            Calculator calc = new Calculator();
            double result = calc.Add(19.5, 0.5);
            Console.WriteLine(result.ToCurrency());

            Output:

            Log: result = 20
            $20.00
            */
            #endregion
            #endregion

            #region Part 2:Practical (Extending the Movie Ticket Booking System)

            //Practical (Extending the Movie Ticket Booking System)



            Console.WriteLine("=== Cinema Opened ===");

            // This line cannot run because Ticket is abstract
            // Ticket t = new Ticket("Test", 100);

            Console.WriteLine("// Ticket t = new Ticket(\"Test\", 100);  // ERROR: Cannot create instance of abstract type 'Ticket'"); // iam using this to show error in the output like the assigment only

            Ticket t1 = new StandardTicket("Inception", 80, "A5");
            Ticket t2 = new VIPTicket("Avengers", 200, true, 50);
            Ticket t3 = new IMAXTicket("Dune", 130, true);

            t1.Book();
            t2.Book();
            t3.Book();

            Cinema cinema = new Cinema();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintTickets();

            Console.WriteLine("\n--- Polymorphism: Final Price per Ticket ---");

            Ticket[] tickets = { t1, t2, t3 };

            foreach (var t in tickets)
            {
                Console.WriteLine($"{t.GetType().Name} => Final Price: {t.FinalPrice():F2}");
            }

            Console.WriteLine("\n--- Extension Method: Receipt ---");
            Console.WriteLine(t2.Receipt());

            Console.WriteLine("\n--- Extension Method: Total Revenue ---");
            Console.WriteLine($"Total Revenue: {tickets.TotalRevenue():F2}");

            Console.WriteLine("\n=== Cinema Closed ===");

            #endregion
        }
    }
}
