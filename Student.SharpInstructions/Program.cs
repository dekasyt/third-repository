using System;

class Program
{
    static void Main()
    {
        ShowMenu();
    }

    static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("Для вызова подпрограммы укажите номер и нажмите Enter:\n1 - IF ELSE\n2 - WHILE\n3 - DO WHILE\n4 - FOR\n5 - FOREACH\n6 - SWITCH");
            string proga = Console.ReadLine();
            switch (proga)
            {
                case "1": IfElse(); break;
                case "2": While(); break;
                case "3": DoWhile(); break;
                case "4": For(); break;
                case "5": Foreach(); break;
                case "6": Switch(); break;
                default: Console.WriteLine("Некорректный ввод! Пожалуйста, выберите номер из списка."); break;
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }

    static void IfElse()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Введите Пароль для доступа на сайт:");
            string password = Console.ReadLine();
            if (password == "Пароль")
            {
                Console.WriteLine("Пароль верный, доступ открыт.");
            }
            else
            {
                Console.WriteLine("Пароль неверный.");
            }
            Console.WriteLine("Нажмите Enter для повтора или Esc для возврата в меню:");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                Console.Clear();
                ShowMenu();
                break;
            }
        }
    }

    static void While()
    {
        while (true)
        {
            Console.Clear();
            string a = "";
            string b = "Да";
            Console.WriteLine("Телеграм — лучший мессенджер?\nОтветьте: Да || Нет");
            while (a != b)
            {
                a = Console.ReadLine();
                if (a == "Нет")
                {
                    Console.WriteLine("Повторите попытку.");
                }
                else if (a != b && a != "Нет")
                {
                    Console.WriteLine("Введите Да || Нет");
                }
            }
            Console.WriteLine("Ответ верный.");
            Console.WriteLine("Нажмите Enter для повтора или Esc для возврата в меню:");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                Console.Clear();
                ShowMenu();
                break;
            }
        }
    }

    static void DoWhile()
    {
        while (true)
        {
            Console.Clear();
            string a = "";
            do
            {
                Console.WriteLine("Вам нужно отдохнуть?\nОтветьте: Да || Нет");
                a = Console.ReadLine();
            }
            while (a != "Да");
            Console.WriteLine("Программа завершена.");
            Console.WriteLine("Нажмите Enter для повтора или Esc для возврата в меню:");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                Console.Clear();
                ShowMenu();
                break;
            }
        }
    }

    static void For()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Для цикла FOR введите начальное число и количество повторений через Enter:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (int.TryParse(a, out int c) && int.TryParse(b, out int d))
            {
                for (int i = c; i < c + d; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректные числа.");
            }
            Console.WriteLine("Нажмите Enter для повтора или Esc для возврата в меню:");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                Console.Clear();
                ShowMenu();
                break;
            }
        }
    }

    static void Foreach()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Для регистрации введите: ФИО, пол, дату рождения, номер телефона, адрес прописки");
            string[] userdata = new string[5];
            Console.WriteLine("ФИО:");
            userdata[0] = Console.ReadLine();
            Console.WriteLine("Пол:");
            userdata[1] = Console.ReadLine();
            Console.WriteLine("Дата рождения:");
            userdata[2] = Console.ReadLine();
            Console.WriteLine("Номер телефона:");
            userdata[3] = Console.ReadLine();
            Console.WriteLine("Адрес прописки:");
            userdata[4] = Console.ReadLine();

            Console.WriteLine("Введенные данные верны?\nДа || Нет");
            string a = Console.ReadLine();
            if (a == "Да")
            {
                Console.WriteLine("Введенные данные:");
                foreach (string item in userdata)
                {
                    Console.WriteLine(item);
                }
            }
            else if (a == "Нет")
            {
                Console.WriteLine("Перезапустите форму.");
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
            }
            Console.WriteLine("Нажмите Enter для повтора или Esc для возврата в меню:");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                Console.Clear();
                ShowMenu();
                break;
            }
        }
    }

    static void Switch()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Введите номер месяца (1-12):");
            string a = Console.ReadLine();
            if (int.TryParse(a, out int b))
            {
                switch (b)
                {
                    case 1: case 2: case 12: Console.WriteLine("Зима"); break;
                    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
                    case 6: case 7: case 8: Console.WriteLine("Лето"); break;
                    case 9: case 10: case 11: Console.WriteLine("Осень"); break;
                    default: Console.WriteLine("Ошибка: введите число от 1 до 12."); break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное число.");
            }
            Console.WriteLine("Нажмите Enter для повтора или Esc для возврата в меню:");
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                Console.Clear();
                ShowMenu();
                break;
            }
        }
    }
}