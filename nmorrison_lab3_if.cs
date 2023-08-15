/*
 * Author: Nicole Morrison
 * Date: 2/19/2023
 * 
 * Program Name: nmorrison_lab3a
 * Program Description: Magic 8 Ball if else if
 */

/* using Directives*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

//Define project Namespace
namespace STCLab3if

{
    class Lab3
    {
        //Program execution begins here
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(120, 80);
            Console.SetWindowSize(120, 80);
            
            //Declare variable to represent random number generator
            Random rnd = new Random();
            string question;
            //Ask user to enter question
            Console.Write("Welcome!  I am the Magic 8-Ball. Ask me a Yes or No question, press Enter, and I will give you an answer:\n");
            question = Console.ReadLine();
            Console.WriteLine();
            //Generate random number between 1 and 5 by dividing by 5, which gives 0 to 4, and adding 1 to get 1 to 5
            int roll = rnd.Next() % 5 + 1;
            //**this displayed the random number to check if functioning***Console.WriteLine("The random number is: {0}", roll);
            if (roll == 1)
                Console.WriteLine("You asked:\n\n  {0}?\n\nMy answer:\n\n  It is certain\n", question);

            else if (roll == 2)
                Console.WriteLine("You asked:\n\n  {0}?\n\nMy answer:\n\n  Reply hazy.Try again\n", question);
                
            else if (roll == 3)
                Console.WriteLine("You asked:\n\n  {0}?\n\nMy answer:\n\n  Dont't count on it\n", question);
                
            else if (roll == 4)
                Console.WriteLine("You asked:\n\n  {0}?\n\nMy answer:\n\n  Signs point to yes\n", question);

            else if (roll == 5)
                Console.WriteLine("You asked:\n\n  {0}?\n\nMy answer:\n\n  My sources say no\n", question);

            Console.WriteLine("Thank you for using Nicole's Magic 8-Ball");
       



        }
    }
}
