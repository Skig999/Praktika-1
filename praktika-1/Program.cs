//#1
using System;

namespace Практика1
{
    // Класс "Треугольник"
    class Triangle
    {
        // Поля — длины сторон
        private double a;
        private double b;
        private double c;

        // Конструктор без параметров
        // Это конструктор по умолчанию присваеват сторонам значения 3, 4, 5. Он вызывается, когда пишут new Triangle() без аргументов
        // Такой конструктор полезен, чтобы всегда иметь «запасной» вариант, если пользователь не задал свои стороны.
        public Triangle()
        {
            a = 3;
            b = 4;
            c = 5;
        }

        // Конструктор с параметрами. Этот конструктор принимает три числа при создании объекта
        // Строка this.a = a; присваивает значение параметра полю класса. Так мы сохраняем данные внутри объекта.
        public Triangle(double a, double b, double c)
        {
            this.a = a;        //присваивание значения переменной a полю a текущего экземпляра класса
            this.b = b;
            this.c = c;
        }

        // Метод, вычисляющий периметр
        public double Perimeter()
        {
            return a + b + c;
        }

        // Метод, выводящий длины сторон и периметр на экран
        public void PrintInfo()
        {
            Console.WriteLine($"Стороны: a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"Периметр = {Perimeter()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Первый объект — ввод с клавиатуры
            Console.Write("Введите сторону a: ");
            double a = double.Parse(Console.ReadLine()); //Parse - метод, который преобразует строку(тип string) в другой тип данных, например, число

            Console.Write("Введите сторону b: ");
            double b = double.Parse(Console.ReadLine());   //double.Parse - метод для преобразования строкового представления числа

            Console.Write("Введите сторону c: ");
            double c = double.Parse(Console.ReadLine());

            Triangle t1 = new Triangle(a, b, c); //создание объекта класса Triangle с помощью конструктора

            // Второй объект — программно
            Triangle t2 = new Triangle(6, 8, 10);

            // Вывод результатов
            Console.WriteLine("\n--- Первый треугольник ---");
            t1.PrintInfo();   //PrintInfo -  класс  опказываюший информацию треугольников

            Console.WriteLine("\n--- Второй треугольник ---");
            t2.PrintInfo();

            Console.ReadLine();
        }
    }
}