using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTouch : MonoBehaviour
{

    public GameObject LoseText;
    public GameObject WinText;
    bool loseTextAppears = false;
    bool winTextAppears = false;
    Rigidbody2D body;
    //BoxCollider2D collider;

    /*private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }*/

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Landmine")
        {
            LoseText.gameObject.SetActive(true);
            loseTextAppears = true;

        } else if (loseTextAppears == false && randomSpawner.landmineCounter == 0) 
        {
            WinText.gameObject.SetActive(true);
            winTextAppears = true;
        }

        if (winTextAppears == true)
        {
            LoseText.gameObject.SetActive(false);
            loseTextAppears = false;
        }
    }
}
