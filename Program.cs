//Задачи на разных ветках.


//Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

Console.Write("Введите целое число: ");
double number = Convert.ToInt32(Console.ReadLine());
double len = (number.ToString()).Length;

double i = 1;
double c = 10;
double a = Math.Pow(c, len - 1);
while (i < len )
{
    int result = (int)(number / a);
    number = (int)(number % a);
    Console.Write(result + ",");
    a = a / 10;
    i++;
  
}

Console.Write(number);
