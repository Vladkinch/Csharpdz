
// Console.WriteLine("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sqrt = number * number;
// Console.WriteLine("число в квадрате: " + sqrt);

Console.Write("введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <= 999)
{
    Console.WriteLine("последняя цифра трехзначного числа: " + Math.Abs(number) % 10);

}
else
{
    Console.WriteLine("введено не трех значное число");
}