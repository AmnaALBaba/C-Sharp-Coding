using UnityEngine;

public class Character 
{
    private string name  ;
    private int health;

    public string Name
    {
        get{ return name ;}
        set{name = value ; }

    }
    public int Health
    {
        get{return health;}
        set{health = value ; }
    }

    public Character(string name , int health)
    {
        Name  = name;
        Health = health;
    } 
 
   
}
