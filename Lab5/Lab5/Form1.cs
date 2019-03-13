using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        const int bottomRange = -50;
        const int topRange = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            Vector[] learningPoints = new Vector[4];
            learningPoints[0] = new Vector(2);
            learningPoints[1] = new Vector(2);
            learningPoints[2] = new Vector(2);
            learningPoints[3] = new Vector(2);

            if(int.TryParse(x11TextBox.Text, out learningPoints[0].Elements[0]) && int.TryParse(x12TextBox.Text, out learningPoints[0].Elements[1]) &&
                int.TryParse(x21TextBox.Text, out learningPoints[1].Elements[0]) && int.TryParse(x22TextBox.Text, out learningPoints[1].Elements[1]) &&
                int.TryParse(x31TextBox.Text, out learningPoints[2].Elements[0]) && int.TryParse(x32TextBox.Text, out learningPoints[2].Elements[1]) &&
                int.TryParse(x41TextBox.Text, out learningPoints[3].Elements[0]) && int.TryParse(x42TextBox.Text, out learningPoints[3].Elements[1]))
            {
                Vector k = new Vector(4);

                k = Functions.FindK(learningPoints[0]);

                do
                {
                    int i = 1;

                    while (i < learningPoints.Length)
                    {
                        if (i < 2)
                        {
                            if (Functions.GetSum(learningPoints[i], k) <= 0)
                                k = k + Functions.FindK(learningPoints[i]);

                        }
                        else
                        {
                            if (Functions.GetSum(learningPoints[i], k) > 0)
                                k = k - Functions.FindK(learningPoints[i]);
                        }

                        i++;
                    }

                    if (Functions.GetSum(learningPoints[0], k) <= 0)
                        k = k + Functions.FindK(learningPoints[0]);

                } while (!Functions.CheckAll(learningPoints, k));

                Vector[] testingImages = Functions.RandomizeImages(250, bottomRange, topRange);
                DrawGraphicWithImages(k, learningPoints, testingImages);
            }
            else
            {
                MessageBox.Show("Please, enter correct values of learning points");
            }
        }

        private void DrawGraphicWithImages(Vector k, Vector[] learningPoints, Vector[] testingPoints)
        {
            Graphics graphics = pictureBoxForGraphic.CreateGraphics();
            graphics.Clear(Color.White);

            graphics.DrawLine(Pens.Black, 150, 0, 150, 300);
            graphics.DrawLine(Pens.Black, 0, 150, 300, 150);

            for (int i = 0; i < pictureBoxForGraphic.Width; i++)
            {
                double a1 = Functions.GetX2(i-150, k);
                double a = pictureBoxForGraphic.Height - 300*a1;
                double b1 = Functions.GetX2(i -150 + 1, k);
                double b = pictureBoxForGraphic.Height - 300*b1;
                graphics.DrawLine(Pens.Blue, i, (float)a, i + 1, (float)b);
            }

            Brush br;

            foreach(Vector v in testingPoints)
            {
                if(Functions.GetSum(v, k) > 0)
                {
                    br = Brushes.Red;
                }
                else
                {
                    br = Brushes.Green;
                }

                graphics.FillRectangle(br, 3 * v.Elements[0] + 150, pictureBoxForGraphic.Height - 3 * v.Elements[1] - 150, 3, 3);
            }
        }

        

        private void x1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешить вставку, если это первый символ и это минус или цифра
            if (((TextBox)sender).Text.Length == 0 && (e.KeyChar == '-' || char.IsDigit(e.KeyChar)))
            {
                e.Handled = false;
                return;
            }

            //ввод не происходит, если (это не цифра и не пробел) или (длина уже имеющегося текста 4 и это не бэкспэйс)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length == 3 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void x2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешить вставку, если это первый символ и это минус или цифра
            if (((TextBox)sender).Text.Length == 0 && (e.KeyChar == '-' || char.IsDigit(e.KeyChar)))
            {
                e.Handled = false;
                return;
            }

            //ввод не происходит, если (это не цифра и не пробел) или (длина уже имеющегося текста 4 и это не бэкспэйс)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length == 2 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void x12TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешить вставку, если это первый символ и это минус или цифра
            if (((TextBox)sender).Text.Length == 0 && (e.KeyChar == '-' || char.IsDigit(e.KeyChar)))
            {
                e.Handled = false;
                return;
            }

            //ввод не происходит, если (это не цифра и не пробел) или (длина уже имеющегося текста 4 и это не бэкспэйс)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length == 3 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void x22TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешить вставку, если это первый символ и это минус или цифра
            if (((TextBox)sender).Text.Length == 0 && (e.KeyChar == '-' || char.IsDigit(e.KeyChar)))
            {
                e.Handled = false;
                return;
            }

            //ввод не происходит, если (это не цифра и не пробел) или (длина уже имеющегося текста 4 и это не бэкспэйс)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length == 3 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void x31extBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешить вставку, если это первый символ и это минус или цифра
            if (((TextBox)sender).Text.Length == 0 && (e.KeyChar == '-' || char.IsDigit(e.KeyChar)))
            {
                e.Handled = false;
                return;
            }

            //ввод не происходит, если (это не цифра и не пробел) или (длина уже имеющегося текста 4 и это не бэкспэйс)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length == 3 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void x32TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешить вставку, если это первый символ и это минус или цифра
            if (((TextBox)sender).Text.Length == 0 && (e.KeyChar == '-' || char.IsDigit(e.KeyChar)))
            {
                e.Handled = false;
                return;
            }

            //ввод не происходит, если (это не цифра и не пробел) или (длина уже имеющегося текста 4 и это не бэкспэйс)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length == 3 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void x41TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешить вставку, если это первый символ и это минус или цифра
            if (((TextBox)sender).Text.Length == 0 && (e.KeyChar == '-' || char.IsDigit(e.KeyChar)))
            {
                e.Handled = false;
                return;
            }

            //ввод не происходит, если (это не цифра и не пробел) или (длина уже имеющегося текста 4 и это не бэкспэйс)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length == 3 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void x42TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //разрешить вставку, если это первый символ и это минус или цифра
            if (((TextBox)sender).Text.Length == 0 && (e.KeyChar == '-' || char.IsDigit(e.KeyChar)))
            {
                e.Handled = false;
                return;
            }

            //ввод не происходит, если (это не цифра и не пробел) или (длина уже имеющегося текста 4 и это не бэкспэйс)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length == 3 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
