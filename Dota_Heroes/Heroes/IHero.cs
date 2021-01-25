using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Heroes.Heroes
{
    public interface IHero
    {
        public string ShowHeroCounters();

        public string ShowCounters();

        public void Counters(Hero hero);

        public void IsCounteredBy(Hero hero);
    }
}
