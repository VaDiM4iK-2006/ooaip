using Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class TeapotCommandOff : ICommand
    {
        private readonly Teapot _teapot;

        public TeapotCommandOff(Teapot teapot)
        {
            _teapot = teapot == null ? throw new ArgumentNullException() : teapot;
        }

        public void Execute()
        {
            _teapot.Off();
        }
    }
}
