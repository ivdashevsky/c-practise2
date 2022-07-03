//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели");
int num = Convert.ToInt32(Console.ReadLine());

void YesOrNot(int a){
    if(a>=1 && a<=7)
    {
        if (a >= 1 && a < 6){Console.WriteLine("Этот день - рабочий");}
        if (a == 6 | a == 7) {Console.WriteLine("Этот день - выходной");}
    }
    else Console.WriteLine("Число не входит в диапозон дней");
}

YesOrNot(num);