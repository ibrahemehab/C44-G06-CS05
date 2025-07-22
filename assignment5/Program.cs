using System.Diagnostics.Tracing;
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
            //int[] numbers = {1,4,6,7};
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"the sum of all elements of the array is : {sum}");
            #endregion
            #region q3
            //Write a program in C# Sharp to merge two arrays of the same size sorted in
            //ascending order.
            //int size = 2;
            //int[] numbers01 = { 5, 2 };
            //int[] numbers02 = { 3, 8 };
            //int[] merged = new int[2*2];
            //for (int i = 0; i < numbers01.Length; i++)
            //{
            //    merged[i] = numbers01[i];
            //}
            //for (int i = 0; i < numbers02.Length; i++)
            //{
            //    merged[size+i] = numbers02[i];
            //}
            //Array.Sort(merged);
            //foreach (int i in merged)
            //    Console.WriteLine(i);

            #endregion
            #region q4
            //Write a program in C# Sharp to find maximum and minimum element in an
            //array = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 }
            //int[] array = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };
            //int minimum = int.MaxValue;
            //int maximum = int.MinValue;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < minimum)
            //        minimum = array[i];
            //    if (array[i] > maximum)
            //        maximum = array[i];
            //}
            //Console.WriteLine(maximum);
            //Console.WriteLine(minimum);
            #endregion
            #region q5
            //Write a program in C# Sharp to find the second largest element in an
            //array.

            //int[] array = { 58, 4, 2, 6, 6, 8, 9, 10, 30, 59 };
            //int maximum = int.MinValue;
            //int maximum2 = int.MinValue;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > maximum)
            //        maximum = array[i];
            //}
            //Console.WriteLine(maximum);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == maximum)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        if (array[i] > maximum2)
            //            maximum2 = array[i];
            //    }
            //}
            //Console.WriteLine(maximum2);


            #endregion
            #region q6
            //int[] array = new int[10];
            //int distance = 0;
            //int maxdistance = int.MinValue;
            //for(int i = 0; i < array.Length;i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < array.Length; i++)

            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j]) 
            //        { 
            //            distance = j - i - 1;
            //            if (distance > maxdistance)
            //                maxdistance = distance;
            //        }
            //    }
            //Console.WriteLine($"max index is {maxdistance}");
            #endregion
            #region q7
            //
            //string sentence = "omar essam mohamed ali ";
            //string[] words = sentence.Split(' ');
            //string reversed = "";
            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    reversed += words[i] + " ";
            //}
            //Console.WriteLine(reversed);
            string input = "this is a test";
            string result = ""; 
            int end = input.Length;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == ' ')
                {
                    string word = input.Substring(i + 1, end - i - 1);
                    result += word + " ";
                    end = i;
                }
            }
            string word2 = input.Substring(0, end);
            result += word2;
            Console.WriteLine(result);

            #endregion
        }
    }
}
