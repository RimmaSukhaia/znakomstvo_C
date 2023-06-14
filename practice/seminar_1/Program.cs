/*

// программа принимает на вход число и выдает его квадрат

 System.Console.WriteLine("Введите число: ");
 int num = Convert.ToInt32(Console.ReadLine());
int step = 2;
 int sq = (int)Math.Pow(num, step);
 System.Console.WriteLine($"{sq} квадрат числа {num}");

 */
 /*

 // напишите программу, которая на вход принимает 2 числа и проверяет,
 // является ли первое число квадратом второго?

System.Console.Write("Введите число1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sq = (int)Math.Pow(num2, 2);
if(num1 == sq)
{
    System.Console.WriteLine($"число {num1} явяется квадратом {num2}");
}
else System.Console.WriteLine($"число {num1} НЕ явяется квадратом {num2}");

*/

/*
 //напишите програму, которая по вводимому числу определяет день недели

 System.Console.WriteLine("Введите номер дня недели: ");
 int num = int.Parse(Console.ReadLine());

 if (num == 1) System.Console.WriteLine("понедельник");
 else if (num == 2)System.Console.WriteLine("вторник");
else if (num == 3) System.Console.WriteLine("среда");
else if (num == 4)System.Console.WriteLine("четверг");
 else if (num == 5) System.Console.WriteLine("пятница");
else if (num == 6)System.Console.WriteLine("суббота");
else if(num == 7) System.Console.WriteLine("воскресенье");
 else Console.WriteLine("неверное значение");

 */

/*
 //напишите программу, которая на вход принимает число N и выдает
 // все целые числа от -N до N

System.Console.WriteLine("введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = num*(-1);
while(i < num)
{
    Console.Write($"{i}, ");
    i++;
}
*/

 //напишите програму, которая принимает на вход трехзначное число и 
 //выдает последнюю цифру 
 System.Console.WriteLine("введите трехзначное число: ");
 int num = int.Parse(Console.ReadLine());

 int n = num%10;
 System.Console.WriteLine(n);