// Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее,
//а какое меньшее
int maxNumber = 0;
int minNumber = 0;

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    maxNumber = firstNumber;
    minNumber = secondNumber;
}
else
{
    maxNumber = secondNumber;
    minNumber = firstNumber;
}
System.Console.WriteLine($"max =  {maxNumber} min = {minNumber}");
