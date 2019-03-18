using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    struct Names
    {
        public string name;
        public int X;
        public int Y;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int objectsCount;
            Graphics g = hierarchyPictureBox.CreateGraphics();
            g.Clear(Color.White);

            g.DrawLine(Pens.Black, 40, hierarchyPictureBox.Height - 40, 450, hierarchyPictureBox.Height - 40);
            g.DrawLine(Pens.Black, 40, hierarchyPictureBox.Height - 40, 40, hierarchyPictureBox.Height - 360);

            if (int.TryParse(objectsCountTextBox.Text, out objectsCount) && objectsCount < 11 && objectsCount > 2)
            {
                double[,] distanceTable = Functions.RandomizeDistanceTable(objectsCount);
                //double[,] distanceTable = new double[,] { {0, 5, 0.5, 2}, {5, 0, 1, 0.6}, {0.5, 1, 0, 2.5}, {2, 0.6, 2.5, 0} };
                List <Names> names = Functions.SetNames(objectsCount);

                double minValue;
                int firstObjIndex, secondObjIndex, height;

                while (distanceTable.GetLength(0) > 1)
                {
                    minValue = Functions.FindMinValue(distanceTable, out firstObjIndex, out secondObjIndex);
                    distanceTable = Functions.JoinObjects(distanceTable,firstObjIndex, secondObjIndex);
                    Functions.ChangeDistances(names, firstObjIndex, secondObjIndex);

                    height = Math.Max(hierarchyPictureBox.Height - (names[firstObjIndex].Y + (int)(minValue * 100)),
                        hierarchyPictureBox.Height - (names[secondObjIndex].Y + (int)(minValue * 100)));

                    g.DrawLine(Pens.Black, names[firstObjIndex].X, hierarchyPictureBox.Height - names[firstObjIndex].Y,
                        names[firstObjIndex].X, height);
                    g.DrawLine(Pens.Black, names[secondObjIndex].X, hierarchyPictureBox.Height - names[secondObjIndex].Y,
                        names[secondObjIndex].X, height);
                    g.DrawLine(Pens.Black, names[firstObjIndex].X, height,
                        names[secondObjIndex].X, height);

                    g.DrawString(names[firstObjIndex].name, SystemFonts.DefaultFont, Brushes.Black, names[firstObjIndex].X - 2,
                       hierarchyPictureBox.Height - names[firstObjIndex].Y + 10);
                    g.DrawString(names[secondObjIndex].name, SystemFonts.DefaultFont, Brushes.Black, names[secondObjIndex].X - 2,
                       hierarchyPictureBox.Height - names[secondObjIndex].Y + 5);

                    g.DrawString(minValue.ToString(), SystemFonts.DefaultFont, Brushes.Black, 2,
                       hierarchyPictureBox.Height - (40 + (int)(minValue * 100)));

                    Functions.ChangeNames(names, firstObjIndex, secondObjIndex, minValue);
                }

                g.DrawString(names[0].name, SystemFonts.DefaultFont, Brushes.Black, names[0].X - 2,
                       hierarchyPictureBox.Height - names[0].Y + 5);
            }
            else
            {
                MessageBox.Show("Please, enter count of objects in range between 3 to 10");
            }
        }
    }
}
