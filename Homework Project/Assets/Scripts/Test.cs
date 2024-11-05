using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
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
        //Destroys object when player touches 
        Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        //Destorys object when player leaves trigger
        Destroy(gameObject);
    }

}
