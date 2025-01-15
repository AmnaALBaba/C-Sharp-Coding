using UnityEngine;
namespace assignment35

{


    public class BoxingUnboxing : MonoBehaviour
    {

        void Start()
        {
            int health = 100;
            object healthUpCasting = health;

            // ^int? healthDownCasting  = healthUpCasting as int? //int ? because int is not nullanble variables ; 
            int healthDownCasting = (int)healthUpCasting;
            healthDownCasting = 50;
            print($"health  : {health}");
            print($"health after boxing   : {healthUpCasting}");
            print($"health after unboxing and modify it   : {healthDownCasting}");




        }

    }
}
