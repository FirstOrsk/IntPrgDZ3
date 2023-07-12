// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int inputCoord(string quest){
    Console.WriteLine($"Введите координату {quest}");
    int coord = Convert.ToInt32(Console.ReadLine());
    return coord;
}

int x1 = inputCoord("X точки №1:");
int y1 = inputCoord("Y точки №1:");
int z1 = inputCoord("Z точки №1:");

int x2 = inputCoord("X точки №2:");
int y2 = inputCoord("Y точки №2:");
int z2 = inputCoord("Z точки №2:");

double distance = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));

Console.WriteLine($"Расстояние между точками = {Math.Round(distance, 2)}");