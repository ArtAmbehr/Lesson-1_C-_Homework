// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write ("Введите цифру 1: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write ("Введите число больше нуля: ");
int numberB = int.Parse(Console.ReadLine());
int count = numberA;
while (count < numberB)
{
        count++;

    if (count % 2 == 0) 
    {
        Console.Write(count + " ");
    }
}
