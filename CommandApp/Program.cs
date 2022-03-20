class program
{
    static void Main(string[] args)
    {
        string userName;
        string changeUserName = "Change name";
        string userPassword;
        string changeUserPassword = "Change password";
        string exitSystem = "Escape";
        string changeBackGroundConsoleColor = "Change background color";
        string ChangeConsoleColor = "Change console color";
        string userInput;
        string backgroundColorRed = "Красный";
        string backgroundColorGreen = "Зеленый";
        string backgroundColorBlue = "Синий";
        string foregroundColorBlack = "Черный";
        string foregroundColorGray = "Серый";

        Console.WriteLine("Меня зовут IO, перед тем как начать, представьтесь и придумайте пароль.");
        Console.WriteLine("Как вас зовут?");
        userName = Console.ReadLine();
        Console.WriteLine($"Привет {userName}! Теперь придумай пароль.");
        userPassword = Console.ReadLine();
        Console.WriteLine($"Отлично {userName}, добро пожаловать в меню!");
        Console.WriteLine("Введи одну из комманд, представленных ниже:");
        Console.WriteLine($"{changeUserName} - Сменить имя.\n{changeUserPassword} - Сменить пароль.\n{changeBackGroundConsoleColor} - Сменить цвет фона консоли\n" +
            $"{ChangeConsoleColor} - Изменить цвет строки в консоли.\n{exitSystem} - выход из системы.");
        userInput = Console.ReadLine();

        switch (userInput)
        {
            case "Change name":
                Console.Write("Введите новое имя:");
                userName = Console.ReadLine();
                Console.WriteLine($"Имя изменено,{userName}");
                break;
            case "Change password":
                Console.WriteLine("ВВедите старый пароль:");
                userInput = Console.ReadLine();
                if(userInput == userPassword)
                {
                    Console.WriteLine("Введите новый пароль:");
                    userPassword = Console.ReadLine();
                    Console.WriteLine("Пароль успешно изменен!");
                }
                else
                {
                    Console.WriteLine("Неверный пароль.");
                }
                break;
            case "Change background color":
                Console.WriteLine($"Выберите один из трех цветов фона:\n{backgroundColorBlue}\n{backgroundColorGreen}\n{backgroundColorRed}");
                userInput = Console.ReadLine();
                if(userInput == backgroundColorBlue)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("Цвет фона изменен на синий.");
                }
                else if(userInput == backgroundColorGreen)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Цвет фона изменен на зеленый.");
                }
                else if(userInput== backgroundColorRed)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Цвет фона изменен на красный.");
                }
                else
                {
                    Console.WriteLine("Такого цвета нет.");
                }
                break;
            case "Change console color":
                Console.WriteLine($"Выберите один из двух цветов:\n{foregroundColorBlack}\n{foregroundColorGray}");
                userInput= Console.ReadLine();
                if( userInput == foregroundColorBlack)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if(userInput == foregroundColorGray)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.WriteLine("Такого цвета нет.");
                }
                break;
            case "Escape":
                Console.WriteLine("Досвидания!");
                break;
            default:
                Console.WriteLine("Комманда несуществует");
                break;
        }
    }
}