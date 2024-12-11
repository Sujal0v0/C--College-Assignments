using System;
using System.IO.Pipelines;
using System.Runtime.InteropServices;

namespace Program
{
    //?1
    class AddNumbers
    {
        private int a, b;
        public int Sum { get; set; }
        public AddNumbers(int num1, int num2)
        {
            a = num1;
            b = num2;
        }
        public void AddTwoNumbers()
        {
            Sum = (a + b);
        }
        public void DisplaySum()
        {
            Console.WriteLine($"The sum of numbers is {Sum}");
        }
    }
    //?2
    class SI
    {
        public double principal { get; set; }
        public double rate { get; set; }
        public double time { get; set; }
        public double CalculateSI()
        {
            return ((principal * rate * time) / 100);
        }
    }
    //?3
    public class Quadratic
    {
        public double root1 { get; set; }
        public double root2 { get; set; }
        public void FindRoots(
        double a, double b, double c)
        {
            root1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            root2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }
    }
    class QuadraticEquation
    {
        double a, b, c;
        public void Inputabc()
        {
            Console.Write("Enter the value of a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of c: ");
            c = Convert.ToDouble(Console.ReadLine());
        }
        public void CalculateRoot()
        {
            if (a == 0)
            {
                Console.WriteLine("Not a quadratic equation (a can't be 0).");
                return;
            }
            double temp = b * b - 4 * a * c;

            if (temp > 0)
            {
                double root1 = (-b + Math.Sqrt(temp)) / (2 * a);
                double root2 = (-b - Math.Sqrt(temp)) / (2 * a);
                Console.WriteLine($"The equation has two real roots: {root1} and {root2}");
            }
            else if (temp == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"The equation has one real root: {root}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-temp) / (2 * a);
                Console.WriteLine($"The equation has complex roots: {realPart} + {imaginaryPart}i and {realPart} - {imaginaryPart}i");
            }
        }
    }
    //?4
    class MarksInSubjects
    {
        string[] subjects = new string[5];
        double[] marks = new double[5];
        public MarksInSubjects(string[] allSubjects)
        {
            subjects = allSubjects;
        }
        public string GetSubjectByIndex(int i)
        {
            if (i >= 0 && i < subjects.Length)
            {
                return subjects[i];
            }
            else
            {
                return "Index out of range";
            }
        }
        public void setMarks(int i, double m)
        {
            if (i >= 0 && i < subjects.Length)
            {
                marks[i] = m;
            }
        }
        public void DisplayData()
        {
            Console.WriteLine("Marks obtained in each subjects are: ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"{subjects[i]} : {marks[i]}");
            }
        }

    }
    //?5
    class DynamicOperation
    {
        public double a, b;
        public char symbol;
        public double result;
        public DynamicOperation(double num1, double num2)
        {
            a = num1;
            b = num2;
        }
        public void InputSymbol()
        {
            Console.WriteLine("Enter the operation you want to perform: ");
            symbol = Convert.ToChar(Console.ReadLine());
        }
        private double add() => a + b;
        private double subtract() => a - b;
        private double multiply() => a * b;
        private double divide()
        {
            if (b != 0)
            {
                return (a / b) * 1.0;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Environment.Exit(0);
                return 0;
            }
        }
        public void PerformOperation()
        {
            switch (symbol)
            {
                case '+':
                    result = add();
                    break;
                case '-':
                    result = subtract();
                    break;
                case '*':
                    result = multiply();
                    break;
                case '/':
                    result = divide();
                    break;
                default:
                    Console.WriteLine("Invalid operator! Please enter one of (+, -, *, /).");
                    break;
            }
        }
    }
    //?6
    class NamesWithT
    {
        private string[] nameArray;
        public NamesWithT(int n)
        {
            nameArray = new string[n];
        }
        public void InputNames()
        {
            Console.WriteLine("Enter the name of students: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter name of student {i + 1}: ");
                nameArray[i] = Console.ReadLine();
            }
        }
        public void DisplayNamesWithT()
        {
            Console.WriteLine("The Students whose names start with the t are: ");
            foreach (string name in nameArray)
            {
                if (name.IndexOf("t", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
    //?7
    class AlphaNames
    {
        private string[] names;
        public AlphaNames(int n)
        {
            names = new string[n];
        }
        public void InputNames()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Person {i + 1}: ");
                names[i] = Console.ReadLine();
            }
        }
        public void SortNames()
        {
            Array.Sort(names);
        }
        public void DisplayNames()
        {
            foreach (string name in names)
            {
                Console.Write($"{name}, ");
            }
            Console.Write("\n");
        }
    }
    //?8
    class MinMax
    {
        private int[] array1;
        public MinMax(int size)
        {
            array1 = new int[size];
        }
        public void InputItems()
        {
            Console.WriteLine("Enter the elements in array: ");
            string[] inputArray = Console.ReadLine().Split(' ');
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(inputArray[i]);
            }
        }
        public int FindMax()
        {
            int max = array1[0];
            foreach (int value in array1)
            {
                if (value > max)
                    max = value;
            }
            return max;
        }
        public int FindMin()
        {
            int min = array1[0];
            foreach (int value in array1)
            {
                if (value < min)
                    min = value;
            }
            return min;
        }
    }
    //?9
    class UpperTriangular
    {
        public void DisplayOriginal(int[,] array, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($" {array[i, j]} ");
                }
                Console.Write("\n");
            }
        }
        public void DisplayUpper(int[,] array, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j < i)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write($" {array[i, j]} ");
                    }

                }
                Console.Write("\n");
            }
        }
    }
    //?10
    class Rectangle
    {
        public float Length { set; get; }
        public float Breadth { set; get; }
        private float Area;
        public void ComputeArea()
        {
            Area = Length * Breadth;
        }
        public void DisplayData()
        {
            Console.WriteLine($"The area is {Area}");
        }
        public float GetArea()
        {
            return Area;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //?Q1
            // Console.Write("Enter two numbers: ");
            // string input = Console.ReadLine();
            // string[] inputArray = input.Split(' ');
            // AddNumbers a = new AddNumbers(int.Parse(inputArray[0]), int.Parse(inputArray[1]));
            // a.AddTwoNumbers();
            // a.DisplaySum();
            //?Q2
            // SI s1 = new SI();

            // Console.WriteLine("Enter the Principal(P): ");
            // s1.principal = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Enter the Rate of interest (R): ");
            // s1.rate = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Enter the Time period (T): ");
            // s1.time = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine($"The Simple Interest is: {s1.CalculateSI()}");
            //?Q3



            // Console.Write("Enter the value of a: ");
            // double a = double.Parse(Console.ReadLine() ?? "0");
            // Console.Write("Enter the value of b: ");
            // double b = double.Parse(Console.ReadLine() ?? "0");
            // Console.Write("Enter the value of c: ");
            // double c = double.Parse(Console.ReadLine() ?? "0");
            // Quadratic quadratic = new Quadratic();
            // quadratic.FindRoots(a, b, c);
            // Console.WriteLine("The roots of the quadratic equation are: " +
            // quadratic.root1 + " and " + quadratic.root2);


            // QuadraticEquation q = new QuadraticEquation();
            // q.Inputabc();
            // q.CalculateRoot();

            //?Q4
            // Console.WriteLine("Enter the name of the five subjects:");
            // string input1 = Console.ReadLine();
            // string[] subjectNames = input1.Split(' ');
            // MarksInSubjects m1 = new MarksInSubjects(subjectNames);
            // Console.WriteLine("Enter the marks obtained in five subjects: ");
            // string input = Console.ReadLine();
            // string[] subjectMarks = input.Split(' ');
            // for (int i = 0; i < 5; i++)
            // {
            //     m1.setMarks(i, Convert.ToDouble(subjectMarks[i]));
            // }
            // m1.DisplayData();

            //?Q5
            // Console.WriteLine("Enter the two numbers: ");
            // string input = Console.ReadLine();
            // string[] inputArray = input.Split(' ');
            // DynamicOperation d = new DynamicOperation(Convert.ToDouble(inputArray[0]), Convert.ToDouble(inputArray[1]));
            // d.InputSymbol();
            // d.PerformOperation();
            // Console.WriteLine($"The result of {d.a} {d.symbol} {d.b} = {d.result}");
            //?Q6
            // NamesWithT T = new NamesWithT(4);
            // T.InputNames();
            // T.DisplayNamesWithT();
            //?Q7

            // Console.Write("Enter the number of people: ");
            // int n = int.Parse(Console.ReadLine());
            // AlphaNames A = new AlphaNames(n);
            // A.InputNames();
            // Console.WriteLine("Order of names before sorting:");
            // A.DisplayNames();
            // A.SortNames();
            // Console.WriteLine("The names in alphabetic order is:");
            // A.DisplayNames();
            //?Q8
            // Console.Write("Enter the size of array: ");
            // int n = int.Parse(Console.ReadLine());
            // MinMax first = new MinMax(n);
            // first.InputItems();
            // Console.WriteLine($"Min = {first.FindMin()}");
            // Console.WriteLine($"Max = {first.FindMax()}");

            //?Q9
            // int[,] default1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // UpperTriangular u1 = new UpperTriangular();

            // Console.WriteLine("The Original matrix is: ");
            // u1.DisplayOriginal(default1, 3, 3);
            // Console.WriteLine("The Upper Triangular matrix is: ");
            // u1.DisplayUpper(default1, 3, 3);
            //?Q10
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();
            Console.WriteLine("Enter the length and breadth of first rectangle: ");
            r1.Length = Convert.ToSingle(Console.ReadLine());
            r1.Breadth = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the length and breadth of second rectangle: ");
            r2.Length = Convert.ToSingle(Console.ReadLine());
            r2.Breadth = Convert.ToSingle(Console.ReadLine());

            r1.ComputeArea();
            r2.ComputeArea();
            Console.WriteLine("Rectangle 1: ");
            r1.DisplayData();
            Console.WriteLine("Rectangle 2: ");
            r2.DisplayData();

            if (r1.GetArea() >= r2.GetArea())
            {
                Console.WriteLine("The first rectangle is larger.");
            }
            else
            {

                Console.WriteLine("The second rectangle is larger.");
            }

        }
    }
}
