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
        public static int diagonalDifference(List<List<int>> arr, int n)
        {
            int index = 0;
            int index2 = n - 1;
            int firstDiag = 0;
            int secondDiag = 0;
            int conclusion = 0;
            foreach (var subArr in arr)
            {
                firstDiag = firstDiag + subArr[index];
                secondDiag = secondDiag + subArr[index2];
                conclusion = firstDiag - secondDiag;

                if (firstDiag > secondDiag)
                {
                    conclusion = firstDiag - secondDiag;
                }
                else if (firstDiag == secondDiag)
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

                return convertTime.Remove(indexAMPM, 2);
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

                convertTime = string.Concat(0, convertToPM.ToString(), minute);
                indexAMPM = convertTime.IndexOf("AM");
                Console.WriteLine(convertTime.Remove(indexAMPM, 2));
                return s;
            }
        }

        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x1 > x2 && v1 > v2)
            {
                Console.WriteLine("No");
                return "NO";
            }

            if (x1 < x2 && v1 < v2)
            {
                Console.WriteLine("No");
                return "NO";
            }
            
            if ((x2-x1) % (v1-v2) == 0 || (x2 - x1) % (v2 - v1)== 0)
            {
                Console.WriteLine("Yes");
                return "Yes";
            }

            return "No";
        }


        static int[] breakingRecords(int[] scores)
        {
            int max = scores[0]; // 20
            int min = scores[0]; // 4
            int maxCount = 0;
            int minCount = 0;
            List<int> countList = new List<int>();
            int[] ms = { };
            foreach (var score in scores)
            {
                if(min > score)
                {
                    min = score;
                    minCount++;
                };
                if (max < score)
                {
                    max = score;
                    maxCount++;
                }

            }
            countList.Add(maxCount);
            countList.Add(minCount);
            return countList.ToArray();

        }

        public static int BirthdayResult(List<int> elements, int d, int m)
        {
            int sum = 0;
            int count = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                sum += elements[i];
                if (i >= m) sum -= elements[i - m];
                if (sum == d && i >= m - 1)
                    count++;
            }

            Console.WriteLine(count);
            return count;

        }

        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                for (int j = i + 1; j < ar.Count; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                        count++;
                }
            }

            Console.WriteLine(count);
            return count;
        }

        public static int migratoryBirds(List<int> arr)
        {
            var birdTypeCounts = new int[5];

            for (int i = 0; i < arr.Count; i++)
                birdTypeCounts[arr[i] - 1]++;

            var maxBirdTypeCount = birdTypeCounts[0];
            var maxBirdType = 1;

            for (int i = 1; i < 5; i++)
            {
                if (birdTypeCounts[i] > maxBirdTypeCount)
                {
                    maxBirdTypeCount = birdTypeCounts[i];
                    maxBirdType = i + 1;
                }

                if (birdTypeCounts[i] == maxBirdTypeCount && i + 1 < maxBirdType)
                    maxBirdType = i + 1;
            }

            return maxBirdType;
        }


        public static int bonAppetit(List<int> bill, int k, int b)
        {
            bill.Remove(bill[k]);
            int sum = 0;
            int annaCash = 0;
            int returnCash = 0;
            foreach (var item in bill)
            {
                sum += item;
            }
            annaCash = sum / 2;
            if (b == annaCash)
            {
                Console.WriteLine("Bon Appetit");
            }
            if (b > annaCash)
            {
                returnCash = b - annaCash;
                Console.WriteLine(returnCash);
            }
            return returnCash;
        }


        public static int sockMerchant(int n, List<int> ar)
        {
            int count = 0;
            int max = ar.Max() + 1;
            for (int i = 0; i < ar.Count; i++)
            {
                if (ar[i] == max) continue;
                for (int j = i+1; j < ar.Count; j++)
                {
                    if(ar[i] == ar[j])
                    {
                        ar[i] = max;
                        ar[j] = max;
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine(count); 
            return count;
        }

        public static int pageCount(int n, int p)
        { 
            int diffFrom1 = (int)Math.Ceiling((float)(p-1)/2);
            int diffFromN;

            if(n%2 == 0)
            {
                diffFromN = (int)Math.Ceiling((float)(n - p) / 2); ;
            }
            else
            {
                diffFromN = (int)Math.Floor((float)(n - p) / 2);
            }

            if (diffFrom1 <= diffFromN)
            {
                Console.WriteLine(diffFrom1);
                return diffFrom1;
            }
            else {
                Console.WriteLine(diffFromN);
                return diffFromN;
            }            
        }

        static int countingValleys(int n, string s)
        {

            int elevation = 0;
            int valleyCount = 0;
            bool aboveSeaLevel = true;

            foreach (char c in s)
            {
                if (c == 'D')
                {
                    elevation--;
                }

                else
                {
                    elevation++;
                }

                if (elevation < 0 && aboveSeaLevel == true)
                {
                    valleyCount++;
                    aboveSeaLevel = false;
                }
                else if (elevation >= 0 && aboveSeaLevel == false)
                {
                    aboveSeaLevel = true;
                }
            }
            Console.WriteLine(valleyCount);
            return valleyCount;
        }

        static int getMoneySpent(int[] keyboards, int[] drives, int totalMoneyAvailable)
        {
            var sortedKeyboardPrices = from keyboard in keyboards
                                       orderby keyboard descending
                                       select keyboard;
            var sortedDrivePrices = from drive in drives
                                    orderby drive ascending
                                    select drive;
            //default if not able to purchase anything
            var maxMoneySpendable = -1;

            foreach (var keyboard in sortedKeyboardPrices)
            {
                foreach (var drive in sortedDrivePrices)
                {
                    if (keyboard + drive <= totalMoneyAvailable)
                    {
                        if (keyboard + drive > maxMoneySpendable)
                            maxMoneySpendable = keyboard + drive;
                    }
                    else
                        break;
                }
            }
            return maxMoneySpendable;
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


            //8 Kenqurularin addimlarinin sonsuz dovrde ust uste dusme ehtimali //
            //string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            //int x1 = Convert.ToInt32(x1V1X2V2[0]);

            //int v1 = Convert.ToInt32(x1V1X2V2[1]);

            //int x2 = Convert.ToInt32(x1V1X2V2[2]);

            //int v2 = Convert.ToInt32(x1V1X2V2[3]);

            //string result = kangaroo(x1, v1, x2, v2);
            //8 Kenqurularin addimlarinin sonsuz dovrde ust uste dusme ehtimali //

            //-----------------------------------------------------------------------------------------------------  

            //9 Daxil olunan ededlerden max ve min ededlerin sayini tapmaq 
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            //;
            //int[] result = breakingRecords(scores);
            //9 Daxil olunan ededlerden max ve min ededlerin sayini tapmaq 



            //------------------------------------------------------------------------------------------------------- 

            //10 Sokolad meselesi(Subarray Division)
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //int d = Convert.ToInt32(firstMultipleInput[0]);

            //int m = Convert.ToInt32(firstMultipleInput[1]);

            //int result = BirthdayResult(s, d, m);
            //------------------------------------------------------------------------------------------------------- 

            //------------------------------------------------------------------------------------------------------- 
            //11 Divisible Sum Pairs

            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //int n = Convert.ToInt32(firstMultipleInput[0]);

            //int k = Convert.ToInt32(firstMultipleInput[1]);

            //List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            //int result =divisibleSumPairs(n, k, ar); 

            //-------------------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------------------- 
            //12 Migratory Birds


            //int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //int result = migratoryBirds(arr);

            //------------------------------------------------------------------------------------------------------- 

            //------------------------------------------------------------------------------------------------------- 
            //13 Bill Division
            //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //int n = Convert.ToInt32(firstMultipleInput[0]);

            //int k = Convert.ToInt32(firstMultipleInput[1]);

            //List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            //int b = Convert.ToInt32(Console.ReadLine().Trim());

            //bonAppetit(bill, k, b);

            //------------------------------------------------------------------------------------------------------- 



            //------------------------------------------------------------------------------------------------------- 

            //14 Sales By Match
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            //int result = sockMerchant(n, ar);


            //------------------------------------------------------------------------------------------------------- 

            //15 Drawing Book

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //int p = Convert.ToInt32(Console.ReadLine().Trim());

            //int result = pageCount(n, p);

            //------------------------------------------------------------------------------------------------------- 

            //------------------------------------------------------------------------------------------------------- 

            //16 Counting Valleys

            //int steps = Convert.ToInt32(Console.ReadLine().Trim());

            //string path = Console.ReadLine();

            //int result = countingValleys(steps, path);

            //------------------------------------------------------------------------------------------------------- 


            //------------------------------------------------------------------------------------------------------- 
            //17 Electronics Shop
            //string[] bnm = Console.ReadLine().Split(' ');

            //int b = Convert.ToInt32(bnm[0]);

            //int n = Convert.ToInt32(bnm[1]);

            //int m = Convert.ToInt32(bnm[2]);

            //int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp));

            //int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp));

            //int moneySpent = getMoneySpent(keyboards, drives, b);

            //------------------------------------------------------------------------------------------------------- 


        }

    }
}
