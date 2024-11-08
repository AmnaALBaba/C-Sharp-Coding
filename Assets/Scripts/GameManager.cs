using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player gamer1 = new Player();
        Player gamer2 = new Player();
        Player gamer3= new Player();
        //initalize amna as gamer 1 and heath =80
        gamer1.initializePlayer("Amna" , 80);

        //initialize emad as gamer 2 and health = 90
        gamer2.initializePlayer("Emad", 90);

        //initialize said as gamer 2 and health = 95
        gamer3.initializePlayer("Said",95);

        
        //amount = 3  , health of amna is 83
        gamer1.Heal(3);
        //when a parameter is false not thing change 
        gamer1.Heal(false);
        //when a parameter is true the health become full =100
        gamer2.Heal(true);

        gamer2.Heal(10);        
        //when health is 95 ,amount  = 10 , not accept health more than 100 , so become the output =100
        gamer3.Heal(10);
        Player.ShowPlayerCount();



        
    }
}

   
