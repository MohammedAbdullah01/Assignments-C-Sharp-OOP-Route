using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Mohamed_Abdullah_sun_wed_8pm_C__OOP_01
{


    #region Q => 1 || Q => 3 
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public byte Age { get; set; }

    //    public Person(string _Name, byte _Age)
    //    {
    //        Name = _Name;
    //        Age = _Age;
    //    }


    //    public static Person FindOldestPerson(Person[] persons)
    //    {
    //        Person oldest = new Person();
    //        foreach (var person in persons)
    //        {
    //            if (person.Age > oldest.Age)
    //            {
    //                oldest = person;
    //            }
    //        }
    //        return oldest;
    //    }
    //}
    #endregion


    #region Q => 2 
    /*
      2. Create a struct called “Point” to represent a 2D point
        with properties “X” and “Y”. Write a C# program that
        takes two points as input from the user and calculates
        the distance between them.
     */

    //struct Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }

    //    public Point(double _x, double _y)
    //    {
    //        X = _x;
    //        Y = _y;
    //    }


    //    public static bool CheckInputsPoints(string inputX, string inputY, out double x, out double y)
    //    {
    //        if (double.TryParse(inputX, out x) && double.TryParse(inputY, out y))
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            x = 0;
    //            y = 0;
    //            return false;
    //        }
    //    }


    //    public static bool TryGetPoint(string pointName, out Point point)
    //    {
    //        double x, y;
    //        Console.WriteLine($"Enter Coordinates For The {pointName} Point:");

    //        Console.Write("X: ");
    //        string inputX = Console.ReadLine() ?? "";

    //        Console.Write("Y: ");
    //        string inputY = Console.ReadLine() ?? "";

    //        if (Point.CheckInputsPoints(inputX, inputY, out x, out y))
    //        {
    //            point = new Point(x, y);
    //            return true;
    //        }
    //        else
    //        {
    //            point = new Point();
    //            return false;
    //        }
    //    }



    //    public static double CalculateDistance(Point p1, Point p2)
    //    {
    //        double dx = p1.X - p2.X;
    //        double dy = p1.Y - p2.Y;
    //        return Math.Round( Math.Sqrt(dx * dx + dy * dy) , 3);
    //    }
    //} 
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q => 1
            /*
              1. Define a struct “Person” with properties “Name” and
                “Age”. Create an array of three “Person” objects and
                populate it with data. Then, write a C# program to
                display the details of all the persons in the array.
             */


            //Person[] persons = { new Person("Mohamed", 30), new Person("Ahmed", 26), new Person("Rayyan", 20) };

            //Console.WriteLine("Display All Persons :");
            //Console.WriteLine("=======================");


            //byte i = 1;
            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"{i++} - Person Name = {person.Name}");
            //    Console.WriteLine($"    Person Age  = {person.Age}");
            //    Console.WriteLine("=======================================");

            //} 
            #endregion
             

            #region Q => 2 
            /*
              2. Create a struct called “Point” to represent a 2D point
                with properties “X” and “Y”. Write a C# program that
                takes two points as input from the user and calculates
                the distance between them.
             */


            //Point point1 , point2;

            //if (!Point.TryGetPoint("First", out point1))
            //{
            //    Console.WriteLine("Invalid Entry. Both Coordinates Must Be Numbers");
            //    return;
            //}

            //if (!Point.TryGetPoint("Second", out point2))
            //{
            //    Console.WriteLine("Invalid Entry. Both Coordinates Must Be Numbers");
            //    return;
            //}

            //double distance = Point.CalculateDistance(point1, point2);
            //Console.WriteLine("\n------------------------------------------------------------");
            //Console.WriteLine($"The distance between the two points is: {distance}");
            //Console.WriteLine("------------------------------------------------------------");
            #endregion


            #region Q => 3 
            /*
              Create a struct called “Person” with properties “Name” and
                “Age”. Write a C# program that takes details of 3 persons as
                input from the user and displays the name and age of the
                oldest person.
             */

            //Console.Write("Please Enter The Number Of Persons To Add :");

            //string inputCountPersons =  Console.ReadLine() ?? "";
            //byte countPersons;

            //if(!CheckInputTypeByte(inputCountPersons, out countPersons))
            //{
            //    Console.WriteLine("You Must Enter An Integer Number");
            //    return;
            //}

            //DisplayMessageOnConsole($"Please Enter {countPersons} Persons .");

            //Person[] persons = new Person[countPersons];

            //for (int i = 0; i < countPersons; i++)
            //{

            //    DisplayMessageOnConsole($"Enter Person {i + 1} Details:");

            //    Console.Write($"Enter Person ( {i + 1} ) Name: ");

            //    string inputName = Console.ReadLine() ?? "";

            //    inputName = inputName.Length > 0 ? inputName :  "Unknow";

            //    Console.Write($"Enter Person ( {i + 1} ) Age: ");

            //    string inputAge = Console.ReadLine() ?? "";

            //    if (!CheckInputTypeByte(inputAge, out byte agePerson))
            //    {
            //        Console.WriteLine("You Must Enter Age  An Integer Number");
            //        return;
            //    }

            //    persons[i] = new Person(inputName, agePerson);

            //}

            //DisplayMessageOnConsole("List of Persons Entered:");

            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"Name: {person.Name}    =>    Age: {person.Age}");
            //}

            //Person oldestPerson = Person.FindOldestPerson(persons);

            //DisplayMessageOnConsole($"The Biggest Person Name Per Is:\n {oldestPerson.Name}     =>    Is Age = {oldestPerson.Age} ");



            //static void DisplayMessageOnConsole(string msg)
            //{
            //    Console.WriteLine("\n============================================");
            //    Console.WriteLine($"{msg}");
            //    Console.WriteLine("============================================\n");
            //}


            //static bool CheckInputTypeByte(string input, out byte num)
            //{
            //    if (!byte.TryParse(input, out num))
            //    {
            //        num = 0;
            //        return false;
            //    }
            //    return true;
            //} 
            #endregion

        }
    }
}
