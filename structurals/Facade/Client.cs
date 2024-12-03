using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Client
    {
        public void Facade()
        {
            var gosha = new FrontendDev();
            var yan = new BackendDev();
            var dmitry = new Designer();

            Manager VasiliyIvanovich = new Manager(gosha, yan, dmitry);

            VasiliyIvanovich.AddButton();
            VasiliyIvanovich.FixUI();
            VasiliyIvanovich.FixBugs();
        }
    }
}
