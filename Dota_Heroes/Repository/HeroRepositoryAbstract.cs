using Dota_Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Heroes.Repository
{
    public abstract class HeroRepositoryAbstract : IHeroRepository
    {
        protected Dictionary<string, IHero> allHeroes;
        public HeroRepositoryAbstract()
        {
            this.allHeroes = new Dictionary<string, IHero>();
        }
        public void AddNewHero(Hero hero)
        {
            allHeroes.Add(hero.Name, hero);
        }

        protected IHero FindHero(string name)
        {
            throw new NotImplementedException();
        }

        public void RemoveHero()
        {
            throw new NotImplementedException();
        }

        Hero IHeroRepository.FindHero(string heroName)
        {
            throw new NotImplementedException();
        }

        public void EditHeroName(Hero hero, string newHeroName)
        {
            throw new NotImplementedException();
        }
    }
}
