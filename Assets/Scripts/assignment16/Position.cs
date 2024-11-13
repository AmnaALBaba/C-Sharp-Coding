using UnityEngine;

namespace Assignment18
{
    public struct Position
    {
        //fields
        public float x;
        public float y;
        public float z;
        //constructor
        public Position(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
        //method to print position 
        public void PrintPosition()
        {
            Debug.Log("Position(X = " + this.x + ",Y = " + this.y + ",Z= " + this.z + ")");


        }


    }
}