using System;
using System.IO;

namespace InClassAssignment3
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Program using no constructors
            Carc Ford = new Carc();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Carc Opel = new Carc();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            //Program using constructors
            Car FordCar = new Car("Mustang", "Red", 1969);
            Car OpelCar = new Car("Astra", "White", 2005);

            Console.WriteLine(FordCar.model);
            Console.WriteLine(OpelCar.model);

            //Person class using get/set
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);

            //***Using inheritance
            // Create a myCar object
            Cars myCar = new Cars();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            DemoClass myObj2 = new DemoClass();
            myObj2.myMethod();
            myObj2.myOtherMethod();

            //showing enums
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);

            //showing how to use system.io:
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
            //using Try Catch Finally
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
    class Car
    {
        public string model;
        public string color;
        public int year;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        //Constructor
        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

    }
    class Carc //using no arguments
    {
        public string model;
        public string color;
        public int year;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

    }
    class Person
    {
        public string Name  // property
        { get; set; }
    }
    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Cars : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound() //override to use this class over parent
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound() //override to use this class over parent
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    // Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pigs : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }
    enum Months //enums with value changes
    {
        January,    // 0
        February,   // 1
        March = 6,    // 6
        April,      // 7
        May,        // 8
        June,       // 9
        July        // 10
    }
}
