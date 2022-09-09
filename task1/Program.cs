// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string GetQuarter(int number)
{
    if (number == 1) return "Диапазон возможных координат: x > и y > 0 ";
    if (number == 2) return "Диапазон возможных координат: x < и y > 0 ";
    if (number == 3) return "Диапазон возможных координат: x < и y < 0 ";
    if (number == 4) return "Диапазон возможных координат: x > и y < 0 ";
    return "Введены некорректные координаты";
}

string result = GetQuarter(num);
Console.WriteLine(result);
