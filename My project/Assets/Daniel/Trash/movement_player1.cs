using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_player1 : MonoBehaviour
{
    public float speed;
    //This script takes wasd input and translate it to positional movement.  The Speed can be edited in the component itself.
    void Update()
    {
        if (Input.GetKey("w"))
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, (gameObject.transform.position.y + speed * Time.deltaTime));
        }
        if (Input.GetKey("a"))
        {
            gameObject.transform.position = new Vector2((gameObject.transform.position.x + -speed * Time.deltaTime), gameObject.transform.position.y);
        }
        if (Input.GetKey("s"))
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, (gameObject.transform.position.y + -speed * Time.deltaTime));
        }
        if (Input.GetKey("d"))
        {
            gameObject.transform.position = new Vector2((gameObject.transform.position.x + speed * Time.deltaTime), gameObject.transform.position.y);
        }


    }
}
