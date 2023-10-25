namespace pr10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //код для 4ого задания
            Console.Write("AB: ");
            double ab = double.Parse(Console.ReadLine());
            Console.Write("AC: ");
            double ac = double.Parse(Console.ReadLine());
            Console.Write("DC: ");
            double dc = double.Parse(Console.ReadLine());

            double bc = hypotenuse(ab, ac);
            double bd = hypotenuse(dc, bc);

            Console.WriteLine($"P: {ab + ac + dc + bd}");
        }
        
        static int Min(int a, int b) => a > b ? a : b;

        static int f(int x) => x % 10;

        static double hypotenuse(double a, double b) => Math.Sqrt(a*a + b*b);


        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}