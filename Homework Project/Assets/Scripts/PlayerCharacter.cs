using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public float moveSpeed = 10f;

    public float sprintSpeed = 20f;

    public float originalSpeed = 10f;

    public float jumpSpeed = 10f;

    public float originalJumpSpeed = 10f;

    public float powerGainedPerSecond = 1f;

    public float rotateSpeed = 1f;

    public float scaleSpeed = 1f;

    public float distanceSprinted = 0f;

    public float maxSprintTime = 10f; 

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

        //Spacebar for jumping & Left Control for charging a jump

        bool jumpPressed = Input.GetKeyDown(KeyCode.Space);

        bool chargePressed = Input.GetKey(KeyCode.LeftControl);

        if (chargePressed)
        {
            jumpSpeed = jumpSpeed + powerGainedPerSecond * Time.deltaTime; 
        }

        if (jumpPressed) 
        {
            myRigidbody.AddForce(new Vector3(0f,1f,0f) * jumpSpeed, ForceMode.Impulse);
            jumpSpeed = originalJumpSpeed;
        }

        // Left Shift for sprinting
        // Can only sprint for 5 consecutive seconds 
        // before returning to normal speed 
        // then reset distance travelled upon releasing sprint

        bool sprintPressed = Input.GetKey(KeyCode.LeftShift);

        if (sprintPressed) 
        {
            moveSpeed = sprintSpeed;
            distanceSprinted = distanceSprinted + 1 * Time.deltaTime;
            if (distanceSprinted > maxSprintTime)
            {
                moveSpeed = originalSpeed;
            }
        }
        else 
        {
            moveSpeed = originalSpeed;
        }

        bool sprintReleased = Input.GetKeyUp(KeyCode.LeftShift);

        if (sprintReleased)
        {
            distanceSprinted = 0f;
        }

        // Q and E for rotating left and right 

        bool leftTurnPressed = Input.GetKey(KeyCode.Q);

        if (leftTurnPressed)
        {
            transform.Rotate(0f,-rotateSpeed,0f,Space.Self);
        }

        bool rightTurnPressed = Input.GetKey(KeyCode.E);

        if (rightTurnPressed) 
        {
            transform.Rotate(0f,rotateSpeed,0f,Space.Self);
        }

        // Rotate mouse left or right to rotate left or right 
        
        float rotation = Input.GetAxis("Mouse X") * rotateSpeed; 

        transform.Rotate(0,rotation,0);

        // Scale big using F or small using C

        bool bigScalePressed = Input.GetKey(KeyCode.F);

        if (bigScalePressed)
        {
            transform.localScale = transform.localScale + new Vector3(1f,1f,1f) * scaleSpeed * Time.deltaTime;
        }

        bool smallScalePressed = Input.GetKey(KeyCode.C);

        if (smallScalePressed)
        {
            transform.localScale = transform.localScale + new Vector3(-1f,-1f,-1f) * scaleSpeed * Time.deltaTime;
        }
        
    }
}
