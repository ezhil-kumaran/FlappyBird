using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddlescript : MonoBehaviour
{
    // Start is called before the first frame update
    public logicscript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addscore(1);
        }
    }
}
