using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Functions
    {
        public static int SortListByLength(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
                for (int j = i + 1; j < list.Count; j++)
                    if (list[j].Length > list[i].Length)
                    {
                        string temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }

            return list[0].Length;
        }

        public static bool IfRuleExists(List<string[]> rules, ref string element, string firstElement)
        {
            bool result = false;

            foreach(string[] rule in rules)
                if(rule[0] == element && rule[1][0].ToString() == firstElement)
                {
                    result = true;
                    element = rule[1].Substring(1);
                    break;
                }

            return result;
        }

        public static bool AreEquivalent(List<string[]> rules, string firstNotTermEl, string secondNotTermEl)
        {
            bool result = true;

            List<string[]> firstElList = GetRulesForElement(rules, firstNotTermEl);
            List<string[]> secondElList = GetRulesForElement(rules, secondNotTermEl);

            if (firstElList.Count == secondElList.Count)
            {
                foreach (string[] rule1 in firstElList)
                {
                    bool isSame = false;
                    foreach(string[] rule2 in secondElList)
                        if(rule1[1][0] == rule2[1][0] && ((rule1[1].Length == 1 && rule2[1].Length == 1) ||
                            (rule1[1].Length > 1 && rule2[1].Length > 1)))
                        {
                            isSame = true;
                            break;
                        }

                    if (!isSame)
                    {
                        result = false;
                        break;
                    }

                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        public static List<string[]> GetRulesForElement(List<string[]> rules, string element)
        {
            List<string[]> list = new List<string[]>();

            foreach (string[] rule in rules)
                if (rule[0] == element)
                    list.Add(rule);

            return list;
        }

        public static string FindNotTerminalToReplaceBy(List<string[]> rules, string element)
        {
            string result = "";

            foreach (string[] rule in rules)
                if (rule[1].Substring(1) == element && rule[0] != element)
                    result = rule[0];

            return result;
        }

        public static List<string> GetUniqueNotTerminals(List<string[]> rules)
        {
            List<string> uniqueTerms = new List<string>();

            foreach (string[] rule in rules)
                if (!IfExists(uniqueTerms, rule[0]))
                    uniqueTerms.Add(rule[0]);

            return uniqueTerms;
        }

        private static bool IfExists(List<string> list, string notTerminal)
        {
            bool result = false;

            foreach(string t in list)
                if(t == notTerminal)
                {
                    result = true;
                    break;
                }

            return result;
        }

        public static void DeleteEquivalents(List<string[]> list, string elementToReplace, string elementToReplaceBy)
        {
            int j = 0;
            while (j < list.Count)
            {
                if (list[j][0] == elementToReplace)
                {
                    list.RemoveAt(j);
                }
                else
                {
                    if (list[j][1].Substring(1) == elementToReplace)
                        list[j][1] = list[j][1][0].ToString() + elementToReplaceBy;
                    j++;
                }

            }
        }
    }
}
