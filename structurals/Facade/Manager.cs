namespace Facade
{
    public class Manager
    {
        protected FrontendDev _frontender { get; }
        protected BackendDev _backender { get; }
        protected Designer _designer { get; }

        public Manager(FrontendDev frontender, BackendDev backender, Designer designer)
        {
            _frontender =  frontender == null ? throw new ArgumentNullException() : frontender;
            _backender = backender == null ? throw new ArgumentNullException() : backender;
            _designer = designer == null ? throw new ArgumentNullException() : designer;
        }

        public void AddButton()
        {   
            _frontender.Develop();
            _backender.Develop();
            _designer.Design();
        }

        public void FixUI()
        {   
            _frontender.Fix();
            _designer.Redesign();
        }

        public void FixBugs()
        {
            _backender.Fix();
        }
    }
}
