using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnscript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float height = 9;

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
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        float highest = transform.position.y + height;
        float lowest = transform.position.y - (height);
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowest,highest),0), transform.rotation);
    }
}
