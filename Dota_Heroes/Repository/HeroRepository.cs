using Dota_Heroes.Mediator;
using Dota_Heroes.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Heroes.Heroes
{
    public class HeroRepository : BaseComponent, IHeroRepository
    {
        private Dictionary<string, Hero> allHeroes;

        public HeroRepository(IMediator mediator) : base()
        {

        }
        public HeroRepository()
        {
            this.allHeroes = new Dictionary<string, Hero>();
        }

        public void AddNewHero(Hero hero)
        {
            allHeroes.Add(hero.Name, hero);
        }

        public Hero FindHero(string name)
        {
            return allHeroes[name];
        }

        public void RemoveHero()
        {
            throw new NotImplementedException();
        }

        public void SetMediator(IMediator mediator)
        {
            
        }
    }
}
