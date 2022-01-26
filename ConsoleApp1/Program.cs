using System;
using System.IO;
using System.Collections.Generic;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = @"C:\Users\opilane\Samples\TITpe21";

            string[] datafromfile = File.ReadAllLines($@"{rootdirect}\milkyway.txt");
            List<string> Stars = new List<string>();
            List<string> Planets = new List<string>();
         

            foreach (string element in datafromfile)
            {
                if (element.Contains("Stars"))
                {
                    Stars.Add(element);
                }
               else if (element.Contains("Planets"))
                {
                    Planets.Add(element);
                }
               

                File.WriteAllLines($@"{rootdirect}\Stars.txt", Stars);
                File.WriteAllLines($@"{rootdirect}\Planets.txt", Planets);
        
            }

        }
    }

}