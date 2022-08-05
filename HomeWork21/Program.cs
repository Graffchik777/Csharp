// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = Coordinat("x", "A");
// int y1 = Coordinat("y", "A");
// int z1 = Coordinat("z", "A");
// int x2 = Coordinat("x", "B");
// int y2 = Coordinat("y", "B");
// int z2 = Coordinat("z", "B");

// int Coordinat(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segmentLength}");


int coordXPointA;
int coordYPointA;
int coordZPointA;
int coordXPointB;
int coordYPointB;
int coordZPointB;
double lengtAB;

void readDataOfPoint()
{
    Console.WriteLine("Введите координат Х точки А");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координат Y точки А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координат Z точки А");
    coordZPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координат Х точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координат Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координат Z точки B");
    coordZPointB = int.Parse(Console.ReadLine());
}

// Расчет длины
void colculateLenghAB()
{
lengtAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2) + Math.Pow((coordZPointA - coordZPointB), 2));

}

readDataOfPoint();
colculateLenghAB();

Console.WriteLine(lengtAB);