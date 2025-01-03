using UnityEngine;

public class UnitySpecificScript : MonoBehaviour
{
    GameObject targetObject;
    GameObject joker;
    Light lightPoint;



    void OnEnable()
    {
        print("GameObject Enabled");
    }
    void OnDisable()
    {
        print("GameObject Disabled");
    }

    void Start()
    {
        print("Game Started ");

        targetObject = GameObject.Find("TargetObject");
        if (targetObject != null)
        {
            print($"Found object by name : {targetObject.name}");
        }
        else
        {
            print("No TargetObject found");
        }
        joker = GameObject.FindGameObjectWithTag("Joker");

        if (joker != null)
        {
            print($"Found object by tag : {joker.name}");
        }
        else
        {
            print("No joker object found");
        }
        lightPoint = GameObject.FindObjectOfType<Light>();
        if (lightPoint != null)
        {
            print($"Found object of type Light : {lightPoint.type}");
        }
        else
        {
            print("No light object found");
        }

    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            targetObject.SetActive(false);
            print("TargetObject deactivated");
        }
    }


}
