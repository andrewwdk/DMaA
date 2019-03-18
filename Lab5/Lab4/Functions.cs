using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Functions
    {
        public static Vector[] RandomizeImages(int imageCount, int bottomRange, int topRange)
        {
            Random rand = new Random();
            Vector[] vectors = new Vector[imageCount];

            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new Vector(2);

                for (int j = 0; j < 2; j++)
                {
                    vectors[i].Elements[j] = rand.Next(bottomRange, topRange);
                }
            }
            return vectors;
        }

        public static double GetX2(int x1, Vector k)
        {
            double x2 = k.Elements[0] + k.Elements[1] * x1;
            x2 /= (k.Elements[2] + k.Elements[3] * x1);
            return -1*x2;
        }

        public static bool CheckAll(Vector[] x, Vector k)
        {
            if (GetSum(x[0], k) > 0 && GetSum(x[1], k) > 0 && GetSum(x[2], k) <= 0 && GetSum(x[3], k) <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetSum(Vector learningPoint, Vector k)
        {
            int sum = k.Elements[0] + k.Elements[1] * learningPoint.Elements[0] + k.Elements[2] * learningPoint.Elements[1] +
                k.Elements[3] * learningPoint.Elements[0] * learningPoint.Elements[1];

            return sum;
        }

        public static Vector FindK(Vector learningPoint)
        {
            Vector k = new Vector(4);

            k.Elements[0] = 1;
            k.Elements[1] = 4 * learningPoint.Elements[0];
            k.Elements[2] = 4 * learningPoint.Elements[1];
            k.Elements[3] = 16 * learningPoint.Elements[0] * learningPoint.Elements[1];

            return k;
        }
    }
}
