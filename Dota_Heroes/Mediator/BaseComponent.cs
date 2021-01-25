using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Heroes.Mediator
{
    public abstract class BaseComponent : IComponent
    {
        protected IMediator mediator;
        protected BaseComponent(IMediator mediator = null)
        {
            this.mediator = mediator;
        }
        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
