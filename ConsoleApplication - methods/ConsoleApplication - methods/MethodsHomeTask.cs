using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication___methods
{
    static class MethodsHomeTask
    {
        // HomeTask 1
        public static int IsNumberInArray(int[] arr4, int n)
        {
            int temp = 0;
            for (int i = 0; i < arr4.Length; i++)
            {
                if (arr4[i] == n)
                {
                    temp = i;
                    break;
                }
                else
                    temp = -1;
            }
             return temp;
        }


        //HomeTask 2
        public static void OutputText(string text, params int[] list) //params - масив інтів невизначеної довжини
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }

            if (sum > 20)
                Console.WriteLine(text);
            else
                Console.WriteLine("Sorry, the sum is {0}", sum);
        }

        // HomeTask 3
        // ??????????????????????????????????/
        public static void Progressia(int[,] arr)
        {
            int temp1 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    arr [i,j] = temp1+1;
                    temp1 = arr[i, j];
                    Console.WriteLine(arr[i,j] + "\t");
                }

            }
        }
        

    }


}
