using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class ProjectorCommand : ICommand
    {
        private readonly Projector _projector;

        public ProjectorCommand(Projector projector)
        {
            _projector = projector == null ? throw new ArgumentNullException() : projector;
        }

        public void Execute()
        {
            _projector.OnOff();
        }
    }
}
