using System.Collections;
using System.Xml.Linq;

namespace Composite
{
    public class Tree : IEnumerable<IComponent>
    {
        class Node
        {
            public IComponent Value { get; set; }
            public Node? Left { get; set; }
            public Node? Right { get; set; }
            public Node(IComponent val)
            {
                Value = val;
                Left = Right = null;
            }
        }

        Node root = null;

        internal int count { get; private set; }

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
                var currValue = current.Value.GetValue().First();
                var newValue = val.GetValue().First();

                if (currValue < newValue)
                {
                    if (current.Left == null)
                    {
                        current.Left = new Node(val);
                        return;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = new Node(val);
                        return;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        private IEnumerable<IComponent> LRR(Node t)
        {
            if (t != null)
            {
                foreach (var left in LRR(t.Left))
                {
                    yield return left;
                }

                yield return t.Value;

                foreach (var right in LRR(t.Right))
                {
                    yield return right;
                }
            }
        }

        public IEnumerator<IComponent> GetEnumerator()
        {
            return LRR(root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

