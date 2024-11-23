using UnityEngine;
namespace Generics
{
    public class GameContainer<T>
    {
        private T item;
        /// <summary>
        /// this is method for Set item 
        /// </summary>
        /// <param name="item"></param>
        public void SetItem(T item)
        {
            this.item = item;

        }
        /// <summary>
        /// this is method for get item 
        /// </summary>
        /// <returns></returns>
        public T GetItem()
        {
            return item;

        }
    }
}
