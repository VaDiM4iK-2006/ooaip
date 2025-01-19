using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class LightCommand : ICommand
    {
        private readonly Light _light;

        public LightCommand(Light light)
        {
            _light = light == null ? throw new ArgumentNullException() : light;
        }

        public void Execute()
        {
            _light.OnOff();
        }
    }
}
