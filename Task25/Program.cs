Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int exp = 1;
while (b > 0)
{
    exp = exp * a;
    b = b - 1;
}
Console.WriteLine(exp);