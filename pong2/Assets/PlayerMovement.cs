using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    public int playerNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player2") * speed * Time.deltaTime));
        }
            
        if (playerNumber == 1)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player1") * speed * Time.deltaTime));
        }
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.25f, 3.25f), transform.position.z);
    }

}
