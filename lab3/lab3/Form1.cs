using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        private const int countOfPoints = 10000;
        private const int startPoint = 0;
        private const int endPoint = 500;
        private const int graphicsDifference = 200;
        private const int scaling = 400; //масштабирование графиков
        private const double epsilon = 0.002;

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            double pc1 = Convert.ToDouble(pc1TextBox.Text);
            double pc2 = Convert.ToDouble(pc2TextBox.Text);
            Graphics graphics;

            if(pc1 + pc2 == 1)
            {
                graphics = pictureBoxForGraphics.CreateGraphics();
                Do(graphics, pc1, pc2);
            }
            else
            {
                MessageBox.Show("Sum of P(C1) and P(C2) doesn't equal 1! Please, enter correct numbers!");
            }
        }

        private void Do(Graphics graphics, double pc1, double pc2)
        {
            int[] points1 = new int[countOfPoints];
            int[] points2 = new int[countOfPoints];

            RandomizePoints(points1, points2);

            double m1 = FindM(points1);
            double m2 = FindM(points2);
            double sigma1 = FindSigma(points1, m1);
            double sigma2 = FindSigma(points2, m2);

            double[] pointsOfGraphic1 = FindPointsOfGraphic(m1, sigma1, pc1);
            double[] pointsOfGraphic2 = FindPointsOfGraphic(m2, sigma2, pc2);

            int intersectionPoint = FindIntersectionPoint(pointsOfGraphic1, pointsOfGraphic2);

            DrawGraphics(graphics, pointsOfGraphic1, pointsOfGraphic2, intersectionPoint);

            double error1 = pointsOfGraphic2.Take(intersectionPoint).Sum(); //ошибка ложной тревоги
            double error2 = pointsOfGraphic1.Skip(intersectionPoint).Sum();//ошибка пропуска обнаружения

           // double error1 = pointsOfGraphic2.Take(700).Sum(); //ошибка ложной тревоги
           // double error2 = pointsOfGraphic1.Take(700).Sum();//ошибка пропуска обнаружения

            falseAlarmLabel.Text = Math.Round(error1, 3).ToString();
            detectionSkipLabel.Text = Math.Round(error2, 3).ToString();
            summaryLabel.Text = Math.Round(error1 + error2, 3).ToString();

        }

        private void RandomizePoints(int[] points1, int[] points2)
        {
            Random random = new Random();

            for(int i = 0; i < countOfPoints; i++)
            {
                points1[i] = random.Next(startPoint, endPoint);
                points2[i] = random.Next(startPoint + graphicsDifference, endPoint + graphicsDifference);
            }
        }

        private double FindM(int[] points)
        {
            double m = 0;

            foreach (int point in points)
                m += point;

            return m / points.Length;
        }

        private double FindSigma(int[] points, double m)
        {
            double sigma = 0;

            foreach (int point in points)
                sigma += Math.Pow(point - m, 2);

            return Math.Sqrt(sigma / points.Length);
        }

        private double[] FindPointsOfGraphic(double m, double sigma, double pc)
        {
            double[] array = new double[pictureBoxForGraphics.Width];

            for (int x = 0; x < pictureBoxForGraphics.Width; x++)
                array[x] = (Math.Exp(-0.5 * Math.Pow((x - m) / sigma, 2)) / (sigma * Math.Sqrt(2 * Math.PI)) * pc);

            return array;
        }

        private int FindIntersectionPoint(double[] pointsOfGraphic1, double[] pointsOfGraphic2)
        {
            int intersectionPoint = 0;

            for (int x = 0; x < pictureBoxForGraphics.Width; x++)
                if (Math.Abs((pointsOfGraphic1[x] - pointsOfGraphic2[x]) * scaling) < epsilon)
                    intersectionPoint = x;

            return intersectionPoint;
        }

        private void DrawGraphics(Graphics graphics, double[] pointsOfGraphic1, double[] pointsOfGraphic2, int intersectionPoint)
        {
            graphics.Clear(Color.White);
            int curY1, nextY1, curY2, nextY2;

            graphics.DrawLine(Pens.Black, new Point(0, 399), new Point(700, 399));
            graphics.DrawLine(Pens.Black, new Point(680, 390), new Point(700, 399));
            graphics.DrawString("X", this.Font, Brushes.Black, new Point(670, 380));
            graphics.DrawLine(Pens.Black, new Point(0, 399), new Point(0, 0));
            graphics.DrawLine(Pens.Black, new Point(0, 0), new Point(10, 20));

            for (int x = 0; x < pictureBoxForGraphics.Width - 1; x++)
            {
                curY1 = pictureBoxForGraphics.Height - (int)(pointsOfGraphic1[x] * scaling * pictureBoxForGraphics.Height);
                nextY1 = pictureBoxForGraphics.Height - (int)(pointsOfGraphic1[x + 1] * scaling * pictureBoxForGraphics.Height);
                graphics.DrawLine(Pens.Green, new Point(x, curY1), new Point(x+1, nextY1));

                curY2 = pictureBoxForGraphics.Height - (int)(pointsOfGraphic2[x] * scaling * pictureBoxForGraphics.Height);
                nextY2 = pictureBoxForGraphics.Height - (int)(pointsOfGraphic2[x+1] * scaling * pictureBoxForGraphics.Height);
                graphics.DrawLine(Pens.Red, new Point(x, curY2), new Point(x + 1, nextY2));
            }

            graphics.DrawLine(Pens.Blue, new Point(intersectionPoint, 399), new Point(intersectionPoint, 150));
        }

        private void pc1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if(c != '0' && pc1TextBox.Text.Length == 0) //первым символом можно ввести лишь 0
            {
                e.Handled = true;
                return;
            }

            if (c != ',' && pc1TextBox.Text.Length == 1) //вторым символом можно ввести лишь ,
            {
                e.Handled = true;
                return;
            }

            if (pc1TextBox.Text.Length < 3 && c == 8) //нельзя стирать первые 2 символа
            {
                e.Handled = true;
                return;
            }

            if (pc1TextBox.Text.Length == 5 && c != 8) //если длина достигла 5, то можно лишь стирать
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(c) && c != 8 && pc1TextBox.Text.Length > 1)//начиная с 3его символа нельзя вводить не цифры
            {
                e.Handled = true;
                return;
            }
        }

        private void pc2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c != '0' && pc2TextBox.Text.Length == 0) //первым символом можно ввести лишь 0
            {
                e.Handled = true;
                return;
            }

            if (c != ',' && pc2TextBox.Text.Length == 1) //вторым символом можно ввести лишь ,
            {
                e.Handled = true;
                return;
            }

            if (pc2TextBox.Text.Length < 3 && c == 8) //нельзя стирать первые 2 символа
            {
                e.Handled = true;
                return;
            }

            if (pc2TextBox.Text.Length == 5 && c != 8) //если длина достигла 5, то можно лишь стирать
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(c) && c != 8 && pc2TextBox.Text.Length > 1)//начиная с 3его символа нельзя вводить не цифры
            {
                e.Handled = true;
                return;
            }
        }

        private void pc1TextBox_Enter(object sender, EventArgs e)
        {
            if (Convert.ToDouble(pc1TextBox.Text) == 0)
            {
                pc1TextBox.Clear();
            }
        }

        private void pc1TextBox_Leave(object sender, EventArgs e)
        {
            if (pc1TextBox.Text == "" || Convert.ToDouble(pc1TextBox.Text) == 0)
            {
                pc1TextBox.Text = "0,000";
            }
        }

        private void pc2TextBox_Enter(object sender, EventArgs e)
        {
            if (Convert.ToDouble(pc2TextBox.Text) == 0)
            {
                pc2TextBox.Clear();
            }
        }

        private void pc2TextBox_Leave(object sender, EventArgs e)
        {
            if (pc2TextBox.Text == "" || Convert.ToDouble(pc2TextBox.Text) == 0)
            {
                pc2TextBox.Text = "0,000";
            }
        }
    }
}
