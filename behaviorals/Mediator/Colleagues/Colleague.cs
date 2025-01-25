namespace Mediator.Colleagues
{
    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator == null ? throw new ArgumentNullException() : mediator;
        }
    }
}
