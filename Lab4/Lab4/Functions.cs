using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Functions
    {
        public static Vector[] RandomizeLearningImages(int classCount, int signsCount, int bottomRange, int topRange)
        {
            Random rand = new Random();
            Vector[] vectors = new Vector[classCount];

            for(int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new Vector(signsCount + 1);

                for(int j=0; j < signsCount; j++)
                {
                    vectors[i].Elements[j] = rand.Next(bottomRange, topRange);
                }

                vectors[i].Elements[signsCount] = 1;
            }

            return vectors;
        }

        public static Vector[] InitializeClassesWeightVectors(int classCount, int signsCount)
        {
            Vector[] vectors = new Vector[classCount];

            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = new Vector(signsCount + 1);

                for (int j = 0; j <= signsCount; j++)
                {
                    vectors[i].Elements[j] = 0;
                }
            }

            return vectors;
        }

        public static bool IfNumberBiggestAtIndex(int[] arr, int index, out List<int> falseClaseIndexesList)
        {
            bool result = true;
            int value = arr[index];
            falseClaseIndexesList = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(i != index)
                {
                    if(value <= arr[i])
                    {
                        result = false;
                        falseClaseIndexesList.Add(i);
                    }

                }
            }

            return result;
        }

        public static Vector[] DoPanishment(int classIndex, List<int> falseClassIndexesList, int c, Vector[] weights, Vector learningImage)
        {
            weights[classIndex] = weights[classIndex] + c * learningImage;

            foreach(int i in falseClassIndexesList)
                 weights[i] = weights[i] - c * learningImage;

            return weights;
        }
    }
}
