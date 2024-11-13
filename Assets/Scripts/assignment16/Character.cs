//using System.Diagnostics;
using UnityEngine;
namespace Assignment18
{
    public class Character
    {
        //fields
        public string name;
        private int health;
        protected Position position;

        //properity
        public int Health
        {
            get { return health; }
            set
            {

                if (health < 0) { health = 0; }
                else if (health > 100) { health = 100; }
                else { health = value; }


            }
        }

        //constructor
        public Character(string name, int Health, Position position)
        {
            this.name = name;
            this.Health = Health;
            this.position = position;
        }
        //chaining constructor
        public Character() : this("No Name", 100, new Position(0, 0, 0))
        {

        }
        //method to display information for Character object
        public virtual void DisplayInfo()
        {
            Debug.Log("Name :" + this.name);
            Debug.Log("Health :" + this.Health);
            this.position.PrintPosition();

        }

        //method decrease health after attacked 
        public void Attack(int damage, Character target)
        {
            target.Health -= damage;

            Debug.Log(target + " attacked by " + damage + " amount");




        }

        //method overloading by adding a parameter attacked type 
        public void Attack(int damage, Character target, string attackType)
        {
            target.Health -= damage;
            Debug.Log(target + "attacked by " + damage + "amount" + "by " + attackType);


        }






    }
}

