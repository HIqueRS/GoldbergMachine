using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testinggravity : MonoBehaviour
{

    private bool blep = true;
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
        if(collision.transform.tag == "Player")
        {
            //collision.transform.GetComponent<Rigidbody>().mass = -10;
            
            //Physics.gravity = new Vector3(0, 1.0F, 0);
        }
    }

}
