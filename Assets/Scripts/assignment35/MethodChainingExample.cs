
using UnityEngine;

namespace assignment35
{
    public class MethodChainingExample : MonoBehaviour
    {
        ChangeTransform change;


        void Start()
        {
            change = new();
            change.gameObject = GameObject.Find("part7");
            change.SetPosition(new Vector3(0, 1, 0)).SetRotation(new Vector3(45, 0, 0))
            .SetScale(new Vector3(2, 2, 2));

        }



    }
    public class ChangeTransform
    {


        public GameObject gameObject;

        public ChangeTransform SetPosition(Vector3 pos)
        {
            gameObject.transform.position = pos;
            return this;

        }
        public ChangeTransform SetRotation(Vector3 rotate)
        {
            gameObject.transform.rotation = Quaternion.Euler(rotate);
            return this;

        }
        public ChangeTransform SetScale(Vector3 scale)
        {
            gameObject.transform.localScale = scale;
            return this;

        }

    }
}
