using System;
using System.Collections.Generic;
using System.Threading;

namespace Task12_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();
            users.Add(new User("lex74", "Алексей Демиденко", false));
            users.Add(new User("kate2003", "Екатерина Колесникова", true));
            users.Add(new User("mike01", "Mike Peterson", true));
            users.Add(new User("bomj99", "Бомж Бомжов", false));
            users.Add(new User("???", "Аноним", true));

            try
            {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();
                
                var user = users.Find(x => x.Login == login);

                if (user == null)
                {
                    throw new Exception("Пользователя с таким логином нет...");
                }
                else
                {
                    if (user.IsPremium)
                    {
                        Console.WriteLine($"Здравствуйте, {user.Name}, как поживаете?)))");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"А, халявщег? На вот, рекламку глянь)");
                        ShowAds();
                        return;
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Логин не может быть пустым...");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
