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
            #endregion
        }
    }
}
