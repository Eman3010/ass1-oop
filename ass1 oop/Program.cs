using System.ComponentModel;
using System.Drawing;

namespace ass1_oop
{
    internal class Program
    {

        enum weekdays
        {
            mon, tue, wed, thu, fri, sat, sun
        }

        enum Season
        {
            Spring, Summer, Autumn, Winter
        }

        enum Colors
        {
            Red, Green, Blue
        }

        static void Main(string[] args)
        {


            #region Question1
            /*1) Create an enum called "WeekDays" with the days of the       
                  week(Monday to Sunday) as its members.Then, write a C#
                  programthat prints out all the days of the week using this enum.

              for (int i = 0; i <= 6; i++)
              {
                  weekdays w = (weekdays)i;
                  Console.WriteLine(w);
              }
              */
            #endregion

            #region Question2
            /* 2)Define a struct "Person" with properties "Name" and
                    "Age". Create an array of three "Person" objects and 
                   populate it with data. Then, write a C# program to display the details of all the persons in the array.
            person2[] persons = new person2[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                persons[i] = new person2(name, age);
            }
            Console.WriteLine("Details of all persons:");
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Person {i + 1}: Name = {persons[i].Name}, Age = {persons[i].Age}");
            }*/
            #endregion

            #region Question3
            /* 3)Create an enum called "Seas on" with the four seasons
                 * (Spring, Summer, Autumn, Winter) as its members. 
                 * Write a C# program that takes a season name as input 
                 * from the user and displays the corresponding month 
                 * range for that season. Note range for seasons 
                 * ( spring march to may , summer june to august , autumn September to November , winter December to February)

                 Console.WriteLine("Enter a season name:");
                 string input = Console.ReadLine(); ;

                 if (Enum.TryParse(input, out Season season))
                 {
                     if (season == Season.Spring)

                         Console.WriteLine("Spring from March to May.");

                     else if (season == Season.Summer)

                         Console.WriteLine("Summer from June to August.");

                     else if (season == Season.Autumn)

                         Console.WriteLine("Autumn from September to November.");

                     else if (season == Season.Winter)

                         Console.WriteLine("Winter from December to February.");


                     else

                         Console.WriteLine("Invalid season name");
                 }*/
            #endregion


            #region Question5

            /* Create an enum called "Colors" with the basic colors 
              (Red, Green, Blue) as its members. Write a C# program 
              that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            console.writeline("enter a color");
            string input = console.readline();
               if (enum.tryparse(input, out colors color))
              {
                console.writeline($"{color} is a primary color");
              }
              else
              {
                console.writeline($"{input} is not a primary color.");
               }*/
            #endregion

            #region Question6
            /* 6)Create a struct called "Point" to represent a 2D point with 
            properties "X" and "Y". Write a C# program that takes two 
            points as input from the user and calculates the distance between them.


            Console.WriteLine("Enter the coordinates of the first point (X1 and Y1):");
            Console.Write("Enter X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point (X2 and Y2):");
            Console.Write("Enter X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());


            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            Console.WriteLine($"The distance between the two points is: {distance}");*/


            #endregion

            #region Question7
            /* 7)Create a struct called "Person" with properties 
      "Name" and "Age". Write a C# program that takes 
      details of 3 persons as input from the user and displays
      the name and age of the oldest person.

    Person[] persons = new Person[3];
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Enter details for person {i + 1}:");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        persons[i] = new Person(name, age);
    }
    Person oldestPerson = persons[0];

    for (int i = 1; i < 3; i++)
    {
        if (persons[i].Age > oldestPerson.Age)
        {
            oldestPerson = persons[i];
        }
    }

    Console.WriteLine($"The oldest person is {oldestPerson.Name}{oldestPerson.Age}");*/

            #endregion

        }
}

}







