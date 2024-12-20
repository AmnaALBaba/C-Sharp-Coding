using Unity.Mathematics;
using UnityEngine;

public class ChagingShip : MonoBehaviour
{

    public float speed = 3.8f;

    public GameObject[] shape;

    private int index;

    void Strat()
    {
        foreach (var shapes in shape)
        {
            shapes.SetActive(false);
        }
    }
    //  is called once per frame
    void Update()
    {
        float xnew = Mathf.PingPong(Time.time, 8);
        // transform.rotation = quaternion.Euler(new Vector3(0f, xnew *angle, 0f));
        transform.rotation = Quaternion.Euler(new Vector3(0f, xnew * 90, 0f));
        //transform.Rotate(Vector3.up * angle);


        ChangeShipe();


    }
    void ChangeShipe()
    {
        if (shape.Length > 0)
        {
            int totalValue = Mathf.FloorToInt(Time.time * speed);//40
            int result = totalValue / shape.Length;//10
            index = result % shape.Length;//2

            for (int i = 0; i < shape.Length; i++)
            {

                shape[i].SetActive(i == index);



            }
        }
        else
        {
            Debug.Log("the shape array is empty !");
        }



    }
}
