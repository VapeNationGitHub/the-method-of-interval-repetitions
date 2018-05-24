using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MIR
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Здравствуйте! Вы находитесь в программе <<Метод интервальных повторений>>");

            int a = 10;
            int b = 20;
            int c = 60;
            string s1 = "words";
            string s2 = "formula";
            string s3 = "hello";
            string s4 = "buy";

            Console.WriteLine("Введите, что вы хотите повторить: " + s1 + " или " + s2);
            string answer = Console.ReadLine();
            if (answer == s1)
            {                             
                Console.WriteLine("Введите одно из следующих слов, котоорые вы хотите повторить: " + s3 + " или " + s4);
                string wordsline = Console.ReadLine();
                if (wordsline == s3)
                {
                    Console.WriteLine("Вы выбрали повторить слово " + s3);
                    Console.WriteLine("Введите время, через которое вы хотите повторить слово " + s3 + "? " + a + " секунд, " + b + " секунд, или " + c + " секунд");


                    string wordstime = Console.ReadLine();
                    switch (wordstime)
                    {
                        case "10":
                            Console.WriteLine("Напоминание сработает через " + a + " секунд");
                            Thread.Sleep(10000);
                            Console.WriteLine(s3);
                            break;
                        case "20":
                            Console.WriteLine("Напоминание сработает через " + b + " секунд");
                            Thread.Sleep(20000);
                            Console.WriteLine(s3);
                            break;
                        case "60":
                            Console.WriteLine("Напоминание сработает через " + c + " секунд");
                            Thread.Sleep(60000);
                            Console.WriteLine(s3);
                            break;
                        default:
                            Console.WriteLine("Вы ввели неверное значение! Напоминаение сработает по умолчанию, через 10 секунд");
                            goto case "10";      
                    }
                    
     

                }
                /*
                else if (wordsline == s4)
                    Console.WriteLine(s4);  
                    */
                    
            }
            /*
            else if (answer == s2)
                Console.WriteLine(s2);
                */
    
            Console.ReadLine();
        }
    }
}
