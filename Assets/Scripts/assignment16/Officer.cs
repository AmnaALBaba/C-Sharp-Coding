using UnityEngine;
namespace Assignment18
{
    //inhertense from character class 
    public class Officer : Character
    {
        //constructor called thes base constuctor and apply DRY
        public Officer(string name, int Health, Position position) : base(name, Health, position)
        {

        }
        //method override to display info
        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();

        }
    }
}
