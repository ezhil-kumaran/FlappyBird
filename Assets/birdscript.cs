using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public logicscript logic;
    public bool birdisalive = true;
    public float birddead = -25;
    public float birddead2 = 25;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdisalive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            logic.flapp();
        }
        if(transform.position.y < birddead||transform.position.y>birddead2)
        {
            logic.gameOver();
            birdisalive=false;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdisalive = false;
    }
}
