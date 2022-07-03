//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Console.WriteLine("Введите число");
//int a = Convert.ToInt32(Console.ReadLine());

void thirdNum(int arg){
     string arg_s = Convert.ToString(arg);
     double n = arg_s.Length;
     if (n == 1| n == 2) {Console.WriteLine("третьей цифры нет");}
     else {double f1 = Math.Pow(10,n-2);
           double f2 = Math.Pow(10,n-3);
           int result = (arg%Convert.ToInt32(f1))/Convert.ToInt32(f2);
           Console.WriteLine($"Третья цифра - {result}");}
           
 }

int a = 5;
Console.Write("Число a = ");
Console.WriteLine(a);
thirdNum(a);