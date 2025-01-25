using Mediator.Colleagues;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Mediator
    {
        private Colleagues.Calendar _calendar;
        private Clock _clock;
        private CoffeeMachine _coffeeMachine;
        private IrrigationSystem _irrigationSystem;

        public Mediator(Colleagues.Calendar calendar, Clock clock, CoffeeMachine coffeeMachine, IrrigationSystem irrigationSystem)
        {
            _calendar = calendar == null ? throw new ArgumentNullException() : calendar;
            _clock = clock == null ? throw new ArgumentNullException() : clock;
            _coffeeMachine = coffeeMachine == null ? throw new ArgumentNullException() : coffeeMachine;
            _irrigationSystem = irrigationSystem == null ? throw new ArgumentNullException() : irrigationSystem;
        }

        void Notify(object sender, int time)
        {
            if (sender == "calendar" && time % 2 == 0)
            {
                _irrigationSystem.Irrigate();
            }

            if (sender == "clock" && time == 7)
            {
                _coffeeMachine.MakeCoffee();
            }
        }
    }
}
