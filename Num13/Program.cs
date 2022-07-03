//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
long a = Convert.ToInt64(Console.ReadLine());

void thirdNum(long arg){
     long arg1 = Math.Abs(arg);
     string arg_s = Convert.ToString(arg1);
     double n = arg_s.Length;
     if (n == 1| n == 2) {Console.WriteLine("третьей цифры нет");}
     else {double f1 = Math.Pow(10,n-2);
           double f2 = Math.Pow(10,n-3);
           long result = (arg1%Convert.ToInt64(f1))/Convert.ToInt64(f2);
           Console.WriteLine($"Третья цифра - {result}");}
           
 }

Console.Write("Число a = ");
Console.WriteLine(a);
thirdNum(a);