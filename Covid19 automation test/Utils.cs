using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public static void WriteStudentsLine(string newText, TestInfo student)
        {
            //StreamWriter sw = new StreamWriter(Application.StartupPath + "\\files\\" + "finishedStudents.txt");
            //sw.WriteLine(newText);
            //sw.Close();
            string path = Application.StartupPath + "\\files\\" + "finishedStudents.txt";
            string sudurjanie = "";

            sudurjanie = JsonConvert.SerializeObject(student);

            var newStudent = JsonConvert.DeserializeObject<TestInfo>(sudurjanie);

            var text = File.ReadAllText(path);

            var students = text.Split("\n");

            for (int i = 0; i < students.Length; i++)
            {
                var studentData = students[i].Split(",");

                Student s = new Student();
                s.Name = studentData[0];
                s.Class = new List<string>().Where(x => x == studentData[1]).FirstOrDefault();
            }

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            File.WriteAllText(path, sudurjanie); // prezapisva
            File.AppendAllText(path, sudurjanie); // dobavq
        }
    }

    [Serializable]
    public class Student
    {
        public string Name;
        public string Class;
    }
}
