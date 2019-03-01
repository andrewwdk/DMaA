using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        const int c = 1; //коэффициент пересчёта весов
        const int signsCount = 2; //количество признаков у объектов
        const int bottomRandomRange = -10;//нижний предел для генерирования значения признака образа из обучающей выборки
        const int topRandomRange = 10;//верхний предел для генерирования значения признака образа из обучающей выборки

        public Form1()
        {
            InitializeComponent();
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            if (classCountTextBox.Text != "")
            {
                int classCount = Convert.ToInt32(classCountTextBox.Text);

                if (classCount >= 2 && classCount <= 5)
                {
                    Vector[] imagesForLearning = Functions.RandomizeLearningImages(classCount, signsCount, bottomRandomRange, topRandomRange);

                   /* Vector[] imagesForLearning = new Vector[3];  //Для тестирования(пример из методички)
                    imagesForLearning[0] = new Vector(3);
                    imagesForLearning[0].Elements[0] = 0;
                    imagesForLearning[0].Elements[1] = 0;
                    imagesForLearning[0].Elements[2] = 1;
                    imagesForLearning[1] = new Vector(3);
                    imagesForLearning[1].Elements[0] = 1;
                    imagesForLearning[1].Elements[1] = 1;
                    imagesForLearning[1].Elements[2] = 1;
                    imagesForLearning[2] = new Vector(3);
                    imagesForLearning[2].Elements[0] = -1;
                    imagesForLearning[2].Elements[1] = 1;
                    imagesForLearning[2].Elements[2] = 1;*/


                    Vector[] classesWeightVectors = Functions.InitializeClassesWeightVectors(classCount, signsCount);
                    int[] decisionFunctionsResults = new int[classCount];

                    int countOfIteration = 0;
                    bool stopCalculating = false;
                    List<int> falseClassIndexesList = new List<int>(); //индексы классов, которым по ошибке был присвоен чужой образ

                    while(!stopCalculating && countOfIteration < 100)
                    {
                        stopCalculating = true;

                        for(int i = 0; i < classCount; i++)//цикл для перебора обучающих образов
                        {
                            for(int j=0; j < classCount; j++)
                            {
                                decisionFunctionsResults[j] = classesWeightVectors[j] * imagesForLearning[i];
                            }

                            if(!Functions.IfNumberBiggestAtIndex(decisionFunctionsResults, i,out falseClassIndexesList))//если образ НЕ отнёсся к нужному классу
                            {
                                classesWeightVectors = Functions.DoPanishment(i, falseClassIndexesList, c, classesWeightVectors, imagesForLearning[i]);
                                stopCalculating = false;
                            }
                        }

                        countOfIteration++;
                    }

                    if(countOfIteration == 100)
                    {
                        MessageBox.Show("Impossible to find functions");
                        return;
                    }

                    ShowLearningImagesAndDecisionFunctions(imagesForLearning, classesWeightVectors);
                    decideButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Count of classes should range between 2 to 5!");
                }
            }
            else
            {
                MessageBox.Show("Please, enter count of classes");
            }
        }

        private void ShowLearningImagesAndDecisionFunctions(Vector[] imagesForLearning, Vector[] classesWeightVectors)
        {
            functionsTextBox.Clear();

            for (int i = 0; i < imagesForLearning.Length; i++)
            {
                functionsTextBox.Text += Environment.NewLine + imagesForLearning[i].ToString() + "  " + classesWeightVectors[i].ToStringAsFunction();
            }
        }

        private void classCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод не происходит, если (это не цифра и не пробел) или (длина уже имеющегося текста не 0 и это не бэкспэйс)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length != 0 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
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
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length == 4 && e.KeyChar != (char)Keys.Back))
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
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) || (((TextBox)sender).Text.Length == 4 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
