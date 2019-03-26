using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Grammatics
    {
        const string mainNotTerminalElement = "S";
        const string notTerminalElement = "A";

        public List<string[]> ListOfRules { get; private set; }
        private int notTerminalCount;

        public Grammatics()
        {
            ListOfRules = new List<string[]>();
            notTerminalCount = 1;
        }

        public void MakeRules(List<string> chains)
        {
            int maxLength = Functions.SortListByLength(chains);

            foreach(string chain in chains)
                if(chain.Length == maxLength)
                {
                    AddRules(mainNotTerminalElement, chain);
                }
            //Текущий символ - "S". (*)Ищем все его вхождения в правила. Если хотя бы 1 символ не совпадает с цепочкой,
            //то делаем его разбор AddRules. Если первый символ совпадает, то текущим становится нетерминальный символ из
            //найденной подстановки. Если нет нетерминальных символов, то конец. Повторяем, начиная с(*)
                else
                {
                    string curElement = mainNotTerminalElement;
                    string curChain = chain;

                    while(curChain != "")
                    {
                        if((curElement == mainNotTerminalElement || curElement.Contains(notTerminalElement)) && 
                            Functions.IfRuleExists(ListOfRules, ref curElement, curChain[0].ToString()))
                        {
                            curChain = curChain.Substring(1);
                        }
                        else
                        {
                            AddRules(curElement, curChain);
                            break;
                        }
                    }

                }
        }

        private void AddRules(string element, string chain)
        {
            string leftPart = element, rightPart;

            while(chain.Length > 2)
            {
                rightPart = chain[0] + notTerminalElement + notTerminalCount.ToString();
                ListOfRules.Add(new string[] { leftPart, rightPart });
                leftPart = notTerminalElement + notTerminalCount.ToString();
                notTerminalCount++;
                chain = chain.Substring(1); //удаляем первый символ
            }

            ListOfRules.Add(new string[] { leftPart, chain }); //добавляем остаточное правило
        }

        public void MakeRecursiveAutomaticGrammatics()
        {
            int i = 0;
            while (i < ListOfRules.Count)
            {
                if(!ListOfRules[i][1].Contains(notTerminalElement) && ListOfRules[i][1].Length == 2) //2 - по условию
                {
                    string elementToReplace = ListOfRules[i][0];
                    string elementToReplaceBy = Functions.FindNotTerminalToReplaceBy(ListOfRules,elementToReplace);

                    if (Functions.AreEquivalent(ListOfRules, elementToReplace, elementToReplaceBy))
                    {
                        Functions.DeleteEquivalents(ListOfRules, elementToReplace, elementToReplaceBy);
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    i++;
                }
            }
        }

        public void DeleteEquivalents()
        {
            List<string> uniqueNotTerminals = Functions.GetUniqueNotTerminals(ListOfRules);

            for(int i = 0; i<uniqueNotTerminals.Count;i++)
                for(int j = i + 1; j < uniqueNotTerminals.Count; j++)
                    if(Functions.AreEquivalent(ListOfRules, uniqueNotTerminals[i], uniqueNotTerminals[j]))
                    {
                        //передаём наоборот(j), т.к. удаляем всегда второй по порядку
                        Functions.DeleteEquivalents(ListOfRules, uniqueNotTerminals[j], uniqueNotTerminals[i]
                            /*Functions.FindNotTerminalToReplaceBy(ListOfRules, uniqueNotTerminals[j])*/);
                    }
        }

        public string NextValue()
        {
            string result = "S";
            string curNotTerm = mainNotTerminalElement;
            Random rand = new Random();
            List<string[]> substitutionList;
            string[] curRule;

            while(result.Contains(mainNotTerminalElement) || result.Contains(notTerminalElement))
            {
                substitutionList = Functions.GetRulesForElement(ListOfRules, curNotTerm);
                curRule = substitutionList[rand.Next(substitutionList.Count)];
                result = result.Replace(curNotTerm, curRule[1]);
                curNotTerm = curRule[1].Substring(1);
            }

            return result;
        }

        public override string ToString()
        {
            string result = "";

            foreach (string[] rule in ListOfRules)
                result += (rule[0] + " -> " + rule[1] + "   ");

            return result;
        }
    }
}
