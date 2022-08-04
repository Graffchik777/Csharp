//Заводим координаты точек А и В

int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
double lengtAB;

void readDataOfPoint()
{
    Console.WriteLine("Введите координат Х точки А");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координат Y точки А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координат Х точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координат Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());
}

// Расчет длины
void colculateLenghAB()
{
lengtAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2));

}


readDataOfPoint();
colculateLenghAB();

Console.WriteLine(lengtAB);