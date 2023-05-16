using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeFactoryScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2.0f;
    private float timer = 0;
    public float heightOff = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } 
        else
        {
            spawnPipe();
            timer = 0;
        }

    }

    void spawnPipe()
    {
        float lowestP = transform.position.y - heightOff;
        float highestP = transform.position.y + heightOff;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestP, highestP), 0), transform.rotation);
    }
}
