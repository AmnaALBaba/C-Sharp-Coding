using System.Runtime.ExceptionServices;
using Assignment18;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        Soldier soldeir;
        Officer officer;
        void Start()
        {
            soldeir = new Soldier();  //new object with empty cons.
            officer = new Officer("Emad", 90, new Position(4, 4, 4)); //new object with cons.
            Character[] characters = new Character[2]; //array with 2 item
            characters[0] = soldeir;
            characters[1] = officer;
            //test method attack 
            Debug.Log("officer Health before attacked  = " + officer.Health);
            soldeir.Attack(10, officer);
            Debug.Log("officer Health after attecked  = " + officer.Health);

            //for loop to display info with override method.
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }





        }


    }
}