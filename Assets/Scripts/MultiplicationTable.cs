using UnityEngine;

public class assignment10 : MonoBehaviour
{
    int Multiply(int n , int m )
    {
        return n*m;
    }
    
    void Start()
    {
        for(int i=1 ; i<=10 ;i++)
        {
            Debug.Log(i+" * "+5+" = "+i*5);

        }
        
    }


   
}
