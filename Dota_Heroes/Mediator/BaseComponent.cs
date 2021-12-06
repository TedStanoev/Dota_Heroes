namespace Dota_Heroes.Mediator
{
    public abstract class BaseComponent : IComponent
    {
        protected IMediator mediator;
        protected BaseComponent(IMediator mediator)
        {
            this.SetMediator(mediator);
        }
        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
