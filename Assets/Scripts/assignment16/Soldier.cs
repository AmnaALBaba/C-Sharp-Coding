//using System.Diagnostics;
using UnityEngine;
namespace Assignment18
{
    //inhertense from character class 
    public class Soldier : Character
    {
        //empty constructor
        public Soldier()
        {

        }
        //constructor called thes base constuctor and apply DRY
        public Soldier(string name, int Health, Position position) : base(name, Health, position)
        {

        }
        //method override to display info
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();

        }

    }
}




