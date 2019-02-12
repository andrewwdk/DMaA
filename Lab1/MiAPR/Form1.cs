using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MiAPR
{ 
    public partial class Form1 : Form
    {
        const int lowCountOfClasses = 2; //минимальное количество классов
        const int highCountOfClasses = 20; //максимальное количество классов
        const int lowCountOfImages = 1000; //минимальное количество образов
        const int highCountOfImages = 20000; //максимальное количество образов

        public Form1()
        {
            InitializeComponent();
        }

        //блокировка элементов интерфейса
        private void UnenableControls()
        {
            classTextBox.Enabled = false;
            imageTextBox.Enabled = false;
            drawButton.Enabled = false;
        }

        //разблокировка элементов управления
        private void EnableControls()
        {
            classTextBox.Enabled = true;
            imageTextBox.Enabled = true;
            drawButton.Enabled = true;
        }

        private bool IsKernelExist( List<Point> list, Point point)
        {
            bool result = false;

            foreach(Point kernel in list)
            {
                if(kernel.X==point.X && kernel.Y == point.Y)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        //Генерирование всех образов
        private List<Point> RandomizeListOfPoints(int countOfPoints)
        {
            List<Point> list = new List<Point>();
            Random rand = new Random();
           
            for(int i = 0; i<countOfPoints; i++)
            {
                Point point = new Point();

                point.IsKernel = false;
                point.X = rand.Next(0, backgroundPicture.Width / 3 - 1);
                point.Y = rand.Next(0, backgroundPicture.Height / 3 - 1);

                list.Add(point);
            }

            return list;
        }

        //Инициализация групп
        private List<List<Point>> MakeListOfGroups(int countOfGroups)
        {
            List<List<Point>> list = new List<List<Point>>();
            
            for(int i = 0; i < countOfGroups; i++)
            {
                List<Point> group = new List<Point>();
                list.Add(group);
            }

            return list;
        }

        private void RandomizeKernels(ref List<List<Point>> listOfGroups, List<Point> listOfImages)
        {
            List<Point> listOfKernels = new List<Point>();
            Random random = new Random();
            int index;

            foreach(List<Point> group in listOfGroups)
            {
                do
                {
                    index = random.Next(0, listOfImages.Count - 1);
                }
                while (IsKernelExist(listOfKernels, listOfImages[index]));

                group.Add(listOfImages[index]);
                group[0].IsKernel = true;
            }
        }

        private void DevideIntoGroups(ref List<List<Point>> listOfGroups, List<Point> listOfPoints)
        {
            double dist, currentDist;
            int numberOfGroup, currentNumberOfGroup;

            foreach (List<Point> group in listOfGroups)
            {
                group.RemoveRange(1, group.Count - 1);
            }

                foreach (Point point in listOfPoints)
            {
                if (!point.IsKernel)
                {
                    currentNumberOfGroup = 0;
                    dist = 1000;
                    numberOfGroup = 0;

                    foreach (List<Point> group in listOfGroups)
                    {
                        currentDist = Math.Sqrt((group[0].X - point.X) * (group[0].X - point.X) + (group[0].Y - point.Y) * (group[0].Y - point.Y));

                        if(currentDist < dist)
                        {
                            dist = currentDist;
                            numberOfGroup = currentNumberOfGroup;
                        }

                        currentNumberOfGroup++;
                    }

                    listOfGroups[numberOfGroup].Add(point);
                }
            }
        }

        private Brush[] MakeListOfBrushes(int countOfClasses)
        {
            Brush[] list = new Brush[20]{ new SolidBrush(Color.Red), new SolidBrush(Color.Yellow), new SolidBrush(Color.Blue), new SolidBrush(Color.Brown),
                                    new SolidBrush(Color.Green), new SolidBrush(Color.Gold), new SolidBrush(Color.Gray),new SolidBrush(Color.Violet),
                                    new SolidBrush(Color.Pink),new SolidBrush(Color.Lime),new SolidBrush(Color.Navy),new SolidBrush(Color.Orange),
                                    new SolidBrush(Color.Teal),new SolidBrush(Color.SpringGreen),new SolidBrush(Color.Plum),new SolidBrush(Color.Orchid),
                                    new SolidBrush(Color.Moccasin),new SolidBrush(Color.Turquoise),new SolidBrush(Color.Khaki),new SolidBrush(Color.Indigo)};

            return list;
        }

        private void DrawPoints(List<List<Point>> listOfGroups, Brush[] listOfBrushes, int countOfClasses)
        {

            Graphics graphics = backgroundPicture.CreateGraphics();
            graphics.Clear(Color.White);
            int currentNumberOfGroup = 0;

            foreach(List<Point> list in listOfGroups)
            {
                for(int i = 1; i < list.Count; i++)
                {
                   // graphics.FillRectangle(listOfBrushes[currentNumberOfGroup], 3 * list[i].X, 3 * list[i].Y, 3, 3);
                    graphics.FillRectangle(listOfBrushes[currentNumberOfGroup], 3 * list[i].X, 3 * list[i].Y, 3, 3);
                }

                graphics.FillRectangle(new SolidBrush(Color.Black), 3 * list[0].X - 4, 3 * list[0].Y - 4, 8, 8);
                
                currentNumberOfGroup++;
            }
        }

        private bool IsKernelsChanged(ref List<List<Point>> listOfGroups, List<Point> listOfPoint)
        {
            bool result = false;
            int currentIndexOfKernel;
            double currentMaxDistanceToKernelFromPoint, minDistanceToKernelFromFarrestPoint, distance;
            Point temp;

            foreach(List<Point> group in listOfGroups)
            {
                minDistanceToKernelFromFarrestPoint = 1000;
                currentIndexOfKernel = 0;

                for(int i=0; i < group.Count; i++)
                {
                    currentMaxDistanceToKernelFromPoint = 0;

                    for(int j=0; j < group.Count; j++)
                    {
                        distance = Math.Sqrt((group[j].X - group[i].X) * (group[j].X - group[i].X) + (group[j].Y - group[i].Y) * (group[j].Y - group[i].Y));

                        if (distance > currentMaxDistanceToKernelFromPoint)
                        {
                            currentMaxDistanceToKernelFromPoint = distance;
                        }
                    }

                    if(currentMaxDistanceToKernelFromPoint < minDistanceToKernelFromFarrestPoint)
                    {
                        minDistanceToKernelFromFarrestPoint = currentMaxDistanceToKernelFromPoint;
                        currentIndexOfKernel = i;
                        if (i != 0)
                        {
                            result = true;
                        }
                    }
                }

                if(currentIndexOfKernel != 0)
                {
                    group[0].IsKernel = false;
                    group[currentIndexOfKernel].IsKernel = true;
                    temp = group[0];
                    group[0] = group[currentIndexOfKernel];
                    group[currentIndexOfKernel] = temp;
                }
            }

            return result;
        }


        private void drawButton_Click(object sender, EventArgs e)
        {
            int countOfClasses, countOfImages; //количество классов и образов, выбранных пользователем
            List<Point> listOfPoints; // список всех образов, которые генерируются случайным образом
            List<List<Point>> listOfGroups; //список групп образов

            Brush[] listOfBrushes; //список ручек с разными цветами

            stateLabel.Text = "";

            if (classTextBox.Text != "" && imageTextBox.Text != "")
            {
                countOfClasses = Convert.ToInt32(classTextBox.Text);

                //проверка на корректность значения количества классов
                if (countOfClasses >= lowCountOfClasses && countOfClasses <= highCountOfClasses)
                {
                    countOfImages = Convert.ToInt32(imageTextBox.Text);

                    //проверка на корректность значения количества образов
                    if (countOfImages >= lowCountOfImages && countOfImages <= highCountOfImages)
                    {
                        UnenableControls();
                        listOfBrushes = MakeListOfBrushes(countOfClasses);

                        listOfPoints = RandomizeListOfPoints(countOfImages);
                        listOfGroups = MakeListOfGroups(countOfClasses);
                        RandomizeKernels(ref listOfGroups, listOfPoints);

                        int count = 0;

                        do
                        {
                            DevideIntoGroups(ref listOfGroups, listOfPoints);
                            DrawPoints(listOfGroups, listOfBrushes, countOfClasses);
                            count++;
                        } while (IsKernelsChanged(ref listOfGroups, listOfPoints));

                        stateLabel.Text = count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please, enter the count of images in the range of 1000 to 100000");
                    }
                }
                else
                {
                    MessageBox.Show("Please, enter the count of classes in the range of 2 to 20");
                }

                EnableControls();
            }
            else
            {
                MessageBox.Show("Fields can't be empty!");
            }
        }
    }
}
