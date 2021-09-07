using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DodgeRoll : MonoBehaviour
{
    public bool Candash; //check to see if player can dash
    public float WaitTime; //Creates float for dash cooldown

    public Text cooldown; //text slot for dash UI element

    // Start is called before the first frame update
    void Start()
    {
        Candash = true; //dash is available at start
        WaitTime = 2.0f; //cooldown times is defaulted at 2 seconds
        
    }

    // Update is called once per frame
    void Update()
    {


        if (WaitTime > 0.5) //if cooldown is greater than half a second
        {
            if(Candash == true && Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Space)) //press space and left arrow at the same time
            {
                tag = "NoHit"; //change player tag to stop damage
                transform.Translate(2, 0, 0); //move forward 2 spaces on x axis
                Candash = false; //disable dash
                cooldown.text = "Dash Not Available"; //change text

            }
            if (Candash == true && Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Space)) //press space and right arrow at the same time
            {
                tag = "NoHit"; //change player tag to stop damage
                transform.Translate(2, 0, 0); //move forward 2 spaces on x axis
                Candash = false; //disable dash
                cooldown.text = "Dash Not Available"; //change text

            }
            WaitTime -= Time.deltaTime; //countdown cooldown time
        }

        else if (WaitTime < 0.5) //if cooldown time is smaller than half a second
        { 
            {
                WaitTime = 2.0f; //reset cooldown time
                tag = "Player"; //change player tag to re-enable damage
                Candash = true; //enable dash
                cooldown.text = "Dash Available"; //change text

            }

        }
    }

    public void waitTime() //void for wait time, UNUSED
    {
       WaitTime -= Time.deltaTime;
    }
}
