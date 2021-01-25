using System;
using System.Collections.Generic;
using System.Text;

namespace Dota_Heroes.Mediator
{
    public interface IMediator
    {
        public void Notify(object component, string function);
    }
}
