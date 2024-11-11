using UnityEngine;

public class PlayerInherits : Character
{
    public PlayerInherits(string playerName  , int playrthealth):base(playerName , playrthealth)
    {

    }

    public void Heal(int amount){

        Health +=amount;
        if(Health>100)
        {
            Health = 100;
            
        }
    }
    
  
}
