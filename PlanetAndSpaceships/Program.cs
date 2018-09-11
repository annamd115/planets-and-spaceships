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

            var probes = new Dictionary<string, List<string>>
            {
                { "Mariner 10", new List<string> { "Mercury", "Earth"} },
                { "Messenger", new List<string> { "Mercury", "Venus" } },
                { "BepiColombo",  new List<string> { "Mercury", } },
                { "Venus Express", new List<string>{ "Venus",} },
                { "Parker Solar Probe", new List<string>{ "Venus",} },
                { "Pioneer 10", new List<string> { "Earth", "Jupiter"} },
                { "Pioneer 11", new List<string> { "Earth", "Saturn", "Jupiter"} },
                { "Voyager 1", new List<string>{ "Earth", "Jupiter", "Saturn"} },
                { "Voyager 2", new List<string>{ "Earth", "Jupiter", "Saturn", "Uranus", "Neptune"} },
                { "Mariner 3", new List<string>{ "Mars"} },
                { "Mariner 4", new List<string>{ "Mars"} },
                { "Mariner 6", new List<string>{ "Mars"} },
                { "Mariner 7", new List<string>{ "Mars"} },
                { "New Horizons", new List<string>{ "Jupiter", "Pluto"} }
            };

            foreach (string planet in combinedPlanetList)
            {
                var visitedProbe = new List<string>();

                foreach (var probe in probes)
                {
                    if (probe.Value.Contains(planet))
                    {
                        visitedProbe.Add(probe.Key);

                    }
                }
                string visitedProbes = string.Join(", ", visitedProbe);
                Console.WriteLine($"{planet}: {visitedProbes}");
            }



            Console.ReadLine();
        }
    }
}
