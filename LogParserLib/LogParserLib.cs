using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LogParserLib
{
    public class LogParser
    {
        public static List<string[]> GetFileRegexMatches(string file, string pattern)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                Regex regex = new Regex(pattern);

                // Количество совпадений неизвестно, используем динамический массив
                List<string[]> matchesList = new List<string[]>();
                string line;

                // Поочередно считываем строки
                while ((line = sr.ReadLine()) != null)
                {
                    Match match = regex.Match(line);

                    if (match.Success)
                    {
                        // Создаем массив со сгруппированными значениями
                        string[] strData = new string[match.Groups.Count - 1];

                        for (int i = 1; i < match.Groups.Count; i++)
                        {
                            strData[i - 1] = match.Groups[i].Value;
                        }

                        matchesList.Add(strData);
                    }
                }

                return matchesList;
            }
        }
    }
}
