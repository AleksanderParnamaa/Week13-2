using System;
using System.IO;

namespace pf
{
    class Program
    {
        static void Main(string[] args)
        {
            string newPath = @"C:\Users\opilane\samples\TITpe21";
            string Stars = @$"{newPath}\Stars.txt";
            string Planets = @$"{newPath}\Planets.txt";
           

            bool directoryExists = Directory.Exists(newPath);
            bool StarsExists = File.Exists(Stars);
            bool PlanetsExists = File.Exists(Planets);
          


            if (directoryExists && StarsExists && PlanetsExists)
            {
                Console.WriteLine($"{Stars} already exists.");
                Console.WriteLine($"{Planets} already exists");
              

            }
            else
            {

                File.Create(Stars);
                File.Create(Planets);
           
                Console.WriteLine($"Files {Stars}and{Planets} has been created in Week13.");
            }
            Console.ReadLine();

        }
    }
}