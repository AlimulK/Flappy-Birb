using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{

    // Reference the RigidBody on the birb
    public Rigidbody2D rb;
    public float flapStr;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
        // Check space is pressed
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            // Sends birb upwards
            rb.velocity = Vector2.up * flapStr;
        }

        if (transform.position.y > 17 || transform.position.y < -17)
        {
            logic.gameOver();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}
