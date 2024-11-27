namespace Bridge
{
    public abstract class Remote
    {
        protected ITV _tv { get; }

        public Remote(ITV tv)
        {
            _tv = tv;
        }

        public virtual void TurnOn()
        {
            _tv.WorkStatus(true);
        }

        public virtual void TurnOff()
        {
            _tv.WorkStatus(false);
        }

        public virtual void SetChannel(int number)
        {
            _tv.SetChannel(number);
        }
    }
}
