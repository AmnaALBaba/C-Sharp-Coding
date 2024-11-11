using Unity.VisualScripting;
using UnityEngine;

public class Enemy : Character
{

  
    public Enemy(string enemyName  , int enemyHealth):base(enemyName , enemyHealth)
    {

    }
   
    public void Attack(Character character  ,int amount)
    {
        character.Health -= amount;
        if(character.Health <0)
        {
            character.Health =  0;
        }

    }

}
