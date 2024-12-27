using UnityEngine;
namespace assignment29
{
    public class TestingScript : MonoBehaviour
    {
        void Start()
        {
            CustomObject custom1 = new CustomObject(1, "Amna");
            CustomObject custom2 = new CustomObject(1, "Kareem");
            CustomObject custom3 = new CustomObject(1, "Amna");
            print(custom1); //calling toString method 
            print(custom2);
            print(custom3);
            print($"Doese custum 1 equal custum  2 : {custom1 == custom2}");
            print($"Doese custum 1 Not equal custum  2 : {custom1 != custom2}");
            print($"Doese custum 1 equal custum  3 : {custom1 == custom3}");




        }


    }
}
