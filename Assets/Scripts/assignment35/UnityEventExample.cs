using UnityEngine;
using UnityEngine.Events;
using System;

namespace assignment35
{
    public class UnityEventExample : MonoBehaviour
    {
        public UnityEvent onEventTriggered;



        void Start()
        {
            onEventTriggered = new UnityEvent();
            onEventTriggered.AddListener(OnEventResponse);

        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) onEventTriggered?.Invoke();

        }

        void OnEventResponse()
        {
            Debug.Log("The event has been triggered!");
        }
    }
}