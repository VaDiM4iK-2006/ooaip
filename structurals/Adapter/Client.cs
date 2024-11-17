using Adapter.Duck;
using Adapter.Frog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Client
    {
        public void Intruder()
        {
            List<IDuck> MyDuckCollection = new List<IDuck>();

            IDuck Vitya = new WhiteDuck();
            MyDuckCollection.Add(Vitya);

            IDuck Rustambek = new GrayDuck();
            MyDuckCollection.Add(Rustambek);

            IFrog Gregory = new GreenFrog();
            IDuck GregoryNEO = new FrogToDuckAdapter(Gregory);
            MyDuckCollection.Add(GregoryNEO);

            IDuck Nina = new WhiteDuck();
            MyDuckCollection.Add(Nina);

            foreach (var duck in MyDuckCollection)
            {
                Console.WriteLine(duck.Quack());
            }
        }
    }
}
