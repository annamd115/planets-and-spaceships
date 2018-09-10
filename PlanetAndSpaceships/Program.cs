using System;
using System.Collections.Generic;

namespace PlanetAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            //Add Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //Create another List that contains the last two planets of our solar system.
            List<string> lastTwoPlanetsList = new List<string>() {"Neptune", "Uranus" };

            //Combine the two lists by using AddRange().
            List<string> combinedPlanetList = new List<string>();
            combinedPlanetList.AddRange(planetList);
            combinedPlanetList.AddRange(lastTwoPlanetsList);

            //Use Insert() to add Earth, and Venus in the correct order.
            combinedPlanetList.Insert(2, "Earth");
            combinedPlanetList.Insert(1, "Venus");

            //Use Add() again to add Pluto to the end of the list.
            combinedPlanetList.Add("Pluto");

            //Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
            List<string> rockyPlanets = new List<string>();
            rockyPlanets = combinedPlanetList.GetRange(0,3);

            //Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            combinedPlanetList.Remove("Pluto");

            foreach (string planet in combinedPlanetList)
            {
                Console.WriteLine(planet);
            }

            Console.ReadLine();
        }
    }
}
