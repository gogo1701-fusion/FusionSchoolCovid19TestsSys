using System;
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

        public static void WriteFinishedStudent(ETestCondition testCondition, TestInfo student)
        {

            //StreamWriter sw = new StreamWriter(Application.StartupPath + "\\files\\" + "finishedStudents.txt");
            
            File.AppendAllText(Application.StartupPath +
                "\\files\\" +
                "finishedStudents.txt",
                "\n" +
                student.Name +
                ": " +
                TranslateTestEnum(student.TestCondition));

            /*sw.WriteLine(currentFileText +
                student.Name + ": " +
                TranslateTestEnum(student.TestCondition));
            sw.Close();*/
        }
    }
}
