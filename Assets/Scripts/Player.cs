using UnityEngine;

public class Player 
{
    public string playerName ;
    public int health =100 ;

    public static int playerCount;



    public void initializePlayer(string name , int initialHealth)
    {
        playerName = name;
        if(initialHealth>100)
        {health =100;}
        else if(initialHealth<0)
        {health =0;}
        else 
        {health = initialHealth;}
        playerCount++;
    }
    public void Heal(int amount)
    {
        health +=amount ;
        if(health>100)
        {health =100;}
        Debug.Log("health for "+playerName+" = " + health);
    }
    public void Heal(bool fullRestore)

    {
        if(fullRestore)
        {
            health = 100;
        }
        
        Debug.Log("health for "+playerName+" = " +health);
    
    }

    public static void ShowPlayerCount(){
        Debug.Log("Total Number of player  = " + playerCount);
    }






  
}
