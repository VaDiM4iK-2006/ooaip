using System.Collections;
using System.Xml.Linq;

namespace Composite
{
    public class Tree : IEnumerable<IComponent>
    {
        class Node
        {
            public IComponent Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node(IComponent val)
            {
                Value = val;
                Left = Right = null;
            }
        }
        Node root = null;
        int count;
        internal int Count
        {
            get { return count; }
            private set { count = value; } 
        }
        public void Add(IComponent val)
        {
            count++;
            if (root == null)
            {
                root = new Node(val);
                return;
            }
            Node current = root;
            while (true)
            {
                double currValue = current.Value.GetValue().First();
                double newValue = val.GetValue().First();

                if (currValue < newValue)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node(val);
                        return;
                    }
                    else
                        current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node(val);
                        return;
                    }
                    else
                        current = current.Right;
                }
            }
        }

        private IEnumerable<IComponent> InOrderWalk(Node t)
        {
            if (t != null)
            {
                foreach (var left in InOrderWalk(t.Left))
                {
                    yield return left;
                }

                yield return t.Value;

                foreach (var right in InOrderWalk(t.Right))
                {
                    yield return right;
                }
            }
        }

        public IEnumerator<IComponent> GetEnumerator()
        {
            return InOrderWalk(root).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

