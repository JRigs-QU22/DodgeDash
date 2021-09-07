using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0); //move left continuously

        if (transform.position.x < -9.7f) //if object moves too far off screen
        { 
            transform.position = new Vector3(9.7f,-3.04f,1); //move object back to marked starting position
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") //if object collides with player
        { 
            transform.position = new Vector3(9.7f, -3.04f, 1); //move object back to marked starting position
        }
    }
}

