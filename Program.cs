/*
   Author : Suyog Thengale 
   Date: 09/24/2020
   Project: To ask users to enter their name and print their greeting
*/

using System;

namespace techproject_3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name."); //using try catch block to validate user input  

            try
            {
                string name = Console.ReadLine(); //will gather data from user input 

                greeting(name);  

                /* 
                    will generate user greeting after executing try 
                */
                
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit the program."); //syntax to exit the program 
                Console.ReadKey(true);

            } //end of try

            catch
            {
                Console.WriteLine(" ");
                Console.WriteLine("Please enter your name.");
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit the program and try again.");
                Console.ReadKey(true);
            } // end of catch


        } //end of main 

        private static void greeting(string name) //entlising the method "greeting" 
        {
            Console.WriteLine(" ");
            Console.WriteLine("Hello" + " " + name + " - Welcome to the team!");
        } //end of greeting

    } //end of class
} // end of program 
    

