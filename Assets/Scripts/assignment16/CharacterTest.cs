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
        soldeir = new Soldier();
        officer = new Officer("Emad" , 90 , new Position(4,4,4));
        Character [] characters = new Character[2];
        characters[0] = soldeir;
        characters[1] = officer;

        for(int i = 0 ; i<characters.Length ; i++){
            characters[i].DisplayInfo();
        }

        


        
    }

    
}
}