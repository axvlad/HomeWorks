using System;

namespace MathGaem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            var date = DateTime.Now;
            Console.WriteLine
(@"******************************************
Привет, я хочу сыграть с тобой в одну игру
******************************************");

            Console.WriteLine("\nТы готов?");
            Console.WriteLine("(Введи да/нет)");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Ввести ответ: ");
            string answ1 = Console.ReadLine();

            if (answ1 == "да" || answ1 == "yes" || answ1 == "da")
            {
                Console.ResetColor();
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Тогда начинаем");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\nВведи свое имя чтобы продолжить: ");
                string name = Console.ReadLine();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine(name + " нужно будет немного напряч мозги. Ты точно готов?");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nНажми Enter, если готов");
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Необходимо решить пример и написать решение (число)");
                Console.WriteLine("6:2(1+2)");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\nВведи свой ответ: ");

                int answ2 = Convert.ToInt32(Console.ReadLine());

                if (answ2 == 9)
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Откуда ты знал правильный ответ?");
                    Console.WriteLine("Молодец, двигаемся дальше");
                }
                else if (answ2 != 9)
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(name + " ,ты был очень близок но нет. Хочешь узнать ответ?");
                    Console.Write("\n(напиши да/нет):");
                    string answ3 = Console.ReadLine();

                    if (answ3 == "да")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nДля наглядности упростим примемр и посмотрим на ответ: ");
                        Console.WriteLine("6:2*3=9");
                        Console.WriteLine("Правильный ответ = 9");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nОчень жаль, что не хочешь. В любом случае, правильный ответ = 9");
                    }

                }
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nНажми Enter для перехода на следующий уровень");
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(1, 1);
                Console.WriteLine("***Это не выход***");
                Console.SetCursorPosition(2, 3);
                Console.WriteLine("***Это не выход***");
                Console.SetCursorPosition(3, 5);
                Console.WriteLine("***Это не выход***");
                Console.SetCursorPosition(4, 7);
                Console.WriteLine("***Это не выход***");
                Console.SetCursorPosition(5, 9);

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(19, 0);
                Console.WriteLine("***И это не выход***");
                Console.SetCursorPosition(20, 2);
                Console.WriteLine("***И это не выход***");
                Console.SetCursorPosition(21, 4);
                Console.WriteLine("***И это не выход***");
                Console.SetCursorPosition(22, 6);
                Console.WriteLine("***И это не выход***");
                Console.SetCursorPosition(23, 8);

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(39, 0);
                Console.WriteLine("***Снова не выход***");
                Console.SetCursorPosition(40, 2);
                Console.WriteLine("***Снова не выход***");
                Console.SetCursorPosition(41, 4);
                Console.WriteLine("***Снова не выход***");
                Console.SetCursorPosition(42, 6);
                Console.WriteLine("***Снова не выход***");
                Console.SetCursorPosition(43, 8);

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(59, 0);
                Console.WriteLine("***Ищи дальше***");
                Console.SetCursorPosition(60, 2);
                Console.WriteLine("***Ищи дальше***");
                Console.SetCursorPosition(61, 4);
                Console.WriteLine("***Ищи дальше***");
                Console.SetCursorPosition(62, 6);
                Console.WriteLine("***Ищи дальше***");
                Console.SetCursorPosition(63, 8);

                Console.SetCursorPosition(95, 5);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*****НАЙДИ  ВЫХОД*****");
                Console.SetCursorPosition(95, 6);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("**********************");
                Console.SetCursorPosition(95, 4);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("**********************");

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(135, 0);
                Console.WriteLine("***Продолжаем  поиск****");
                Console.SetCursorPosition(134, 2);
                Console.WriteLine("***Продолжаем  поиск****");
                Console.SetCursorPosition(133, 4);
                Console.WriteLine("***Продолжаем  поиск****");
                Console.SetCursorPosition(132, 6);
                Console.WriteLine("***Продолжаем  поиск****");
                Console.SetCursorPosition(131, 8);

                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(159, 0);
                Console.WriteLine("***Ты почти у цели***");
                Console.SetCursorPosition(158, 2);
                Console.WriteLine("***Ты почти у цели***");
                Console.SetCursorPosition(157, 4);
                Console.WriteLine("***Ты почти у цели***");
                Console.SetCursorPosition(156, 6);
                Console.WriteLine("***Ты почти у цели***");
                Console.SetCursorPosition(155, 8);

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(185, 7);


                Console.WriteLine("####🄴🅇🄸🅃####");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(185, 8);
                Console.WriteLine("**Нажми ENTER**");


                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(name + " - ты красавчик, лови сердечко. Осталось парочку вопросов.");

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Жми Enter и двигаемся дальше");

                Console.ResetColor();
                Console.WriteLine("\n");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("──────██────────────██");
                Console.WriteLine("───███▓▓█─██────██─█▓▓███");
                Console.WriteLine("──█▒▒█▓▓██▒▒█──█▒▒██▓▓█▒▒█");
                Console.WriteLine("──█▒▒███░█▒▒████▒▒█░███▒▒█");
                Console.WriteLine("─████░░░░░███▓▓███░░░░░███​█");
                Console.WriteLine("█▓▓█░░░░░░░░█▓▓█░░░░░░░░█▓​▓█");
                Console.WriteLine("█▓▓█░░░░░░░░░██░░░░░░░░░█▓​▓█");
                Console.WriteLine("─██░░░░░░░░░░░░░░░░░░░░░░█​█");
                Console.WriteLine("█▒▒█░░▄██▄██▄░░▄██▄██▄░░█▒​▒█");
                Console.WriteLine("█▒▒█░░▀██▄██▀░░▀██▄██▀░░█▒​▒█");
                Console.WriteLine("─████░░░▀█▀░░░░░░▀█▀░░░███​█");
                Console.WriteLine("──█▓▓█░░░░░░░░░░░░░░░░░█▓▓​█");
                Console.WriteLine("──█▓▓█░░▀▄▄▄▄▄▄▄▄▄▄▀░░░█▓▓​█");
                Console.WriteLine("───████░░░▄▄▄▄▄▄▄▄♥░░████");
                Console.WriteLine("────█▒▒█░░░░░░░░░░░░█▒▒█");
                Console.WriteLine("────█▒▒███░░░░░░░░███▒▒█");
                Console.WriteLine("─────███▓▓█░░░░░░█▓▓███");
                Console.WriteLine("───────█▓▓███░░███▓▓█");
                Console.WriteLine("────────███▒▒██▒▒███");
                Console.WriteLine("──────────█▒▒██▒▒█");
                Console.WriteLine("───────────██▓▓██");
                Console.WriteLine("────────────█▓▓█");
                Console.WriteLine("─────────────██ ");

                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Сколько будет 7 в 7 степени?");
                Console.WriteLine("Если лень считать напиши цифру 1 и нажми Enter");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\nОтвет: ");

                int answ4 = Convert.ToInt32(Console.ReadLine());

                if (answ4 == 823543)
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(name + ", ты - молодец, все умеют гуглить и пользоваться калькулятором :)");
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nДля перехода на следующий уровень напиши фразу: 'я сам решал' и нажми Enter");
                }
                else if (answ4 != 823543)
                {
                    
                    Console.ResetColor();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Правильный ответ - 823543, но считать было необязательно :) Осталось 3 вопроса, жми Enter и двигаемся дальше");
                }
                else
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Правильный ответ - 823543, но считать было необязательно, пусть это делают другие. Осталось 3 вопроса, жми Enter и двигаемся дальше");
                }

                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Теперь гуглить точно нельзя");
                Console.WriteLine("Какая стола Турции?");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\nОтвет: ");
                string answ5 = Console.ReadLine();
                Console.WriteLine("Жми Enter");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nКакая столица Канады?");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Ответ: ");
                string answ6 = Console.ReadLine();

                if (answ5 == "Анкара" && answ6 == "Оттава")
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ты точно не гуглил? {0}, - ты молодец", name);
                }
                else if (answ5 == "Анкара" && answ6 != "Оттава")
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}, ты прав на половину. Да, столица Турции - {1}, но столица Канады - Оттава", name, answ5);
                }
                else if (answ5 != "Анкара" && answ6 == "Оттава")
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("{0}, ты прав на половину. Столица Турции - Анкара, а столица Канады - {1}", name, answ6);
                }
                else
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ты был близок. Столица Турции - Анкара, Столица Канады - Оттава");
                }

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nНажми Enter для перехода к финальному вопросу");
                Console.WriteLine("Надеюсь, ты не устал :)");

                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Задачка на подумать");
                Console.WriteLine("Простая математическая загадка. Бейсбольный мяч и бита вместе стоят 1 доллар и 10 центов. " +
                    "При этом бита стоит на 1 доллар дороже мяча. Сколько стоит мяч?");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("\nВведи ответ (целое число): ");
                int answ7 = Convert.ToInt32(Console.ReadLine());

                if (answ7 == 5)
                {
                    Console.ResetColor();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Молодец!Более 50% студентов Гарварда, Принстона и Массачусетского " +
                        "технологического института неправильно ответили на вопрос");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Это неправильный ответ. Но не переживай Более 50% студентов Гарварда, " +
                        "Принстона и Массачусетского " +
                        "технологического института неправильно ответили на вопрос");
                    Console.WriteLine("Хочешь узнать правильный ответ?");
                    Console.WriteLine("(Напиши да/нет): ");
                    string answ8 = Console.ReadLine();

                    if (answ8 == "да")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Правильный ответ - 5 центов. Для наглядности приведу в качестве примера уравнение");
                        Console.WriteLine("Мяч примем за х, биту за х+1.");
                        Console.WriteLine("х+(х+1)=1.1");
                        Console.WriteLine("2х+1=1.1");
                        Console.WriteLine("2х=0.1");
                        Console.WriteLine("х=0,05");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Очень жаль, но все равно: равильный ответ - 5 центов. Для наглядности приведу в качестве примера уравнение");
                        Console.WriteLine("Мяч примем за х, биту за х+1.");
                        Console.WriteLine("х+(х+1)=1.1");
                        Console.WriteLine("2х+1=1.1");
                        Console.WriteLine("2х=0.1");
                        Console.WriteLine("х=0,05");
                    }
                }

                
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Нажми Enter для завершения");
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                Console.WriteLine(name + ", твои ответы:");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Задание 1: " + answ2);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Правильный ответ: 9");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Задание 2: " + answ4);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Правильный ответ: 823543");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Задание 3: " + answ5);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Правильный ответ: Анкара");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Задание 4: " + answ6);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Правильный ответ: Оттава");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Задание 5: " + answ7);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Правильный ответ: 5 центов");

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Для завершения работы нажми Enter");
                Console.ReadLine();
            }

            else if (answ1 == "нет" || answ1 == "no" || answ1 == "net" || answ1 == "ne" || answ1 == "не")
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Очень жаль. Хорошего дня. Перезапусти приложение, если захочешь начать");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nБудь внимательнее, такого варианта ответа нет");
                Console.WriteLine("Перезапусти приложение и начни сначала");
                Console.ReadLine();
            }

        }

    }
        
    }

