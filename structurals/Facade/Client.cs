using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Client
    {
        void Facade()
        {
            FrontendDev Gosha = new FrontendDev();
            BackendDev Yan = new BackendDev();
            Designer Dmitry = new Designer();

            Manager Vasiliy_Ivanovich = new Manager(Gosha, Yan, Dmitry);

            Vasiliy_Ivanovich.AddButton();
            Vasiliy_Ivanovich.FixUI();
            Vasiliy_Ivanovich.FixBugs();
        }
    }
}
