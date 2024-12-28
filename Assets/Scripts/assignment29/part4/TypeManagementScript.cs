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
            animal = cat;

            //downcasting
            cat = animal as Cat;


            animal.MakeSound();
            animal.Move();

            cat.MakeSound();
            cat.Move();

            List<ICanFight> animalList = new List<ICanFight> { new Cat(), new Warrior() };

            foreach (var animals in animalList)
            {
                animals.Attack();
                if (animals is Cat)
                {
                    Debug.Log("The object is a Cat.");


                }
                if (animals is Warrior)
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
        public virtual void Move()
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
        public override void Move()
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