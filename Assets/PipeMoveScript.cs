using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 10;
    public float dead = -45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = transform.position + (Vector3.left * movespeed)*Time.deltaTime;
        if(transform.position.x < dead)
        { 
            Destroy(gameObject);
        }
    }
}
