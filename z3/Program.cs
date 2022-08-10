// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number == 6 || Number == 7)
{
    Console.WriteLine("Этот день выходной");
}
else if (Number < 1 || Number > 7)
{
    Console.WriteLine("Введено неверное значение");
}
else Console.WriteLine("Этот день не выходной");


