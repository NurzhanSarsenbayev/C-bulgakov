//. Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.WriteLine("Type your even number from 1 to 7 ");
string numberA = (Console.ReadLine());
if (numberA == "1")
{
    Console.WriteLine("1 is for Monday");
}

else if (numberA == "2")
{
 Console.WriteLine("2 is for Tuesday");
}
else if (numberA == "3")
{
 Console.WriteLine("3 is for Wednesday");
}
else if (numberA == "4")
{
 Console.WriteLine("4 is for Thursday");
}
else if (numberA == "5")
{
 Console.WriteLine("5 is for Friday");
}
else if (numberA == "6")
{
 Console.WriteLine("6 is for Saturday");
}
else if (numberA == "7")
{
 Console.WriteLine("7 is for Sunday");
}
else 
{
    Console.WriteLine("Invalid Number");
};
