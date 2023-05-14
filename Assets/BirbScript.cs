using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{

    // Reference the RigidBody on the birb
    public Rigidbody2D rb;

    public float flapStr;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        // Check space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Sends birb upwards
            rb.velocity = Vector2.up * flapStr;
        }

    }
}
