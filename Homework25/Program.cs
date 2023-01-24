// 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//  3, 5 -> 243 (3⁵)
//  2, 4 -> 16

void Exponent(double number, int expNumb)  // в задании написано цикл, а не программа. Так что написал только метод.
{
    double finalnumb = 1;
    for (int i = 0; i < expNumb; i++)
    {
        finalnumb = finalnumb*number;
        
    }
    Console.WriteLine($"{number}, {expNumb} -> {finalnumb}");
}

Exponent(3,5);

Exponent(2,4);

Exponent(2.5,4);   // так как в условии написано только про натуральную степеньь, сделал вариант с дробным первым числом