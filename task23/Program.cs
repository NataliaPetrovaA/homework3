// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int GetNumber()
{
    int N = 0;
    while (N < 1)
    {
       Console.WriteLine("Введите число!");
       N = Convert.ToInt32(Console.ReadLine());  
    }
    return N;
}

void GetTabSquaring(int N)
{
    Console.WriteLine("Таблица кубов до " + N + ": ");
    int meaning = 1;
    while (meaning <= N)
{
       Console.WriteLine($"{meaning} * {meaning} * {meaning} = {Math.Pow((meaning),3)}");
       meaning ++;
}
}
GetTabSquaring(GetNumber());

