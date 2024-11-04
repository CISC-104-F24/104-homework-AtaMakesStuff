using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public int healthPoints = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Reset"))
        {
            Debug.Log("Reset!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("HealthBoost"))
        {
            healthPoints++;
            Debug.Log("You have " + healthPoints + " health.");
        }

        if (collision.gameObject.CompareTag("Pain"))
        {
            healthPoints--;
            Debug.Log("You have " + healthPoints + " health!");
        }
    }

    private void OnCollisionExit(Collision collison)
    {
        if (collison.gameObject.CompareTag("HealthBoost"))
        {
            Debug.Log("You are no longer gaining health");
        }
    }
}
