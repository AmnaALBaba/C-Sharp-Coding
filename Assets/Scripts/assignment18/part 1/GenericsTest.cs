using UnityEngine;

namespace Generics
{
    public class G : MonoBehaviour
    {

        void Start()
        {
            GameContainer<string> gameContainer = new GameContainer<string>();
            gameContainer.SetItem("Healing Potion");
            string item = gameContainer.GetItem();
            Debug.Log("Stored item : " + item);

            GameUnits.DescribeItem(item);

        }


    }
}
