//using System.Diagnostics;
using UnityEngine;
namespace Assignment18
{
public class Character 
{
    public string name;
    private int health;
    protected Position position;

    public int Health
    {
        get {return health;}
        set{
            if(value>=0 && value<=100){
                health = value;
            }
        }
    }

    public Character(string name , int Health , Position position){
        this.name = name;
        this.Health  = Health;
        this.position = position;
    }

    public Character():this("No Name",100,new Position(0,0,0))
    {

    }

    public virtual void DisplayInfo()
    {
        Debug.Log("Name :" + this.name);
        Debug.Log("Health :" + this.Health);
        this.position.PrintPosition();
        
    }


    public void CommonAttack(int damage)
    {
        Health -= damage;
        if(Health<0)
        {
            Health = 0 ; 

        }



    }
    public void Attack( int damage , Character target)
    {
        target.CommonAttack(damage);
        Debug.Log(target + "attacked by " + damage +"amount" );
        



    }

    public void Attack( int damage , Character target,string attackType)
    {
        target.CommonAttack(damage);
        Debug.Log(target + "attacked by " + damage +"amount" + "by "+ attackType);


    }



   


}
}

