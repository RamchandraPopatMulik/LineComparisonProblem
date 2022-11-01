namespace Line_Comparision_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparsion Problems");

            int x1, x2, y1, y2;

            Console.WriteLine("Please Enter X1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter X2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Y2:");
            y2 = Convert.ToInt32(Console.ReadLine());

            double LineLength1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Length of Line 1 is : {LineLength1}");
            
        }
    }
}