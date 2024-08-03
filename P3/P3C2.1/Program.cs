
// TODO: Run the printName function
using P3C2;
using System;
using System.Diagnostics.SymbolStore;

class Program
{
    public static void Main(string[] args)
    {
        // Work on the MagicMath class
        Console.WriteLine("\nWork on the MagicMath class:");
        MagicMath mm = new() { a=5 };  // The initialization of a to the number  will overtake it's initialization to 8 and even 4.
        Console.WriteLine($"a={mm.a}, b={mm.b}");
        mm.ChangeValues();
        Console.WriteLine($"a={mm.a}, b={mm.b}");

        // Work on the animal class
        Animal.PrintName();

        // Work on the Instance_VS_Class_Member class
        Console.WriteLine("\n\nWork on the Instance_VS_Class_Member class:");
        Instance_VS_Class_Member ivc = new Instance_VS_Class_Member();
        Console.WriteLine("instanceVariable: " + ivc.instanceVariable +  // instance variables are accessed via an instance
                          "\nclassVariable: " + Instance_VS_Class_Member.classVariable);  // class variables are accessed by directly asking the class to give it to us.
        ivc.InstanceMethod();
        Console.WriteLine("instanceVariable: " + ivc.instanceVariable +  // As you can see, the instance method can modify instance variables
                          "\nclassVariable: " + Instance_VS_Class_Member.classVariable);  // as well as class variable !!
        Instance_VS_Class_Member.ClassMethod();
        Console.WriteLine("instanceVariable: " + ivc.instanceVariable +  // However, class method cannot reach instance variable
                          "\nclassVariable: " + Instance_VS_Class_Member.classVariable);  // but can indeed modify class variable
        Console.WriteLine($"For now, we only created {Instance_VS_Class_Member.NumberOfInstance()}/{ivc.NumberOfInstance2()} instance of the class");
        Instance_VS_Class_Member ivc2 = new(), ivc3 = new(), ivc4 = new();
        Console.WriteLine($"Now, we created {Instance_VS_Class_Member.NumberOfInstance()}/{ivc.NumberOfInstance2()} instance of the class");


        // Work on the Const_VS_Readonly class
        Console.WriteLine("\n\nWork on the Const_VS_Readonly class:");
        Const_VS_Readonly cvr = new Const_VS_Readonly();
        Console.WriteLine($"Constant value: {Const_VS_Readonly.CONST_VALUE}\n" +
                          $"Readonly value: {cvr.READONLY_VALUE}");
        cvr.AMethod ();  // The NEW_CONST_VALUE inside that function cannot be accessed here.

        // Work on the TestProperty class
        Console.WriteLine("\n\nWork on the TimePeriod class:");
        TimePeriod t = new TimePeriod("duration"){Language="fr", InitTime=666};  // Language here is required whereas InitTime is not.
        t.Hours = 24;  // The property assignment causes the 'set' accessor to be called.
        Console.WriteLine($"Time in hours: {t.Hours}");  // Retrieving the property causes the 'get' accessor to be called.
        Console.WriteLine($"{t.Name}");
        Console.WriteLine($"ID: {t.Id}");
        
    }

    class MagicMath
    {
        // 'public' keyword is necessary to make those elements visible outside the class itself.
        // By oposition, 'private' keyword specify that the element won't be accessible outside of the class
        public int a = 8;
        public int b;
        public readonly int c = 9;  // the 'readonly' keyword will prevent any modification of this variable
        const int d = 10;

        public MagicMath() 
        {
            a = 4;
        }

        public void ChangeValues(int d = 3)
        {
            this.a = d;
            this.b = 9;
        }
    }

    public class Instance_VS_Class_Member
    {
        // As you can see, we can chose whether or not a variable is an instance variable or a class variable by writing the 'static' keyword:
        public int instanceVariable = 666;
        public static int classVariable = 69;

        /// Same goes for methods:

        // instance method (or 'non-static') particularities:
        //   - work in the context of an instance of a class. They require object instantiation.
        //   - blueprint classes are the most valuable because they define both a state (with fields) and a behavior (with instance methods).
        public void InstanceMethod() 
        {
            Console.WriteLine("--We are inside the instance method");
            instanceVariable++;
            classVariable++;
        }

        // class method (or 'static') particularities:
        //   - operate in the context of a class in general, and do not require object instantiation.
        //   - used inside static classes. They provide functionalities that can be used by several classes. The math class is one example.
        public static void ClassMethod() 
        {
            Console.WriteLine("--We are inside the class method");
            // instanceVariable++;  // Cannot be accessed inside a static method
            classVariable++;
        }

        // Both methods below gives the very same result
        public static int NumberOfInstance()
        {
            return count;
        }
        public int NumberOfInstance2()
        {
            return count;
        }

        // Another cool thing you can do with class variables for example is to use them to keep track of the number of object you created.
        private static int count = 0;

        public Instance_VS_Class_Member()
        {
            count++;
        }
    }

    /// <summary>
    /// This class is just here to show the differences between the 'readonly' keyword and the 'const' keyword.
    /// </summary>
    /// <remarks>
    /// Here are some helpfull resources that helped me understand the difference:
    ///  - https://www.geeksforgeeks.org/difference-between-readonly-and-const-keyword-in-c-sharp/
    ///  - https://stackoverflow.com/questions/55984/what-is-the-difference-between-const-and-readonly-in-c
    ///  - https://www.youtube.com/watch?v=jA30qZNGNoM
    /// </remarks>
    public class Const_VS_Readonly
    {
        // 'const' keyword particularities:
        //   - static by default and must be initialized with a constant value at compile-time.
        //   - compile-time constant
        //   - can be declared inside a method.
        //   - values cannot be changed later, including in constructors.
        //   - some datatypes, like DateTime, cannot be used with const due to the requirement for compile-time initialization.
        //   - Use const for static, unchanging values that must be initialized at compile-time.
        public const int CONST_VALUE = 0;

        // 'readonly' keyword particularities:
        //   - can be declared as instance or static, but static is not necessary.
        //   - run-time constant
        //   - cannot be declared inside a method.
        //   - initial values can be assigned at declaration or in a constructor, but cannot be changed later.
        //   - instance-specific values are allowed using constructors, making readonly suitable for instance members.
        //   - Use readonly for instance or static fields that can be initialized at declaration or in a constructor, but remain unchanging throughout the program’s lifetime.
        public readonly int READONLY_VALUE;
        public Const_VS_Readonly()
        {
            READONLY_VALUE = 1;  // As you can see, we can assign a value to a readonly variable in the constructor. It can be initialized at run-time.
        }
        public void AMethod()
        {
            const int NEW_CONST_VALUE = 2;  // Cannot be accessed outside of that function!
            // readonly int NEW_READONLY_VALUE = 3;  // Cannot be done
            Console.WriteLine("--We are in AMethod!\n" +
                              $"New const value: {NEW_CONST_VALUE}");
        }
    }

    /// <summary>
    /// This class implement some test on the accessors.
    /// </summary>
    /// <remarks>
    /// As the OC course wasn't very insightful on the matter, I had to search for more ressources on the web:
    ///  - https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/properties
    ///  - https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers#object-initializers-with-the-required-modifier
    ///  - https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/using-properties
    ///  - https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties
    /// </remarks>
    public class TimePeriod(string label)  // Here we define the constructor directly here.
    {
        private double _seconds;
        private string _label = label;
        private int _importance;
        // When working with very simple variables, there's no complex logic or checking to do, so we can simply let the compiler do its magic.
        public string? Author { get; set; } // This is an auto implemented property. The '?', is here to explicitly say that Author can take a null value.
        public int Id { get; private set; } = 1234;  // Obviously we can specify a value directly after.
        public required string Language { get; set; }  // The modifier "required" specify the the caller will have to specify a value for it in the initialize.
        public int InitTime { get; init; } // This can be initialize in the initializer, but not modified afterwards
        public decimal UselessValue { get; }  // Using an auto implemented value, we can define the 'get' accessor only. Unfortunately we can't do the same with set
        private decimal _uselessValue2;
        public decimal UselessValue2  // However, when implementing accessors manual we can choose which ever we want to implement.
        {
            set
            {
                _uselessValue2 = value;
            }
        }



        // The following is a read-only expression-bodied member. That means that the 'get' and 'return' keywords
        // were not necessary and that there is no 'set' property
        public string Name => $"Timer {_label}";

        public double Hours
        {
            get { return _seconds / 3600; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        "The value provided must be positive");
                }
                _seconds = value * 3600;
            }
        }
        public double Minutes
        {
            get { return _seconds / 60; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        "The value provided must be positive");
                }
                _seconds = value * 60;
            }
        }
        public double Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        "The value provided must be positive");
                }
                _seconds = value;
            }
        }
        // As you can see just bellow, both 'get' and 'set' can be implemented using an expression-bodied member.
        // In that case those keyword are necessary, but the 'return' keyword is still not necessary
        public int Importance
        {
            get => _importance;
            set => _importance = value;
        }
    }
}