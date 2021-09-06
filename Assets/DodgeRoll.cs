using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeRoll : MonoBehaviour
{
    public bool IsRolling;
    public float WaitTime;

    // Start is called before the first frame update
    void Start()
    {
        IsRolling = true;
        WaitTime = 2.0f;
        
    }

    // Update is called once per frame
    void Update()
    {


        if (WaitTime > 0.5)
        {
            if(IsRolling == true && Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Space))
        {
                tag = "NoHit";
                transform.position += new Vector3(-4, 0) * 30.0f * Time.deltaTime;
                IsRolling = false;

            }
            if (IsRolling == true && Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Space))
            {
                tag = "NoHit";
                transform.position += new Vector3(4, 0) * 30.0f * Time.deltaTime;
                IsRolling = false;


            }
            WaitTime -= Time.deltaTime;
        }

        else if (WaitTime < 0.5)
        { 
            {
                WaitTime = 2.0f;
                tag = "Player";
                IsRolling = true;
                
            }

        }
    }

    public void waitTime()
    {
       WaitTime -= Time.deltaTime;
    }
}
