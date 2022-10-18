// задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());

 if( a !=b )
 {
    if( a > b )
    {
        Console.WriteLine("min: + b");
        Console.WriteLine("max: + a");
    } 
    else
    {
        Console.WriteLine("min: + a");
        Console.WriteLine("max: + b");
    }
 }
 else
{
    Console.WriteLine("ввод разных чисел");
}

