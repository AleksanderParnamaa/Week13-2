using System;
using System.IO;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = $@"C:\Users\opilane\samples\TITpe21";
            Console.WriteLine("What file would you like displayed?");
            string userFile = Console.ReadLine();
            string fileDirect = $@"{rootdirect}\{userFile}.txt";
            bool exists = File.Exists(fileDirect);
            if (exists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirect);
                if (userFile == "Stars" || userFile == "Planets")
                {
                    foreach (string line in dataFromFile)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{userFile}.txt file does not exist.");
                }
            }
            else
            {
                Console.WriteLine($"{userFile}.txt file does not exist.");

            }
        }
    }
}