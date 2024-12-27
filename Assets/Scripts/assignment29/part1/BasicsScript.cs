using System;
using UnityEngine;
namespace assignment29
{



    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            var number = 10;
            var name = "Amna";
            var isPlay = true;

            var result = (number % 2 == 0) ? "even " : "odd";
            Debug.Log($"The number {number} is {result}.");
            Debug.Log($"the current date : {DateTime.Now.Date}");
            //with out time .. 
            Debug.Log($"the current date : {DateTime.Now.ToShortDateString()}");

            Debug.Log($"the current time : {DateTime.Now.TimeOfDay}");
            Debug.Log($"the current day :  {DateTime.Now.DayOfWeek}");

        }


    }
}