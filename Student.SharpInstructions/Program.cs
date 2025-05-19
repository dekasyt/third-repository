using System;
using System.Net.Http.Headers;

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
        Console.WriteLine($"Для вызова выполняемой подпрограммы укажите ее номер и нажните Enter: \n1 - IF ELSE \n2 - WHILE \n3 - DO WHILE\n4 - FOR\n5 - FOREACH\n6 - SWITCH");
            switch (int.Parse(Console.ReadLine())) 
            {
                case 1: IfElse(); break;
                case 2: While(); break;
                case 3: DoWhile(); break;
                case 4: For(); break;
                case 5: Foreach(); break;
                case 6: Switch(); break;
            }

        }

    }
  

    static void IfElse()
    {
        Console.Clear();
        Console.WriteLine("Для доступа на сайт введите Пароль");
        string password = Console.ReadLine();
        if (password == "Пароль")
        {
            Console.WriteLine("Пароль правильный, доступ открыт");
        }
        else 
        { 
            Console.WriteLine("Пароль не правильный"); 
        }
        Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:");
        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Enter)
        {
            Console.Clear();
            IfElse();
        }
        else if (key == ConsoleKey.Escape)
        {
            Console.Clear();

        }

    }

    static void While()
    {
        Console.Clear();
        Console.WriteLine($"Телеграм лучший мессенджер? \n Дайте ответ: Да || Нет");
        string a = "";
        string b = "Да";
        while (a != b)
        {
            a = Console.ReadLine();
            if (a == "Нет")
            {
                Console.WriteLine("Ответ неверный");
            }
            else if(a != b && a != "Нет")
            {
                Console.WriteLine("Некорректный ввод"); 
            }
        }
        Console.WriteLine("Ответ верный");
        Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:");
        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Enter)
        {
            Console.Clear();
            While();
        }
        else if (key == ConsoleKey.Escape)
        {
            Console.Clear();

        }
    }

    static void DoWhile()
    {
        Console.Clear();
        string Po;
        do
        {
            Console.WriteLine($"Вам нужно отдохнуть? \nДа || Нет");
            Po = Console.ReadLine();
        }
        while (Po != "Да");
        
        Console.WriteLine("Программа завершена.");
        Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:");
        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Enter)
        {
            Console.Clear();
            DoWhile();
        }
        else if (key == ConsoleKey.Escape)
        {
            Console.Clear();

        }
    }

    static void For()
    {

        Console.Clear();
        Console.WriteLine("Для выполнения подпрограммы FOR введите начальное число и количество повторений последовательно через Enter, для возврата к списку подпрограмм нажмите Esc:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            Console.WriteLine(i); 
        }
        Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:");
        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Enter)
        {
            Console.Clear();
            For();
        }
        else if (key == ConsoleKey.Escape)
        {
            Console.Clear();

        }

    }
    static void Foreach()
    {
        Console.Clear();
        Console.WriteLine("Для регистрации введите: ФИО, пол, дату рождения, номер телефона, адрес прописки");
        string[] userdata = new string[5];

        Console.WriteLine("Введите ФИО: ");
        userdata[0] = Console.ReadLine();


        Console.WriteLine("Введите пол: ");
        userdata[1] = Console.ReadLine();


        Console.WriteLine("Введите дату рождения: ");
        userdata[2] = Console.ReadLine();


        Console.WriteLine("Введите номер телефона: ");
        userdata[3] = Console.ReadLine();


        Console.WriteLine("Введите адрес прописки: ");
        userdata[4] = Console.ReadLine();


        Console.WriteLine($"Введенные данные верны? \n Да || Нет");
        string a = Console.ReadLine();
        if (a == "Да")
        {
            Console.WriteLine("Введенные данные: ");
            foreach (string z in userdata)
            {
                Console.WriteLine(z);
            }
        }
        else if (a == "Нет")
        {
            Console.WriteLine("Перезапустите форму!");
        }
        else
        {
            Console.WriteLine("Некорректный ввод!");
        }
            Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:");
        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Enter)
        {
            Console.Clear();
            Foreach();
        }
        else if (key == ConsoleKey.Escape)
        {
            Console.Clear();

        }
        
    }
    static void Switch()
    {
        Console.Clear();
        Console.WriteLine("номер месяца (целое число от 1 до 12), программа выводит к какому сезону относится этот месяц: Зима, Весна, Лето или Осень");
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1: case 2: case 12: Console.WriteLine("Зима"); break;
            case 3: case 4: case 5: Console.WriteLine("Весна"); break;
            case 6: case 7: case 8: Console.WriteLine("Лето"); break;
            case 9: case 10: case 11: Console.WriteLine("Осень"); break;
            default: Console.WriteLine("Некорректный ввод"); break;
        }
        Console.WriteLine("Для повтора выполнения подпрограммы нажмите Enter, для возврата к списку подпрограмм нажмите Esc:");
        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Enter)
        {
            Console.Clear();
            Switch();
        }
        else if (key == ConsoleKey.Escape)
        {
            Console.Clear();

        }
    }
}
