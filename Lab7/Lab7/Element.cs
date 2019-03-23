using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Element
    {
        public string Name { get; }
        public int X { get; }
        public int Y { get; }
        public Element FirstChild { get; }
        public Element SecondChild { get; }

        public Element(string name, int x, int y, Element firstChild, Element secondChild)
        {
            Name = name;
            X = x;
            Y = y;
            FirstChild = firstChild;
            SecondChild = secondChild;
        }
    }
}
