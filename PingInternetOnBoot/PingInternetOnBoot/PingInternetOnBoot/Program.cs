using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PingInternetOnBoot
{
    class Program
    {
        static void Main(string[] args)
        {
            string logPath = "C:\\InternetCheckCount";
            string logFileName = "ConnectCount_log.txt";
            string fullLogPath = logPath + "\\" + logFileName;
            StreamWriter logger;
            if (Directory.Exists(logPath))
            {
                if (File.Exists(fullLogPath))
                {
                    logger = File.AppendText(fullLogPath);
                }
                else
                {
                    logger = new StreamWriter(fullLogPath);
                }
            }
            else
            {
                Directory.CreateDirectory(logPath);
                logger = new StreamWriter(fullLogPath);
            }
            
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("www.google.com", 1000);
                if (reply != null)
                {

                    Console.WriteLine("Status :  " + reply.Status + " \nTime : " + reply.RoundtripTime.ToString() + " \nAddress : " + reply.Address);
                    //Console.WriteLine(reply.ToString());
                    if (reply.Status == IPStatus.Success)
                    {
                        Console.WriteLine("Rebooting your computer......");
                        logger.WriteLine(DateTime.Now + " => Status : " + reply.Status + "  Time : " + reply.RoundtripTime.ToString() + "  Address : " + reply.Address);
                        logger.Close();
                        Process.Start("shutdown", "/r /t 5");
                    }
                    else
                    {
                        Console.WriteLine("ERROR: You have some internet connection issue");
                        logger.WriteLine(DateTime.Now + " => Status : " + reply.Status);
                        logger.Close();
                    }
                }
                else
                {
                    Console.WriteLine("Reply is Null");
                    logger.WriteLine(DateTime.Now + " => Status : Reply is NULL");
                    logger.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("UnHandled Exception: " + e.ToString());
                logger.WriteLine(DateTime.Now + " => Status : " + e.ToString());
                logger.Close();
            }

            Console.ReadKey();
        }
    }
}
