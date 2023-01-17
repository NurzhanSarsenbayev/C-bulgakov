// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool Multi723(int arg)
{
 if (arg % 7 == 0 && arg % 23 == 0)
    return true;
 return false;
}

Console.WriteLine ("Write your number ");
int number = Convert.ToInt32(Console.ReadLine());
bool result= Multi723(number);
if (result) Console.WriteLine("yes");
else { Console.WriteLine("no");
};

