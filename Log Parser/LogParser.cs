using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LogParser
{
    //    нужно найти все строки вида...Request for Х_Y_Z_K, 
    //    получить из них данные Дата записи, Время записи, Х, Y, Z, K, и сложить их куда-нибудь на хранение.
    //    Плюсом будет демонстрация работы с регулярными выражениями и модульными тестами.

    class AppClass
    {
        static void Main(string[] args)
        {
            string file = "EventService_1.log";
            string pattern = @"([0-9\-]*) ([0-9:.]*).*Request for (\d*)_(\d*)_(\d*)_(\w*)";

            try
            {
                List<string[]> logData = LogParserLib.LogParser.GetFileRegexMatches(file, pattern);

                Console.WriteLine("Всего совпадений: " + logData.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
