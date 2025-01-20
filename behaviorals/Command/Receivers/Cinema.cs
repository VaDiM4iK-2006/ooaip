using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receivers
{
    public class Cinema
    {
        protected Acoustics _acoustics { get; }
        protected Projector _projector { get; }
        protected Screen _screen {  get; }

        private bool state = false;

        public Cinema(Acoustics acoustics, Projector projector, Screen screen)
        {
            _acoustics = acoustics == null ? throw new ArgumentNullException() : acoustics;
            _projector = projector == null ? throw new ArgumentNullException() : projector;
            _screen = screen == null ? throw new ArgumentNullException() : screen;
        }

        public void OnOff()
        {
            state = !state;
            _acoustics.OnOff();
            _projector.OnOff();
            _screen.UpDown();
        }
    }
}
