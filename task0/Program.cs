// Напишите программу, которая принимает на вох координаты точки (X и Y),
// причем X не = 0 и Y не = 0 и выдает номер четверти плоскости, в которой 
// находится эта точка.

//Console.Clear();
Console.WriteLine("Введите координаты точки: ");
Console.Write("X - ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y - ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть ");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть "); // else нам нужен для, чтобы программа не проверяла все условия
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть ");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть ");
// else Console.WriteLine("Введены некорректные координаты");

// Программа с помощью метода

string GetQuarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть ";
    if (xc < 0 && yc > 0) return "Вторая четверть "; 
    if (xc < 0 && yc < 0) return "Третья четверть ";
    if (xc > 0 && yc < 0) return "Четвертая четверть ";
    return "Введены некорректные координаты";
}

string result = GetQuarter(x, y);
Console.WriteLine(result);

// int quarter = 0;
// if (x > 0 && y > 0) quarter = 1;
// else if (x < 0 && y > 0) quarter = 2;
// else if (x < 0 && y < 0) quarter = 3;
// else if (x > 0 && y < 0) quarter = 4;

// if (x != 0 && y != 0) Console.WriteLine($"{quarter} четверть");
// else Console.WriteLine("Введены некорректные координаты");
