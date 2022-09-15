using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private float Move;
    public string player = "Player1";
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (player == "Player1")
        {
            if (Input.GetKey(KeyCode.S))
            {
                Movedown();
            }

            if (Input.GetKey(KeyCode.W))
            {
                Moveup();
            }
        }

        if (player == "Player2")
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Movedown();
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                Moveup();
            }
        }
    }

    void Moveup()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void Movedown()
    {
        transform.Translate(-Vector3.up * speed * Time.deltaTime);
    }
}
