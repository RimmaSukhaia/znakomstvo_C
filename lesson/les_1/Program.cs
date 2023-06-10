
/*
//  программа для сложение 2х чисел
System.Console.WriteLine("введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
System.Console.Write("сумма ");
System.Console.WriteLine(num1+num2);


//программа на деление с остатком

double num1 = 12;
double num2 = 5;
System.Console.WriteLine(num1/num2);


// программа с случайными числами

int num1 = new Random().Next(0, 10);
System.Console.WriteLine(num1);
int num2 = new Random().Next(0, 10);
System.Console.WriteLine(num2);
int result = num1 + num2;
System.Console.WriteLine(result);


//программа на приветствие

System.Console.WriteLine("Введите имя пользователя:  ");
string username = Console.ReadLine();
if(username.ToLower() == "римма")
{
    System.Console.WriteLine("Ура! Это же Римма!");
}
else
{
    System.Console.WriteLine("Привет, "+username);
}



//задача на поиск большего числа

int a = 3;
int b = 5;
int c = 10;
int d = 8;
int e = 1;

int max = a;
if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

System.Console.WriteLine("max = "+max);
*/

//программа с циклом

Console.Clear();

int xa = 20, ya = 1,
    xb = 1, yb = 20,
    xc = 40, yc = 20;

Console.SetCursorPosition(xa, ya);
System.Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
System.Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
System.Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
        if (what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
        if (what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x, y);
    System.Console.WriteLine("+");
    count ++;
}
