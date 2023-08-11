Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
int i = 1;

while (i <= n)
{
    if (i % 2 == 0)
    {
    System.Console.Write($"{i} ");
    i = i + 1;
    }
    else
    {
        i = i + 1;
    }
}