using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering.Universal;
namespace trainCodin
{
    public class train : MonoBehaviour
    {


        void Start()
        {






        }



    }


    public interface IInheretance
    {
        public void printInfo();
    }

    public class Subhi
    {
        public int number1;
        public int number2;
        public Subhi(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
    }

    public struct Example : IInheretance
    {

        public int x;
        public int y;

        public Example(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void printInfo()
        {
            Debug.Log($"x = {x} ,  y = {y}");
        }
    }


}
