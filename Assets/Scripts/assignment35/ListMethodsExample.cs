using System.Collections.Generic;
using UnityEngine;
namespace assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
        List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        List<int> filterNumber = new List<int>();


        void Start()
        {

            numbers.Sort((int x, int y) => y.CompareTo(x));
            string decendingSortingList = string.Join(" , ", numbers);
            print($"Sorting numbers list : {decendingSortingList} ");

            foreach (int number in numbers2.FindAll((number) => number % 2 == 0))
            {
                // Debug.Log(number);
                filterNumber.Add(number);

            }
            string filterList = string.Join(" , ", filterNumber);
            print($"filter numbers list : {filterList} ");




        }

    }

}
