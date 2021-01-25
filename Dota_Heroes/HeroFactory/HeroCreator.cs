using Dota_Heroes.Heroes;
using Dota_Heroes.Mediator;
using Dota_Heroes.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Heroes.HeroFactory
{
    public class HeroCreator : BaseComponent, IHeroCreator
    {
        private IMediator mediator;
        private IHeroRepository heroRepository;
        public HeroCreator(IHeroRepository heroRepository, IMediator mediator = null) : base()
        {
            this.heroRepository = heroRepository;
        }

        private void AddToRepository(Hero hero)
        {
            heroRepository.AddNewHero(hero);
        }

        public Hero CreateHero(string name)
        {
            Hero hero = new Hero(name);
            this.AddToRepository(hero);

            return hero;
        }


    }
}
