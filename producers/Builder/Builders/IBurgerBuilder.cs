using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public interface IBurgerBuilder
    {
        void AddMeat();
        void AddSalad();
        void AddPickles();
        void AddTomato();
        void AddBacon();
        void AddSauce();
        void AddCheese();
        void AddOnion();
        void AddVobla();
    }
}