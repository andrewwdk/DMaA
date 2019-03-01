using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Vector
    {
        public int[] Elements { get; set; }

        public Vector(int size)
        {
            Elements = new int[size];
        }

        public static Vector operator* (int c, Vector v)
        {
            for (int i = 0; i < v.Elements.Length; i++)
                v.Elements[i] *= c;

            return v;
        }

        public static Vector operator* (Vector v, int c)
        {
            for (int i = 0; i < v.Elements.Length; i++)
                v.Elements[i] *= c;

            return v;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            for (int i = 0; i < v1.Elements.Length; i++)
                v1.Elements[i] += v2.Elements[i];

            return v1;
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            for (int i = 0; i < v1.Elements.Length; i++)
                v1.Elements[i] -= v2.Elements[i];

            return v1;
        }

        public static int operator *(Vector v1, Vector v2)
        {
            int sum = 0;

            for (int i = 0; i < v1.Elements.Length; i++)
                sum += v1.Elements[i] * v2.Elements[i];

            return sum;
        }

        public override string ToString()
        {
            return "(" + Elements[0].ToString() + ", " + Elements[1].ToString() + ")";
        }

        public string ToStringAsFunction()
        {
            return Elements[0].ToString() + "x1 + " + Elements[1].ToString() + "x2 + " + Elements[2].ToString();
        }
    }
}
