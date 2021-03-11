using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algoritms
{
    class Program
    {
        //1 Daxil edilen array-deki ededlerin cemi
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (var item in ar)
            {
                sum = sum + item;
            }
            return sum;
        }

   //-----------------------------------------------------------------------------------------------------

        //2 Kvadratik matrixin diaqonallarinin ceminin  mutleq ferqi.
        public static int diagonalDifference(List<List<int>> arr,int n)
        {
            int index = 0;
            int index2 = n-1;
            int firstDiag = 0;
            int secondDiag = 0;
            int conclusion = 0;
            foreach (var subArr in arr)
            {
                firstDiag = firstDiag + subArr[index];
                secondDiag= secondDiag + subArr[index2];
                conclusion = firstDiag - secondDiag;
                
                if (firstDiag > secondDiag)
                {
                    conclusion = firstDiag - secondDiag;
                }
                else if(firstDiag == secondDiag)
                {
                    conclusion = 0;
                }
                else
                {
                    conclusion = secondDiag - firstDiag;
                }

                index++;
                index2--;
            }

            return conclusion;
        }

        //-----------------------------------------------------------------------------------------------------    

        static void plusMinus(int[] arr)
        {
            decimal positiveCount = 0;
            decimal negativeCount = 0;
            decimal zeroCount = 0;
            decimal positive;
            decimal negative;
            decimal zero;
            foreach (var f in arr)
            {
                if (f > 0)
                {
                    positiveCount++;
                }
                else if (f < 0)
                {
                    negativeCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            positive = positiveCount / (arr.Length);
            negative = negativeCount / (arr.Length);
            zero = zeroCount / (arr.Length);         
        }


        static void staircase(int n)
        {

            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    if (j <= n - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }

        static void miniMaxSum(int[] arr)
        {
            long max = 0;
            long min = arr[0];
            long sum = 0;
            long maxSum = 0;
            long minSum = 0;
            foreach (var f in arr)
            {
                sum = sum + f;
                if (max < f)
                {
                    max = f;
                }
                if (min > f)
                {
                    min = f;
                }
            }
            maxSum = sum - min;
            minSum = sum - max;
            Console.Write(minSum);
            Console.Write(" ");
            Console.Write(maxSum);

        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = 0;
            int count = 0;
            foreach (var f in candles)
            {
                if (max < f)
                {
                    max = f;
                }
            } 
            foreach (var f in candles)
            {
                if (max == f)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }

        static string timeConversion(string s)
        {

            bool amOrPm = s.Contains("AM");
            int index;
            string hour;
            int convertToPM;
            int indexAMPM;
            string convertTime;
            string minute;

            if (amOrPm == false)
            {
                index = s.IndexOf(':');
                indexAMPM = s.IndexOf("PM");
                hour = s.Substring(0, index);
                minute = s.Substring(index);
                if (int.Parse(hour) < 12)
                {
                    convertToPM = int.Parse(hour) + 12;
                }
                else
                {
                    convertToPM = int.Parse(hour);
                }
                convertTime = string.Concat(convertToPM.ToString(), minute);
                Console.WriteLine(convertTime.Remove(indexAMPM, 2));
                
                return convertTime.Remove(indexAMPM,2);
            }
            else
            {
                
                index = s.IndexOf(':');
                hour = s.Substring(0, index);
                if (int.Parse(hour) >= 12)
                {
                     convertToPM = int.Parse(hour) - 12;
                }
                else
                {
                     convertToPM = int.Parse(hour);
                }
                minute = s.Substring(index);
                
                convertTime = string.Concat(0,convertToPM.ToString(), minute);
                indexAMPM = convertTime.IndexOf("AM");
                Console.WriteLine(convertTime.Remove(indexAMPM, 2));
                return s;
            }
        }

        public static void Main(string[] args)
        {
            ////1 Daxil edilen array-deki ededlerin cemi. Start.

            //int arCount = Convert.ToInt32(Console.ReadLine());

            //long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            //;
            //long result = aVeryBigSum(ar);

            ////1 Daxil edilen array-deki ededlerin cemi. Start.

            //-----------------------------------------------------------------------------------------------------

            ////2 Kvadratik matrixin diaqonallarinin ceminin  mutleq ferqi. Start.

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            //int result = diagonalDifference(arr,n);

            ////2 Kvadratik matrixin diaqonallarinin ceminin  mutleq ferqi. End

            //-----------------------------------------------------------------------------------------------------        

            ////3 Menfi musbet ve 0 olan ededlerin sayinin arrayin uzunluguna nisbeti

            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            //;
            //plusMinus(arr);

            ////3 Menfi musbet ve 0 olan ededlerin sayinin arrayin uzunluguna nisbeti

            //-----------------------------------------------------------------------------------------------------   

            //4 Ulduz duzeltmek
            //int n = Convert.ToInt32(Console.ReadLine());

            //staircase(n);

            ////4 Ulduz duzeltmek


            //-----------------------------------------------------------------------------------------------------   

            //5 Minimum maximum ededlersiz arraydeki ededlerin cemini tapmaq

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //miniMaxSum(arr);

            //5 Minimum maximum ededlersiz arraydeki ededlerin cemini tapmaq

            //-----------------------------------------------------------------------------------------------------   

            //6 Arraydaki max ededin sayi//

            //int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            //int result = birthdayCakeCandles(candles);

            //6 Arraydaki max ededin sayi//

            //-----------------------------------------------------------------------------------------------------   

            //7 AM ile olan saati PM-e cevirmek

            //string s = Console.ReadLine();

            //string result = timeConversion(s);

            //7 AM ile olan saati PM-e cevirmek

            //-----------------------------------------------------------------------------------------------------   
        }
    }
}
