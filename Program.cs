// int age = 15;
// if (age >= 21) {
//     System.Console.WriteLine("Доступ разрешён");
// }
// System.Console.WriteLine("Программа продолжает работу");

// int age = 15;
// if (age >= 18) {
//     System.Console.WriteLine("Доступ разрешён");
// } else {
//     System.Console.WriteLine("Доступ запрещён");
//     System.Console.WriteLine($"До совершеннолетия: {18 - age} года");
// }

// int age = 18;
// if (age < 13)
// {
//     System.Console.WriteLine("Ребенок");
// } else if (age < 18)
// {
//     System.Console.WriteLine("Подросток");
// } else if (age < 60)
// {
//     System.Console.WriteLine("Взрослый");
// } else
// {
//     System.Console.WriteLine("Пенсионер");
// }

// int age = 16;
// double height = 1.4;
// bool withParent = false;
// if (age >= 14 && height >= 1.5 || height < 1.5 && withParent)
// {
//     System.Console.WriteLine("Можно кататься");
// } else
// {
//     System.Console.WriteLine("Пока нельзя");
// }

// int day = 2132;
// string dayName;
// switch (day)
// {
//     case 1:
//         dayName = "Понедельник";
//         break;
//     case 2:
//         dayName = "Вторник";
//         break;
//     default:
//         dayName = "Другой день";
//         break;
// }
// System.Console.WriteLine(dayName);

// int number = 13;
// string result = (number % 2 == 0) ? "четное" : "нечетное";
// System.Console.WriteLine(result);

// // Задача А
// System.Console.Write("Введите число: ");
// int number = int.Parse(System.Console.ReadLine());
// string result = (number % 2 == 0) ? $"Число {number} - чётное." : $"Число {number} - нечетное.";
// System.Console.WriteLine(result);

// // Задача Б
// System.Console.Write("Ваша оценка (от 2 до 5): ");
// int Grade = int.Parse(System.Console.ReadLine());
// string verbalAssessment;
// switch (Grade)
// {
//     case 2:
//         verbalAssessment = "Неудовлетворительно";
//         break;
//     case 3:
//         verbalAssessment = "Удовлетворительно";
//         break;
//     case 4:
//         verbalAssessment = "Хорошо";
//         break;
//     case 5:
//         verbalAssessment = "Отлично";
//         break;
//     default:
//         verbalAssessment = "Неверная оценка";
//         break;
// }
// System.Console.WriteLine(verbalAssessment);

// Вариант 3 (24.09 я был на больничном, вариант я выбрал с помощью колеса фортуны.)
using System.Runtime.InteropServices;

System.Console.Write("Номер месяца (1-12): ");
int month = int.Parse(System.Console.ReadLine());
if (month == 12 || month == 1 || month == 2)
{
    System.Console.WriteLine("Зима");
} else if (month == 3 || month == 4 || month == 5)
{
    System.Console.WriteLine("Весна");
} else if (month == 6 || month == 7 || month == 8)
{
    System.Console.WriteLine("Лето");
} else if (month == 9 || month == 10 || month == 11)
{
    System.Console.WriteLine("Осень");
} else
{
    System.Console.WriteLine("Неверный месяц");
}