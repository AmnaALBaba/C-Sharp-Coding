using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem.Android;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()


    {
        /*exercise 1 :
        1.Write a C# script that generates random numbers (from 1 to 20) using a while loop.
        2. Print each number. If the number is 5, use continue to skip printing it.
        3. If the number is 15, use break to exit the loop.*/
        while (true)
        {
            int randomNumber = Random.Range(1, 21);
            if (randomNumber == 5)
            {
                //Debug.Log("Number is 5, I will skip this itreation and countinue to the next");
                continue;

            }
            else if (randomNumber == 15)
            {
                //Debug.Log("Number is 15 , sorry I will exists the while loop");
                break;

            }
            else 
            {
                Debug.Log(randomNumber);
            }
            
           


        }


        /*exercise 2 :
        1. Write a C# script that uses an array of these words:
             Cat, Dog, Car, Pizza, Hat, Fish, Tree, Monkey, Ball, Bird.
        2. Use a while loop to build a funny sentence with 7 words randomly chosen from the
              array.
        3. Print the sentence to the console.*/
        
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Bail", "Brid" };
        string funnySentence = "";
        int count = 0;
        while (count < 7)
        {
            int indexArray = Random.Range(0, words.Length);
            funnySentence +=  words[indexArray] +" ";
            
            count++;

        }
        Debug.Log(funnySentence);
       








    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
