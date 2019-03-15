using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string question;
            string response;

            do
            {

                Console.WriteLine("sup?");
                question = Console.ReadLine();

                switch (question)
                {

                    case "not much":
                        response = "mood";
                        break;
                    case "the sky":
                        response = "lmao";
                        break;
                    case "studying":
                        response = "zzz";
                        break;
                    case "dying":
                        response = "same";
                        break;
                    default:
                        response = "wut?";
                        break;


                }
                Console.WriteLine(response);

            }
            while (question != "exit");
        }
    }
}
