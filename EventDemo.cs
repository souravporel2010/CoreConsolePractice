using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreConsolePractice
{
    class EventDemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("----My Event Demo----");
            //MailService ms = new MailService();

            JobService js = new JobService();
            js.jobhandler += MailService.MailSending;
            js.jobhandler += MessageService.MessageSending;
            //js.jobhandler();
            js.JobRunning();
            int i = 19;
            Console.WriteLine(i.Addsum().ToString()); 
        }

    }
    public static class Util
    {
        public static int Addsum(this int i)
        {
            return i + 100;
        }
    }
    public class JobService
    {
        public delegate void JobEventHandler();

        public event JobEventHandler jobhandler;

        public void JobRunning()
        {
            Console.WriteLine("Job Running---");
            Thread.Sleep(3000);
            Console.WriteLine("Job Completed");
            JobEventPublisher();
        }

        public void JobEventPublisher()
        {
            if (jobhandler != null)
            {
                jobhandler();
            }

        }
    }

    public class MailService
    {
        public static void MailSending()
        {
            Console.WriteLine("Mail sended");
        }
    }

    public class MessageService
    {
        public static void MessageSending()
        {
            Console.WriteLine("Message sended");
        }
    }
}
