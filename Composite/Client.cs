using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Client
    {
        void Tree()
        {
            Tree tree = new Tree();
            Composite branch1 = new Composite();
            Composite branch2 = new Composite();

            tree.Add(new Leaf(2));
            branch1.AddComponent(new Leaf(53));
            branch2.AddComponent(new Leaf(332));
            tree.Add(new Leaf(5));
            tree.Add(branch1);
            branch2.AddComponent(new Leaf(873));
            tree.Add(branch2);
            tree.Add(new Leaf(0));

            List<IEnumerable<double>> treeInfo = new List<IEnumerable<double>>();

            foreach (var value in tree)
            {
                treeInfo.Add(value.GetValue());
            }
        }
    }
}
