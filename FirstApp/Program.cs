namespace FirstApp
{
    internal class Program
    {

        #region Enum
        //enum DayOfWeek
        //{
        //    Saturday = 1,
        //    Sunday,
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday
        //} 
        #endregion

        #region StaticMethod
        //static double Add(double a, double b)
        //{
        //    return a + b;
        //}

        //static double Subtract(double a, double b)
        //{
        //    return a - b;
        //}

        //static double Multiply(double a, double b)
        //{
        //    return a * b;
        //}

        //static double Divide(double a, double b)
        //{
        //    if (b == 0)
        //    {
        //        Console.WriteLine("Cannot divide by zero!");
        //        return 0;
        //    }
        //    return a / b;
        //}
        #endregion

        #region CalculateCircle
        static void CalculateCircle(double radius, out double area, out double circumference)
        {
            area = Math.PI * radius * radius;
            circumference = 2 * Math.PI * radius;
        } 
        #endregion
        static void Main(string[] args)
        {
            #region Part01
            //Console.Write("Enter a day number (1-7): ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //// Convert number to enum
            //DayOfWeek day = (DayOfWeek)number;

            //Console.WriteLine("Day: " + day);

            //// Check Workday or Weekend
            //switch (day)
            //{
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("It's the Weekend");
            //        break;

            //    default:
            //        Console.WriteLine("It's a Workday");
            //        break;
            //}
            //Console.ReadLine(); 
            #endregion


            #region Part02
            //Console.Write("Enter array size: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] arr = new int[size];

            //int sum = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("Enter element [" + i + "]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0; i < size; i++)
            //{
            //    sum = sum + arr[i];

            //    if (arr[i] > max)
            //        max = arr[i];

            //    if (arr[i] < min)
            //        min = arr[i];
            //}

            //double avg = (double)sum / size;

            //Console.WriteLine("Sum = " + sum);
            //Console.WriteLine("Average = " + avg);
            //Console.WriteLine("Max = " + max);
            //Console.WriteLine("Min = " + min);
            //Console.Write("Reverse = ");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //} 
            #endregion


            #region Part03

            // Q.1
            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter operation (+, -, *, /): ");
            //char op = Console.ReadLine()[0];

            //double result = 0;

            //switch (op)
            //{
            //    case '+':
            //        result = Add(num1, num2);
            //        break;

            //    case '-':
            //        result = Subtract(num1, num2);
            //        break;

            //    case '*':
            //        result = Multiply(num1, num2);
            //        break;

            //    case '/':
            //        result = Divide(num1, num2);
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operation");
            //        return;
            //}

            //Console.WriteLine("Result = " + result); 

            //----------------------------------------------------

            // Q.2
            //Console.Write("Enter radius: ");
            //double r = double.Parse(Console.ReadLine());

            //double area, circ;

            //CalculateCircle(r, out area, out circ);

            //Console.WriteLine("Area = " + area);
            //Console.WriteLine("Circumference = " + circ);
            #endregion
        }
    }
}
