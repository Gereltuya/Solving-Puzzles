using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.com
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int n = Convert.ToInt32(Console.ReadLine().Trim());

            //  List<int> arr = Console.ReadLine().TrimEnd().Split(" ").ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            

            List<int> arr = new List<int>();

            //Problem 1 

            /*
             
            Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
            Print the decimal value of each fraction on a new line with  places after the decimal.
            Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, 
            though answers with absolute error of up to  are acceptable.
             
             */

            //   Result.plusMinus(arr);



            //Problem 2 


            /*Given five positive integers, find the minimum and maximum values that can be calculated 
             * by summing exactly four of the five integers. Then print the respective minimum 
             * and maximum values as a single line of two space-separated long integers.
             * 
             */

            // Result.miniMaxSum(arr);

            //Problem 3 


            /*Given an array of integers, where all elements but one occur twice, find the unique element.*/


            //Problem Average of Two Dimension Array 

            //  Result.findAverageTwoDimensionalArray();

            // Problem 5 Diagnolly Average

            //List<int> files, int numCores, int limit

            List<int> files = new List<int> { 3, 1, 5 };

            Result.minTime(files, 1, 5);


            Result.diagonalDifference();

        }

    }

    class Result {




        public static void plusMinus(List<int> arr)
        {

            int len = arr.Count();

            float positiveCount = 0;
            float negativeCount = 0;
            float zeroCount = 0;

            for (int i = 0; i < len; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                else if (arr[i] < 0)
                {

                    negativeCount++;
                }
                else if (arr[i] > 0)
                {

                    zeroCount++;
                }
            }

            Console.WriteLine("{0:f6}", positiveCount / len);
            Console.WriteLine("{0:F6}", negativeCount / len);
            Console.WriteLine("{0:F6}", zeroCount / len);

        }


        public static void miniMaxSum(List<int> arr) {

            arr.Sort();

            long min = 0;
            long max = 0;

            int count = 0;
            int len = arr.Count();

            do
            {
                min += arr[count];
                max += arr[len - 1];
                count++;
                len--;
            }
            while (count < 4);

            Console.Write(min + "  " + max);


        }


        public static string timeConversion(string s)
        {
            DateTime d = DateTime.Parse(s);
           return d.ToString("HH:m:ss");

        }


        public static int lonelyinteger(List<int> a)
        {
            a.Sort();
            a.Reverse
              
            int size = a.Count();
            int re = a[0];
            for (int i = 1; i < size; i++)
            {
                re = re ^ a[i];


            }
            return re;
        }


        public static void findAverageTwoDimensionalArray() {
            int[,] grades = new int[,] { { 1,82,74,89,100},
                                     { 2, 93, 96, 85, 86 },
                                     { 3,83,72,95,89 },
                                     {4,91,98,79,88 } };

            int last_grade = grades.GetUpperBound(1);
            double average = 0.0;
            int total;
            int last_student = grades.GetUpperBound(0);

            for (int row = 0; row < last_grade; row++) {
                total = 0;

                for (int col = 0; col < last_student; col++) {
                  
                    total += grades[row, col];
                }
                average = total / last_grade;
                Console.Write("Average Grade is", average);

            
            }
        }


        public static void diagonalDifference()
        {
            int[,] arr = new int[,] { { 1,2,3},
                                        { 4,5,6},
                                        { 7,8,9} };


            int row = arr.GetUpperBound(1);
            int col = arr.GetUpperBound(0);
            int total;
            for (int r = 0; r < row; r++) {
                total = 0;
                for (int c = 0; c <= col; c++) {

                    if (r == c) {

                        total += arr[r, c] / 2;
                    }
                    Console.WriteLine("Column" + total);
                   
                }
                Console.WriteLine("Diagnol sum is " + total);
            }

        
        }

        public static long minTime(List<int> files, int numCores, int limit)
        {
            List<int> equal_Cores = new List<int>();
            for (int i = 0; i < files.Count(); i++)
            {
                if (numCores == 0)
                {
                    equal_Cores.Add(i);
                    files.Remove(i);
                }

            }

            if (equal_Cores.Count() == numCores)
            {
                equal_Cores.Sort();
                equal_Cores.Reverse();

                for (int i = 0; i < limit; i++)
                {
                    equal_Cores[i] = equal_Cores[i] / numCores;
                }
            }
            else
            {
                for (int i = 0; i < equal_Cores.Count(); i++)
                {
                    equal_Cores[i] = equal_Cores[i] / numCores;
                }
            }
           var list = files.Union(equal_Cores).ToList();

            return (long)list.Sum();
        }


    }
}
