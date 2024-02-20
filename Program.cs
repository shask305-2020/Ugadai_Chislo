using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugadai_Chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа \"Угадай число\"");
            Console.WriteLine("Попытайтесь угадать загаданное в системе число (от 0 до 10)");
            Random random = new Random();
            int ZagChislo = random.Next(0, 10);
            Console.WriteLine(ZagChislo);
            Console.Write("\n");
            int n = 0;
            while (true)
            {
                Console.Write("Ваше число: ");
                string stroka = Console.ReadLine();

                while (!int.TryParse(stroka, out n))
                {
                    Console.WriteLine("\nВведенные данные не являются числом");
                    Console.WriteLine("Повторите ввод данных");
                    stroka = Console.ReadLine();
                }
                if (n != ZagChislo)
                {
                    Console.WriteLine("Вы не угадали. Попробуйте еще раз");
                    if (n > ZagChislo)
                    {
                        Console.WriteLine("Загаданное число меньше\n");
                    }
                    else
                    {
                        Console.WriteLine("Загаданное число больше\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nПоздравляем! \nВы угадали загаданное число");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
