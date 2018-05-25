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
            string s4 = "bye";
            string s5 = "1";
            string s6 = "2";

            Console.WriteLine("Введите, что вы хотите повторить: " + s1 + " или " + s2);

            // повторение слов
            string answer = Console.ReadLine();
            if (answer == s1)
            {
                Console.WriteLine("Введите одно из следующих слов, которое вы хотите повторить: " + s3 + " или " + s4);
                string wordsline = Console.ReadLine();
                if (wordsline == s3)
                {
                    Console.WriteLine("Вы выбрали повторить слово " + s3);
                    Console.WriteLine("Введите время, через которое вы хотите повторить слово " + s3 + " : " + a + " секунд, " + b + " секунд, или " + c + " секунд");

                    LabelHello:
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
                            Console.WriteLine("Вы ввели неверное значение! Пожалуйста, введите корректное время!");
                            goto LabelHello;
                    }
                }
                else if (wordsline == s4)
                {
                    Console.WriteLine("Вы выбрали повторить слово " + s4);
                    Console.WriteLine("Введите время, через которое вы хотите повторить слово " + s4 + " : " + a + " секунд, " + b + " секунд, или " + c + " секунд");

                    LabelBye:
                    string wordstime = Console.ReadLine();
                    switch (wordstime)
                    {
                        case "10":
                            Console.WriteLine("Напоминание сработает через " + a + " секунд");
                            Thread.Sleep(10000);
                            Console.WriteLine(s4);
                            break;
                        case "20":
                            Console.WriteLine("Напоминание сработает через " + b + " секунд");
                            Thread.Sleep(20000);
                            Console.WriteLine(s4);
                            break;
                        case "60":
                            Console.WriteLine("Напоминание сработает через " + c + " секунд");
                            Thread.Sleep(60000);
                            Console.WriteLine(s4);
                            break;
                        default:
                            Console.WriteLine("Вы ввели неверное значение! Пожалуйста, введите корректное время!");
                            goto LabelBye;
                    }
                }
            }


            // повторение формул          

            else if (answer == s2)
            {
                Console.WriteLine("Введите одну из следующих формул, которую вы хотите повторить: 1) [x = 2x + 3] или 2) [y = 4x^2]");
                string formulaline = Console.ReadLine();
                if (formulaline == s5)
                {
                    Console.WriteLine("Вы выбрали повторить формулу " + s5);
                    Console.WriteLine("Введите время, через которое вы хотите повторить формулу " + s5 + " : " + a + " секунд, " + b + " секунд, или " + c + " секунд");

                    LabelFormula1:
                    string formulatime = Console.ReadLine();
                    switch (formulatime)
                    {
                        case "10":
                            Console.WriteLine("Напоминание сработает через " + a + " секунд");
                            Thread.Sleep(10000);
                            Console.WriteLine(s5);
                            break;
                        case "20":
                            Console.WriteLine("Напоминание сработает через " + b + " секунд");
                            Thread.Sleep(20000);
                            Console.WriteLine(s5);
                            break;
                        case "60":
                            Console.WriteLine("Напоминание сработает через " + c + " секунд");
                            Thread.Sleep(60000);
                            Console.WriteLine(s5);
                            break;
                        default:
                            Console.WriteLine("Вы ввели неверное значение! Пожалуйста, введите корректное время!");
                            goto LabelFormula1;
                    }
                }
                else if (formulaline == s6)
                {
                    Console.WriteLine("Вы выбрали повторить формулу " + s6);
                    Console.WriteLine("Введите время, через которое вы хотите повторить формулу " + s6 + " : " + a + " секунд, " + b + " секунд, или " + c + " секунд");

                    LabelFormula2:
                    string formulatime = Console.ReadLine();
                    switch (formulatime)
                    {
                        case "10":
                            Console.WriteLine("Напоминание сработает через " + a + " секунд");
                            Thread.Sleep(10000);
                            Console.WriteLine(s4);
                            break;
                        case "20":
                            Console.WriteLine("Напоминание сработает через " + b + " секунд");
                            Thread.Sleep(20000);
                            Console.WriteLine(s4);
                            break;
                        case "60":
                            Console.WriteLine("Напоминание сработает через " + c + " секунд");
                            Thread.Sleep(60000);
                            Console.WriteLine(s4);
                            break;
                        default:
                            Console.WriteLine("Вы ввели неверное значение! Пожалуйста, введите корректное время!");
                            goto LabelFormula2;
                    }
                }
            }                
            Console.ReadLine();
        }
    }
}
