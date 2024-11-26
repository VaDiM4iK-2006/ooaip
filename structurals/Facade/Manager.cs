namespace Facade
{
    public class Manager
    {
        protected FrontendDev _frontender;
        protected BackendDev _backender;
        protected Designer _designer;

        public Manager(FrontendDev frontender, BackendDev backender, Designer designer)
        {
            if (frontender == null || backender == null || designer == null) 
            { throw new ArgumentNullException(); }
            _frontender = frontender;
            _backender = backender;
            _designer = designer;
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
