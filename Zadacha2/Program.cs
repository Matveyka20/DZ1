Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num2 > max)
{
    max =num2;
}
else
{
    max = num1;
}
 if (num3 > max)
{
    max = num3;
}

System.Console.WriteLine($"Максимальным числом является {max}");