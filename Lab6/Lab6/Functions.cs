using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Functions
    {
        static public double[,] RandomizeDistanceTable(int objectsCount)
        {
            double[,] distanceTable = new double[objectsCount, objectsCount];
            Random rand = new Random();

            for (int i = 0; i < objectsCount; i++)
                for (int j = i; j < objectsCount; j++)
                {
                    distanceTable[i, j] = i == j ? 0 : (double)rand.Next(1, 30) / 10;
                    distanceTable[j, i] = distanceTable[i, j];
                }

            return distanceTable;
        }

        static public List<Names> SetNames(int objectsCount)
        {
            List<Names> names = new List<Names>();

            for (int i = 1; i <= objectsCount; i++)
            {
                Names n = new Names();
                n.name = "x" + i.ToString();
                n.X = 40;
                n.Y = 40;
                names.Add(n);
            }

            return names;
        }

        static public double FindMinValue(double[,] distanceTable, out int firstObjIndex, out int secondObjIndex)
        {
            double minValue = double.MaxValue;
            firstObjIndex = secondObjIndex = 0;

            for (int i = 0; i < distanceTable.GetLength(0); i++)
                for (int j = i + 1; j < distanceTable.GetLength(0); j++)
                {
                    if (distanceTable[i, j] < minValue)
                    {
                        minValue = distanceTable[i, j];
                        firstObjIndex = i;
                        secondObjIndex = j;
                    }
                }

            return minValue;
        }

        static public double[,] JoinObjects(double[,] distanceTable, int firstObjIndex, int secondObjIndex)
        {
            double[,] newDistTable = new double[distanceTable.GetLength(0) - 1, distanceTable.GetLength(0) - 1];
            int currI = 0;
            int currJ = 0;

            for (int i = 0; i < distanceTable.GetLength(0); i++)
            {
                if (i != firstObjIndex && i != secondObjIndex)
                {
                    for (int j = i; j < distanceTable.GetLength(0); j++)
                    {
                        if (j != firstObjIndex && j != secondObjIndex)
                        {
                            newDistTable[currI, currJ] = distanceTable[i, j];
                            newDistTable[currJ, currI] = distanceTable[j, i];
                            currJ++;
                        }
                    }
                    currI++;
                    currJ = currI;
                }
            }

            currI = 0;
            currJ = newDistTable.GetLength(0) - 1;

            for (int i = 0; i < distanceTable.GetLength(0); i++)
            {
                if (i != firstObjIndex && i != secondObjIndex)
                {
                    newDistTable[currI, currJ] = Math.Min(distanceTable[i, firstObjIndex], distanceTable[i, secondObjIndex]);
                    newDistTable[currJ, currI] = newDistTable[currI, currJ];
                    currI++;
                }
            }

            newDistTable[newDistTable.GetLength(0) - 1, newDistTable.GetLength(0) - 1] = 0;

            return newDistTable;
        }

        static public void ChangeNames(List<Names> names, int first, int second, double minValue)
        {
            string last = names.Last().name;
            Names n = new Names();

            if (last.Contains("x"))
            {
                n.name = "a";
            }
            else
            {
                n.name = Convert.ToChar((Convert.ToChar(last) + 1)).ToString();
            }

            n.X = names[first].X + (names[second].X - names[first].X) / 2;
            n.Y = 40 + (int)(minValue * 100);
            names.Add(n);

            names.RemoveAt(second);
            names.RemoveAt(first);
        }

        static public void ChangeDistances(List<Names> names, int first, int second)
        {
            if (names[first].name.Contains("x") || names[second].name.Contains("x"))
            {
                for(int i = 0; i < names.Count; i++)
                {
                    if (names[i].name.Contains("x"))
                    {
                        Names n = new Names();
                        n.name = names[i].name;

                        if (i == first)
                        {
                            n.X = names[i].X + 40;
                        }
                        else
                        {
                            n.X = names[i].X + 80;
                        }
                        n.Y = names[i].Y;
                        names[i] = n;
                    }  
                }
            }
        }
    }
}
