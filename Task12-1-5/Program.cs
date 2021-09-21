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
            users.Add(new User("", "Екатерина Колесникова", true));
            users.Add(new User("mike01", "Mike Peterson", true));
            users.Add(new User("bomj99", "Бомж Бомжов", false));
            users.Add(new User("?????", "Аноним", true));

            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();
            for (int i = 0; i < users.Count; i++)
            {
                if (login == users[i].Login)
                {
                    if (users[i].IsPremium == true)
                    {
                        Console.WriteLine($"Здравствуйте, {users[i].Name}, как поживаете?)))");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"А, халявщег? На вот, рекламку глянь)");
                        ShowAds();
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Такого пользователя нет...");
                }
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
