using UnityEngine;

namespace Assignment26
{
    public class Kangroo : Creature, IRunnable, IJumpable
    {
        public void Run()
        {
            Debug.Log("Kangoo runs.");
        }

        public void Jump()
        {
            Debug.Log("Kangoo jumps.");
        }

        public override void Speak()
        {
            Debug.Log("Kangaroo says : Hop!");
        }



    }
}

