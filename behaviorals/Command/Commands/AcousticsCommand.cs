using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class AcousticsCommand : ICommand
    {
        private readonly Acoustics _acoustics;

        public AcousticsCommand(Acoustics acoustics)
        {
            _acoustics = acoustics == null ? throw new ArgumentNullException() : acoustics;
        }

        public void Execute()
        {
            _acoustics.OnOff();
        }
    }
}
