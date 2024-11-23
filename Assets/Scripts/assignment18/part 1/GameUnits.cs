using UnityEngine;

namespace Generics
{
    public class GameUnits
    {
        /// <summary>
        /// static method that returns a description of something as a string  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="somthing"></param>
        public static void DescribeItem<T>(T somthing)
        {
            Debug.Log("This item is a " + somthing);
        }
    }
}
