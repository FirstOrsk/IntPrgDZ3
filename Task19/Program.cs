// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5-тизначное число для проверки на палиндром:");
int num = Convert.ToInt32(Console.ReadLine());

int n1 = num / 10000;
int n2 = num / 1000 % 10;

int n4 = num / 10 % 10;
int n5 = num % 10;

//Console.WriteLine($"{n1}_{n2}_{n4}_{n5}");

if (n1 == n5 && n2 == n4){
    Console.WriteLine("Это палиндром");
}
else{
    Console.WriteLine("Это НЕ палиндром");
}
