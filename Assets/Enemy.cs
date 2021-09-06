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
        GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);

        if (transform.position.x < -9.7f) //if the sprite moves past bottom edge of screen...
        {
            transform.position = new Vector3(9.7f,-3.04f,1); //... move it within the horizontal range provided and to the height specified (above the screen)
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") //checks for a game object with a collider with the "Player" tag
        {
            transform.position = new Vector3(9.7f, -3.04f, 1); //repositions sprite within the horizontal range provided and to the height specified (above the screen)(as if it moved beneath the screen)
        }
    }
}

