using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float killArea = -40.0f;
    public float moveSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < killArea)
        {
            Destroy(gameObject);
        }
    }
}
