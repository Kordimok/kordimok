// Напишите программу которая на вход принимает число и выдает его квадрат
// Console.Write ("Введите число : ");
// int number = int.Parse(Console.ReadLine ( )!);

// // решаем математически
// int num = number * number ;
// Console.WriteLine (num);
// Console.WriteLine ($"Квадрат этого  числа {number} равен {num}");


// // решение через библиотеку
// int num2 = Convert.ToInt32(Math.Pow(number, 2));  
// Console.WriteLine ($"Квадрат числа {number} равен {num}");

// // // Напишите программу которая на вход принимает число и выдает его квадрат
// // Console.Write ("Введите число : ");
// // int number = int.Parse(Console.ReadLine ( )!);

// // // решаем математически
// // int num = number * number ;
// // Console.WriteLine (num);
// // Console.WriteLine ($"Квадрат этого  числа {number} равен {num}");


// // // решение через библиотеку
// // int num2 = Convert.ToInt32(Math.Pow(number, 2));  
// // Console.WriteLine ($"Квадрат числа {number} равен {num}");
// ___________________________________________________________________________________________


//Написать программу которую выдает название дня недели по заданному номеру

// Console.Write ("Введите  число  ");
// int x = int.Parse(Console.ReadLine());
// if (x == 1)
// {
//     Console.Write ("Понедельник ");
// }
// if (x == 2)
// {
//     Console.Write ("Вторник ");
// }
// if (x == 3)
// {
//     Console.Write ("Среда ");
// }
// if (x == 4)
// {
//     Console.Write ("Четверг ");
// }
// if (x == 5)
// {
//     Console.Write ("Пятница ");
// }
// if (x == 6)
// {
//     Console.Write ("Суббота ");
// }
// if (x == 7)
// {
//     Console.Write ("Воскресенье ");
// }   
// else if (x<1||x>7)
// {
//     Console.Write( "Такого дня не бывает" );      
// }
// ___________________________________________________________________


//Необходимо написать программу которая на вход принимает одно число n, а на выходе показывает все целые числа в промежутке от -n до n.

// Console.WriteLine ("Введите число ");
// int a = int.Parse(Console.ReadLine()); 
// int count = -a;
// while(count <= a)
// {    
//     Console.Write($"{count}  ");
//     count++ ; 
// }  
// _____________________________________________________________


//необходимо написать программу которая принимает на вход 3х значное число и на выходе показыват последню цифру этого числа

// Console.Write("Введи трехзначное число :  ");
// int num3 = int.Parse(Console.ReadLine () );
// int ost = num3 % 10;
// Console.Write(ost);  

// _______________________________________________________
//                                          ДЗ 1 семинар

// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write ("Введите число a : ");
// int a = int.Parse(Console.ReadLine ( )!);
// Console.Write ("Введите число b : ");
// int b = int.Parse(Console.ReadLine ( )!);
// if (a > b) 
// {
//     Console.WriteLine($"Максимальное число {a} ");
// }
// else
// {
//     Console.WriteLine($"Максимальное число {b} ");
// }
// if (a < b) 
// {
//     Console.WriteLine($"Минимальное число {a} ");
// }
// else
// {
//     Console.WriteLine($"Минимальное  число {b} ");
}
// _________________________________________________________

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write ("Введите первое число  : ");
int a = int.Parse(Console.ReadLine ( )!);
Console.Write ("Введите второе число  : ");
int b = int.Parse(Console.ReadLine ( )!);
Console.Write ("Введите третье число  : ");
int c = int.Parse(Console.ReadLine ( )!);

int maximal = Math.Max(Math.Max(a, b), c);
int minimal = Math.Min(Math.Min(a, b), c);

Console.WriteLine($"Максимально число {maximal} ");
