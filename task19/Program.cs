// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int GetNumber()
{
    int number = 0;
    while (number < 9999 || number > 99999)
    {
       Console.WriteLine("Введите пятизначное число!");
       number = Convert.ToInt32(Console.ReadLine());  
    }
       return number;
}

void CheckPalindrom(int number)
{
    int currentN = number;
    int result = 0;
    while (currentN > 0)
    {
        int digit = currentN % 10;
        result = result * 10 + digit;
        currentN /= 10;
        // Console.WriteLine(result);
    }
        if (number == result)
        {
            Console.WriteLine($"число {number} палиндром"); 
        }
        else
        {
            Console.WriteLine($"число {number} не палиндром");    
        }
}
   
int number = GetNumber();
CheckPalindrom(number);
