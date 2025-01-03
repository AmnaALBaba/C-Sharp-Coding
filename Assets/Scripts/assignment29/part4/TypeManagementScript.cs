using UnityEngine;
using System.Collections.Generic;
namespace assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        void Start()
        {
            Animal animal = new Animal();

            Cat cat = new Cat();


            //UpCasting 
            animal = cat;  // animal ref execute all method &feild  in animal and method override in cat ; 

            //downcasting
            cat = animal as Cat;


            animal.MakeSound();
            animal.Move();

            if (cat != null)
            {

                cat.MakeSound();
                cat.Move();
            }

            List<ICanFight> animalList = new List<ICanFight> { new Cat(), new Warrior() };

            foreach (var animl in animalList)
            {
                animl.Attack();
                if (animl is Cat)
                {
                    Debug.Log("The object is a Cat.");


                }
                if (animl is Warrior)
                {
                    Debug.Log("The object is a Warrior.");


                }

            }


        }
    }

    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");

        }
        public void Move()
        {
            Debug.Log("Animal Moves");

        }

    }

    public class Cat : Animal, ICanFight

    {
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }

        public override void MakeSound()
        {
            Debug.Log("Meow!");

        }

        //hiding by new keyword ; 
        public new  void Move()
        {
            Debug.Log("Cat runs quickly.");

        }
    }

    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }


    public interface ICanFight
    {
        public void Attack();

    }
}