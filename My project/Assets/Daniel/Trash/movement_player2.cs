using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_player2 : MonoBehaviour
{
    public float speed;
    // Update is called once per frame 
    void Update()
    {
        if (Input.GetKey("up"))
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, (gameObject.transform.position.y + speed * Time.deltaTime));
        }
        if (Input.GetKey("left"))
        {
            gameObject.transform.position = new Vector2((gameObject.transform.position.x + -speed * Time.deltaTime), gameObject.transform.position.y);
        }
        if (Input.GetKey("down"))
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, (gameObject.transform.position.y + -speed * Time.deltaTime));
        }
        if (Input.GetKey("right"))
        {
            gameObject.transform.position = new Vector2((gameObject.transform.position.x + speed * Time.deltaTime), gameObject.transform.position.y);
        }


    }
}
