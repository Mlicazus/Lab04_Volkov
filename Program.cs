// int age = 15;
// if (age >= 21) {
//     System.Console.WriteLine("Доступ разрешён");
// }
// System.Console.WriteLine("Программа продолжает работу");

int age = 15;
if (age >= 18) {
    System.Console.WriteLine("Доступ разрешён");
} else {
    System.Console.WriteLine("Доступ запрещён");
    System.Console.WriteLine($"До совершеннолетия: {18 - age} года");
}