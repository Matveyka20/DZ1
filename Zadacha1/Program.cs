Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("Первое число равно второму");
}
else if (num1 > num2)
{
    Console.WriteLine("Первое число большее, а второе меньшее ");
}
else 
{
    Console.WriteLine("Второе число большее, а первое меньшее ");
}
