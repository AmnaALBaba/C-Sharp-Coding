using Unity.Mathematics;
using UnityEngine;
namespace assignment35
{
    delegate void MathOperation(int number);
    public class MulticastDelegateExample : MonoBehaviour
    {
        MathOperation operation;
        void Start()
        {
            //Subscribe the Methods
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;

            operation?.Invoke(5);


        }

        void DoubleNumber(int number) => Debug.Log($"Double : {2 * number}");
        void SquareNumber(int number) => Debug.Log($"Square : {number * number}");
        void CubeNumber(int number) => Debug.Log($"Cube : {number * number * number}");





    }
}
