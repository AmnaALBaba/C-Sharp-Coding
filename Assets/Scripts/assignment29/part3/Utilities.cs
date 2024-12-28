using Unity.VisualScripting;
using UnityEngine;
namespace assignment29
{
    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sumResult = 0;
            if (numbers.Length > 0)
            {


                foreach (int number in numbers)
                {
                    sumResult += number;

                }
            }
            return sumResult;


        }
     

        public static string RepeatString(this string str , int repeat)
        {
            string result = "";
            for (int i = 1; i <= repeat; i++)
            {
                result += str + ' ';

            }
            return result;
        }
    }
}
