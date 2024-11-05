using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public int healthPoints = 10;

    public int score = 0;
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

        if (collision.gameObject.CompareTag("Color"))
        {
            GetComponent<MeshRenderer>().material.color = new Color(1f,0.1f,0.79f);
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Color"))
        {
            GetComponent<MeshRenderer>().material.color = new Color(1f,1f,0f);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("HealthBoost"))
        {
            score++;
            Debug.Log("Your score is " + score + ", nice!");
        }

        if (other.gameObject.CompareTag("Reset"))
        {
            score--;
            Debug.Log("You have " + score + " score remaining, be careful");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("HealthBoost"))
        {
            Debug.Log("You are no longer gaining score");
        }

        if (other.gameObject.CompareTag("Reset"))
        {
            if (score < 1)
            {
                Debug.Log("You ran out of score, you died!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}
