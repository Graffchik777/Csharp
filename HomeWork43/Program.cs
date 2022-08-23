
// // void CrossPoint(double k1, double b1, double k2, double b2)
// // {
// //     double x = (b1 - b2) / (k2 - k1);
// //     double y = ((k2 * b1 - k1 * b2) / (k2 - k1)) + b1; 

// //     if (k1 == k2) 
// //          Console.Write("С такимим вводными -  прямые не пересекаются!");
// //     else
// //          Console.Write($"Вводные нормальные! Точка пересечения заданных прямых: ({x}; {y})");
// // }

// // Console.WriteLine("Вводим b1: ");
// // int b1 = int.Parse(Console.ReadLine() ?? "");
// // Console.WriteLine("Ввводим k1: ");
// // int k1 = int.Parse(Console.ReadLine() ?? "");
// // Console.WriteLine("Вводим b2: ");
// // int b2 = int.Parse(Console.ReadLine() ?? "");
// // Console.WriteLine("Вводим k2: ");
// // int k2 = int.Parse(Console.ReadLine() ?? "");

// // CrossPoint(k1, b1, k2, b2);




// #define readkey

// using System;

// namespace m7tr1x
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Title = "tH3 M7tr1x 3ff3<t";
//             Console.ForegroundColor = ConsoleColor.DarkGreen;
//             Console.WindowLeft = Console.WindowTop = 0;
//             Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
//             Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
// #if readkey
//             Console.WriteLine("H1T 7NY K3Y T0 C0NT1NU3 =/");
//             Console.ReadKey();
// #endif
//             Console.CursorVisible = false;
//             int width, height;
//             int[] y;
//             int[] l;
//             Initialize(out width, out height, out y, out l);
//             int ms;
//             while (true)
//             {
//                 DateTime t1 = DateTime.Now;
//                 MatrixStep(width, height, y, l);
//                 ms = 10 - (int)((TimeSpan)(DateTime.Now - t1)).TotalMilliseconds;
//                 if (ms > 0)
//                     System.Threading.Thread.Sleep(ms);
//                 if (Console.KeyAvailable)
//                     if (Console.ReadKey().Key == ConsoleKey.F5)
//                         Initialize(out width, out height, out y, out l);
//             }
//         }

//         static volatile bool thistime = false;

//         private static void MatrixStep(int width, int height, int[] y, int[] l)
//         {
//             int x;
//             thistime = !thistime;
//             for (x = 0; x < width; ++x)
//             {
//                 if (x % 11 == 10)
//                 {
//                     if (!thistime)
//                         continue;
//                     Console.ForegroundColor = ConsoleColor.White;
//                 }
//                 else
//                 {
//                     Console.ForegroundColor = ConsoleColor.DarkGreen;
//                     Console.SetCursorPosition(x, inBoxY(y[x] - 2 - (l[x] / 40 * 2), height));
//                     Console.Write(R);
//                     Console.ForegroundColor = ConsoleColor.Green;
//                 }
//                 Console.SetCursorPosition(x, y[x]);
//                 Console.Write(R);
//                 y[x] = inBoxY(y[x] + 1, height);
//                 Console.SetCursorPosition(x, inBoxY(y[x] - l[x], height));
//                 Console.Write(' ');
//             }
//         }

//         private static void Initialize(out int width, out int height, out int[] y, out int[] l)
//         {
//             int h1;
//             int h2 = (h1 = (height = Console.WindowHeight) / 2) / 2;
//             width = Console.WindowWidth - 1;
//             y = new int[width];
//             l = new int[width];
//             int x;
//             Console.Clear();
//             for (x = 0; x < width; ++x)
//             {
//                 y[x] = r.Next(height);
//                 l[x] = r.Next(h2 * ((x % 11 != 10) ? 2 : 1), h1 * ((x % 11 != 10) ? 2 : 1));
//             }
//         }

//         static Random r = new Random();
//         static char R
//         {
//             get
//             {
//                 int t = r.Next(10);
//                 if (t <= 2)
//                     return (char)('0' + r.Next(10));
//                 else if (t <= 4)
//                     return (char)('a' + r.Next(27));
//                 else if (t <= 6)
//                     return (char)('A' + r.Next(27));
//                 else
//                     return (char)(r.Next(32, 255));
//             }
//         }

//         public static int inBoxY(int n, int height)
//         {
//             n = n % height;
//             if (n < 0)
//                 return n + height;
//             else
//                 return n;
//         }
//     }
// }

using System;
using System.Linq;
using System.Text;
using System.Threading;
 
namespace ConsoleMatrixEffect
{
 
    // для того, чтобы растянуть консоль на весь экран, нажмите Alt+Enter
    static class Program
    {
        
        private const int delay = 40;
 
        static void Main(string[] args)
        {
            SetConsoleParams();
 
            // задаю Матрицу в размер консольного окна
            var consoleMatrix = new ConsoleMatrix(Console.WindowWidth, Console.WindowHeight);
 
            var cycle = 1; // счетчик цикла. Нужен для регулирования скорости различных столбцов
            do
            {
                consoleMatrix.ShowMatrix();
                Thread.Sleep(delay);
                consoleMatrix.ShiftMatrixElements(cycle);
                cycle = ((cycle+1) % 1000); // ограничиваю переменную, чтобы не случилось переполнение int
            } while (!Console.KeyAvailable);
        }
 
        private static void SetConsoleParams()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
        }
    }
 
    public class ConsoleMatrix
    {
        // символы которые будут использоваться для матрицы
        //private static readonly char[] _symbols = "¢£¥§gYhjHwWÞßĦŠŊŁþøðÖ ".ToCharArray(); 
        //если консольный шрифт поддерживает Unicode
        private static readonly char[] _symbols = "&%#$@*(@Yyuзвпклвдидч%:*+:8№8дerjfndjhОЛДОКОЫЬ6%АРУП8*№5АЬЖДЫUjJhHДЛОFfsqVТЙЦУВNnv ".ToCharArray();
        private readonly int _symbolsLen = _symbols.Length;
 
        // матрица
        private char[][] _matrix;
        private readonly int _width; 
        private readonly int _height;
 
        private readonly Random _rand = new Random(); // задаю глобальный рандомизатор для символов.
        private const int period = 6; // для вычисления скорости столбцов
 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="width">Ширина окна консоли</param>
        /// <param name="height">Высота окна консоли</param>
        public ConsoleMatrix(int width, int height)
        {
            _width = width;
            _height = height;
            CreateMatrix();
        }
 
        /// <summary>
        /// Заполняю первоначальную матрицу
        /// </summary>
        private void CreateMatrix()
        {
            // матрица - массив с массивами символов
            _matrix = new char[_height][];
 
            for (var h = 0; h < _height; h++)
            {
                // заполняю строки символами. Каждый второй символ - пробел, формирования пустых столбцов
                _matrix[h] =
                    // Создание последовательности 1..N. Можно использовать вместо стандартных циклов
                    Enumerable.Range(0, _width)
                        .Select(position => (position + 1) % 2 == 0
                                ? ' ' // пробел нужен для формирования пустых столбцов
                                : _symbols[_rand.Next(0, _symbolsLen)])
                        .ToArray();
            }
        }
 
        /// <summary>
        /// Печатаю матрицу в консоли
        /// </summary>
        public void ShowMatrix()
        {
            // сбрасываю позицию курсока в начальную позицию
            Console.SetCursorPosition(0, 0);
 
            // вывожу символы построчно
            for (var h = 0; h < _height; h++)
            {
                var s = new string(_matrix[h]); // делаю из массива символов одну строку, т.к. печать одной строки намного быстрее, чем печать символов по одному
                if (h < _height - 1) Console.WriteLine(s);
                else Console.Write(s); // последнюю строку печатаю без переноса, чтобы не образовалась пустая строка внизу
            }
        }
 
        /// <summary>
        /// Метод для сдвига символов в столбцах
        /// </summary>
        /// <param name="cycle"></param>
        public void ShiftMatrixElements(int cycle)
        {
            for (var w = 0; w < _width; w += 2) // каждый второй столбец пустой
            {
                if (w % period > cycle % period) continue; // регулирую скорость для разных столбцов
 
                // сдвигаю все символы в столбце вниз на один символ
                for (var h = _height - 1; h >= 0; h--)
                {
                    // для первой строки добавляю случайный символ
                    if (h == 0)
                    {
                        _matrix[h][w] = _symbols[_rand.Next(0, _symbolsLen)];
                        continue;
                    }
                    // перемещаю вышестоящий символ в текущую строку
                    _matrix[h][w] = _matrix[h - 1][w];
                }
            }
        }
    }
}
