using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    public float jumpSpeed = 10f;

    private Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        myRigidbody.AddForce(new Vector3(0f,1f,0f) * jumpSpeed * Time.deltaTime, ForceMode.Impulse);
    }
}
