// Напишите программу, которая выводит
//  случайное число из отрезка [10, 99]
//   и показывает наибольшую цифру числа.
// Например:
// 78 -> 8    78/10=7;  78%10=8;
// 12-> 2    146/100=1;  146 % 10=6
// 85 -> 8

    // int num= new Random().Next(10,100);
    // Console.WriteLine(num);

    // int num1=num/10;
    // int num2=num%10;

    // if (num1>num2)
    // {
    //     Console.WriteLine(num1);
    // }
    // else if(num1==num2)
    // {
    //     Console.WriteLine("Равны");
    // }
    // else
    // {
    //     Console.WriteLine(num2);
    // }


//     Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num= new Random().Next(100,1000);
// Console.WriteLine(num);

// int num1=num/100;
// int num2=num%10;

// int result= num1*10+num2;

// Console.WriteLine(result);

// Напишите программу, которая будет 
// принимать на вход два числа и выводить,
//  является ли второе число кратным первому.
//   Если число 2 не кратно числу 1, то программа 
//   выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4       34/5=6
// 16, 4 -> кратно                     16/4=4

// int num= new Random().Next(100,1000);

// Console.WriteLine("Введите большее  число");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2=Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0) 
// {
//     Console.WriteLine("Кратны");
// }
// else
// {
//     // Console.WriteLine("Остаток от деления"+ num1 % num2); Канкатинация

//     // Интерполяция
//     Console.WriteLine($"Остаток от деления {num1 % num2}");
// }

// Напишите программу, которая будет 
// принимать на вход два числа и выводить,
//  является ли второе число кратным первому.
//   Если число 2 не кратно числу 1, то программа 
//   выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4       34/5=6
// 16, 4 -> кратно                     16/4=4

// int num= new Random().Next(100,1000);

// Console.WriteLine("Введите большее  число");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2=Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0) 
// {
//     Console.WriteLine("Кратны");
// }
// else
// {
//     // Console.WriteLine("Остаток от деления"+ num1 % num2); Канкатинация

//     // Интерполяция
//     Console.WriteLine($"Остаток от деления {num1 % num2}");
// }

// Напишите программу, которая принимает
//  на вход число и проверяет, кратно ли 
//  оно одновременно 
// 7 и 23.
// 14 -> нет 
// // 46 -> нет 
// // 161 -> да   && и   || или

// Console.WriteLine("Введите число");
// int num1=Convert.ToInt32(Console.ReadLine());

// if ((num1 % 7 == 0) && (num1 % 23 == 0)) 
// {
//     Console.WriteLine("Да");
// }
// else
// {
//    Console.WriteLine("Нет");
// }

// Напишите программу, которая принимает
//  на вход два числа и проверяет, является 
//  ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("Введите число");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2=Convert.ToInt32(Console.ReadLine());

// if ((num1 == num2*num2) || (num2 == num1*num1)) 
// {
//     Console.WriteLine("Да");
// }
// else
// {
//    Console.WriteLine("Нет");
// }

// ___________________________________________ДЗ________________________________________________


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int num= new Random().Next(100,1000);
// Console.WriteLine(num);

// int num1= num % 100; 

// int num2= num1/10;

// int result= num2;

// Console.WriteLine(result);




// ________________________________________Задача№ 15____________________________
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


// Console.WriteLine ("Введите номер дня недели");
// int num=Convert.ToInt32 (Console.ReadLine());

// while (num<6 & num>-0)
// {
// Console.WriteLine ("Будний день");
// break;
// }


// while (num<8 & num>5)
// {
// Console.WriteLine ("Выходной день");
// break;
// }

// while (num>7)
// {
// Console.WriteLine ("Такого дня нет");
// break;
// }


// ___________________________________________________________Задача 13________________________________

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.WriteLine ("введите 3-х или более значное число");


// Console.WriteLine("Введите число");
// int num= Convert.ToInt32(Console.ReadLine());

// if(num<=99)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else if(num>=100 && num<999)
// {
//     int num1= num/100;
//     int num2= (num-(num1*100))%10;
//     Console.WriteLine(num2);
// }
// else if(num>=1000 && num<9999)
// {
//     int num1= num/10;
//     int num2= num1%10;
//     Console.WriteLine(num2);
// }
// else if(num>=10000 && num<99999)
// {
//     int num1= num/100;
//     int num2= num1%10;
//     Console.WriteLine(num2);
// }


// Console.WriteLine("Write number: ");
// int num= Convert.ToInt32(Console.ReadLine());

// if (num / 100 == 0)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while(num>1000)
//     {
//         num= num/10;
//     }

//     Console.WriteLine(num%10);
// }