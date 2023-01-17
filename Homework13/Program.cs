//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int thirdDigit(int arg1)
{
    while (arg1 > 1000)
    {
       arg1 = arg1/10;
    }
    arg1 = arg1%10;
    return arg1;

}


int number = new Random().Next(-9999999,999999);
Console.WriteLine($"Your number is {number}");
 if (number<0)
 number = number*-1;
 else number = number;
         if (number>100)
             {
               int result = thirdDigit(number);
               Console.WriteLine($"Third digit from the left is {result}");
             }
         else Console.WriteLine("There is no third digit");