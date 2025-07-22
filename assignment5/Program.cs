using System.Drawing;

namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Write a program that prints an identity matrix using for loop, in other
            //words takes a value n from the user and shows the identity table of size n *
            //n.
            //Console.WriteLine("enter the number :");
            //int n = int.Parse(Console.ReadLine());
            //int[,] numbers = new int[n, n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"row number{i+1} ");
            //    for (int j = 0; j < n; )
            //    {
            //        Console.WriteLine($"enter row number{i+1} coloumn number {j+1} ");
            //        bool isparsed = int.TryParse(Console.ReadLine(), out numbers[i,j]);
            //        if (isparsed)
            //            j++;
            //    }
            //}
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #region q2
            //Write a program in C# Sharp to find the sum of all elements of the array.
            int[] numbers = {1,4,6,7};
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"the sum of all elements of the array is : {sum}");
                #endregion
        }
    }
}
