using System;
using UnityEngine;
namespace assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {


        void Start()
        {

            Action logMessage = () => Debug.Log("Hello from Action delegate!");
            logMessage(); //claling 

            Func<int, int> square = (int number) => number * number;
            Debug.Log($"Square: {square(5)}"); //call the func 

            Predicate<int> isEven = (int number) => (number % 2 == 0) ? true : false;
            Debug.Log($"Is 4 even? {isEven(4)}");

        }


    }
}
