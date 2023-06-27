﻿using System.Security.Cryptography.X509Certificates;


namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To get started... What is your major?");

            var studentAnswer = Console.ReadLine();

            switch (studentAnswer.ToLower()) 
            {
                case "electrical engineer":
                    Console.WriteLine($"Amazing! That's a great career field.");
                    break;
                case "software engineer":
                    Console.WriteLine($"You're on your way to do great things!");
                    break;
                case "painter":
                    Console.WriteLine($"What a way to tap into your creativity");
                    break;
                case "trainer":
                    Console.WriteLine($"You will be the reason most of the world will stay fit");
                    break;
                case "pilot":
                    Console.WriteLine($"One of the best ways to travel the world. You must be a genius?!");
                    break;
                default:
                    Console.WriteLine($"I know you will change the world one day! Wish you the best in all of your endeavors!");
                    break;
                
            }
        }
    }
}
