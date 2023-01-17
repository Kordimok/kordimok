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

Console.Write("Введи трехзначное число :  ");
int num3 = int.Parse(Console.ReadLine () );
int ost = num3 % 10;
Console.Write(ost);  
