using System.Runtime.ExceptionServices;
using UnityEngine;
namespace assignment29
{

    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            print($"the FibonacciRecursive of n = 10  :{FibonacciRecursive(10)}");
            print($"the FibonacciRecursive of n = 30 :{FibonacciRecursive(30)}");
            print($"the FibonacciIterative of n = 10  :{FibonacciIterative(10)}");
            print($"the FibonacciIterativeof n = 30 :{FibonacciIterative(30)}");


        }

        int FibonacciRecursive(int n)
        {

            if (n == 1 || n == 0) { return n; }
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);

        }

        int FibonacciIterative(int n)
        {

            if (n == 1 || n == 0) { return n; }
            int result = 0;
            int first = 0;//(n-2); 
            int second = 1;//(n-1) ; 
            for (int i = 2; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;



            }
            return result;
        }


    }

}
