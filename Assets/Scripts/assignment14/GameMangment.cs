using UnityEngine;

public class GameMangment : MonoBehaviour
{
    PlayerInherits player1 ;
    Enemy enemy1 ;

    //Character character ;

    void Start()
    {
        player1  = new PlayerInherits("Aman"  ,90);
        enemy1  =new Enemy("emad" , 80);
        //character  = new Character("said",  70);
        Debug.Log("player1.Name : "+player1.Name+" player1.Health = "+ player1.Health);
        Debug.Log("enemy.Name : "+enemy1.Name+" enemy1.Health = "+ enemy1.Health);

        player1.Heal(10);
        Debug.Log("player1.Name : "+player1.Name+" player1.Health after health increase = "+ player1.Health);

        enemy1.Attack(player1 , 10);
        Debug.Log("player1.Name : "+player1.Name+" player1.Health after health decrease = "+ player1.Health);

    }

    
}
