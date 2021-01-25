using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Dota_Heroes.Heroes
{
    public class Hero : IHero
    {
        private List<Hero> heroCounters;
        private List<Hero> counters;

        public Hero(string name)
        {
            this.Name = name;
            this.heroCounters = new List<Hero>();
            this.counters = new List<Hero>();
        }

        public string Name { get; protected set; }

        public void Counters(Hero hero)
        {
            this.counters.Add(hero);
        }

        public void IsCounteredBy(Hero hero)
        {
            if (heroCounters.Contains(hero))
            {
                throw new ArgumentException($"{this.Name} is already countered by {hero.Name}!");
            }
            else if (counters.Contains(hero))
            {
                throw new ArgumentException($"{this.Name} already counters {hero.Name}!");
            }

            this.heroCounters.Add(hero);
            hero.Counters(this);
        }

        public string ShowCounters()
        {
            return string.Join(", ", this.counters.Select(c => c.Name));
        }

        public string ShowHeroCounters()
        {
            return string.Join(", ", this.heroCounters.Select(c => c.Name));
        }
    }
}
