using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Пространство имен - Namespaces

namespace SEP_171.Module_II
{
    public class User
    {
        public int Age = 10;
    }
    // camelCase - arguments, all variables inside methods
    // PascalCase - all classes, all methods
    // F12
    class ProgramNumberOne
    {
        static void Main(string[] args)
        {
            //int age = 23;
            //Console.WriteLine(age);



            // cin and cout
            /*
            Console.WriteLine("Hello \n World");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "C# Group";

            Console.Write("Hello");
            Console.Write("World");
            */

            // Variables

            // sbyte myByteValue = 128;
            // Console.WriteLine(myByteValue);
            /*
            Console.WriteLine("Get money - 1");
            Console.WriteLine("Insert money - 2");

            if (args.Length != 0)
            {
                if(args[0] == "adminstrator")
                {
                    Console.WriteLine("ATM management panel - 3");
                }      
            } */


            //int myMaxInteger = int.MaxValue;
            //int myNextMaxInteger = Int32.MaxValue;
            //Single myFloat = float.MaxValue;
            //Double myDouble = double.MaxValue;
            //long myLong = Int64.MaxValue;
            //short myShort = Int16.MaxValue;

            //char myChar = '*';
            //string myString = "Iskander";

            //bool isTrue = true;

            //decimal myDecimal = Decimal.MaxValue;



            //// ToString();
            //string myInput = Console.ReadLine();
            //int age = int.Parse(myInput);

            //Console.WriteLine(myMaxInteger);
            //Console.WriteLine(" {myLong}  {myMaxInteger}  {myNextMaxInteger} ");

            //string myString = "Iskander" + "Dota2";
            //int[] array = new int[10];

            //// a[i]
            //foreach (int item in array)
            //{
            //    item--;
            //    Console.WriteLine(item);
            //}

            int spaceCounter = 0;

            char inputChar = (char)Console.Read();

            while (inputChar != '.')
            {
                if(inputChar == ' ')
                {
                    spaceCounter++;
                }
                inputChar = (char)Console.Read();
            }

            Console.WriteLine(spaceCounter);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
