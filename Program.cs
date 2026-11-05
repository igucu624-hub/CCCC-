using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных
            Console.Write("Здоровье гладиатора 1 : ");
            double health1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Броня гладиатора 1 в % : ");
            double armor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Здоровье гладиатора 2: ");
            double health2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Броня гладиатора 2 в % : ");
            double armor2 = Convert.ToDouble(Console.ReadLine());

            // Контроль ввода: только положительные значения
            if (health1 <= 0)

            {
                Console.WriteLine("Ошибка: здоровье длжно быть больше 0.");
                return;
            }
            if (health2 <= 0)
            {
                Console.WriteLine("Ошибка: здоровье длжно быть больше 0.");
                return;
            }
            if (armor1 <= 0 || armor1 > 100)
            {
                Console.WriteLine("Ошибка : броня должна быть от 1 до 100%.");
                return;
            }
            if (armor2 <= 0 || armor2 > 100)
            {
                Console.WriteLine("Ошибка : броня должна быть от 1 до 100%.");
                return;
            }

            // Случайная сила удара (от 10 до 50)
            Random rand = new Random();
            int hits = 0;
            while (health1 > 0 && health2 > 0)
            {
                hits = hits + 1;
                double attack1 = rand.Next(10, 51);
                double attack2 = rand.Next(10, 51);
                Console.WriteLine("Сила удара по гладиатору 1 : " + attack1);
                Console.WriteLine("Сила удара по гладиатору 2 : " + attack2);

                // Урон с учётом брони
                double damage1 = attack1 - attack1 * armor1 / 100;
                double damage2 = attack2 - attack2 * armor2 / 100;
                health1 = health1 - damage1;
                health2 = health2 - damage2;

                if (health1 < 0)
                {
                    health1 = 0;
                }
                if (health2 < 0)
                {
                    health2 = 0;
                }

                Console.WriteLine("Осталось здоровья у гладиатора 1: " + health1);
                Console.WriteLine("Осталось здоровья у гладиатора 2: " + health2);
            }

            // Ветвление: определяем результат боя
            if (health1 == 0 && health2 == 0)
            {
                Console.WriteLine("Оба гладиатора погибли.");
            }
            else if (health1 > health2)
            {
                Console.WriteLine("Победил гладиатор 1.");
            }
            else if (health2 > health1)
            {
                Console.WriteLine("Победил гладиатор 2.");
            }
            else
            {
                Console.WriteLine("Ничья.");
            }

            Console.WriteLine("Ударов за бой : " + hits);
        }
    }
}

