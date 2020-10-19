using Fitness_CodeBlog.BL.Controller;
using System;

namespace Fitness_CodeBlog.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение Fitness CodeBlog");

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var birthday = DateTime.Parse(Console.ReadLine()); // TODO переписать на TryParce
            
            Console.WriteLine("Введите вес");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthday, weight, height);
            userController.Save();

        }
    }
}
