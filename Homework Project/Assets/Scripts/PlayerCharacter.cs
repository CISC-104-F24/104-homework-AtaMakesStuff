using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public float moveSpeed = 10f;

    private Rigidbody myRigidbody; 

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // WASD for four directional movement
        bool forwardPressed = Input.GetKey(KeyCode.W);

        if (forwardPressed)
        {
            transform.position = transform.position + transform.forward * moveSpeed * Time.deltaTime;
        }

        bool backPressed = Input.GetKey(KeyCode.S);
        
        if (backPressed)
        {
            transform.position = transform.position + new Vector3(0f,0f,-1f) * moveSpeed * Time.deltaTime;
        }

        bool leftPressed = Input.GetKey(KeyCode.A);
        
        if (leftPressed)
        {
            transform.position = transform.position + new Vector3(-1f,0f,0f) * moveSpeed * Time.deltaTime;
        }

        bool rightPressed = Input.GetKey(KeyCode.D);

        if (rightPressed)
        {
            transform.position = transform.position + new Vector3(1f,0f,0f) * moveSpeed * Time.deltaTime;
        }

        //Spacebar for jumping 

        bool jumpPressed = Input.GetKeyDown(KeyCode.Space);

        if (jumpPressed) 
        {
            myRigidbody.AddForce(new Vector3(0f,1f,0f) * moveSpeed, ForceMode.Impulse);
        }

        
    }
}
