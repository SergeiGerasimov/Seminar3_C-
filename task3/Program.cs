// Напишите программу, которая принимает на вход число (N) 
// и выдает таблицу квадратов чисел от 1 до n
// 5 - 1, 4, 9, 16, 25
// 2 - 1, 4

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num<1) Console.WriteLine("Введите положительное число ");

void PrintQuart (int number)
{
        for(int i = 1; i <= number; i++)//перебираем от 1 до number
    Console.WriteLine($"{i} \t {i*i}");// \t-табуляция, для вывода в виде таблицы
}

PrintQuart(num);