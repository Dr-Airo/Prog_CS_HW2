// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.WriteLine("Введите любое трёхзначное число (от 100 до 999)");
// int x=Convert.ToInt32(Console.ReadLine());
// int y = x%100;
// int z = y/10;
// if (x<100) Console.WriteLine ("Вы ввели не трехзначное число");
// else if (x>1000) Console.WriteLine ("Вы ввели не трехзначное число");
// else Console.WriteLine ($"Вторая цифра, введенной вами числа - {z}");
 
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Очень долго думал, как реализовать хотя бы что-то. Поэтому, другого варианта решения не знаю. 
// Я с нуля в программировании. Хотелось бы посмотреть на код, в котором не будет ограничения (до 100k), помимо массива. 
// Console.WriteLine("Введите число до 100k");
// int x=Convert.ToInt32(Console.ReadLine());
// int y = x%10;
// int z = (x%100)/10;
// int i = (x%1000)/100;
// if (x<100) Console.WriteLine("В числе нет третьей цифры");
// else if (x<1000) Console.WriteLine ($"Третья цифра - {y}");
// else if (x<10000) Console.WriteLine ($"Третья цифра - {z}");
// else if (x<100000) Console.WriteLine ($"Третья цифра - {i}");

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.WriteLine("Введите число, соответсвующее дню недели");
// int x=Convert.ToInt32(Console.ReadLine());
// if (x == 6) Console.WriteLine("Это выходной день - СУББОТА!");
// else if (x == 7) Console.WriteLine("Это выходной день - Воскресенье. Уже!");
// else if (x < 6) Console.WriteLine("Это будний день");
// else Console.WriteLine("В неделе только 7 дней Оо");

// N программистов
// Console.WriteLine("Введите число N");
// int x=Convert.ToInt32(Console.ReadLine());
// if (x % 100 == 11 || x % 100 ==12 || x % 100 ==13  || x % 100 ==14) Console.WriteLine($"{x} программистов");
// else if (x % 10 == 1) Console.WriteLine($"{x} программист");
// else if (x % 10 == 2 || x % 10 == 3 || x % 10 == 4) Console.WriteLine($"{x} программиста");
// else Console.WriteLine($"{x} программистов");