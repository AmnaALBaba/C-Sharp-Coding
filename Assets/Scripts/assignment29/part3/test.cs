using UnityEngine;
using UnityEngine.InputSystem.Controls;
namespace assignment29
{
    public class test : MonoBehaviour
    {
        void Start()
        {
            int sum =Utilities.Add(1, 2, 3, 4, 5, 6, 7, 8, 9);
 
            Debug.Log(sum); 

            string repeatString = "Hello";
           
            Debug.Log(repeatString.RepeatString(3));
        


        }


    }
}
