using Unity.Mathematics;
using UnityEngine;
namespace Toy
{
    public class Toy : MonoBehaviour
    {


        bool isplayerOneActive = false;
        bool isplayerTwoActive = false;

        public Transform playerOneball;
        public Transform playerTwoball;

        float vInput;
        float hInput;



        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Play();
            BallRest();

        }



        void PlayerInput(Transform ball)
        {
            vInput = Input.GetAxis("Vertical");
            hInput = Input.GetAxis("Horizontal");
            ball.transform.Translate(Vector3.forward * vInput * Time.deltaTime);
            ball.transform.Translate(Vector3.left * hInput * Time.deltaTime);
        }
        void Play()
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                isplayerOneActive = true;
                isplayerTwoActive = false;

                PlayerInput(playerOneball);


                Debug.Log("Player One is active");


            }
            else if (Input.GetKey(KeyCode.Alpha2) )
            {
                isplayerTwoActive = true;
                isplayerOneActive = false;

                PlayerInput(playerTwoball);
                Debug.Log("Player Two is active");

            }
            else if (Input.GetKey(KeyCode.Alpha0))
            {
                isplayerOneActive = true;
                isplayerTwoActive = true;
                PlayerInput(playerOneball);
                PlayerInput(playerTwoball);
                Debug.Log("Player One & Player Two is active");


            }

        }
        void BallRest()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (isplayerOneActive || isplayerTwoActive)
                {
                    playerOneball.transform.position = new Vector3(0.0489999987f,0.231999993f,-0.791000009f);
                    



                    playerTwoball.transform.position = new Vector3(-1.92900002f,0.231999993f,-0.791000009f);

                }


            }
        }
    }
}
