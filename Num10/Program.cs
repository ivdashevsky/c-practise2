//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Случайное трёхзначное число");
int a = new Random().Next(100,1000);
Console.WriteLine(a);

int secondNum(int arg) {
    int second = (arg%100)/10;
    return second;
}

Console.WriteLine($"Вторая цифра числа -  {secondNum(a)}");

