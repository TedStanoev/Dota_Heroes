using Dota_Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Heroes.Repository
{
    public interface IHeroRepository
    {
        public void AddNewHero(Hero hero);

        public void RemoveHero();

        public Hero FindHero(string heroName);

        public void EditHeroName(Hero hero, string newHeroName);
    }
}
