using Dota_Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Heroes.HeroFactory
{
    public interface IHeroCreator
    {
        public Hero CreateHero(string name);

    }
}
