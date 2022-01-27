﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19_automation_test
{
    public class Utils
    {
        public static string TranslateTestEnum(ETestCondition testEnum)
        {
            if (testEnum == ETestCondition.Positive)
            {
                return "Позитивен";

            } else if (testEnum == ETestCondition.Negative)
            {
                return "Отрицателен";
            }

            return "";
        }

        public static void WriteStudentsLine(string newText)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\files\\" + "finishedStudents.txt");
            sw.WriteLine(newText);
            sw.Close();
        }
    }
}