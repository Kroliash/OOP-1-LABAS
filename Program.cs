using System;

namespace OOP_1_LABAS
{
    class Program
    {   
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                try
                {
                    Console.WriteLine("Введіть 1, щоб запустити виконання завдання №1");
                    Console.WriteLine("Введіть 2, щоб запустити виконання завдання №2");
                    Console.WriteLine("Введіть 0, щоб завершити программу. ");
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 0:
                            b = false;
                            break;
                        case 1:
                            FirstTask();
                            break;
                        case 2:
                            SecondTask();
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Помилка: {e.Message}");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }

        static void FirstTask()
        {
            Console.Clear();
            bool b = true;
            Console.WriteLine("Введіть координати точок 1 вершини");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координати точок 2 вершини");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть координати точок 3 вершини");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Triangle Tr = new Triangle(x1, y1, x2, y2, x3, y3);
            Console.Clear();
            while (b)
            {
                Console.WriteLine("Введіть 1, щоб вивести довжини сторін трикутника");
                Console.WriteLine("Введіть 2, щоб вивести периметр трикутника");
                Console.WriteLine("Введіть 3, щоб вивести площу трикутника");
                Console.WriteLine("Введіть 4, щоб змінити координати вершин трикутника");
                Console.WriteLine("Введіть 0, щоб повернутись до головного меню");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        b = false;
                        break;
                    case 1:
                        Console.WriteLine("A-{0}, B-{1}, C-{2}", Tr[0], Tr[1], Tr[2]);
                        break;
                    case 2:
                        Console.WriteLine("Периметр трикутника дорівнює = {0}", Tr.Perimeter());
                        break;
                    case 3:
                        Console.WriteLine("Площа трикутника дорівнює = {0}", Tr.Square());
                        break;
                    case 4:
                        Tr.A0 = -2;
                        Tr.A1 = 3;
                        Tr.B0 = 4;
                        Tr.B1 = 5;
                        Tr.C0 = 4;
                        Tr.C1 = 0;
                        Tr.SideLength();
                        break;
                    default:
                        break;
                }
            }
        }


        static void SecondTask()
        {
            Console.Clear();
            bool b = true;

            while (b)
            {
                Console.WriteLine("Введіть 1, щоб перейти до роботи з трикутником");
                Console.WriteLine("Введіть 2, щоб перейти до роботи з пірамідою");
                Console.WriteLine("Введіть 0, щоб перейти до головного меню");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        b = false;
                        break;
                    case 1:
                        Console.Clear();
                        EquilateralTriangle();
                        break;
                    case 2:
                        EquilateralPyramide();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        b = false;
                        break;
                }
                Console.Clear();
            }
        }

        static void EquilateralTriangle()
        {
            Console.Clear();
            bool b = true;
            Console.WriteLine("Введіть значення сторони трикутника");
            TETriangle triangle = GetTriangle(Console.ReadLine());
            while (b)
            {
                Console.WriteLine("Введіть 1, щоб вивести площу трикутника");
                Console.WriteLine("Введіть 2, щоб вивести периметр трикутника");
                Console.WriteLine("Введіть 3, щоб порівняти з іншим трикутником");
                Console.WriteLine("Введіть 4, щоб помножити трикутник на число");
                Console.WriteLine("Введіть 5, щоб змінити значення сторони");
                Console.WriteLine("Введіть 6, щоб вивести довжину сторони");
                Console.WriteLine("Введіть 0, щоб повернутись до попереднього меню");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        b = false;
                        break;
                    case 1:
                        Console.WriteLine(triangle.Square());
                        break;
                    case 2:
                        Console.WriteLine(triangle.Perimetr());
                        break;
                    case 3:
                        Console.WriteLine("Введіть значення сторони трикутника");
                        TETriangle compareTet = GetTriangle(Console.ReadLine());
                        Console.WriteLine(triangle.Equals(compareTet));
                        break;
                    case 4:
                        Console.WriteLine("Введіть множник");
                        int num = int.Parse(Console.ReadLine());
                        triangle *= num;
                        break;
                    case 5:
                        triangle.A = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        triangle.PrintData();
                        break;
                    default:
                        break;
                }
            }
        }

        static void EquilateralPyramide()
        {
            Console.Clear();
            bool b = true;
            Console.WriteLine("Введіть значеня сторони трикутника, та висоти піраміди");
            TEPiramid pyramid = GetPyramid(Console.ReadLine());
            while (b)
            {
                Console.WriteLine("Введіть 1, щоб вивести площу трикутника");
                Console.WriteLine("Введіть 2, щоб вивести периметр трикутника");
                Console.WriteLine("Введіть 3, щоб вивести об'єм піраміди");
                Console.WriteLine("Введіть 4, щоб порівняти з іншою пірамідою");
                Console.WriteLine("Введіть 5, щоб помножити піраміду на число");
                Console.WriteLine("Введіть 6, щоб змінити значення сторони");
                Console.WriteLine("Введіть 7, щоб змінити значення висоти");
                Console.WriteLine("Введіть 8, щоб вивести довжину сторони і висоти");
                Console.WriteLine("Введіть 0, щоб повернутись до попереднього меню");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 0:
                        b = false;
                        break;
                    case 1:
                        Console.WriteLine(pyramid.Square());
                        break;
                    case 2:
                        Console.WriteLine(pyramid.Perimetr());
                        break;
                    case 3:
                        Console.WriteLine(pyramid.Volume());
                        break;
                    case 4:
                        Console.WriteLine("Введіть сторону та висоту");
                        TEPiramid compPyr = GetPyramid(Console.ReadLine());
                        Console.WriteLine(pyramid.Equals(compPyr));
                        break;
                    case 5:
                        Console.WriteLine("Введіть множник");
                        int num = int.Parse(Console.ReadLine());
                        pyramid *= num;
                        Console.WriteLine();
                        break;
                    case 6:
                        pyramid.A = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        pyramid.H = int.Parse(Console.ReadLine());
                        break;
                    case 8:
                        pyramid.PrintData();
                        break;
                    default:
                        break;
                }
            }

        }

        static TETriangle GetTriangle(string input)
        {
            if (input =="")
                return new TETriangle();
            return new TETriangle(int.Parse(input));
        }

        static TEPiramid GetPyramid(string input)
        {
            if (input =="")
                return new TEPiramid();
            string[] splitStr = input.Trim().Split();
            return new TEPiramid(int.Parse(splitStr[0]), int.Parse(splitStr[1]));
        }
    }
}
