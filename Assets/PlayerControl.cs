using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public int health = 100; //health value, set to 100 by default
    public Text hp; //health text UI element

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) //if lrft arrow pressed, move left
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) //if right arrow pressed, move right
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
        }

        if (Input.GetKey(KeyCode.R)) //if r is pressed
        {
            SceneManager.LoadScene("SampleScene"); //reset level
        }

        if (health <= 0) //if health is lower or equal to zero
        {
            SceneManager.LoadScene("SampleScene"); //reset scene
        } 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy") //if player is hit by an enemy object
        {
            health = health - 20; //deduct 20 from health int
            hp.text = "Health: " + health; //change health text readout
        }
    }
}
