//Задачи на разных ветках.


//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа

using System.Runtime.ExceptionServices;

Console.Write("Введите любое целое число от 0 до 99: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number/100 <=0)
{
    int first_number = number/10;
    int second_number = number%10;
    if(first_number>second_number)
    {Console.Write(first_number);}
    else
    {Console.Write(second_number);}

}
else
{Console.Write("число не входит в требуемый отрезок от 10 до 99");}