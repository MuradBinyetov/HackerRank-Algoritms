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
        }
    }
}
