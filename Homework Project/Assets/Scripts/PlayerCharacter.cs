using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public float moveSpeed = 100f;

    private Rigidbody myRigidbody; 

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey(KeyCode.W);

        if (forwardPressed)
        {
            myRigidbody.AddForce(new Vector3(0f,0f,1f) * moveSpeed, ForceMode.Impulse);
        }
    }
}
