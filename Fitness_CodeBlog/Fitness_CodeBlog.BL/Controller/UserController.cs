using Fitness_CodeBlog.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fitness_CodeBlog.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя. 
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        public User User { get; }
        /// <summary>
        /// Создание нового контроллера пользователя.
        /// </summary>
        /// <param name="user"> Имя пользователя. </param>
        public UserController(string userName, string genderName, DateTime birthday, double weight, double height)
        {
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthday, weight, height);
        }
        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                // TODO Что делать, если пользователя не прочитали?
            }
        }

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using(var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Получить данные пользователя.
        /// </summary>
        /// <returns> Пользователь приложения </returns>
        
    }
}
