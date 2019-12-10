using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace C_Course_100
{
    class Program
    {
        public static void Main(string[] args)
        {
            ////1.Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.

            //string[] menuOrder = new string[] { "$15.50", "$6.95", "$3.75", "$3.25", "$2.95" };
            //Console.WriteLine("Please select what food you want to order?: \n \t (0)Pizza \n \t (1)Hamburger \n \t (2)Hotdog  \n \t (3)Corndog \n \t (4)Fries ");

            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your order will cost you " + menuOrder[input]);


            ////2.Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.

            //int[] SpeedingTicket = new int[] { 0, 60, 120, 500 , 1500};
            //Console.WriteLine("Please select how fast do you like to drive?: \n \t (1)75mph \n \t (2)85mph \n \t (3)120mph  \n \t (4)180mph ");

            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your ticket amount for going faster than speed limit is : $" + SpeedingTicket[input]);


            ////3.Add in a message that displays when the user selects an index that doesn’t exist.

            //string userInput;
            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("Enter a number between 0 and 10 " +
            //           "(or just hit return to exit) ");
            //        userInput = Console.ReadLine();
            //        if (userInput == "")
            //            break;
            //        int index = Convert.ToInt32(userInput);
            //        if (index < 0 || index > 10)
            //            throw new IndexOutOfRangeException("You entered in " + userInput);
            //        Console.WriteLine("Your number was " + index);
            //    }
            //    catch (IndexOutOfRangeException wrong)
            //    {
            //        Console.WriteLine("Wrong: Number should be between 0 and 10. " + wrong.Message);
            //    }

            //    finally
            //    {
            //        Console.WriteLine("Awesome");
            //    }


            ////4.Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
            ///

            // Create a list of strings 

            
            

            ArrayList menuOrder = new ArrayList();
            menuOrder.Add("$15.50");
            menuOrder.Add("$6.95");
            menuOrder.Add("$3.75");
            menuOrder.Add("$3.25");
            menuOrder.Add("$2.95");

            Console.WriteLine("Please select what food you want to order?: \n \t (0)Pizza \n \t (1)Hamburger \n \t (2)Hotdog  \n \t (3)Corndog \n \t (4)Fries ");

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Your order will cost you " + menuOrder[input]);
            



            Console.ReadLine();
        
            }
        
    }
}

