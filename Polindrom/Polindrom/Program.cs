//3. Daxil edilən müsbət tam ədədin palindrom olub-olmamasını yoxlayın 
int numbers = 47874;
int numbers1;
int r;
int m = 0;
numbers1 = numbers;
while (numbers != 0)
{
    r = numbers % 10;
    m = m * 10 + r;
    numbers /= 10;
}
if (m == numbers1)
{
    Console.WriteLine("polindrom");
}
else
{
    Console.WriteLine("polindrom deyil");
}
Console.ReadLine();
