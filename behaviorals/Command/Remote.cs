using Command.Commands;
using Command.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command
{
    public class Remote
    {
        private List<Commands.ICommand[]> _commandСollection;
        private Commands.ICommand[] _lastCommand = null;
        public Remote()
        {
            Light light = new Light();
            Teapot teapot = new Teapot();
            Acoustics acoustics = new Acoustics();
            Projector projector = new Projector();
            Screen screen = new Screen();
            Cinema cinema = new Cinema(acoustics, projector, screen);
            
            LightCommand lightCommand = new LightCommand(light);
            TeapotCommandOn teapotCommandOn = new TeapotCommandOn(teapot);
            TeapotCommandOff teapotCommandOff = new TeapotCommandOff(teapot);
            AcousticsCommand acousticsCommand = new AcousticsCommand(acoustics);
            ProjectorCommand projectorCommand = new ProjectorCommand(projector);
            ScreenCommand screenCommand = new ScreenCommand(screen);

            _commandСollection = new List<Commands.ICommand[]>          //оно путает ICommand с каким-то встроенным
            {
                new Commands.ICommand[] { lightCommand },
                new Commands.ICommand[] { teapotCommandOn, teapotCommandOff },
                new Commands.ICommand[] { acousticsCommand, projectorCommand, screenCommand }
            };
        }

        void On(int num)
        {
            if (num < 0 && num > _commandСollection.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            _lastCommand = _commandСollection[num];
            if (num != 1)
            {
                foreach (var command in _commandСollection[num])
                {
                    command.Execute();
                }
            }
            else
            {
                _commandСollection[num][0].Execute();
                _lastCommand = [_commandСollection[num][0]];
            }
        }

        void Off(int num)
        {
            if (num < 0 && num > _commandСollection.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            _lastCommand = _commandСollection[num];
            if (num != 1)
            {
                foreach (var command in _commandСollection[num])
                {
                    command.Execute();
                }
            }
            else
            {
                _commandСollection[num][1].Execute();
                _lastCommand = [_commandСollection[num][1]];
            }
        }

        void Undo() 
        {
            if (_lastCommand != null)
            {
                throw new ArgumentNullException();
            }
            foreach (var command in _lastCommand)
            {
                command.Undo();
            }
        }
    }
}
