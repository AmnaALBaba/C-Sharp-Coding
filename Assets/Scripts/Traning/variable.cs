using assignment29;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class variable : MonoBehaviour
{
    int num ; 


    void Start()
    {
        inputpara(out num);
        print(num);


   



    }
    void inputpara(out int number){
        number = 10 ; 
        print(number); 
    }

  



}
