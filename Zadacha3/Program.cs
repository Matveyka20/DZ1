Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("Число равно нулю ");
}

if (num % 2 == 0)
{
    Console.WriteLine("Число чётное ");
}
else
{
    Console.WriteLine("Число нечётное ");
}