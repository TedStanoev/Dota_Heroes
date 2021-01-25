using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Heroes.Mediator
{
    public class ConcreteMediator : IMediator
    {
        private IComponent heroRepository;
        private IComponent heroCreator;
        public ConcreteMediator (IComponent heroRepository, IComponent heroCreator)
        {
            this.heroRepository = heroRepository;
            this.heroCreator = heroCreator;
        }
        public void Notify(object component, string function)
        {
            throw new NotImplementedException();
        }
    }
}
