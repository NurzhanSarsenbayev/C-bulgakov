//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend(int arg)
{
   return arg > 5;
}


Console.WriteLine("Type your natural number from 1 to 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number<8 && number>0)
{
bool dayoff = Weekend(number);
string result = dayoff ? "yes" : "no";
Console.WriteLine(result);
}
else Console.WriteLine("Invalid number");