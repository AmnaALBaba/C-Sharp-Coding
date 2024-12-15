using UnityEngine;
namespace Assignment27
{
    public class CallingByRef0rValue : MonoBehaviour
    {


        int number3;

        void Start()
        {
            int number1 = 1;
            int number2 = 2;
            //Calling by value 
            Debug.Log("number1 Before Calling By Value Mehthod = " + number1);
            CallingByValue(number1);
            Debug.Log("number1 After Calling By Value  Mehthod = " + number1);

            //Calling by ref 
            Debug.Log("number2 Before Calling calling By Referance Mehthod = " + number2);
            CallingByReferance(ref number2);
            Debug.Log("number2 After Calling calling By Referance Mehthod = " + number2);

            //Calling using  out 
            Debug.Log("number3 Before Calling Using Out Mehthod = " + number3);
            CallingUsingOut(out number3);
            Debug.Log("number3 After Calling Using Out Mehthod = " + number3);





        }

        void CallingByValue(int number)
        {
            number += 10;
        }
        void CallingByReferance(ref int number)
        {
            number += 10;
        }
        void CallingUsingOut(out int number)
        {
            number = 10;
        }


    }
}
