using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace List_OperatorOverloading
{
    public class Inventory
    {
        private List<string> names = new List<string>();

        public void AddItem(string item)
        {
            names.Add(item);
        }
        public void ShowItem()
        {
            for (int i = 0; i < names.Count; i++)
            {
                Debug.Log("Index : " + i + " - " + names[i]);

            }
        }

        public static Inventory operator +(Inventory a, Inventory b)
        {
            Inventory emptyInventory = new Inventory();
            emptyInventory.names.AddRange(a.names);
            emptyInventory.names.AddRange(b.names);
            return emptyInventory;


        }

    }
}
