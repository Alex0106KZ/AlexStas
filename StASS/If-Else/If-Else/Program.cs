Console.WriteLine("Эта программа Дикого Санина");
Console.WriteLine("Введите четное число");

int b = 2;
int a = int.Parse(Console.ReadLine());

int result = a % b;
    
if (result == 0)
{
    Console.WriteLine("Вы Ввели четное число");
}
else
{
    Console.WriteLine("Вы ДОЛБОЕБ!");
}