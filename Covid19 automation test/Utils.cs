using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Covid19_automation_test
{
    public static class Utils
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
                TranslateTestEnum(testCondition));

            /*sw.WriteLine(currentFileText +
                student.Name + ": " +
                TranslateTestEnum(student.TestCondition));
            sw.Close();*/
        }

        public static void SendEmail(string content)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("testingemailcompproj@gmail.com");
            mail.To.Add("testingemailcompproj@gmail.com");
            mail.Subject = "COVID-19 Тестове";
            mail.Body = content;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("testingemailcompproj@gmail.com", "ComputerTesting");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

        public static string ReadStudentsFile()
        {
            string output = File.ReadAllText("\\files\\" + "finishedStudents.txt");

            return output;
        }
    }
}
