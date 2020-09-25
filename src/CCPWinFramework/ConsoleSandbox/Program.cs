using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSandbox
{
    /// <summary>
    /// Console Application used to test different composants
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //var output = ProcessesAndThreads.ProcessesAndThreads.RunSomeApplicationWithConsole();
            var output = ProcessesAndThreads.ProcessesAndThreads.RunGit();
            Console.Write(output);
            //TestSendMailMessage();
            Console.Write("Press Any Key! ");
            Console.ReadKey();
        }

        static void TestSendMailMessage()
        {

            string server = "smtp-mail.outlook.com";
            var from = new MailAddress("ccp.adm@outlook.com");
            //var to = new MailAddress("christian.popescu@outlook.com");
            var to = new MailAddress("alexvpopescu@live.com");
            var message = new MailMessage(from, to)
            {
                Subject = "Using the SmtpClient class.",
                Body = @"Using this feature, you can send an e-mail message from an application very easily.\n Urs"
            };
            var client = new SmtpClient(server)
            {
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential("ccp.adm@outlook.com", "password"),
                
            };

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage4(): {0}",
                            ex.ToString());
            }
        }
    }
}
