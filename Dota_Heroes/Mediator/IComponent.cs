using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Heroes.Mediator
{
    public interface IComponent
    {
        public void SetMediator(IMediator mediator);
    }
}
