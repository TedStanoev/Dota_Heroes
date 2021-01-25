using Dota_Heroes.Heroes;
using Dota_Heroes.HeroFactory;
using Dota_Heroes.Repository;
using System;
using System.Collections.Generic;

namespace Dota_Heroes
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IHeroRepository heroRepository = new HeroRepository();
            IHeroCreator heroCreator = new HeroCreator(heroRepository);

            while (true)
            {
                WelcomeScreen();
                string command = Console.ReadLine();

                if (command == "1")
                {
                    try
                    {
                        Console.WriteLine("Type hero's name:");
                        string heroName = Console.ReadLine();
                        heroCreator.CreateHero(heroName);
                        Console.WriteLine($"Hero {heroName} has been created!");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("This hero is already created!");
                    }

                }
                else if (command == "2")
                {
                    Console.WriteLine("Type hero's name:");
                    string heroName = Console.ReadLine();

                    try
                    {
                        Hero hero = heroRepository.FindHero(heroName);
                        string showHeroInfo = $"This hero is good against: {hero.ShowCounters()}{Environment.NewLine}" +
                            $"This hero is worst against: {hero.ShowHeroCounters()}{Environment.NewLine}";
                        Console.WriteLine(showHeroInfo);
                    }
                    catch (KeyNotFoundException)
                    {
                        Console.WriteLine("This hero doesn't exist!");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("This hero doesn't have any counters!");
                    }
                    
                }
                else if (command == "3")
                {
                    try
                    {
                        Console.WriteLine("Type hero's name:");
                        string heroName = Console.ReadLine();
                        Hero hero = heroRepository.FindHero(heroName);

                        Console.WriteLine("Type the counter's name:");
                        string counterHeroName = Console.ReadLine();                        
                        Hero counterHero = heroRepository.FindHero(counterHeroName);

                        hero.IsCounteredBy(counterHero);

                    }
                    catch (KeyNotFoundException)
                    {
                        Console.WriteLine("This hero doesn't exist!");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                }
            }
        }

        static void WelcomeScreen()
        {            
            string welcomeText = $"Hello and welcome to dota 2 heroes! Type the number of a command...{Environment.NewLine}1. Create a hero{Environment.NewLine}" +
                $"2. Show hero's counters{Environment.NewLine}" +
                $"3. Add a counter to a hero{Environment.NewLine}";
            Console.Write(welcomeText);
        
        }

    }
}
