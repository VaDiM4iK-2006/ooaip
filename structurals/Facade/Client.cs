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
            var Gosha = new FrontendDev();
            var Yan = new BackendDev();
            var Dmitry = new Designer();

            Manager VasiliyIvanovich = new Manager(Gosha, Yan, Dmitry);

            VasiliyIvanovich.AddButton();
            VasiliyIvanovich.FixUI();
            VasiliyIvanovich.FixBugs();
        }
    }
}
