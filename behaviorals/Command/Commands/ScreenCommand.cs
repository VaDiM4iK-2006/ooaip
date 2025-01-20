using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Receivers;

namespace Command.Commands
{
    public class ScreenCommand : ICommand
    {
        private readonly Screen _screen;

        public ScreenCommand(Screen screen)
        {
            _screen = screen == null ? throw new ArgumentNullException() : screen;
        }

        public void Execute()
        {
            _screen.UpDown();
        }

        public void Undo()
        {
            _screen.UpDown();
        }
    }
}
