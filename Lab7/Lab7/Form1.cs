using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        readonly int initialY;
        const int deltaY = 30;
        const int initialX = 40;
        readonly string[,] grammatics = new string[18, 2]{ { "a", "Плечо" }, { "Плечоb", "Плечо" },
            { "bПлечо", "Плечо" }, { "d", "Сторона" }, { "b", "Сторона" },
            { "Сторонаb", "Сторона" }, { "bСторона", "Сторона" }, { "e", "Основание" },
            { "bОснование", "Основание" }, { "Основаниеb", "Основание" },
            { "cПлечо", "Правая часть" }, { "Плечоc", "Левая часть" },
            { "Левая частьПлечо", "Пара плеч" }, { "ПлечоПравая часть", "Пара плеч" },
            { "Пара плечСторона", "Пара плеч" }, { "СторонаПара плеч", "Пара плеч" },
            { "ОснованиеПара плеч", "T" }, { "Пара плечПара плеч", "S" }};

        public Form1()
        {
            InitializeComponent();
            initialY = treePictureBox.Height - 30;
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (Functions.TextIsValid(chromosomeTextBox.Text))
            {
                List<Element> elementsList = Functions.MakeInitialElementsList(chromosomeTextBox.Text, initialX, initialY);

                Element root = Functions.GetRootElement(grammatics, elementsList, deltaY);

                DrawTree(treePictureBox.CreateGraphics(), root);
            }
            else
            {
                MessageBox.Show("Please, enter correct chromosome code!");
            }
        }

        private void DrawTree(Graphics graphics, Element root)
        {
            graphics.Clear(Color.White);
            RecursiveDrawTree(graphics, root);
        }

        private void RecursiveDrawTree(Graphics graphics, Element element)
        {
            graphics.FillEllipse(Brushes.Black, element.X - 2, element.Y - 2, 4, 4);
            graphics.DrawString(element.Name, new Font("Segoe Print", 7), Brushes.Red, element.X - 8, element.Y + 2);

            if(element.FirstChild != null)
            {
                graphics.DrawLine(Pens.Black, element.X, element.Y, element.FirstChild.X, element.FirstChild.Y);
                RecursiveDrawTree(graphics, element.FirstChild);
            }

            if (element.SecondChild != null)
            {
                graphics.DrawLine(Pens.Black, element.X, element.Y, element.SecondChild.X, element.SecondChild.Y);
                RecursiveDrawTree(graphics, element.SecondChild);
            }
        }
    }
}
