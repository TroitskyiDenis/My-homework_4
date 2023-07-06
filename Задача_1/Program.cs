// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int GetNumber(string msg)
{
    Console.Write(msg);
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}

Console.Clear();
Console.WriteLine("Введите два числа:  ");
int rezult=1;
int a = GetNumber("Число А ");
int b = GetNumber("Число B ");
for (int i = 0; i < b; i++)
{
    rezult *= a;
}
Console.WriteLine($"Натуральная степень ->  {rezult}");