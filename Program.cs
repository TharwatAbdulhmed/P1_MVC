using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Assaigment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int number;
            //int sum = 0;
            //Console.Write("Enter a number: ");
            //number = int.Parse(Console.ReadLine());

            //   while (number > 0)
            //    {
            //        int digit = number % 10;
            //        sum += digit;
            //        number /= 10;
            //    }
            //Console.WriteLine($"The sum of digits  the number {number} is: {sum}");

            #endregion

            #region Q2
            //int number;
            //bool isprime;
            //Console.WriteLine("plase enter the prime number");
            //isprime = int.TryParse(Console.ReadLine(),out number);

            //if(number >= 1 )
            //{
            //    Console.WriteLine($"{number} is prime number");
            //}
            //else 
            //{
            //    Console.WriteLine($"{number} is not prime number");
            //}
            #endregion

            #region Q3
            //int number;
            //Console.Write("Enter a number to calculate its factorial: ");
            //number = int.Parse(Console.ReadLine());
            //int factorial = 1;

            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine(factorial);
            #endregion

            #region Q4
            //StringBuilder ChangeChar;

            //ChangeChar = new StringBuilder("Tharwat");
            //Console.WriteLine(ChangeChar);
            //Console.WriteLine(ChangeChar.GetHashCode());
            //ChangeChar.Append("Abulhmed");
            //Console.WriteLine(ChangeChar);
            //Console.WriteLine(ChangeChar.GetHashCode());


            #endregion

            #region Q5

            //int[,] matrix = new int[3, 3];
            //bool flag;
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    Console.WriteLine($"plase enter the value {i + 1} :");
            //    for (int j = 0; j < matrix.Length; j++)
            //        flag = int.TryParse(Console.ReadLine(), out matrix[i, j]);
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }

            //    }
            //}

            #endregion

            #region Q6
            //int[,] numTt = new int[3,3];
            //bool Check;
            //for (int i = 0; i < numTt.GetLength(0); i++)
            //{
            //    Console.WriteLine($"plase enter in first array {i + 1} :");
            //    for (int j = 0; j < numTt.GetLength(1);)
            //    {
            //        Console.WriteLine($"plase enter the data {j + 1} :");

            //    Check = int.TryParse(Console.ReadLine(), out numTt[i,j]);   
            //    j = Check == true && numTt[i, j] >= 0 ? ++j : j;

            //    }
            //}
            //Console.Clear();
            //for(int i = 0;i < numTt.GetLength(0);i++)
            //{
            //    Console.WriteLine($"the array number {i + 1}");
            //    for (int j = 0; j < numTt.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"the value of array number{j + 1} : {numTt[i,j]}");
            //    }
            //    Console.WriteLine($"@Tt_001=========================next:_{i +1}==========================@Tt_001");
            //}

            #endregion
        }
    }
}