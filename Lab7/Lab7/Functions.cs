using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Functions
    {
        public static bool TextIsValid(string code)
        {
            bool result = true;

            if(code == "")
            {
                result = false;
            }
            else
            {
                foreach(char ch in code)
                    if(ch != 'a' && ch != 'b' && ch != 'c' && ch != 'd' && ch != 'e')
                    {
                        result = false;
                        break;
                    }
            }

            return result;
        }

        public static List<Element> MakeInitialElementsList(string code, int initialX, int initialY)
        {
            List<Element> list = new List<Element>();

            for(int i = 0; i < code.Length; i++)
                list.Add(new Element(code[i].ToString(), (i + 1) * initialX, initialY, null, null));

            return list;
        }

        public static Element GetRootElement(string[,] grammatics, List<Element> elements,int deltaY)
        {
            bool isSimpleElement;

            while(elements.Count > 1)
            {
                for(int i = 0; i < grammatics.GetLength(0); i++)
                {
                    //if 'a', 'b', 'c', 'd', 'e' in the rule (dont need to look the next element)
                    isSimpleElement = grammatics[i, 0].Length == 1 ? true : false;  

                    int j = 0;
                    while (j < (isSimpleElement ? elements.Count : elements.Count - 1))
                    {
                        if ((isSimpleElement ? elements[j].Name : elements[j].Name + elements[j + 1].Name) == grammatics[i, 0])
                        {
                            elements.Insert(isSimpleElement ? j + 1 : j + 2, 
                                new Element(grammatics[i, 1], isSimpleElement ? elements[j].X : (elements[j].X + elements[j + 1].X) / 2,
                                isSimpleElement ?  elements[j].Y - deltaY : Math.Min(elements[j].Y, elements[j + 1].Y) - deltaY,
                                elements[j], isSimpleElement ? null : elements[j + 1]));

                            if(!isSimpleElement)
                                elements.RemoveAt(j + 1);

                            elements.RemoveAt(j);
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
            }

            return elements[0];
        }
    }
}
