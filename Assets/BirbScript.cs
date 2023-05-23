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

        if (transform.position.y > 17 || transform.position.y < -17)
        {
            logic.GameOver();
        }

    }

    public void Flap()
    {
        rb.velocity = Vector2.up * flapStr;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
    }
}
