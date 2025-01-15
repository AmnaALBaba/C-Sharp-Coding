using UnityEngine;
namespace assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        DerivedClassExample example;
        void Start()
        {
            example = new();
            example.PerformAction();
            example.PrintInfo();


        }
    }
}
