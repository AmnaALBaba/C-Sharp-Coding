using System.Data.Common;
using UnityEngine;
namespace assignment29
{
    public class CustomObject
    {
        int _id;
        string _name;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public CustomObject(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Object [ID: {ID}, Name: {Name}]";
        }

        // public override bool Equals(object obj)
        // {
        //     if (obj != null && obj is CustomObject custom)
        //     {
        //         return this._name == custom._name && this._id == custom._id;

        //     }
        //     return false;


        // }

        public static bool operator ==(CustomObject c1, CustomObject c2)
        {
            if (!c1.Equals(null) && !c2.Equals(null))
            {
                if (c1.ID.Equals(c2.ID) && c1.Name.Equals(c2.Name)) { return true; }
            }
            return false;



        }
        public static bool operator !=(CustomObject c1, CustomObject c2)
        {
            if (!c1.Equals(null) && !c2.Equals(null))
            {
                if (!c1.ID.Equals(c2.ID) || !c1.Name.Equals(c2.Name)) { return true; }
            }
            return false;



        }
    }

}
